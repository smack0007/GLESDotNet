using System;
using System.Text;
using ImageDotNet;
using static GLESDotNet.GLES2;

namespace GLESDotNet.Samples
{
    public static class GLUtils
    {
        public static uint CompileShader(string shaderSrc, uint type)
        {
            var shader = glCreateShader(type);

            if (shader == 0)
                return 0;

            glShaderSource(shader, shaderSrc);

            glCompileShader(shader);

            glGetShaderiv(shader, GL_COMPILE_STATUS, out int compiled);

            if (compiled == 0)
            {
                glGetShaderiv(shader, GL_INFO_LOG_LENGTH, out int infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetShaderInfoLog(shader, infoLength, out _, infoLog);
                    glDeleteShader(shader);
                    throw new InvalidOperationException($"Error compiling shader:\n{infoLog}");
                }
            }

            return shader;
        }

        public static void LinkProgram(uint program)
        {
            glLinkProgram(program);

            glGetProgramiv(program, GL_LINK_STATUS, out int linked);

            if (linked == 0)
            {
                glGetProgramiv(program, GL_INFO_LOG_LENGTH, out int infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetProgramInfoLog(program, infoLength, out _, infoLog);
                    glDeleteProgram(program);
                    throw new InvalidOperationException($"Error linking program:\n{infoLog}");
                }
            }
        }

        public static TextureData LoadTexture(string fileName)
        {
            glGenTextures(1, out uint handle);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, handle);

            var image = Image.LoadPng(fileName).To<Rgba32>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, image.Width, image.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            return new TextureData() { Handle = handle, Width = image.Width, Height = image.Height };
        }
    }
}
