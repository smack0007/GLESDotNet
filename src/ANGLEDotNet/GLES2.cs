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

namespace ANGLEDotNet
{
	public static unsafe partial class GLES2
	{
		public const string Library = "libglesv2";

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

		[DllImport(Library, EntryPoint = "glActiveTexture")]
		public static extern void glActiveTexture(uint texture);

		[DllImport(Library, EntryPoint = "glAttachShader")]
		public static extern void glAttachShader(uint program, uint shader);

		[DllImport(Library, EntryPoint = "glBindAttribLocation")]
		public static extern void glBindAttribLocation(uint program, uint index, string name);

		[DllImport(Library, EntryPoint = "glBindBuffer")]
		public static extern void glBindBuffer(uint target, uint buffer);

		[DllImport(Library, EntryPoint = "glBindFramebuffer")]
		public static extern void glBindFramebuffer(uint target, uint framebuffer);

		[DllImport(Library, EntryPoint = "glBindRenderbuffer")]
		public static extern void glBindRenderbuffer(uint target, uint renderbuffer);

		[DllImport(Library, EntryPoint = "glBindTexture")]
		public static extern void glBindTexture(uint target, uint texture);

		[DllImport(Library, EntryPoint = "glBlendColor")]
		public static extern void glBlendColor(float red, float green, float blue, float alpha);

		[DllImport(Library, EntryPoint = "glBlendEquation")]
		public static extern void glBlendEquation(uint mode);

		[DllImport(Library, EntryPoint = "glBlendEquationSeparate")]
		public static extern void glBlendEquationSeparate(uint modeRGB, uint modeAlpha);

		[DllImport(Library, EntryPoint = "glBlendFunc")]
		public static extern void glBlendFunc(uint sfactor, uint dfactor);

		[DllImport(Library, EntryPoint = "glBlendFuncSeparate")]
		public static extern void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

		[DllImport(Library, EntryPoint = "glBufferData")]
		public static extern void glBufferData(uint target, int size, void* data, uint usage);

		[DllImport(Library, EntryPoint = "glBufferSubData")]
		public static extern void glBufferSubData(uint target, int offset, int size, void* data);

		[DllImport(Library, EntryPoint = "glCheckFramebufferStatus")]
		public static extern uint glCheckFramebufferStatus(uint target);

		[DllImport(Library, EntryPoint = "glClear")]
		public static extern void glClear(uint mask);

		[DllImport(Library, EntryPoint = "glClearColor")]
		public static extern void glClearColor(float red, float green, float blue, float alpha);

		[DllImport(Library, EntryPoint = "glClearDepthf")]
		public static extern void glClearDepthf(float d);

		[DllImport(Library, EntryPoint = "glClearStencil")]
		public static extern void glClearStencil(int s);

		[DllImport(Library, EntryPoint = "glColorMask")]
		public static extern void glColorMask(bool red, bool green, bool blue, bool alpha);

		[DllImport(Library, EntryPoint = "glCompileShader")]
		public static extern void glCompileShader(uint shader);

		[DllImport(Library, EntryPoint = "glCompressedTexImage2D")]
		public static extern void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

		[DllImport(Library, EntryPoint = "glCompressedTexSubImage2D")]
		public static extern void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

		[DllImport(Library, EntryPoint = "glCopyTexImage2D")]
		public static extern void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

		[DllImport(Library, EntryPoint = "glCopyTexSubImage2D")]
		public static extern void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		[DllImport(Library, EntryPoint = "glCreateProgram")]
		public static extern uint glCreateProgram();

		[DllImport(Library, EntryPoint = "glCreateShader")]
		public static extern uint glCreateShader(uint type);

		[DllImport(Library, EntryPoint = "glCullFace")]
		public static extern void glCullFace(uint mode);

		[DllImport(Library, EntryPoint = "glDeleteBuffers")]
		public static extern void glDeleteBuffers(int n, uint* buffers);

		[DllImport(Library, EntryPoint = "glDeleteFramebuffers")]
		public static extern void glDeleteFramebuffers(int n, uint* framebuffers);

		[DllImport(Library, EntryPoint = "glDeleteProgram")]
		public static extern void glDeleteProgram(uint program);

		[DllImport(Library, EntryPoint = "glDeleteRenderbuffers")]
		public static extern void glDeleteRenderbuffers(int n, uint* renderbuffers);

		[DllImport(Library, EntryPoint = "glDeleteShader")]
		public static extern void glDeleteShader(uint shader);

