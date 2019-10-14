// Copyright (c) 2019 Zachary Snow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLDotNet
{
	public static unsafe partial class GL
	{
		public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint GL_ACTIVE_TEXTURE = 0x84E0;
		public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint GL_ACTIVE_UNIFORMS = 0x8B86;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
		public const uint GL_ALPHA = 0x1906;
		public const uint GL_ALPHA_BITS = 0x0D55;
		public const uint GL_ALWAYS = 0x0207;
		public const uint GL_ARRAY_BUFFER = 0x8892;
		public const uint GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const uint GL_ATTACHED_SHADERS = 0x8B85;
		public const uint GL_BACK = 0x0405;
		public const uint GL_BLEND = 0x0BE2;
		public const uint GL_BLEND_COLOR = 0x8005;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_EQUATION = 0x8009;
		public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const uint GL_BLEND_EQUATION_RGB = 0x8009;
		public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
		public const uint GL_BLEND_SRC_RGB = 0x80C9;
		public const uint GL_BLUE_BITS = 0x0D54;
		public const uint GL_BOOL = 0x8B56;
		public const uint GL_BOOL_VEC2 = 0x8B57;
		public const uint GL_BOOL_VEC3 = 0x8B58;
		public const uint GL_BOOL_VEC4 = 0x8B59;
		public const uint GL_BUFFER_SIZE = 0x8764;
		public const uint GL_BUFFER_USAGE = 0x8765;
		public const uint GL_BYTE = 0x1400;
		public const uint GL_CCW = 0x0901;
		public const uint GL_CLAMP_TO_EDGE = 0x812F;
		public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint GL_COLOR_BUFFER_BIT = 0x00004000;
		public const uint GL_COLOR_CLEAR_VALUE = 0x0C22;
		public const uint GL_COLOR_WRITEMASK = 0x0C23;
		public const uint GL_COMPILE_STATUS = 0x8B81;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_CULL_FACE = 0x0B44;
		public const uint GL_CULL_FACE_MODE = 0x0B45;
		public const uint GL_CURRENT_PROGRAM = 0x8B8D;
		public const uint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint GL_CW = 0x0900;
		public const uint GL_DECR = 0x1E03;
		public const uint GL_DECR_WRAP = 0x8508;
		public const uint GL_DELETE_STATUS = 0x8B80;
		public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
		public const uint GL_DEPTH_BITS = 0x0D56;
		public const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
		public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73;
		public const uint GL_DEPTH_COMPONENT = 0x1902;
		public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
		public const uint GL_DEPTH_FUNC = 0x0B74;
		public const uint GL_DEPTH_RANGE = 0x0B70;
		public const uint GL_DEPTH_TEST = 0x0B71;
		public const uint GL_DEPTH_WRITEMASK = 0x0B72;
		public const uint GL_DITHER = 0x0BD0;
		public const uint GL_DONT_CARE = 0x1100;
		public const uint GL_DST_ALPHA = 0x0304;
		public const uint GL_DST_COLOR = 0x0306;
		public const uint GL_DYNAMIC_DRAW = 0x88E8;
		public const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint GL_EQUAL = 0x0202;
		public const uint GL_ES_VERSION_2_0 = 1;
		public const uint GL_EXTENSIONS = 0x1F03;
		public const uint GL_FALSE = 0;
		public const uint GL_FASTEST = 0x1101;
		public const uint GL_FIXED = 0x140C;
		public const uint GL_FLOAT = 0x1406;
		public const uint GL_FLOAT_MAT2 = 0x8B5A;
		public const uint GL_FLOAT_MAT3 = 0x8B5B;
		public const uint GL_FLOAT_MAT4 = 0x8B5C;
		public const uint GL_FLOAT_VEC2 = 0x8B50;
		public const uint GL_FLOAT_VEC3 = 0x8B51;
		public const uint GL_FLOAT_VEC4 = 0x8B52;
		public const uint GL_FRAGMENT_SHADER = 0x8B30;
		public const uint GL_FRAMEBUFFER = 0x8D40;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint GL_FRONT = 0x0404;
		public const uint GL_FRONT_AND_BACK = 0x0408;
		public const uint GL_FRONT_FACE = 0x0B46;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_GENERATE_MIPMAP_HINT = 0x8192;
		public const uint GL_GEQUAL = 0x0206;
		public const uint GL_GLES_PROTOTYPES = 1;
		public const uint GL_GREATER = 0x0204;
		public const uint GL_GREEN_BITS = 0x0D53;
		public const uint GL_HIGH_FLOAT = 0x8DF2;
		public const uint GL_HIGH_INT = 0x8DF5;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint GL_INCR = 0x1E02;
		public const uint GL_INCR_WRAP = 0x8507;
		public const uint GL_INFO_LOG_LENGTH = 0x8B84;
		public const uint GL_INT = 0x1404;
		public const uint GL_INT_VEC2 = 0x8B53;
		public const uint GL_INT_VEC3 = 0x8B54;
		public const uint GL_INT_VEC4 = 0x8B55;
		public const uint GL_INVALID_ENUM = 0x0500;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint GL_INVALID_OPERATION = 0x0502;
		public const uint GL_INVALID_VALUE = 0x0501;
		public const uint GL_INVERT = 0x150A;
		public const uint GL_KEEP = 0x1E00;
		public const uint GL_LEQUAL = 0x0203;
		public const uint GL_LESS = 0x0201;
		public const uint GL_LINE_LOOP = 0x0002;
		public const uint GL_LINE_STRIP = 0x0003;
		public const uint GL_LINE_WIDTH = 0x0B21;
		public const uint GL_LINEAR = 0x2601;
		public const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703;
		public const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
		public const uint GL_LINES = 0x0001;
		public const uint GL_LINK_STATUS = 0x8B82;
		public const uint GL_LOW_FLOAT = 0x8DF0;
		public const uint GL_LOW_INT = 0x8DF3;
		public const uint GL_LUMINANCE = 0x1909;
		public const uint GL_LUMINANCE_ALPHA = 0x190A;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint GL_MAX_TEXTURE_SIZE = 0x0D33;
		public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const uint GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
		public const uint GL_MEDIUM_FLOAT = 0x8DF1;
		public const uint GL_MEDIUM_INT = 0x8DF4;
		public const uint GL_MIRRORED_REPEAT = 0x8370;
		public const uint GL_NEAREST = 0x2600;
		public const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
		public const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
		public const uint GL_NEVER = 0x0200;
		public const uint GL_NICEST = 0x1102;
		public const uint GL_NO_ERROR = 0;
		public const uint GL_NONE = 0;
		public const uint GL_NOTEQUAL = 0x0205;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint GL_ONE = 1;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint GL_OUT_OF_MEMORY = 0x0505;
		public const uint GL_PACK_ALIGNMENT = 0x0D05;
		public const uint GL_POINTS = 0x0000;
		public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038;
		public const uint GL_POLYGON_OFFSET_FILL = 0x8037;
		public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00;
		public const uint GL_RED_BITS = 0x0D52;
		public const uint GL_RENDERBUFFER = 0x8D41;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const uint GL_RENDERER = 0x1F01;
		public const uint GL_REPEAT = 0x2901;
		public const uint GL_REPLACE = 0x1E01;
		public const uint GL_RGB = 0x1907;
		public const uint GL_RGB5_A1 = 0x8057;
		public const uint GL_RGB565 = 0x8D62;
		public const uint GL_RGBA = 0x1908;
		public const uint GL_RGBA4 = 0x8056;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint GL_SAMPLE_BUFFERS = 0x80A8;
		public const uint GL_SAMPLE_COVERAGE = 0x80A0;
		public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint GL_SAMPLER_2D = 0x8B5E;
		public const uint GL_SAMPLER_CUBE = 0x8B60;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_SCISSOR_BOX = 0x0C10;
		public const uint GL_SCISSOR_TEST = 0x0C11;
		public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint GL_SHADER_COMPILER = 0x8DFA;
		public const uint GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint GL_SHADER_TYPE = 0x8B4F;
		public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint GL_SHORT = 0x1402;
		public const uint GL_SRC_ALPHA = 0x0302;
		public const uint GL_SRC_ALPHA_SATURATE = 0x0308;
		public const uint GL_SRC_COLOR = 0x0300;
		public const uint GL_STATIC_DRAW = 0x88E4;
		public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
		public const uint GL_STENCIL_BACK_FAIL = 0x8801;
		public const uint GL_STENCIL_BACK_FUNC = 0x8800;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint GL_STENCIL_BACK_REF = 0x8CA3;
		public const uint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint GL_STENCIL_BITS = 0x0D57;
		public const uint GL_STENCIL_BUFFER_BIT = 0x00000400;
		public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91;
		public const uint GL_STENCIL_FAIL = 0x0B94;
		public const uint GL_STENCIL_FUNC = 0x0B92;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const uint GL_STENCIL_REF = 0x0B97;
		public const uint GL_STENCIL_TEST = 0x0B90;
		public const uint GL_STENCIL_VALUE_MASK = 0x0B93;
		public const uint GL_STENCIL_WRITEMASK = 0x0B98;
		public const uint GL_STREAM_DRAW = 0x88E0;
		public const uint GL_SUBPIXEL_BITS = 0x0D50;
		public const uint GL_TEXTURE = 0x1702;
		public const uint GL_TEXTURE_2D = 0x0DE1;
		public const uint GL_TEXTURE_BINDING_2D = 0x8069;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint GL_TEXTURE_MAG_FILTER = 0x2800;
		public const uint GL_TEXTURE_MIN_FILTER = 0x2801;
		public const uint GL_TEXTURE_WRAP_S = 0x2802;
		public const uint GL_TEXTURE_WRAP_T = 0x2803;
		public const uint GL_TEXTURE0 = 0x84C0;
		public const uint GL_TEXTURE1 = 0x84C1;
		public const uint GL_TEXTURE10 = 0x84CA;
		public const uint GL_TEXTURE11 = 0x84CB;
		public const uint GL_TEXTURE12 = 0x84CC;
		public const uint GL_TEXTURE13 = 0x84CD;
		public const uint GL_TEXTURE14 = 0x84CE;
		public const uint GL_TEXTURE15 = 0x84CF;
		public const uint GL_TEXTURE16 = 0x84D0;
		public const uint GL_TEXTURE17 = 0x84D1;
		public const uint GL_TEXTURE18 = 0x84D2;
		public const uint GL_TEXTURE19 = 0x84D3;
		public const uint GL_TEXTURE2 = 0x84C2;
		public const uint GL_TEXTURE20 = 0x84D4;
		public const uint GL_TEXTURE21 = 0x84D5;
		public const uint GL_TEXTURE22 = 0x84D6;
		public const uint GL_TEXTURE23 = 0x84D7;
		public const uint GL_TEXTURE24 = 0x84D8;
		public const uint GL_TEXTURE25 = 0x84D9;
		public const uint GL_TEXTURE26 = 0x84DA;
		public const uint GL_TEXTURE27 = 0x84DB;
		public const uint GL_TEXTURE28 = 0x84DC;
		public const uint GL_TEXTURE29 = 0x84DD;
		public const uint GL_TEXTURE3 = 0x84C3;
		public const uint GL_TEXTURE30 = 0x84DE;
		public const uint GL_TEXTURE31 = 0x84DF;
		public const uint GL_TEXTURE4 = 0x84C4;
		public const uint GL_TEXTURE5 = 0x84C5;
		public const uint GL_TEXTURE6 = 0x84C6;
		public const uint GL_TEXTURE7 = 0x84C7;
		public const uint GL_TEXTURE8 = 0x84C8;
		public const uint GL_TEXTURE9 = 0x84C9;
		public const uint GL_TRIANGLE_FAN = 0x0006;
		public const uint GL_TRIANGLE_STRIP = 0x0005;
		public const uint GL_TRIANGLES = 0x0004;
		public const uint GL_TRUE = 1;
		public const uint GL_UNPACK_ALIGNMENT = 0x0CF5;
		public const uint GL_UNSIGNED_BYTE = 0x1401;
		public const uint GL_UNSIGNED_INT = 0x1405;
		public const uint GL_UNSIGNED_SHORT = 0x1403;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint GL_VALIDATE_STATUS = 0x8B83;
		public const uint GL_VENDOR = 0x1F00;
		public const uint GL_VERSION = 0x1F02;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint GL_VERTEX_SHADER = 0x8B31;
		public const uint GL_VIEWPORT = 0x0BA2;
		public const uint GL_ZERO = 0;

		public delegate void glDebugProc(uint source, uint type, uint id, uint severity, int length, string message, IntPtr userParam);

		public static class Delegates
		{
			public delegate void glActiveTexture(uint texture);

			public delegate void glAttachShader(uint program, uint shader);

			public delegate void glBindAttribLocation(uint program, uint index, string name);

			public delegate void glBindBuffer(uint target, uint buffer);

			public delegate void glBindFramebuffer(uint target, uint framebuffer);

			public delegate void glBindRenderbuffer(uint target, uint renderbuffer);

			public delegate void glBindTexture(uint target, uint texture);

			public delegate void glBlendColor(float red, float green, float blue, float alpha);

			public delegate void glBlendEquation(uint mode);

			public delegate void glBlendEquationSeparate(uint modeRGB, uint modeAlpha);

			public delegate void glBlendFunc(uint sfactor, uint dfactor);

			public delegate void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

			public delegate void glBufferData(uint target, int size, void* data, uint usage);

			public delegate void glBufferSubData(uint target, int offset, int size, void* data);

			public delegate uint glCheckFramebufferStatus(uint target);

			public delegate void glClear(uint mask);

			public delegate void glClearColor(float red, float green, float blue, float alpha);

			public delegate void glClearDepthf(float d);

			public delegate void glClearStencil(int s);

			public delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			public delegate void glCompileShader(uint shader);

			public delegate void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

			public delegate void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

			public delegate void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

			public delegate void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate uint glCreateProgram();

			public delegate uint glCreateShader(uint type);

			public delegate void glCullFace(uint mode);

			public delegate void glDeleteBuffers(int n, uint* buffers);

			public delegate void glDeleteFramebuffers(int n, uint* framebuffers);

			public delegate void glDeleteProgram(uint program);

			public delegate void glDeleteRenderbuffers(int n, uint* renderbuffers);

			public delegate void glDeleteShader(uint shader);

			public delegate void glDeleteTextures(int n, uint* textures);

			public delegate void glDepthFunc(uint func);

			public delegate void glDepthMask(bool flag);

			public delegate void glDepthRangef(float n, float f);

			public delegate void glDetachShader(uint program, uint shader);

			public delegate void glDisable(uint cap);

			public delegate void glDisableVertexAttribArray(uint index);

			public delegate void glDrawArrays(uint mode, int first, int count);

			public delegate void glDrawElements(uint mode, int count, uint type, void* indices);

			public delegate void glEnable(uint cap);

			public delegate void glEnableVertexAttribArray(uint index);

			public delegate void glFinish();

			public delegate void glFlush();

			public delegate void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void glFrontFace(uint mode);

			public delegate void glGenBuffers(int n, uint* buffers);

			public delegate void glGenerateMipmap(uint target);

			public delegate void glGenFramebuffers(int n, uint* framebuffers);

			public delegate void glGenRenderbuffers(int n, uint* renderbuffers);

			public delegate void glGenTextures(int n, uint* textures);

			public delegate void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			public delegate void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			public delegate void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

			public delegate int glGetAttribLocation(uint program, string name);

			public delegate void glGetBooleanv(uint pname, bool* data);

			public delegate void glGetBufferParameteriv(uint target, uint pname, int* @params);

			public delegate uint glGetError();

			public delegate void glGetFloatv(uint pname, float* data);

			public delegate void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params);

			public delegate void glGetIntegerv(uint pname, int* data);

			public delegate void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog);

			public delegate void glGetProgramiv(uint program, uint pname, int* @params);

			public delegate void glGetRenderbufferParameteriv(uint target, uint pname, int* @params);

			public delegate void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog);

			public delegate void glGetShaderiv(uint shader, uint pname, int* @params);

			public delegate void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

			public delegate void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source);

			public delegate IntPtr glGetString(uint name);

			public delegate void glGetTexParameterfv(uint target, uint pname, float* @params);

			public delegate void glGetTexParameteriv(uint target, uint pname, int* @params);

			public delegate void glGetUniformfv(uint program, int location, float* @params);

			public delegate void glGetUniformiv(uint program, int location, int* @params);

			public delegate int glGetUniformLocation(uint program, string name);

			public delegate void glGetVertexAttribfv(uint index, uint pname, float* @params);

			public delegate void glGetVertexAttribiv(uint index, uint pname, int* @params);

			public delegate void glGetVertexAttribPointerv(uint index, uint pname, void** pointer);

			public delegate void glHint(uint target, uint mode);

			public delegate bool glIsBuffer(uint buffer);

			public delegate bool glIsEnabled(uint cap);

			public delegate bool glIsFramebuffer(uint framebuffer);

			public delegate bool glIsProgram(uint program);

			public delegate bool glIsRenderbuffer(uint renderbuffer);

			public delegate bool glIsShader(uint shader);

			public delegate bool glIsTexture(uint texture);

			public delegate void glLineWidth(float width);

			public delegate void glLinkProgram(uint program);

			public delegate void glPixelStorei(uint pname, int param);

			public delegate void glPolygonOffset(float factor, float units);

			public delegate void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

			public delegate void glReleaseShaderCompiler();

			public delegate void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

			public delegate void glSampleCoverage(float value, bool invert);

			public delegate void glScissor(int x, int y, int width, int height);

			public delegate void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);

			public delegate void glShaderSource(uint shader, int count, string[] @string, int* length);

			public delegate void glStencilFunc(uint func, int @ref, uint mask);

			public delegate void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			public delegate void glStencilMask(uint mask);

			public delegate void glStencilMaskSeparate(uint face, uint mask);

			public delegate void glStencilOp(uint fail, uint zfail, uint zpass);

			public delegate void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			public delegate void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

			public delegate void glTexParameterf(uint target, uint pname, float param);

			public delegate void glTexParameterfv(uint target, uint pname, float* @params);

			public delegate void glTexParameteri(uint target, uint pname, int param);

			public delegate void glTexParameteriv(uint target, uint pname, int* @params);

			public delegate void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

			public delegate void glUniform1f(int location, float v0);

			public delegate void glUniform1fv(int location, int count, float* value);

			public delegate void glUniform1i(int location, int v0);

			public delegate void glUniform1iv(int location, int count, int* value);

			public delegate void glUniform2f(int location, float v0, float v1);

			public delegate void glUniform2fv(int location, int count, float* value);

			public delegate void glUniform2i(int location, int v0, int v1);

			public delegate void glUniform2iv(int location, int count, int* value);

			public delegate void glUniform3f(int location, float v0, float v1, float v2);

			public delegate void glUniform3fv(int location, int count, float* value);

			public delegate void glUniform3i(int location, int v0, int v1, int v2);

			public delegate void glUniform3iv(int location, int count, int* value);

			public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);

			public delegate void glUniform4fv(int location, int count, float* value);

			public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);

			public delegate void glUniform4iv(int location, int count, int* value);

			public delegate void glUniformMatrix2fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix3fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix4fv(int location, int count, bool transpose, float* value);

			public delegate void glUseProgram(uint program);

			public delegate void glValidateProgram(uint program);

			public delegate void glVertexAttrib1f(uint index, float x);

			public delegate void glVertexAttrib1fv(uint index, float* v);

			public delegate void glVertexAttrib2f(uint index, float x, float y);

			public delegate void glVertexAttrib2fv(uint index, float* v);

			public delegate void glVertexAttrib3f(uint index, float x, float y, float z);

			public delegate void glVertexAttrib3fv(uint index, float* v);

			public delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);

			public delegate void glVertexAttrib4fv(uint index, float* v);

			public delegate void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);

			public delegate void glViewport(int x, int y, int width, int height);

		}

		public static class Functions
		{
			public static Delegates.glActiveTexture glActiveTexture { get; set; }

			public static Delegates.glAttachShader glAttachShader { get; set; }

			public static Delegates.glBindAttribLocation glBindAttribLocation { get; set; }

			public static Delegates.glBindBuffer glBindBuffer { get; set; }

			public static Delegates.glBindFramebuffer glBindFramebuffer { get; set; }

			public static Delegates.glBindRenderbuffer glBindRenderbuffer { get; set; }

			public static Delegates.glBindTexture glBindTexture { get; set; }

			public static Delegates.glBlendColor glBlendColor { get; set; }

			public static Delegates.glBlendEquation glBlendEquation { get; set; }

			public static Delegates.glBlendEquationSeparate glBlendEquationSeparate { get; set; }

			public static Delegates.glBlendFunc glBlendFunc { get; set; }

			public static Delegates.glBlendFuncSeparate glBlendFuncSeparate { get; set; }

			public static Delegates.glBufferData glBufferData { get; set; }

			public static Delegates.glBufferSubData glBufferSubData { get; set; }

			public static Delegates.glCheckFramebufferStatus glCheckFramebufferStatus { get; set; }

			public static Delegates.glClear glClear { get; set; }

			public static Delegates.glClearColor glClearColor { get; set; }

			public static Delegates.glClearDepthf glClearDepthf { get; set; }

			public static Delegates.glClearStencil glClearStencil { get; set; }

			public static Delegates.glColorMask glColorMask { get; set; }

			public static Delegates.glCompileShader glCompileShader { get; set; }

			public static Delegates.glCompressedTexImage2D glCompressedTexImage2D { get; set; }

			public static Delegates.glCompressedTexSubImage2D glCompressedTexSubImage2D { get; set; }

			public static Delegates.glCopyTexImage2D glCopyTexImage2D { get; set; }

			public static Delegates.glCopyTexSubImage2D glCopyTexSubImage2D { get; set; }

			public static Delegates.glCreateProgram glCreateProgram { get; set; }

			public static Delegates.glCreateShader glCreateShader { get; set; }

			public static Delegates.glCullFace glCullFace { get; set; }

			public static Delegates.glDeleteBuffers glDeleteBuffers { get; set; }

			public static Delegates.glDeleteFramebuffers glDeleteFramebuffers { get; set; }

			public static Delegates.glDeleteProgram glDeleteProgram { get; set; }

			public static Delegates.glDeleteRenderbuffers glDeleteRenderbuffers { get; set; }

			public static Delegates.glDeleteShader glDeleteShader { get; set; }

			public static Delegates.glDeleteTextures glDeleteTextures { get; set; }

			public static Delegates.glDepthFunc glDepthFunc { get; set; }

			public static Delegates.glDepthMask glDepthMask { get; set; }

			public static Delegates.glDepthRangef glDepthRangef { get; set; }

			public static Delegates.glDetachShader glDetachShader { get; set; }

			public static Delegates.glDisable glDisable { get; set; }

			public static Delegates.glDisableVertexAttribArray glDisableVertexAttribArray { get; set; }

			public static Delegates.glDrawArrays glDrawArrays { get; set; }

			public static Delegates.glDrawElements glDrawElements { get; set; }

			public static Delegates.glEnable glEnable { get; set; }

			public static Delegates.glEnableVertexAttribArray glEnableVertexAttribArray { get; set; }

			public static Delegates.glFinish glFinish { get; set; }

			public static Delegates.glFlush glFlush { get; set; }

			public static Delegates.glFramebufferRenderbuffer glFramebufferRenderbuffer { get; set; }

			public static Delegates.glFramebufferTexture2D glFramebufferTexture2D { get; set; }

			public static Delegates.glFrontFace glFrontFace { get; set; }

			public static Delegates.glGenBuffers glGenBuffers { get; set; }

			public static Delegates.glGenerateMipmap glGenerateMipmap { get; set; }

			public static Delegates.glGenFramebuffers glGenFramebuffers { get; set; }

			public static Delegates.glGenRenderbuffers glGenRenderbuffers { get; set; }

			public static Delegates.glGenTextures glGenTextures { get; set; }

			public static Delegates.glGetActiveAttrib glGetActiveAttrib { get; set; }

			public static Delegates.glGetActiveUniform glGetActiveUniform { get; set; }

			public static Delegates.glGetAttachedShaders glGetAttachedShaders { get; set; }

			public static Delegates.glGetAttribLocation glGetAttribLocation { get; set; }

			public static Delegates.glGetBooleanv glGetBooleanv { get; set; }

			public static Delegates.glGetBufferParameteriv glGetBufferParameteriv { get; set; }

			public static Delegates.glGetError glGetError { get; set; }

			public static Delegates.glGetFloatv glGetFloatv { get; set; }

			public static Delegates.glGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv { get; set; }

			public static Delegates.glGetIntegerv glGetIntegerv { get; set; }

			public static Delegates.glGetProgramInfoLog glGetProgramInfoLog { get; set; }

			public static Delegates.glGetProgramiv glGetProgramiv { get; set; }

			public static Delegates.glGetRenderbufferParameteriv glGetRenderbufferParameteriv { get; set; }

			public static Delegates.glGetShaderInfoLog glGetShaderInfoLog { get; set; }

			public static Delegates.glGetShaderiv glGetShaderiv { get; set; }

			public static Delegates.glGetShaderPrecisionFormat glGetShaderPrecisionFormat { get; set; }

			public static Delegates.glGetShaderSource glGetShaderSource { get; set; }

			public static Delegates.glGetString glGetString { get; set; }

			public static Delegates.glGetTexParameterfv glGetTexParameterfv { get; set; }

			public static Delegates.glGetTexParameteriv glGetTexParameteriv { get; set; }

			public static Delegates.glGetUniformfv glGetUniformfv { get; set; }

			public static Delegates.glGetUniformiv glGetUniformiv { get; set; }

			public static Delegates.glGetUniformLocation glGetUniformLocation { get; set; }

			public static Delegates.glGetVertexAttribfv glGetVertexAttribfv { get; set; }

			public static Delegates.glGetVertexAttribiv glGetVertexAttribiv { get; set; }

			public static Delegates.glGetVertexAttribPointerv glGetVertexAttribPointerv { get; set; }

			public static Delegates.glHint glHint { get; set; }

			public static Delegates.glIsBuffer glIsBuffer { get; set; }

			public static Delegates.glIsEnabled glIsEnabled { get; set; }

			public static Delegates.glIsFramebuffer glIsFramebuffer { get; set; }

			public static Delegates.glIsProgram glIsProgram { get; set; }

			public static Delegates.glIsRenderbuffer glIsRenderbuffer { get; set; }

			public static Delegates.glIsShader glIsShader { get; set; }

			public static Delegates.glIsTexture glIsTexture { get; set; }

			public static Delegates.glLineWidth glLineWidth { get; set; }

			public static Delegates.glLinkProgram glLinkProgram { get; set; }

			public static Delegates.glPixelStorei glPixelStorei { get; set; }

			public static Delegates.glPolygonOffset glPolygonOffset { get; set; }

			public static Delegates.glReadPixels glReadPixels { get; set; }

			public static Delegates.glReleaseShaderCompiler glReleaseShaderCompiler { get; set; }

			public static Delegates.glRenderbufferStorage glRenderbufferStorage { get; set; }

			public static Delegates.glSampleCoverage glSampleCoverage { get; set; }

			public static Delegates.glScissor glScissor { get; set; }

			public static Delegates.glShaderBinary glShaderBinary { get; set; }

			public static Delegates.glShaderSource glShaderSource { get; set; }

			public static Delegates.glStencilFunc glStencilFunc { get; set; }

			public static Delegates.glStencilFuncSeparate glStencilFuncSeparate { get; set; }

			public static Delegates.glStencilMask glStencilMask { get; set; }

			public static Delegates.glStencilMaskSeparate glStencilMaskSeparate { get; set; }

			public static Delegates.glStencilOp glStencilOp { get; set; }

			public static Delegates.glStencilOpSeparate glStencilOpSeparate { get; set; }

			public static Delegates.glTexImage2D glTexImage2D { get; set; }

			public static Delegates.glTexParameterf glTexParameterf { get; set; }

			public static Delegates.glTexParameterfv glTexParameterfv { get; set; }

			public static Delegates.glTexParameteri glTexParameteri { get; set; }

			public static Delegates.glTexParameteriv glTexParameteriv { get; set; }

			public static Delegates.glTexSubImage2D glTexSubImage2D { get; set; }

			public static Delegates.glUniform1f glUniform1f { get; set; }

			public static Delegates.glUniform1fv glUniform1fv { get; set; }

			public static Delegates.glUniform1i glUniform1i { get; set; }

			public static Delegates.glUniform1iv glUniform1iv { get; set; }

			public static Delegates.glUniform2f glUniform2f { get; set; }

			public static Delegates.glUniform2fv glUniform2fv { get; set; }

			public static Delegates.glUniform2i glUniform2i { get; set; }

			public static Delegates.glUniform2iv glUniform2iv { get; set; }

			public static Delegates.glUniform3f glUniform3f { get; set; }

			public static Delegates.glUniform3fv glUniform3fv { get; set; }

			public static Delegates.glUniform3i glUniform3i { get; set; }

			public static Delegates.glUniform3iv glUniform3iv { get; set; }

			public static Delegates.glUniform4f glUniform4f { get; set; }

			public static Delegates.glUniform4fv glUniform4fv { get; set; }

			public static Delegates.glUniform4i glUniform4i { get; set; }

			public static Delegates.glUniform4iv glUniform4iv { get; set; }

			public static Delegates.glUniformMatrix2fv glUniformMatrix2fv { get; set; }

			public static Delegates.glUniformMatrix3fv glUniformMatrix3fv { get; set; }

			public static Delegates.glUniformMatrix4fv glUniformMatrix4fv { get; set; }

			public static Delegates.glUseProgram glUseProgram { get; set; }

			public static Delegates.glValidateProgram glValidateProgram { get; set; }

			public static Delegates.glVertexAttrib1f glVertexAttrib1f { get; set; }

			public static Delegates.glVertexAttrib1fv glVertexAttrib1fv { get; set; }

			public static Delegates.glVertexAttrib2f glVertexAttrib2f { get; set; }

			public static Delegates.glVertexAttrib2fv glVertexAttrib2fv { get; set; }

			public static Delegates.glVertexAttrib3f glVertexAttrib3f { get; set; }

			public static Delegates.glVertexAttrib3fv glVertexAttrib3fv { get; set; }

			public static Delegates.glVertexAttrib4f glVertexAttrib4f { get; set; }

			public static Delegates.glVertexAttrib4fv glVertexAttrib4fv { get; set; }

			public static Delegates.glVertexAttribPointer glVertexAttribPointer { get; set; }

			public static Delegates.glViewport glViewport { get; set; }

		}

