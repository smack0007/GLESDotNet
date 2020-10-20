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

            public bool GenerateIntPtrOverload => Params.Any(x => x.Type == "void*");

            public bool GenerateGenericOverload => Params.Any(x => x.UseForGenericOverload);

            public bool GenerateRefOverload => Params.Any(x => x.UseForRefOverload);

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
            
            public bool UseForGenericOverload { get; set; }

            public bool UseForRefOverload { get; set; }

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
        }

        static void Main(string[] args)
        {
            GenerateGLES2();
            GenerateEGL();
        }

        private static void GenerateGLES2()
        {
            var (enums, functions) = Parse("gl2.h", "GL", "GL_APICALL", "GL_APIENTRY");

            var glBufferData = functions.Single(x => x.Name == "glBufferData");
            glBufferData.Params.Single(x => x.Name == "data").UseForGenericOverload = true;

            var glBufferSubData = functions.Single(x => x.Name == "glBufferSubData");
            glBufferSubData.Params.Single(x => x.Name == "data").UseForGenericOverload = true;

            var glDrawElements = functions.Single(x => x.Name == "glDrawElements");
            glDrawElements.Params.Single(x => x.Name == "indices").UseForGenericOverload = true;

            var glTexImage2D = functions.Single(x => x.Name == "glTexImage2D");
            glTexImage2D.Params.Single(x => x.Name == "pixels").UseForGenericOverload = true;

            foreach (var function in functions.Where(x =>
                x.Name.StartsWith("glGen") &&
                x.Params.Last().Type == "GLuint*"))
            {
                function.Params.Last().UseForRefOverload = true;
            }

            foreach (var function in functions.Where(x =>
                x.Name.StartsWith("glGet") &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "data")))
            {
                function.Params.Single(x => x.Name == "data").UseForRefOverload = true;
            }

            foreach (var function in functions.Where(x =>
                x.Name.StartsWith("glUniform") &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "value")))
            {
                function.Params.Single(x => x.Name == "value").UseForRefOverload = true;
            }

            Write(
                @"..\..\..\..\src\GLESDotNet\GLES2.cs",
                "GLES2",
                "uint",
                enums,
                functions,
                false,
                "glInit");
        }

        private static void GenerateEGL()
        {
            var (enums, functions) = Parse("egl.h", "EGL", "EGLAPI", "EGLAPIENTRY");

            Write(
                @"..\..\..\..\src\GLESDotNet\EGL.cs",
                "EGL",
                "int",
                enums,
                functions,
                true);
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
            string enumType,
            List<EnumData> enums,
            List<FunctionData> functions,
            bool includeLoadAssemblyFunction,
            string initFunctionName = "")
        {
            string[] license = File.ReadAllLines(Path.Combine(AssemblyDirectory, "License.txt"));

            StringBuilder sb = new StringBuilder(1024);

            foreach (var line in license)
            {
                sb.Append("// ");
                sb.AppendLine(line);
            }

            sb.AppendLine();
            sb.AppendLine("#nullable disable");
            sb.AppendLine();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using System.Security;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace GLESDotNet");
            sb.AppendLine("{");
            sb.AppendLine($"\tpublic static unsafe partial class {className}");
            sb.AppendLine("\t{");

            foreach (var @enum in enums.OrderBy(x => x.Name))
            {
                string type = enumType;
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

                sb.AppendLine($"\t\tpublic const {type} {name} = {value};");
            }

            sb.AppendLine();

            var orderedFunctions = functions.OrderBy(x => x.Name);

            sb.AppendLine("\t\tprivate static class Delegates");
            sb.AppendLine("\t\t{");

            foreach (var function in orderedFunctions)
            {
                string returnType = GetReturnType(function.ReturnType);
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\t\t[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]");
                sb.AppendLine($"\t\t\tpublic delegate {returnType} {function.Name}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                sb.AppendLine($"\t\tprivate static Delegates.{function.Name} _{function.Name};");
                sb.AppendLine();
            }

            if (includeLoadAssemblyFunction)
            {
                sb.AppendLine($"\t\tstatic {className}()");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tLoadFunctions(LoadAssembly());");
            }
            else
            {
                sb.AppendLine($"\t\tpublic static void {initFunctionName}(Func<string, IntPtr> getProcAddress)");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t\tLoadFunctions(getProcAddress);");
            }            

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            sb.AppendLine($"\t\tprivate static void LoadFunctions(Func<string, IntPtr> getProcAddress)");
            sb.AppendLine("\t\t{");

            sb.AppendLine("\t\t\tT getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                sb.AppendLine($"\t\t\t_{function.Name} = getProc<Delegates.{function.Name}>(\"{function.Name}\");");
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                string returnType = GetReturnType(function.ReturnType);
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));
                string parameterNames = string.Join(", ", function.Params.Select(x => GetParamName(x.Name)));

                sb.AppendLine($"\t\tpublic static {returnType} {function.Name}({parameters})");
                sb.AppendLine("\t\t{");

                sb.Append("\t\t\t");

                if (returnType != "void")
                    sb.Append("return ");

                sb.AppendLine($"_{function.Name}({parameterNames});");

                sb.AppendLine("\t\t}");
                sb.AppendLine();

                if (function.GenerateIntPtrOverload)
                {
                    parameters = string.Join(", ", function.Params.Select(x => (GetParamType(x) == "void*" ? "IntPtr" : GetParamType(x)) + " " + GetParamName(x.Name)));
                    parameterNames = string.Join(", ", function.Params.Select(x => (GetParamType(x) == "void*" ? "(void*)" : "") + GetParamName(x.Name)));

                    sb.AppendLine($"\t\tpublic static {returnType} {function.Name}({parameters})");
                    sb.AppendLine("\t\t{");

                    sb.Append("\t\t\t");

                    if (returnType != "void")
                        sb.Append("return ");

                    sb.AppendLine($"_{function.Name}({parameterNames});");

                    sb.AppendLine("\t\t}");
                    sb.AppendLine();
                }

                if (function.GenerateGenericOverload)
                {
                    // T[]
                    parameters = string.Join(", ", function.Params.Select(x => (x.UseForGenericOverload ? "T[]" : GetParamType(x)) + " " + GetParamName(x.Name)));
                    parameterNames = string.Join(", ", function.Params.Select(x => (x.UseForGenericOverload ? "(void*)" : "") + GetParamName(x.Name) + (x.UseForGenericOverload ? "Ptr.AddrOfPinnedObject()" : "")));

                    sb.AppendLine($"\t\tpublic static {returnType} {function.Name}<T>({parameters})");
                    sb.AppendLine("\t\t\twhere T: struct");
                    sb.AppendLine("\t\t{");

                    foreach (var param in function.Params.Where(x => x.UseForGenericOverload))
                        sb.AppendLine($"\t\t\tvar {GetParamName(param.Name)}Ptr = GCHandle.Alloc({GetParamName(param.Name)}, GCHandleType.Pinned);");

                    sb.AppendLine();
                    sb.AppendLine("\t\t\ttry");
                    sb.AppendLine("\t\t\t{");
                    sb.Append("\t\t\t\t");

                    if (returnType != "void")
                        sb.Append("return ");

                    sb.AppendLine($"_{function.Name}({parameterNames});");

                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t\tfinally");
                    sb.AppendLine("\t\t\t{");

                    foreach (var param in function.Params.Where(x => x.UseForGenericOverload))
                        sb.AppendLine($"\t\t\t\t{GetParamName(param.Name)}Ptr.Free();");

                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t}");

                    sb.AppendLine();

                    // ref T
                    parameters = string.Join(", ", function.Params.Select(x => (x.UseForGenericOverload ? "ref T" : GetParamType(x)) + " " + GetParamName(x.Name)));
                    parameterNames = string.Join(", ", function.Params.Select(x => (x.UseForGenericOverload ? "(void*)" : "") + GetParamName(x.Name) + (x.UseForGenericOverload ? "Ptr.AddrOfPinnedObject()" : "")));

                    sb.AppendLine($"\t\tpublic static {returnType} {function.Name}<T>({parameters})");
                    sb.AppendLine("\t\t\twhere T: struct");
                    sb.AppendLine("\t\t{");

                    foreach (var param in function.Params.Where(x => x.UseForGenericOverload))
                        sb.AppendLine($"\t\t\tvar {GetParamName(param.Name)}Ptr = GCHandle.Alloc({GetParamName(param.Name)}, GCHandleType.Pinned);");

                    sb.AppendLine();
                    sb.AppendLine("\t\t\ttry");
                    sb.AppendLine("\t\t\t{");
                    sb.Append("\t\t\t\t");

                    if (returnType != "void")
                        sb.Append("return ");

                    sb.AppendLine($"_{function.Name}({parameterNames});");

                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t\tfinally");
                    sb.AppendLine("\t\t\t{");

                    foreach (var param in function.Params.Where(x => x.UseForGenericOverload))
                        sb.AppendLine($"\t\t\t\t{GetParamName(param.Name)}Ptr.Free();");

                    sb.AppendLine("\t\t\t}");
                    sb.AppendLine("\t\t}");

                    sb.AppendLine();
                }

                if (function.GenerateRefOverload)
                {
                    parameters = string.Join(", ", function.Params.Select(x => (x.UseForRefOverload ? "ref " : "") + GetParamType(x, isRefOverload: x.UseForRefOverload) + " " + GetParamName(x.Name)));
                    parameterNames = string.Join(", ", function.Params.Select(x => GetParamName(x.Name) + (x.UseForRefOverload ? "Ptr" : "")));

                    sb.AppendLine($"\t\tpublic static {returnType} {function.Name}({parameters})");
                    sb.AppendLine("\t\t{");

                    foreach (var param in function.Params.Where(x => x.UseForRefOverload))
                        sb.AppendLine($"\t\t\tfixed ({GetParamType(param)} {GetParamName(param.Name)}Ptr = &{GetParamName(param.Name)})");
                    
                    sb.AppendLine("\t\t\t{");
                    sb.Append("\t\t\t\t");

                    if (returnType != "void")
                        sb.Append("return ");

                    sb.AppendLine($"_{function.Name}({parameterNames});");

                    sb.AppendLine("\t\t\t}");

                    sb.AppendLine("\t\t}");

                    sb.AppendLine();
                }

                if (Overloads.ContainsKey(function.Name))
                {
                    sb.AppendLine(Overloads[function.Name].Trim('\r', '\n'));
                    sb.AppendLine();
                }
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
                    returnType = "int";
                    break;

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

        private static string GetParamType(FunctionParamData param, bool isRefOverload = false)
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

                    case "char*":
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
                        type = "int";
                        break;

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

            if (isRefOverload)
                type = type.TrimEnd('*');

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

        // Overloads which are written by hand.
        private static Dictionary<string, string> Overloads = new Dictionary<string, string>()
        {
            ["eglChooseConfig"] = @"
        public static bool eglChooseConfig(IntPtr dpy, int[] attrib_list, out IntPtr configs, int config_size, out int num_config)
        {
            fixed (int* attrib_listPtr = attrib_list)
            fixed (IntPtr* configsPtr = &configs)
            fixed (int* num_configPtr = &num_config)
            {
                return _eglChooseConfig(dpy, attrib_listPtr, configsPtr, config_size, num_configPtr);
            }
        }",

            ["eglCreateContext"] = @"
        public static IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int[] attrib_list)
        {
            fixed (int* attrib_listPtr = attrib_list)
            {
                return _eglCreateContext(dpy, config, share_context, attrib_listPtr);
            }
        }",

            ["eglCreateWindowSurface"] = @"
        public static IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list)
        {
            fixed (int* attrib_listPtr = attrib_list)
            {
                return _eglCreateWindowSurface(dpy, config, win, attrib_listPtr);
            }
        }

        public static IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, IntPtr attrib_list)
        {
            return _eglCreateWindowSurface(dpy, config, win, (int*)attrib_list);
        }",

            ["eglInitialize"] = @"
        public static bool eglInitialize(IntPtr dpy, out int major, out int minor)
        {
            fixed (int* majorPtr = &major)
            fixed (int* minorPtr = &minor)
            {
                return _eglInitialize(dpy, majorPtr, minorPtr);
            }
        }",
        };
    }
}