		[DllImport(Library, EntryPoint = "glDeleteTextures")]
		public static extern void glDeleteTextures(int n, uint* textures);

		[DllImport(Library, EntryPoint = "glDepthFunc")]
		public static extern void glDepthFunc(uint func);

		[DllImport(Library, EntryPoint = "glDepthMask")]
		public static extern void glDepthMask(bool flag);

		[DllImport(Library, EntryPoint = "glDepthRangef")]
		public static extern void glDepthRangef(float n, float f);

		[DllImport(Library, EntryPoint = "glDetachShader")]
		public static extern void glDetachShader(uint program, uint shader);

		[DllImport(Library, EntryPoint = "glDisable")]
		public static extern void glDisable(uint cap);

		[DllImport(Library, EntryPoint = "glDisableVertexAttribArray")]
		public static extern void glDisableVertexAttribArray(uint index);

		[DllImport(Library, EntryPoint = "glDrawArrays")]
		public static extern void glDrawArrays(uint mode, int first, int count);

		[DllImport(Library, EntryPoint = "glDrawElements")]
		public static extern void glDrawElements(uint mode, int count, uint type, void* indices);

		[DllImport(Library, EntryPoint = "glEnable")]
		public static extern void glEnable(uint cap);

		[DllImport(Library, EntryPoint = "glEnableVertexAttribArray")]
		public static extern void glEnableVertexAttribArray(uint index);

		[DllImport(Library, EntryPoint = "glFinish")]
		public static extern void glFinish();

		[DllImport(Library, EntryPoint = "glFlush")]
		public static extern void glFlush();

		[DllImport(Library, EntryPoint = "glFramebufferRenderbuffer")]
		public static extern void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

		[DllImport(Library, EntryPoint = "glFramebufferTexture2D")]
		public static extern void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

		[DllImport(Library, EntryPoint = "glFrontFace")]
		public static extern void glFrontFace(uint mode);

		[DllImport(Library, EntryPoint = "glGenBuffers")]
		public static extern void glGenBuffers(int n, uint* buffers);

		[DllImport(Library, EntryPoint = "glGenerateMipmap")]
		public static extern void glGenerateMipmap(uint target);

		[DllImport(Library, EntryPoint = "glGenFramebuffers")]
		public static extern void glGenFramebuffers(int n, uint* framebuffers);

		[DllImport(Library, EntryPoint = "glGenRenderbuffers")]
		public static extern void glGenRenderbuffers(int n, uint* renderbuffers);

		[DllImport(Library, EntryPoint = "glGenTextures")]
		public static extern void glGenTextures(int n, uint* textures);

		[DllImport(Library, EntryPoint = "glGetActiveAttrib")]
		public static extern void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

		[DllImport(Library, EntryPoint = "glGetActiveUniform")]
		public static extern void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

		[DllImport(Library, EntryPoint = "glGetAttachedShaders")]
		public static extern void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

		[DllImport(Library, EntryPoint = "glGetAttribLocation")]
		public static extern int glGetAttribLocation(uint program, string name);

		[DllImport(Library, EntryPoint = "glGetBooleanv")]
		public static extern void glGetBooleanv(uint pname, bool* data);