#if !GLDOTNET_EXCLUDE_GLINIT
		public static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)
		{
			if (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));

			T getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));

			if (versionMajor > 0 || (versionMajor == 0 && versionMinor >= 0))
			{
				Functions.glActiveTexture = getProc<Delegates.glActiveTexture>("glActiveTexture");
				Functions.glAttachShader = getProc<Delegates.glAttachShader>("glAttachShader");
				Functions.glBindAttribLocation = getProc<Delegates.glBindAttribLocation>("glBindAttribLocation");
				Functions.glBindBuffer = getProc<Delegates.glBindBuffer>("glBindBuffer");
				Functions.glBindFramebuffer = getProc<Delegates.glBindFramebuffer>("glBindFramebuffer");
				Functions.glBindRenderbuffer = getProc<Delegates.glBindRenderbuffer>("glBindRenderbuffer");
				Functions.glBindTexture = getProc<Delegates.glBindTexture>("glBindTexture");
				Functions.glBlendColor = getProc<Delegates.glBlendColor>("glBlendColor");
				Functions.glBlendEquation = getProc<Delegates.glBlendEquation>("glBlendEquation");
				Functions.glBlendEquationSeparate = getProc<Delegates.glBlendEquationSeparate>("glBlendEquationSeparate");
				Functions.glBlendFunc = getProc<Delegates.glBlendFunc>("glBlendFunc");
				Functions.glBlendFuncSeparate = getProc<Delegates.glBlendFuncSeparate>("glBlendFuncSeparate");
				Functions.glBufferData = getProc<Delegates.glBufferData>("glBufferData");
				Functions.glBufferSubData = getProc<Delegates.glBufferSubData>("glBufferSubData");
				Functions.glCheckFramebufferStatus = getProc<Delegates.glCheckFramebufferStatus>("glCheckFramebufferStatus");
				Functions.glClear = getProc<Delegates.glClear>("glClear");
				Functions.glClearColor = getProc<Delegates.glClearColor>("glClearColor");
				Functions.glClearDepthf = getProc<Delegates.glClearDepthf>("glClearDepthf");
				Functions.glClearStencil = getProc<Delegates.glClearStencil>("glClearStencil");
				Functions.glColorMask = getProc<Delegates.glColorMask>("glColorMask");
				Functions.glCompileShader = getProc<Delegates.glCompileShader>("glCompileShader");
				Functions.glCompressedTexImage2D = getProc<Delegates.glCompressedTexImage2D>("glCompressedTexImage2D");
				Functions.glCompressedTexSubImage2D = getProc<Delegates.glCompressedTexSubImage2D>("glCompressedTexSubImage2D");
				Functions.glCopyTexImage2D = getProc<Delegates.glCopyTexImage2D>("glCopyTexImage2D");
				Functions.glCopyTexSubImage2D = getProc<Delegates.glCopyTexSubImage2D>("glCopyTexSubImage2D");
				Functions.glCreateProgram = getProc<Delegates.glCreateProgram>("glCreateProgram");
				Functions.glCreateShader = getProc<Delegates.glCreateShader>("glCreateShader");
				Functions.glCullFace = getProc<Delegates.glCullFace>("glCullFace");
				Functions.glDeleteBuffers = getProc<Delegates.glDeleteBuffers>("glDeleteBuffers");
				Functions.glDeleteFramebuffers = getProc<Delegates.glDeleteFramebuffers>("glDeleteFramebuffers");
				Functions.glDeleteProgram = getProc<Delegates.glDeleteProgram>("glDeleteProgram");
				Functions.glDeleteRenderbuffers = getProc<Delegates.glDeleteRenderbuffers>("glDeleteRenderbuffers");
				Functions.glDeleteShader = getProc<Delegates.glDeleteShader>("glDeleteShader");
				Functions.glDeleteTextures = getProc<Delegates.glDeleteTextures>("glDeleteTextures");
				Functions.glDepthFunc = getProc<Delegates.glDepthFunc>("glDepthFunc");
				Functions.glDepthMask = getProc<Delegates.glDepthMask>("glDepthMask");
				Functions.glDepthRangef = getProc<Delegates.glDepthRangef>("glDepthRangef");
				Functions.glDetachShader = getProc<Delegates.glDetachShader>("glDetachShader");
				Functions.glDisable = getProc<Delegates.glDisable>("glDisable");
				Functions.glDisableVertexAttribArray = getProc<Delegates.glDisableVertexAttribArray>("glDisableVertexAttribArray");
				Functions.glDrawArrays = getProc<Delegates.glDrawArrays>("glDrawArrays");
				Functions.glDrawElements = getProc<Delegates.glDrawElements>("glDrawElements");
				Functions.glEnable = getProc<Delegates.glEnable>("glEnable");
				Functions.glEnableVertexAttribArray = getProc<Delegates.glEnableVertexAttribArray>("glEnableVertexAttribArray");
				Functions.glFinish = getProc<Delegates.glFinish>("glFinish");
				Functions.glFlush = getProc<Delegates.glFlush>("glFlush");
				Functions.glFramebufferRenderbuffer = getProc<Delegates.glFramebufferRenderbuffer>("glFramebufferRenderbuffer");
				Functions.glFramebufferTexture2D = getProc<Delegates.glFramebufferTexture2D>("glFramebufferTexture2D");
				Functions.glFrontFace = getProc<Delegates.glFrontFace>("glFrontFace");
				Functions.glGenBuffers = getProc<Delegates.glGenBuffers>("glGenBuffers");
				Functions.glGenerateMipmap = getProc<Delegates.glGenerateMipmap>("glGenerateMipmap");
				Functions.glGenFramebuffers = getProc<Delegates.glGenFramebuffers>("glGenFramebuffers");
				Functions.glGenRenderbuffers = getProc<Delegates.glGenRenderbuffers>("glGenRenderbuffers");
				Functions.glGenTextures = getProc<Delegates.glGenTextures>("glGenTextures");
				Functions.glGetActiveAttrib = getProc<Delegates.glGetActiveAttrib>("glGetActiveAttrib");
				Functions.glGetActiveUniform = getProc<Delegates.glGetActiveUniform>("glGetActiveUniform");
				Functions.glGetAttachedShaders = getProc<Delegates.glGetAttachedShaders>("glGetAttachedShaders");
				Functions.glGetAttribLocation = getProc<Delegates.glGetAttribLocation>("glGetAttribLocation");
				Functions.glGetBooleanv = getProc<Delegates.glGetBooleanv>("glGetBooleanv");
				Functions.glGetBufferParameteriv = getProc<Delegates.glGetBufferParameteriv>("glGetBufferParameteriv");
				Functions.glGetError = getProc<Delegates.glGetError>("glGetError");
				Functions.glGetFloatv = getProc<Delegates.glGetFloatv>("glGetFloatv");
				Functions.glGetFramebufferAttachmentParameteriv = getProc<Delegates.glGetFramebufferAttachmentParameteriv>("glGetFramebufferAttachmentParameteriv");
				Functions.glGetIntegerv = getProc<Delegates.glGetIntegerv>("glGetIntegerv");
				Functions.glGetProgramInfoLog = getProc<Delegates.glGetProgramInfoLog>("glGetProgramInfoLog");
				Functions.glGetProgramiv = getProc<Delegates.glGetProgramiv>("glGetProgramiv");
				Functions.glGetRenderbufferParameteriv = getProc<Delegates.glGetRenderbufferParameteriv>("glGetRenderbufferParameteriv");
				Functions.glGetShaderInfoLog = getProc<Delegates.glGetShaderInfoLog>("glGetShaderInfoLog");
				Functions.glGetShaderiv = getProc<Delegates.glGetShaderiv>("glGetShaderiv");
				Functions.glGetShaderPrecisionFormat = getProc<Delegates.glGetShaderPrecisionFormat>("glGetShaderPrecisionFormat");
				Functions.glGetShaderSource = getProc<Delegates.glGetShaderSource>("glGetShaderSource");
				Functions.glGetString = getProc<Delegates.glGetString>("glGetString");
				Functions.glGetTexParameterfv = getProc<Delegates.glGetTexParameterfv>("glGetTexParameterfv");
				Functions.glGetTexParameteriv = getProc<Delegates.glGetTexParameteriv>("glGetTexParameteriv");
				Functions.glGetUniformfv = getProc<Delegates.glGetUniformfv>("glGetUniformfv");
				Functions.glGetUniformiv = getProc<Delegates.glGetUniformiv>("glGetUniformiv");
				Functions.glGetUniformLocation = getProc<Delegates.glGetUniformLocation>("glGetUniformLocation");
				Functions.glGetVertexAttribfv = getProc<Delegates.glGetVertexAttribfv>("glGetVertexAttribfv");
				Functions.glGetVertexAttribiv = getProc<Delegates.glGetVertexAttribiv>("glGetVertexAttribiv");
				Functions.glGetVertexAttribPointerv = getProc<Delegates.glGetVertexAttribPointerv>("glGetVertexAttribPointerv");
				Functions.glHint = getProc<Delegates.glHint>("glHint");
				Functions.glIsBuffer = getProc<Delegates.glIsBuffer>("glIsBuffer");
				Functions.glIsEnabled = getProc<Delegates.glIsEnabled>("glIsEnabled");
				Functions.glIsFramebuffer = getProc<Delegates.glIsFramebuffer>("glIsFramebuffer");
				Functions.glIsProgram = getProc<Delegates.glIsProgram>("glIsProgram");
				Functions.glIsRenderbuffer = getProc<Delegates.glIsRenderbuffer>("glIsRenderbuffer");
				Functions.glIsShader = getProc<Delegates.glIsShader>("glIsShader");
				Functions.glIsTexture = getProc<Delegates.glIsTexture>("glIsTexture");
				Functions.glLineWidth = getProc<Delegates.glLineWidth>("glLineWidth");
				Functions.glLinkProgram = getProc<Delegates.glLinkProgram>("glLinkProgram");
				Functions.glPixelStorei = getProc<Delegates.glPixelStorei>("glPixelStorei");
				Functions.glPolygonOffset = getProc<Delegates.glPolygonOffset>("glPolygonOffset");
				Functions.glReadPixels = getProc<Delegates.glReadPixels>("glReadPixels");
				Functions.glReleaseShaderCompiler = getProc<Delegates.glReleaseShaderCompiler>("glReleaseShaderCompiler");
				Functions.glRenderbufferStorage = getProc<Delegates.glRenderbufferStorage>("glRenderbufferStorage");
				Functions.glSampleCoverage = getProc<Delegates.glSampleCoverage>("glSampleCoverage");
				Functions.glScissor = getProc<Delegates.glScissor>("glScissor");
				Functions.glShaderBinary = getProc<Delegates.glShaderBinary>("glShaderBinary");
				Functions.glShaderSource = getProc<Delegates.glShaderSource>("glShaderSource");
				Functions.glStencilFunc = getProc<Delegates.glStencilFunc>("glStencilFunc");
				Functions.glStencilFuncSeparate = getProc<Delegates.glStencilFuncSeparate>("glStencilFuncSeparate");
				Functions.glStencilMask = getProc<Delegates.glStencilMask>("glStencilMask");
				Functions.glStencilMaskSeparate = getProc<Delegates.glStencilMaskSeparate>("glStencilMaskSeparate");
				Functions.glStencilOp = getProc<Delegates.glStencilOp>("glStencilOp");
				Functions.glStencilOpSeparate = getProc<Delegates.glStencilOpSeparate>("glStencilOpSeparate");
				Functions.glTexImage2D = getProc<Delegates.glTexImage2D>("glTexImage2D");
				Functions.glTexParameterf = getProc<Delegates.glTexParameterf>("glTexParameterf");
				Functions.glTexParameterfv = getProc<Delegates.glTexParameterfv>("glTexParameterfv");
				Functions.glTexParameteri = getProc<Delegates.glTexParameteri>("glTexParameteri");
				Functions.glTexParameteriv = getProc<Delegates.glTexParameteriv>("glTexParameteriv");
				Functions.glTexSubImage2D = getProc<Delegates.glTexSubImage2D>("glTexSubImage2D");
				Functions.glUniform1f = getProc<Delegates.glUniform1f>("glUniform1f");
				Functions.glUniform1fv = getProc<Delegates.glUniform1fv>("glUniform1fv");
				Functions.glUniform1i = getProc<Delegates.glUniform1i>("glUniform1i");
				Functions.glUniform1iv = getProc<Delegates.glUniform1iv>("glUniform1iv");
				Functions.glUniform2f = getProc<Delegates.glUniform2f>("glUniform2f");
				Functions.glUniform2fv = getProc<Delegates.glUniform2fv>("glUniform2fv");
				Functions.glUniform2i = getProc<Delegates.glUniform2i>("glUniform2i");
				Functions.glUniform2iv = getProc<Delegates.glUniform2iv>("glUniform2iv");
				Functions.glUniform3f = getProc<Delegates.glUniform3f>("glUniform3f");
				Functions.glUniform3fv = getProc<Delegates.glUniform3fv>("glUniform3fv");
				Functions.glUniform3i = getProc<Delegates.glUniform3i>("glUniform3i");
				Functions.glUniform3iv = getProc<Delegates.glUniform3iv>("glUniform3iv");
				Functions.glUniform4f = getProc<Delegates.glUniform4f>("glUniform4f");
				Functions.glUniform4fv = getProc<Delegates.glUniform4fv>("glUniform4fv");
				Functions.glUniform4i = getProc<Delegates.glUniform4i>("glUniform4i");
				Functions.glUniform4iv = getProc<Delegates.glUniform4iv>("glUniform4iv");
				Functions.glUniformMatrix2fv = getProc<Delegates.glUniformMatrix2fv>("glUniformMatrix2fv");
				Functions.glUniformMatrix3fv = getProc<Delegates.glUniformMatrix3fv>("glUniformMatrix3fv");
				Functions.glUniformMatrix4fv = getProc<Delegates.glUniformMatrix4fv>("glUniformMatrix4fv");
				Functions.glUseProgram = getProc<Delegates.glUseProgram>("glUseProgram");
				Functions.glValidateProgram = getProc<Delegates.glValidateProgram>("glValidateProgram");
				Functions.glVertexAttrib1f = getProc<Delegates.glVertexAttrib1f>("glVertexAttrib1f");
				Functions.glVertexAttrib1fv = getProc<Delegates.glVertexAttrib1fv>("glVertexAttrib1fv");
				Functions.glVertexAttrib2f = getProc<Delegates.glVertexAttrib2f>("glVertexAttrib2f");
				Functions.glVertexAttrib2fv = getProc<Delegates.glVertexAttrib2fv>("glVertexAttrib2fv");
				Functions.glVertexAttrib3f = getProc<Delegates.glVertexAttrib3f>("glVertexAttrib3f");
				Functions.glVertexAttrib3fv = getProc<Delegates.glVertexAttrib3fv>("glVertexAttrib3fv");
				Functions.glVertexAttrib4f = getProc<Delegates.glVertexAttrib4f>("glVertexAttrib4f");
				Functions.glVertexAttrib4fv = getProc<Delegates.glVertexAttrib4fv>("glVertexAttrib4fv");
				Functions.glVertexAttribPointer = getProc<Delegates.glVertexAttribPointer>("glVertexAttribPointer");
				Functions.glViewport = getProc<Delegates.glViewport>("glViewport");
			}
		}
