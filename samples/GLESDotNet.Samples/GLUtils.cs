using System;
using System.Text;
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
    }
}