		[DllImport(Library, EntryPoint = "glGetBufferParameteriv")]
		public static extern void glGetBufferParameteriv(uint target, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetError")]
		public static extern uint glGetError();

		[DllImport(Library, EntryPoint = "glGetFloatv")]
		public static extern void glGetFloatv(uint pname, float* data);

		[DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
		public static extern void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetIntegerv")]
		public static extern void glGetIntegerv(uint pname, int* data);

		[DllImport(Library, EntryPoint = "glGetProgramInfoLog")]
		public static extern void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog);

		[DllImport(Library, EntryPoint = "glGetProgramiv")]
		public static extern void glGetProgramiv(uint program, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetRenderbufferParameteriv")]
		public static extern void glGetRenderbufferParameteriv(uint target, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetShaderInfoLog")]
		public static extern void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog);

		[DllImport(Library, EntryPoint = "glGetShaderiv")]
		public static extern void glGetShaderiv(uint shader, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetShaderPrecisionFormat")]
		public static extern void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

		[DllImport(Library, EntryPoint = "glGetShaderSource")]
		public static extern void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source);

		[DllImport(Library, EntryPoint = "glGetString")]
		public static extern IntPtr glGetString(uint name);

		[DllImport(Library, EntryPoint = "glGetTexParameterfv")]
		public static extern void glGetTexParameterfv(uint target, uint pname, float* @params);

		[DllImport(Library, EntryPoint = "glGetTexParameteriv")]
		public static extern void glGetTexParameteriv(uint target, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetUniformfv")]
		public static extern void glGetUniformfv(uint program, int location, float* @params);

		[DllImport(Library, EntryPoint = "glGetUniformiv")]
		public static extern void glGetUniformiv(uint program, int location, int* @params);

		[DllImport(Library, EntryPoint = "glGetUniformLocation")]
		public static extern int glGetUniformLocation(uint program, string name);

		[DllImport(Library, EntryPoint = "glGetVertexAttribfv")]
		public static extern void glGetVertexAttribfv(uint index, uint pname, float* @params);

		[DllImport(Library, EntryPoint = "glGetVertexAttribiv")]
		public static extern void glGetVertexAttribiv(uint index, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glGetVertexAttribPointerv")]
		public static extern void glGetVertexAttribPointerv(uint index, uint pname, void** pointer);

		[DllImport(Library, EntryPoint = "glHint")]
		public static extern void glHint(uint target, uint mode);

		[DllImport(Library, EntryPoint = "glIsBuffer")]
		public static extern bool glIsBuffer(uint buffer);

		[DllImport(Library, EntryPoint = "glIsEnabled")]
		public static extern bool glIsEnabled(uint cap);

		[DllImport(Library, EntryPoint = "glIsFramebuffer")]
		public static extern bool glIsFramebuffer(uint framebuffer);

		[DllImport(Library, EntryPoint = "glIsProgram")]
		public static extern bool glIsProgram(uint program);

		[DllImport(Library, EntryPoint = "glIsRenderbuffer")]
		public static extern bool glIsRenderbuffer(uint renderbuffer);

		[DllImport(Library, EntryPoint = "glIsShader")]
		public static extern bool glIsShader(uint shader);

		[DllImport(Library, EntryPoint = "glIsTexture")]
		public static extern bool glIsTexture(uint texture);

		[DllImport(Library, EntryPoint = "glLineWidth")]
		public static extern void glLineWidth(float width);

		[DllImport(Library, EntryPoint = "glLinkProgram")]
		public static extern void glLinkProgram(uint program);

		[DllImport(Library, EntryPoint = "glPixelStorei")]
		public static extern void glPixelStorei(uint pname, int param);

		[DllImport(Library, EntryPoint = "glPolygonOffset")]
		public static extern void glPolygonOffset(float factor, float units);

		[DllImport(Library, EntryPoint = "glReadPixels")]
		public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

		[DllImport(Library, EntryPoint = "glReleaseShaderCompiler")]
		public static extern void glReleaseShaderCompiler();

		[DllImport(Library, EntryPoint = "glRenderbufferStorage")]
		public static extern void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

		[DllImport(Library, EntryPoint = "glSampleCoverage")]
		public static extern void glSampleCoverage(float value, bool invert);

		[DllImport(Library, EntryPoint = "glScissor")]
		public static extern void glScissor(int x, int y, int width, int height);

		[DllImport(Library, EntryPoint = "glShaderBinary")]
		public static extern void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);

		[DllImport(Library, EntryPoint = "glShaderSource")]
		public static extern void glShaderSource(uint shader, int count, string[] @string, int* length);

		[DllImport(Library, EntryPoint = "glStencilFunc")]
		public static extern void glStencilFunc(uint func, int @ref, uint mask);

		[DllImport(Library, EntryPoint = "glStencilFuncSeparate")]
		public static extern void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

		[DllImport(Library, EntryPoint = "glStencilMask")]
		public static extern void glStencilMask(uint mask);

		[DllImport(Library, EntryPoint = "glStencilMaskSeparate")]
		public static extern void glStencilMaskSeparate(uint face, uint mask);

		[DllImport(Library, EntryPoint = "glStencilOp")]
		public static extern void glStencilOp(uint fail, uint zfail, uint zpass);

		[DllImport(Library, EntryPoint = "glStencilOpSeparate")]
		public static extern void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

		[DllImport(Library, EntryPoint = "glTexImage2D")]
		public static extern void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

		[DllImport(Library, EntryPoint = "glTexParameterf")]
		public static extern void glTexParameterf(uint target, uint pname, float param);

		[DllImport(Library, EntryPoint = "glTexParameterfv")]
		public static extern void glTexParameterfv(uint target, uint pname, float* @params);

		[DllImport(Library, EntryPoint = "glTexParameteri")]
		public static extern void glTexParameteri(uint target, uint pname, int param);

		[DllImport(Library, EntryPoint = "glTexParameteriv")]
		public static extern void glTexParameteriv(uint target, uint pname, int* @params);

		[DllImport(Library, EntryPoint = "glTexSubImage2D")]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

		[DllImport(Library, EntryPoint = "glUniform1f")]
		public static extern void glUniform1f(int location, float v0);

		[DllImport(Library, EntryPoint = "glUniform1fv")]
		public static extern void glUniform1fv(int location, int count, float* value);

		[DllImport(Library, EntryPoint = "glUniform1i")]
		public static extern void glUniform1i(int location, int v0);

		[DllImport(Library, EntryPoint = "glUniform1iv")]
		public static extern void glUniform1iv(int location, int count, int* value);

		[DllImport(Library, EntryPoint = "glUniform2f")]
		public static extern void glUniform2f(int location, float v0, float v1);

		[DllImport(Library, EntryPoint = "glUniform2fv")]
		public static extern void glUniform2fv(int location, int count, float* value);

		[DllImport(Library, EntryPoint = "glUniform2i")]
		public static extern void glUniform2i(int location, int v0, int v1);

		[DllImport(Library, EntryPoint = "glUniform2iv")]
		public static extern void glUniform2iv(int location, int count, int* value);

		[DllImport(Library, EntryPoint = "glUniform3f")]
		public static extern void glUniform3f(int location, float v0, float v1, float v2);

		[DllImport(Library, EntryPoint = "glUniform3fv")]
		public static extern void glUniform3fv(int location, int count, float* value);

		[DllImport(Library, EntryPoint = "glUniform3i")]
		public static extern void glUniform3i(int location, int v0, int v1, int v2);

		[DllImport(Library, EntryPoint = "glUniform3iv")]
		public static extern void glUniform3iv(int location, int count, int* value);

		[DllImport(Library, EntryPoint = "glUniform4f")]
		public static extern void glUniform4f(int location, float v0, float v1, float v2, float v3);

		[DllImport(Library, EntryPoint = "glUniform4fv")]
		public static extern void glUniform4fv(int location, int count, float* value);

		[DllImport(Library, EntryPoint = "glUniform4i")]
		public static extern void glUniform4i(int location, int v0, int v1, int v2, int v3);

		[DllImport(Library, EntryPoint = "glUniform4iv")]
		public static extern void glUniform4iv(int location, int count, int* value);

		[DllImport(Library, EntryPoint = "glUniformMatrix2fv")]
		public static extern void glUniformMatrix2fv(int location, int count, bool transpose, float* value);

		[DllImport(Library, EntryPoint = "glUniformMatrix3fv")]
		public static extern void glUniformMatrix3fv(int location, int count, bool transpose, float* value);

		[DllImport(Library, EntryPoint = "glUniformMatrix4fv")]
		public static extern void glUniformMatrix4fv(int location, int count, bool transpose, float* value);

		[DllImport(Library, EntryPoint = "glUseProgram")]
		public static extern void glUseProgram(uint program);

		[DllImport(Library, EntryPoint = "glValidateProgram")]
		public static extern void glValidateProgram(uint program);

		[DllImport(Library, EntryPoint = "glVertexAttrib1f")]
		public static extern void glVertexAttrib1f(uint index, float x);

		[DllImport(Library, EntryPoint = "glVertexAttrib1fv")]
		public static extern void glVertexAttrib1fv(uint index, float* v);

		[DllImport(Library, EntryPoint = "glVertexAttrib2f")]
		public static extern void glVertexAttrib2f(uint index, float x, float y);

		[DllImport(Library, EntryPoint = "glVertexAttrib2fv")]
		public static extern void glVertexAttrib2fv(uint index, float* v);

		[DllImport(Library, EntryPoint = "glVertexAttrib3f")]
		public static extern void glVertexAttrib3f(uint index, float x, float y, float z);

		[DllImport(Library, EntryPoint = "glVertexAttrib3fv")]
		public static extern void glVertexAttrib3fv(uint index, float* v);

		[DllImport(Library, EntryPoint = "glVertexAttrib4f")]
		public static extern void glVertexAttrib4f(uint index, float x, float y, float z, float w);

		[DllImport(Library, EntryPoint = "glVertexAttrib4fv")]
		public static extern void glVertexAttrib4fv(uint index, float* v);

		[DllImport(Library, EntryPoint = "glVertexAttribPointer")]
		public static extern void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);

		[DllImport(Library, EntryPoint = "glViewport")]
		public static extern void glViewport(int x, int y, int width, int height);

	}
}
