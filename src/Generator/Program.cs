using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GLGenerator
{
    class Program
    {
        public static readonly string AssemblyDirectory = Path.GetDirectoryName(typeof(Program).Assembly.Location) ?? "";

        class BaseData
        {
            public int VersionMajor { get; set; }

            public int VersionMinor { get; set; }

            public BaseData() { }

            public BaseData(BaseData other)
            {
                VersionMajor = other.VersionMajor;
                VersionMinor = other.VersionMinor;
            }
        }

        class EnumData : BaseData
        {
            public string Name { get; set; } = "";

            public string Value { get; set; } = "";

            public override string ToString() => $"{Name}: {Value}";
        }

        class FunctionData : BaseData
        {
            public string ReturnType { get; set; } = "";

            public string Name { get; set; } = "";

            public List<FunctionParamData> Params { get; } = new List<FunctionParamData>();

            public FunctionData() { }

            public FunctionData(FunctionData functionData)
                : base(functionData)
            {
                ReturnType = functionData.ReturnType;
                Name = functionData.Name;

                Params = new List<FunctionParamData>();
                foreach (var param in functionData.Params)
                {
                    Params.Add(new FunctionParamData(param));
                }
            }

            public override string ToString() => $"{ReturnType} {Name}({string.Join(", ", Params)})";
        }

        class FunctionParamData
        {
            public bool IsConst { get; set; }

            public int PointerCount { get; set; }

            public bool TypeOverridden { get; private set; } = false;

            public string? TypePrefix { get; set; }

            public string Type { get; set; } = "";

            public string Name { get; set; } = "";

            public bool UseForVoidPointerOverload { get; set; }

            public bool UseForByRefOverload { get; set; }

            public FunctionParamData() { }

            public FunctionParamData(FunctionParamData functionParamData)
            {
                IsConst = functionParamData.IsConst;
                PointerCount = functionParamData.PointerCount;
                TypeOverridden = functionParamData.TypeOverridden;
                TypePrefix = functionParamData.TypePrefix;
                Type = functionParamData.Type;
                Name = functionParamData.Name;
            }

            public override string ToString() => $"{Type}: {Name}";

            public void OverrideType(string type, string? typePrefix = null)
            {
                TypePrefix = typePrefix;
                Type = type;
                TypeOverridden = true;
            }
        }

        static void Main(string[] args)
        {
            GenerateGLES2();
            GenerateEGL();
        }

        private static void GenerateGLES2()
        {
            var (enums, functions) = Parse("gl2.h", "GL", "GL_APICALL", "GL_APIENTRY");

            //var glBufferData = functions.Single(x => x.Name == "glBufferData");
            //glBufferData.Params.Single(x => x.Name == "data").UseForVoidPointerOverload = true;

            //var glBufferSubData = functions.Single(x => x.Name == "glBufferSubData");
            //glBufferSubData.Params.Single(x => x.Name == "data").UseForVoidPointerOverload = true;

            //var glTexImage1D = functions.Single(x => x.Name == "glTexImage1D");
            //glTexImage1D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            //var glTexImage2D = functions.Single(x => x.Name == "glTexImage2D");
            //glTexImage2D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            //var glTexImage3D = functions.Single(x => x.Name == "glTexImage3D");
            //glTexImage3D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            foreach (var function in functions.Where(x =>
                x.Name.StartsWith("glGet") &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "data")))
            {
                function.Params.Single(x => x.Name == "data").UseForByRefOverload = true;
            }

            foreach (var function in functions.Where(x =>
                (x.Name.StartsWith("glUniform") || x.Name.StartsWith("glProgramUniform")) &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "value")))
            {
                function.Params.Single(x => x.Name == "value").UseForByRefOverload = true;
            }

            Write(
                @"..\..\..\..\src\ANGLEDotNet\GLES2.cs",
                "GLES2",
                "libglesv2",
                enums,
                functions);
        }

        private static void GenerateEGL()
        {
            var (enums, functions) = Parse("egl.h", "EGL", "EGLAPI", "EGLAPIENTRY");

            Write(
                @"..\..\..\..\src\ANGLEDotNet\EGL.cs",
                "EGL",
                "libegl",
                enums,
                functions);
        }

        private static (List<EnumData> Enums, List<FunctionData> Functions) Parse(
            string inputPath,
            string enumPrefix,
            string functionApiCall,
            string functionApiEntry)
        {
            var lines = File.ReadAllLines(Path.Combine(AssemblyDirectory, inputPath));

            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            int versionMajor = 0;
            int versionMinor = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith($"#ifndef {enumPrefix}_VERSION_"))
                {
                    var parts = lines[i].Substring($"#ifndef {enumPrefix}_VERSION_".Length).Split('_');
                    versionMajor = int.Parse(parts[0]);
                    versionMinor = int.Parse(parts[1]);
                }
                else if (lines[i].StartsWith($"#define {enumPrefix}_") &&
                         !lines[i].StartsWith($"#define {enumPrefix}_VERSION_") &&
                         !lines[i].StartsWith($"#define {enumPrefix}_APIENTRYP"))
                {
                    var parts = lines[i].Substring("#define ".Length).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    enums.Add(new EnumData()
                    {
                        VersionMajor = versionMajor,
                        VersionMinor = versionMinor,
                        Name = parts[0].Trim(),
                        Value = parts[1].Trim()
                    });
                }
                else if (lines[i].StartsWith($"{functionApiCall} ") && lines[i].Contains(functionApiEntry))
                {
                    var parts = lines[i].Substring($"{functionApiCall} ".Length)
                        .Replace("const GLubyte *GL_APIENTRY", "IntPtr")
                        .Replace("const char *EGLAPIENTRY", "string")
                        .Replace(functionApiEntry, "")
                        .Replace("*const*", "**")
                        .Trim(';')
                        .Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    int j = 0;

                    var function = new FunctionData()
                    {
                        VersionMajor = versionMajor,
                        VersionMinor = versionMinor,
                    };

                    function.ReturnType = parts[j];
                    j++;

                    if (parts[j] == "*")
                    {
                        function.ReturnType += "*";
                        j++;
                    }

                    function.Name = parts[j];
                    j++;

                    if (parts[j] != "void")
                    {
                        for (; j < parts.Length; j += 2)
                        {
                            bool isConst = false;

                            if (parts[j] == "const")
                            {
                                isConst = true;
                                j++;
                            }

                            int pointerCount = 0;

                            while (parts[j + 1].StartsWith("*"))
                            {
                                pointerCount++;
                                parts[j] += "*";
                                parts[j + 1] = parts[j + 1].Substring("*".Length);
                            }

                            var functionParam = new FunctionParamData()
                            {
                                IsConst = isConst,
                                PointerCount = pointerCount,
                                Type = parts[j],
                                Name = parts[j + 1],
                            };

                            function.Params.Add(functionParam);
                        }
                    }

                    functions.Add(function);
                }
            }

            return (enums, functions);
        }

        private static void Write(
            string outputPath,
            string className,
            string library,
            List<EnumData> enums,
            List<FunctionData> functions)
        {
            string[] license = File.ReadAllLines(Path.Combine(AssemblyDirectory, "License.txt"));

            StringBuilder sb = new StringBuilder(1024);

            foreach (var line in license)
            {
                sb.Append("// ");
                sb.AppendLine(line);
            }

            sb.AppendLine();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace ANGLEDotNet");
            sb.AppendLine("{");
            sb.AppendLine($"\tpublic static unsafe partial class {className}");
            sb.AppendLine("\t{");
            sb.AppendLine($"\t\tpublic const string Library = \"{library}\";");
            sb.AppendLine();

            foreach (var @enum in enums.OrderBy(x => x.Name))
            {
                string type = "uint";
                string name = @enum.Name;
                string value = @enum.Value;

                if (value == "0xFFFFFFFFFFFFFFFFull")
                    value = "0xFFFFFFFFFFFFFFFF";

                if (value.EndsWith("ull") || value == "0xFFFFFFFFFFFFFFFF")
                {
                    type = "ulong";
                }
                else if (value.EndsWith("u") || value == "0xFFFFFFFF")
                {
                    type = "uint";
                }

                if (value.StartsWith("EGL_CAST("))
                {
                    int index = value.LastIndexOf(',') + 1;
                    value = value.Substring(index, value.Length - index - 1);
                }

                // Chop off the "u" if we have a negative value.
                if (value.StartsWith("-"))
                    value = $"unchecked((uint){value})";

                sb.AppendLine($"\t\tpublic const {type} {name} = {value};");
            }

            sb.AppendLine();

            foreach (var function in functions.OrderBy(x => x.Name))
            {
                string returnType = GetReturnType(function.ReturnType);
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\t[DllImport(Library, EntryPoint = \"{function.Name}\")]");
                sb.AppendLine($"\t\tpublic static extern {returnType} {function.Name}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(Path.GetFullPath(outputPath), sb.ToString());
        }

        private static string GetReturnType(string returnType)
        {
            switch (returnType)
            {
                case "__eglMustCastToProperFunctionPointerType":
                case "EGLContext":
                case "EGLDisplay":
                case "EGLImage":
                case "EGLSurface":
                case "EGLSync":
                    returnType = "IntPtr";
                    break;

                case "EGLBoolean":
                case "GLboolean":
                    returnType = "bool";
                    break;

                case "EGLenum":
                case "GLenum":
                    returnType = "uint";
                    break;

                case "EGLint":
                case "GLint":
                    returnType = "int";
                    break;

                case "void*":
                case "GLsync":
                    returnType = "IntPtr";
                    break;

                case "GLuint":
                    returnType = "uint";
                    break;
            }

            return returnType;
        }

        private static string GetParamType(FunctionParamData param)
        {
            string type = param.Type;

            if (!param.TypeOverridden)
            {
                switch (param.Type)
                {
                    case "EGLClientBuffer":
                    case "EGLConfig":
                    case "EGLContext":
                    case "EGLDisplay":
                    case "EGLImage":
                    case "EGLNativeDisplayType":
                    case "EGLNativePixmapType":
                    case "EGLNativeWindowType":
                    case "EGLSurface":
                    case "EGLSync":
                        type = "IntPtr";
                        break;

                    case "EGLTime":
                        type = "ulong";
                        break;

                    case "EGLAttrib*":
                    case "EGLConfig*":
                        type = "IntPtr*";
                        break;

                    case "EGLBoolean":
                    case "GLboolean":
                        type = "bool";
                        break;

                    case "GLboolean*":
                        type = "bool*";
                        break;

                    case "GLubyte":
                        type = "byte";
                        break;

                    case "GLubyte*":
                        type = "byte*";
                        break;

                    case "GLchar*":
                        if (param.IsConst)
                        {
                            type = "string";
                        }
                        else
                        {
                            type = "StringBuilder";
                        }
                        break;

                    case "GLchar**":
                        type = "string[]";
                        break;

                    case "GLDEBUGPROC":
                        type = "glDebugProc";
                        break;

                    case "GLdouble":
                        type = "double";
                        break;

                    case "GLdouble*":
                        type = "double*";
                        break;

                    case "GLfloat":
                        type = "float";
                        break;

                    case "GLfloat*":
                        type = "float*";
                        break;

                    case "EGLint":
                    case "GLint":
                    case "GLsizei":
                    case "GLintptr":
                    case "GLsizeiptr":
                        type = "int";
                        break;

                    case "EGLint*":
                    case "GLint*":
                    case "GLsizei*":
                    case "GLintptr*":
                    case "GLsizeiptr*":
                        type = "int*";
                        break;

                    case "GLsync":
                        type = "IntPtr";
                        break;

                    case "void":
                        if (param.PointerCount == 2)
                        {
                            type = "IntPtr[]";
                        }
                        else
                        {
                            type = "IntPtr";
                        }
                        break;

                    case "GLint64":
                        type = "long";
                        break;

                    case "GLint64*":
                        type = "long*";
                        break;

                    case "GLbyte":
                        type = "sbyte";
                        break;

                    case "GLbyte*":
                        type = "sbyte*";
                        break;

                    case "GLshort":
                        type = "short";
                        break;

                    case "GLshort*":
                        type = "short*";
                        break;

                    case "EGLenum":
                    case "GLbitfield":
                    case "GLenum":
                    case "GLuint":
                        type = "uint";
                        break;

                    case "GLuint*":
                    case "GLenum*":
                        type = "uint*";
                        break;

                    case "GLuint64":
                        type = "ulong";
                        break;

                    case "GLuint64*":
                        type = "ulong*";
                        break;

                    case "GLushort":
                        type = "ushort";
                        break;

                    case "GLushort*":
                        type = "ushort*";
                        break;
                }
            }

            return type;
        }

        private static string GetParamName(string name)
        {
            if (name == "params" ||
                name == "ref" ||
                name == "string")
            {
                name = "@" + name;
            }

            return name;
        }
    }
}