#endif

		public static void glActiveTexture(uint texture)
		{
			Functions.glActiveTexture(texture);
		}

		public static void glAttachShader(uint program, uint shader)
		{
			Functions.glAttachShader(program, shader);
		}

		public static void glBindAttribLocation(uint program, uint index, string name)
		{
			Functions.glBindAttribLocation(program, index, name);
		}

		public static void glBindBuffer(uint target, uint buffer)
		{
			Functions.glBindBuffer(target, buffer);
		}

		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			Functions.glBindFramebuffer(target, framebuffer);
		}

		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			Functions.glBindRenderbuffer(target, renderbuffer);
		}

		public static void glBindTexture(uint target, uint texture)
		{
			Functions.glBindTexture(target, texture);
		}

		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			Functions.glBlendColor(red, green, blue, alpha);
		}

		public static void glBlendEquation(uint mode)
		{
			Functions.glBlendEquation(mode);
		}

		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			Functions.glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		public static void glBlendFunc(uint sfactor, uint dfactor)
		{
			Functions.glBlendFunc(sfactor, dfactor);
		}

		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			Functions.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		public static void glBufferData(uint target, int size, void* data, uint usage)
		{
			Functions.glBufferData(target, size, data, usage);
		}

		public static void glBufferSubData(uint target, int offset, int size, void* data)
		{
			Functions.glBufferSubData(target, offset, size, data);
		}

		public static uint glCheckFramebufferStatus(uint target)
		{
			return Functions.glCheckFramebufferStatus(target);
		}

		public static void glClear(uint mask)
		{
			Functions.glClear(mask);
		}

		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			Functions.glClearColor(red, green, blue, alpha);
		}

		public static void glClearDepthf(float d)
		{
			Functions.glClearDepthf(d);
		}

		public static void glClearStencil(int s)
		{
			Functions.glClearStencil(s);
		}

		public static void glColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Functions.glColorMask(red, green, blue, alpha);
		}

		public static void glCompileShader(uint shader)
		{
			Functions.glCompileShader(shader);
		}

		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data)
		{
			Functions.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			Functions.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Functions.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		public static uint glCreateProgram()
		{
			return Functions.glCreateProgram();
		}

		public static uint glCreateShader(uint type)
		{
			return Functions.glCreateShader(type);
		}

		public static void glCullFace(uint mode)
		{
			Functions.glCullFace(mode);
		}

		public static void glDeleteBuffers(int n, uint* buffers)
		{
			Functions.glDeleteBuffers(n, buffers);
		}

		public static void glDeleteFramebuffers(int n, uint* framebuffers)
		{
			Functions.glDeleteFramebuffers(n, framebuffers);
		}

		public static void glDeleteProgram(uint program)
		{
			Functions.glDeleteProgram(program);
		}

		public static void glDeleteRenderbuffers(int n, uint* renderbuffers)
		{
			Functions.glDeleteRenderbuffers(n, renderbuffers);
		}

		public static void glDeleteShader(uint shader)
		{
			Functions.glDeleteShader(shader);
		}

		public static void glDeleteTextures(int n, uint* textures)
		{
			Functions.glDeleteTextures(n, textures);
		}

		public static void glDepthFunc(uint func)
		{
			Functions.glDepthFunc(func);
		}

		public static void glDepthMask(bool flag)
		{
			Functions.glDepthMask(flag);
		}

		public static void glDepthRangef(float n, float f)
		{
			Functions.glDepthRangef(n, f);
		}

		public static void glDetachShader(uint program, uint shader)
		{
			Functions.glDetachShader(program, shader);
		}

		public static void glDisable(uint cap)
		{
			Functions.glDisable(cap);
		}

		public static void glDisableVertexAttribArray(uint index)
		{
			Functions.glDisableVertexAttribArray(index);
		}

		public static void glDrawArrays(uint mode, int first, int count)
		{
			Functions.glDrawArrays(mode, first, count);
		}

		public static void glDrawElements(uint mode, int count, uint type, void* indices)
		{
			Functions.glDrawElements(mode, count, type, indices);
		}

		public static void glEnable(uint cap)
		{
			Functions.glEnable(cap);
		}

		public static void glEnableVertexAttribArray(uint index)
		{
			Functions.glEnableVertexAttribArray(index);
		}

		public static void glFinish()
		{
			Functions.glFinish();
		}

		public static void glFlush()
		{
			Functions.glFlush();
		}

		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Functions.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Functions.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		public static void glFrontFace(uint mode)
		{
			Functions.glFrontFace(mode);
		}

		public static void glGenBuffers(int n, uint* buffers)
		{
			Functions.glGenBuffers(n, buffers);
		}

		public static void glGenerateMipmap(uint target)
		{
			Functions.glGenerateMipmap(target);
		}

		public static void glGenFramebuffers(int n, uint* framebuffers)
		{
			Functions.glGenFramebuffers(n, framebuffers);
		}

		public static void glGenRenderbuffers(int n, uint* renderbuffers)
		{
			Functions.glGenRenderbuffers(n, renderbuffers);
		}

		public static void glGenTextures(int n, uint* textures)
		{
			Functions.glGenTextures(n, textures);
		}

		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			Functions.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			Functions.glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			Functions.glGetAttachedShaders(program, maxCount, count, shaders);
		}

		public static int glGetAttribLocation(uint program, string name)
		{
			return Functions.glGetAttribLocation(program, name);
		}

		public static void glGetBooleanv(uint pname, bool* data)
		{
			Functions.glGetBooleanv(pname, data);
		}

		public static void glGetBufferParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetBufferParameteriv(target, pname, @params);
		}

		public static uint glGetError()
		{
			return Functions.glGetError();
		}

		public static void glGetFloatv(uint pname, float* data)
		{
			Functions.glGetFloatv(pname, data);
		}

		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params)
		{
			Functions.glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		public static void glGetIntegerv(uint pname, int* data)
		{
			Functions.glGetIntegerv(pname, data);
		}

		public static void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog)
		{
			Functions.glGetProgramInfoLog(program, bufSize, length, infoLog);
		}

		public static void glGetProgramiv(uint program, uint pname, int* @params)
		{
			Functions.glGetProgramiv(program, pname, @params);
		}

		public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetRenderbufferParameteriv(target, pname, @params);
		}

		public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog)
		{
			Functions.glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}

		public static void glGetShaderiv(uint shader, uint pname, int* @params)
		{
			Functions.glGetShaderiv(shader, pname, @params);
		}

		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision)
		{
			Functions.glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		public static void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source)
		{
			Functions.glGetShaderSource(shader, bufSize, length, source);
		}

		public static IntPtr glGetString(uint name)
		{
			return Functions.glGetString(name);
		}

		public static void glGetTexParameterfv(uint target, uint pname, float* @params)
		{
			Functions.glGetTexParameterfv(target, pname, @params);
		}

		public static void glGetTexParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetTexParameteriv(target, pname, @params);
		}

		public static void glGetUniformfv(uint program, int location, float* @params)
		{
			Functions.glGetUniformfv(program, location, @params);
		}

		public static void glGetUniformiv(uint program, int location, int* @params)
		{
			Functions.glGetUniformiv(program, location, @params);
		}

		public static int glGetUniformLocation(uint program, string name)
		{
			return Functions.glGetUniformLocation(program, name);
		}

		public static void glGetVertexAttribfv(uint index, uint pname, float* @params)
		{
			Functions.glGetVertexAttribfv(index, pname, @params);
		}

		public static void glGetVertexAttribiv(uint index, uint pname, int* @params)
		{
			Functions.glGetVertexAttribiv(index, pname, @params);
		}

		public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer)
		{
			Functions.glGetVertexAttribPointerv(index, pname, pointer);
		}

		public static void glHint(uint target, uint mode)
		{
			Functions.glHint(target, mode);
		}

		public static bool glIsBuffer(uint buffer)
		{
			return Functions.glIsBuffer(buffer);
		}

		public static bool glIsEnabled(uint cap)
		{
			return Functions.glIsEnabled(cap);
		}

		public static bool glIsFramebuffer(uint framebuffer)
		{
			return Functions.glIsFramebuffer(framebuffer);
		}

		public static bool glIsProgram(uint program)
		{
			return Functions.glIsProgram(program);
		}

		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return Functions.glIsRenderbuffer(renderbuffer);
		}

		public static bool glIsShader(uint shader)
		{
			return Functions.glIsShader(shader);
		}

		public static bool glIsTexture(uint texture)
		{
			return Functions.glIsTexture(texture);
		}

		public static void glLineWidth(float width)
		{
			Functions.glLineWidth(width);
		}

		public static void glLinkProgram(uint program)
		{
			Functions.glLinkProgram(program);
		}

		public static void glPixelStorei(uint pname, int param)
		{
			Functions.glPixelStorei(pname, param);
		}

		public static void glPolygonOffset(float factor, float units)
		{
			Functions.glPolygonOffset(factor, units);
		}

		public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels)
		{
			Functions.glReadPixels(x, y, width, height, format, type, pixels);
		}

		public static void glReleaseShaderCompiler()
		{
			Functions.glReleaseShaderCompiler();
		}

		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			Functions.glRenderbufferStorage(target, internalformat, width, height);
		}

		public static void glSampleCoverage(float value, bool invert)
		{
			Functions.glSampleCoverage(value, invert);
		}

		public static void glScissor(int x, int y, int width, int height)
		{
			Functions.glScissor(x, y, width, height);
		}

		public static void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length)
		{
			Functions.glShaderBinary(count, shaders, binaryformat, binary, length);
		}

		public static void glShaderSource(uint shader, int count, string[] @string, int* length)
		{
			Functions.glShaderSource(shader, count, @string, length);
		}

		public static void glStencilFunc(uint func, int @ref, uint mask)
		{
			Functions.glStencilFunc(func, @ref, mask);
		}

		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			Functions.glStencilFuncSeparate(face, func, @ref, mask);
		}

		public static void glStencilMask(uint mask)
		{
			Functions.glStencilMask(mask);
		}

		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			Functions.glStencilMaskSeparate(face, mask);
		}

		public static void glStencilOp(uint fail, uint zfail, uint zpass)
		{
			Functions.glStencilOp(fail, zfail, zpass);
		}

		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			Functions.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels)
		{
			Functions.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		public static void glTexParameterf(uint target, uint pname, float param)
		{
			Functions.glTexParameterf(target, pname, param);
		}

		public static void glTexParameterfv(uint target, uint pname, float* @params)
		{
			Functions.glTexParameterfv(target, pname, @params);
		}

		public static void glTexParameteri(uint target, uint pname, int param)
		{
			Functions.glTexParameteri(target, pname, param);
		}

		public static void glTexParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glTexParameteriv(target, pname, @params);
		}

		public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels)
		{
			Functions.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glUniform1f(int location, float v0)
		{
			Functions.glUniform1f(location, v0);
		}

		public static void glUniform1fv(int location, int count, float* value)
		{
			Functions.glUniform1fv(location, count, value);
		}

		public static void glUniform1i(int location, int v0)
		{
			Functions.glUniform1i(location, v0);
		}

		public static void glUniform1iv(int location, int count, int* value)
		{
			Functions.glUniform1iv(location, count, value);
		}

		public static void glUniform2f(int location, float v0, float v1)
		{
			Functions.glUniform2f(location, v0, v1);
		}

		public static void glUniform2fv(int location, int count, float* value)
		{
			Functions.glUniform2fv(location, count, value);
		}

		public static void glUniform2i(int location, int v0, int v1)
		{
			Functions.glUniform2i(location, v0, v1);
		}

		public static void glUniform2iv(int location, int count, int* value)
		{
			Functions.glUniform2iv(location, count, value);
		}

		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			Functions.glUniform3f(location, v0, v1, v2);
		}

		public static void glUniform3fv(int location, int count, float* value)
		{
			Functions.glUniform3fv(location, count, value);
		}

		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			Functions.glUniform3i(location, v0, v1, v2);
		}

		public static void glUniform3iv(int location, int count, int* value)
		{
			Functions.glUniform3iv(location, count, value);
		}

		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			Functions.glUniform4f(location, v0, v1, v2, v3);
		}

		public static void glUniform4fv(int location, int count, float* value)
		{
			Functions.glUniform4fv(location, count, value);
		}

		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			Functions.glUniform4i(location, v0, v1, v2, v3);
		}

		public static void glUniform4iv(int location, int count, int* value)
		{
			Functions.glUniform4iv(location, count, value);
		}

		public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix4fv(location, count, transpose, value);
		}

		public static void glUseProgram(uint program)
		{
			Functions.glUseProgram(program);
		}

		public static void glValidateProgram(uint program)
		{
			Functions.glValidateProgram(program);
		}

		public static void glVertexAttrib1f(uint index, float x)
		{
			Functions.glVertexAttrib1f(index, x);
		}

		public static void glVertexAttrib1fv(uint index, float* v)
		{
			Functions.glVertexAttrib1fv(index, v);
		}

		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			Functions.glVertexAttrib2f(index, x, y);
		}

		public static void glVertexAttrib2fv(uint index, float* v)
		{
			Functions.glVertexAttrib2fv(index, v);
		}

		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			Functions.glVertexAttrib3f(index, x, y, z);
		}

		public static void glVertexAttrib3fv(uint index, float* v)
		{
			Functions.glVertexAttrib3fv(index, v);
		}

		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			Functions.glVertexAttrib4f(index, x, y, z, w);
		}

		public static void glVertexAttrib4fv(uint index, float* v)
		{
			Functions.glVertexAttrib4fv(index, v);
		}

		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer)
		{
			Functions.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		public static void glViewport(int x, int y, int width, int height)
		{
			Functions.glViewport(x, y, width, height);
		}

	}
}
