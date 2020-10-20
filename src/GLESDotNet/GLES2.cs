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

#nullable disable

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GLESDotNet
{
	public static unsafe partial class GLES2
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

		private static class Delegates
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glActiveTexture(uint texture);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glAttachShader(uint program, uint shader);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBindAttribLocation(uint program, uint index, string name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBindBuffer(uint target, uint buffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBindFramebuffer(uint target, uint framebuffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBindRenderbuffer(uint target, uint renderbuffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBindTexture(uint target, uint texture);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBlendColor(float red, float green, float blue, float alpha);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBlendEquation(uint mode);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBlendEquationSeparate(uint modeRGB, uint modeAlpha);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBlendFunc(uint sfactor, uint dfactor);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBufferData(uint target, int size, void* data, uint usage);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glBufferSubData(uint target, int offset, int size, void* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate uint glCheckFramebufferStatus(uint target);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glClear(uint mask);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glClearColor(float red, float green, float blue, float alpha);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glClearDepthf(float d);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glClearStencil(int s);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCompileShader(uint shader);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate uint glCreateProgram();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate uint glCreateShader(uint type);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glCullFace(uint mode);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteBuffers(int n, uint* buffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteFramebuffers(int n, uint* framebuffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteProgram(uint program);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteRenderbuffers(int n, uint* renderbuffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteShader(uint shader);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDeleteTextures(int n, uint* textures);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDepthFunc(uint func);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDepthMask(bool flag);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDepthRangef(float n, float f);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDetachShader(uint program, uint shader);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDisable(uint cap);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDisableVertexAttribArray(uint index);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDrawArrays(uint mode, int first, int count);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glDrawElements(uint mode, int count, uint type, void* indices);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glEnable(uint cap);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glEnableVertexAttribArray(uint index);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glFinish();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glFlush();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glFrontFace(uint mode);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGenBuffers(int n, uint* buffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGenerateMipmap(uint target);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGenFramebuffers(int n, uint* framebuffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGenRenderbuffers(int n, uint* renderbuffers);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGenTextures(int n, uint* textures);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate int glGetAttribLocation(uint program, string name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetBooleanv(uint pname, bool* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetBufferParameteriv(uint target, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate uint glGetError();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetFloatv(uint pname, float* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetIntegerv(uint pname, int* data);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetProgramiv(uint program, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetRenderbufferParameteriv(uint target, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetShaderiv(uint shader, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr glGetString(uint name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetTexParameterfv(uint target, uint pname, float* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetTexParameteriv(uint target, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetUniformfv(uint program, int location, float* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetUniformiv(uint program, int location, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate int glGetUniformLocation(uint program, string name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetVertexAttribfv(uint index, uint pname, float* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetVertexAttribiv(uint index, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glGetVertexAttribPointerv(uint index, uint pname, void** pointer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glHint(uint target, uint mode);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsBuffer(uint buffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsEnabled(uint cap);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsFramebuffer(uint framebuffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsProgram(uint program);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsRenderbuffer(uint renderbuffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsShader(uint shader);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool glIsTexture(uint texture);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glLineWidth(float width);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glLinkProgram(uint program);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glPixelStorei(uint pname, int param);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glPolygonOffset(float factor, float units);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glReleaseShaderCompiler();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glSampleCoverage(float value, bool invert);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glScissor(int x, int y, int width, int height);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glShaderSource(uint shader, int count, string[] @string, int* length);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilFunc(uint func, int @ref, uint mask);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilMask(uint mask);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilMaskSeparate(uint face, uint mask);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilOp(uint fail, uint zfail, uint zpass);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexParameterf(uint target, uint pname, float param);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexParameterfv(uint target, uint pname, float* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexParameteri(uint target, uint pname, int param);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexParameteriv(uint target, uint pname, int* @params);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform1f(int location, float v0);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform1fv(int location, int count, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform1i(int location, int v0);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform1iv(int location, int count, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform2f(int location, float v0, float v1);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform2fv(int location, int count, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform2i(int location, int v0, int v1);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform2iv(int location, int count, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform3f(int location, float v0, float v1, float v2);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform3fv(int location, int count, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform3i(int location, int v0, int v1, int v2);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform3iv(int location, int count, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform4fv(int location, int count, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniform4iv(int location, int count, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniformMatrix2fv(int location, int count, bool transpose, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniformMatrix3fv(int location, int count, bool transpose, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUniformMatrix4fv(int location, int count, bool transpose, float* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glUseProgram(uint program);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glValidateProgram(uint program);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib1f(uint index, float x);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib1fv(uint index, float* v);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib2f(uint index, float x, float y);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib2fv(uint index, float* v);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib3f(uint index, float x, float y, float z);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib3fv(uint index, float* v);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttrib4fv(uint index, float* v);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate void glViewport(int x, int y, int width, int height);

		}

		private static Delegates.glActiveTexture _glActiveTexture;

		private static Delegates.glAttachShader _glAttachShader;

		private static Delegates.glBindAttribLocation _glBindAttribLocation;

		private static Delegates.glBindBuffer _glBindBuffer;

		private static Delegates.glBindFramebuffer _glBindFramebuffer;

		private static Delegates.glBindRenderbuffer _glBindRenderbuffer;

		private static Delegates.glBindTexture _glBindTexture;

		private static Delegates.glBlendColor _glBlendColor;

		private static Delegates.glBlendEquation _glBlendEquation;

		private static Delegates.glBlendEquationSeparate _glBlendEquationSeparate;

		private static Delegates.glBlendFunc _glBlendFunc;

		private static Delegates.glBlendFuncSeparate _glBlendFuncSeparate;

		private static Delegates.glBufferData _glBufferData;

		private static Delegates.glBufferSubData _glBufferSubData;

		private static Delegates.glCheckFramebufferStatus _glCheckFramebufferStatus;

		private static Delegates.glClear _glClear;

		private static Delegates.glClearColor _glClearColor;

		private static Delegates.glClearDepthf _glClearDepthf;

		private static Delegates.glClearStencil _glClearStencil;

		private static Delegates.glColorMask _glColorMask;

		private static Delegates.glCompileShader _glCompileShader;

		private static Delegates.glCompressedTexImage2D _glCompressedTexImage2D;

		private static Delegates.glCompressedTexSubImage2D _glCompressedTexSubImage2D;

		private static Delegates.glCopyTexImage2D _glCopyTexImage2D;

		private static Delegates.glCopyTexSubImage2D _glCopyTexSubImage2D;

		private static Delegates.glCreateProgram _glCreateProgram;

		private static Delegates.glCreateShader _glCreateShader;

		private static Delegates.glCullFace _glCullFace;

		private static Delegates.glDeleteBuffers _glDeleteBuffers;

		private static Delegates.glDeleteFramebuffers _glDeleteFramebuffers;

		private static Delegates.glDeleteProgram _glDeleteProgram;

		private static Delegates.glDeleteRenderbuffers _glDeleteRenderbuffers;

		private static Delegates.glDeleteShader _glDeleteShader;

		private static Delegates.glDeleteTextures _glDeleteTextures;

		private static Delegates.glDepthFunc _glDepthFunc;

		private static Delegates.glDepthMask _glDepthMask;

		private static Delegates.glDepthRangef _glDepthRangef;

		private static Delegates.glDetachShader _glDetachShader;

		private static Delegates.glDisable _glDisable;

		private static Delegates.glDisableVertexAttribArray _glDisableVertexAttribArray;

		private static Delegates.glDrawArrays _glDrawArrays;

		private static Delegates.glDrawElements _glDrawElements;

		private static Delegates.glEnable _glEnable;

		private static Delegates.glEnableVertexAttribArray _glEnableVertexAttribArray;

		private static Delegates.glFinish _glFinish;

		private static Delegates.glFlush _glFlush;

		private static Delegates.glFramebufferRenderbuffer _glFramebufferRenderbuffer;

		private static Delegates.glFramebufferTexture2D _glFramebufferTexture2D;

		private static Delegates.glFrontFace _glFrontFace;

		private static Delegates.glGenBuffers _glGenBuffers;

		private static Delegates.glGenerateMipmap _glGenerateMipmap;

		private static Delegates.glGenFramebuffers _glGenFramebuffers;

		private static Delegates.glGenRenderbuffers _glGenRenderbuffers;

		private static Delegates.glGenTextures _glGenTextures;

		private static Delegates.glGetActiveAttrib _glGetActiveAttrib;

		private static Delegates.glGetActiveUniform _glGetActiveUniform;

		private static Delegates.glGetAttachedShaders _glGetAttachedShaders;

		private static Delegates.glGetAttribLocation _glGetAttribLocation;

		private static Delegates.glGetBooleanv _glGetBooleanv;

		private static Delegates.glGetBufferParameteriv _glGetBufferParameteriv;

		private static Delegates.glGetError _glGetError;

		private static Delegates.glGetFloatv _glGetFloatv;

		private static Delegates.glGetFramebufferAttachmentParameteriv _glGetFramebufferAttachmentParameteriv;

		private static Delegates.glGetIntegerv _glGetIntegerv;

		private static Delegates.glGetProgramInfoLog _glGetProgramInfoLog;

		private static Delegates.glGetProgramiv _glGetProgramiv;

		private static Delegates.glGetRenderbufferParameteriv _glGetRenderbufferParameteriv;

		private static Delegates.glGetShaderInfoLog _glGetShaderInfoLog;

		private static Delegates.glGetShaderiv _glGetShaderiv;

		private static Delegates.glGetShaderPrecisionFormat _glGetShaderPrecisionFormat;

		private static Delegates.glGetShaderSource _glGetShaderSource;

		private static Delegates.glGetString _glGetString;

		private static Delegates.glGetTexParameterfv _glGetTexParameterfv;

		private static Delegates.glGetTexParameteriv _glGetTexParameteriv;

		private static Delegates.glGetUniformfv _glGetUniformfv;

		private static Delegates.glGetUniformiv _glGetUniformiv;

		private static Delegates.glGetUniformLocation _glGetUniformLocation;

		private static Delegates.glGetVertexAttribfv _glGetVertexAttribfv;

		private static Delegates.glGetVertexAttribiv _glGetVertexAttribiv;

		private static Delegates.glGetVertexAttribPointerv _glGetVertexAttribPointerv;

		private static Delegates.glHint _glHint;

		private static Delegates.glIsBuffer _glIsBuffer;

		private static Delegates.glIsEnabled _glIsEnabled;

		private static Delegates.glIsFramebuffer _glIsFramebuffer;

		private static Delegates.glIsProgram _glIsProgram;

		private static Delegates.glIsRenderbuffer _glIsRenderbuffer;

		private static Delegates.glIsShader _glIsShader;

		private static Delegates.glIsTexture _glIsTexture;

		private static Delegates.glLineWidth _glLineWidth;

		private static Delegates.glLinkProgram _glLinkProgram;

		private static Delegates.glPixelStorei _glPixelStorei;

		private static Delegates.glPolygonOffset _glPolygonOffset;

		private static Delegates.glReadPixels _glReadPixels;

		private static Delegates.glReleaseShaderCompiler _glReleaseShaderCompiler;

		private static Delegates.glRenderbufferStorage _glRenderbufferStorage;

		private static Delegates.glSampleCoverage _glSampleCoverage;

		private static Delegates.glScissor _glScissor;

		private static Delegates.glShaderBinary _glShaderBinary;

		private static Delegates.glShaderSource _glShaderSource;

		private static Delegates.glStencilFunc _glStencilFunc;

		private static Delegates.glStencilFuncSeparate _glStencilFuncSeparate;

		private static Delegates.glStencilMask _glStencilMask;

		private static Delegates.glStencilMaskSeparate _glStencilMaskSeparate;

		private static Delegates.glStencilOp _glStencilOp;

		private static Delegates.glStencilOpSeparate _glStencilOpSeparate;

		private static Delegates.glTexImage2D _glTexImage2D;

		private static Delegates.glTexParameterf _glTexParameterf;

		private static Delegates.glTexParameterfv _glTexParameterfv;

		private static Delegates.glTexParameteri _glTexParameteri;

		private static Delegates.glTexParameteriv _glTexParameteriv;

		private static Delegates.glTexSubImage2D _glTexSubImage2D;

		private static Delegates.glUniform1f _glUniform1f;

		private static Delegates.glUniform1fv _glUniform1fv;

		private static Delegates.glUniform1i _glUniform1i;

		private static Delegates.glUniform1iv _glUniform1iv;

		private static Delegates.glUniform2f _glUniform2f;

		private static Delegates.glUniform2fv _glUniform2fv;

		private static Delegates.glUniform2i _glUniform2i;

		private static Delegates.glUniform2iv _glUniform2iv;

		private static Delegates.glUniform3f _glUniform3f;

		private static Delegates.glUniform3fv _glUniform3fv;

		private static Delegates.glUniform3i _glUniform3i;

		private static Delegates.glUniform3iv _glUniform3iv;

		private static Delegates.glUniform4f _glUniform4f;

		private static Delegates.glUniform4fv _glUniform4fv;

		private static Delegates.glUniform4i _glUniform4i;

		private static Delegates.glUniform4iv _glUniform4iv;

		private static Delegates.glUniformMatrix2fv _glUniformMatrix2fv;

		private static Delegates.glUniformMatrix3fv _glUniformMatrix3fv;

		private static Delegates.glUniformMatrix4fv _glUniformMatrix4fv;

		private static Delegates.glUseProgram _glUseProgram;

		private static Delegates.glValidateProgram _glValidateProgram;

		private static Delegates.glVertexAttrib1f _glVertexAttrib1f;

		private static Delegates.glVertexAttrib1fv _glVertexAttrib1fv;

		private static Delegates.glVertexAttrib2f _glVertexAttrib2f;

		private static Delegates.glVertexAttrib2fv _glVertexAttrib2fv;

		private static Delegates.glVertexAttrib3f _glVertexAttrib3f;

		private static Delegates.glVertexAttrib3fv _glVertexAttrib3fv;

		private static Delegates.glVertexAttrib4f _glVertexAttrib4f;

		private static Delegates.glVertexAttrib4fv _glVertexAttrib4fv;

		private static Delegates.glVertexAttribPointer _glVertexAttribPointer;

		private static Delegates.glViewport _glViewport;

		public static void glInit(Func<string, IntPtr> getProcAddress)
		{
			LoadFunctions(getProcAddress);
		}

		private static void LoadFunctions(Func<string, IntPtr> getProcAddress)
		{
			T getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));

			_glActiveTexture = getProc<Delegates.glActiveTexture>("glActiveTexture");
			_glAttachShader = getProc<Delegates.glAttachShader>("glAttachShader");
			_glBindAttribLocation = getProc<Delegates.glBindAttribLocation>("glBindAttribLocation");
			_glBindBuffer = getProc<Delegates.glBindBuffer>("glBindBuffer");
			_glBindFramebuffer = getProc<Delegates.glBindFramebuffer>("glBindFramebuffer");
			_glBindRenderbuffer = getProc<Delegates.glBindRenderbuffer>("glBindRenderbuffer");
			_glBindTexture = getProc<Delegates.glBindTexture>("glBindTexture");
			_glBlendColor = getProc<Delegates.glBlendColor>("glBlendColor");
			_glBlendEquation = getProc<Delegates.glBlendEquation>("glBlendEquation");
			_glBlendEquationSeparate = getProc<Delegates.glBlendEquationSeparate>("glBlendEquationSeparate");
			_glBlendFunc = getProc<Delegates.glBlendFunc>("glBlendFunc");
			_glBlendFuncSeparate = getProc<Delegates.glBlendFuncSeparate>("glBlendFuncSeparate");
			_glBufferData = getProc<Delegates.glBufferData>("glBufferData");
			_glBufferSubData = getProc<Delegates.glBufferSubData>("glBufferSubData");
			_glCheckFramebufferStatus = getProc<Delegates.glCheckFramebufferStatus>("glCheckFramebufferStatus");
			_glClear = getProc<Delegates.glClear>("glClear");
			_glClearColor = getProc<Delegates.glClearColor>("glClearColor");
			_glClearDepthf = getProc<Delegates.glClearDepthf>("glClearDepthf");
			_glClearStencil = getProc<Delegates.glClearStencil>("glClearStencil");
			_glColorMask = getProc<Delegates.glColorMask>("glColorMask");
			_glCompileShader = getProc<Delegates.glCompileShader>("glCompileShader");
			_glCompressedTexImage2D = getProc<Delegates.glCompressedTexImage2D>("glCompressedTexImage2D");
			_glCompressedTexSubImage2D = getProc<Delegates.glCompressedTexSubImage2D>("glCompressedTexSubImage2D");
			_glCopyTexImage2D = getProc<Delegates.glCopyTexImage2D>("glCopyTexImage2D");
			_glCopyTexSubImage2D = getProc<Delegates.glCopyTexSubImage2D>("glCopyTexSubImage2D");
			_glCreateProgram = getProc<Delegates.glCreateProgram>("glCreateProgram");
			_glCreateShader = getProc<Delegates.glCreateShader>("glCreateShader");
			_glCullFace = getProc<Delegates.glCullFace>("glCullFace");
			_glDeleteBuffers = getProc<Delegates.glDeleteBuffers>("glDeleteBuffers");
			_glDeleteFramebuffers = getProc<Delegates.glDeleteFramebuffers>("glDeleteFramebuffers");
			_glDeleteProgram = getProc<Delegates.glDeleteProgram>("glDeleteProgram");
			_glDeleteRenderbuffers = getProc<Delegates.glDeleteRenderbuffers>("glDeleteRenderbuffers");
			_glDeleteShader = getProc<Delegates.glDeleteShader>("glDeleteShader");
			_glDeleteTextures = getProc<Delegates.glDeleteTextures>("glDeleteTextures");
			_glDepthFunc = getProc<Delegates.glDepthFunc>("glDepthFunc");
			_glDepthMask = getProc<Delegates.glDepthMask>("glDepthMask");
			_glDepthRangef = getProc<Delegates.glDepthRangef>("glDepthRangef");
			_glDetachShader = getProc<Delegates.glDetachShader>("glDetachShader");
			_glDisable = getProc<Delegates.glDisable>("glDisable");
			_glDisableVertexAttribArray = getProc<Delegates.glDisableVertexAttribArray>("glDisableVertexAttribArray");
			_glDrawArrays = getProc<Delegates.glDrawArrays>("glDrawArrays");
			_glDrawElements = getProc<Delegates.glDrawElements>("glDrawElements");
			_glEnable = getProc<Delegates.glEnable>("glEnable");
			_glEnableVertexAttribArray = getProc<Delegates.glEnableVertexAttribArray>("glEnableVertexAttribArray");
			_glFinish = getProc<Delegates.glFinish>("glFinish");
			_glFlush = getProc<Delegates.glFlush>("glFlush");
			_glFramebufferRenderbuffer = getProc<Delegates.glFramebufferRenderbuffer>("glFramebufferRenderbuffer");
			_glFramebufferTexture2D = getProc<Delegates.glFramebufferTexture2D>("glFramebufferTexture2D");
			_glFrontFace = getProc<Delegates.glFrontFace>("glFrontFace");
			_glGenBuffers = getProc<Delegates.glGenBuffers>("glGenBuffers");
			_glGenerateMipmap = getProc<Delegates.glGenerateMipmap>("glGenerateMipmap");
			_glGenFramebuffers = getProc<Delegates.glGenFramebuffers>("glGenFramebuffers");
			_glGenRenderbuffers = getProc<Delegates.glGenRenderbuffers>("glGenRenderbuffers");
			_glGenTextures = getProc<Delegates.glGenTextures>("glGenTextures");
			_glGetActiveAttrib = getProc<Delegates.glGetActiveAttrib>("glGetActiveAttrib");
			_glGetActiveUniform = getProc<Delegates.glGetActiveUniform>("glGetActiveUniform");
			_glGetAttachedShaders = getProc<Delegates.glGetAttachedShaders>("glGetAttachedShaders");
			_glGetAttribLocation = getProc<Delegates.glGetAttribLocation>("glGetAttribLocation");
			_glGetBooleanv = getProc<Delegates.glGetBooleanv>("glGetBooleanv");
			_glGetBufferParameteriv = getProc<Delegates.glGetBufferParameteriv>("glGetBufferParameteriv");
			_glGetError = getProc<Delegates.glGetError>("glGetError");
			_glGetFloatv = getProc<Delegates.glGetFloatv>("glGetFloatv");
			_glGetFramebufferAttachmentParameteriv = getProc<Delegates.glGetFramebufferAttachmentParameteriv>("glGetFramebufferAttachmentParameteriv");
			_glGetIntegerv = getProc<Delegates.glGetIntegerv>("glGetIntegerv");
			_glGetProgramInfoLog = getProc<Delegates.glGetProgramInfoLog>("glGetProgramInfoLog");
			_glGetProgramiv = getProc<Delegates.glGetProgramiv>("glGetProgramiv");
			_glGetRenderbufferParameteriv = getProc<Delegates.glGetRenderbufferParameteriv>("glGetRenderbufferParameteriv");
			_glGetShaderInfoLog = getProc<Delegates.glGetShaderInfoLog>("glGetShaderInfoLog");
			_glGetShaderiv = getProc<Delegates.glGetShaderiv>("glGetShaderiv");
			_glGetShaderPrecisionFormat = getProc<Delegates.glGetShaderPrecisionFormat>("glGetShaderPrecisionFormat");
			_glGetShaderSource = getProc<Delegates.glGetShaderSource>("glGetShaderSource");
			_glGetString = getProc<Delegates.glGetString>("glGetString");
			_glGetTexParameterfv = getProc<Delegates.glGetTexParameterfv>("glGetTexParameterfv");
			_glGetTexParameteriv = getProc<Delegates.glGetTexParameteriv>("glGetTexParameteriv");
			_glGetUniformfv = getProc<Delegates.glGetUniformfv>("glGetUniformfv");
			_glGetUniformiv = getProc<Delegates.glGetUniformiv>("glGetUniformiv");
			_glGetUniformLocation = getProc<Delegates.glGetUniformLocation>("glGetUniformLocation");
			_glGetVertexAttribfv = getProc<Delegates.glGetVertexAttribfv>("glGetVertexAttribfv");
			_glGetVertexAttribiv = getProc<Delegates.glGetVertexAttribiv>("glGetVertexAttribiv");
			_glGetVertexAttribPointerv = getProc<Delegates.glGetVertexAttribPointerv>("glGetVertexAttribPointerv");
			_glHint = getProc<Delegates.glHint>("glHint");
			_glIsBuffer = getProc<Delegates.glIsBuffer>("glIsBuffer");
			_glIsEnabled = getProc<Delegates.glIsEnabled>("glIsEnabled");
			_glIsFramebuffer = getProc<Delegates.glIsFramebuffer>("glIsFramebuffer");
			_glIsProgram = getProc<Delegates.glIsProgram>("glIsProgram");
			_glIsRenderbuffer = getProc<Delegates.glIsRenderbuffer>("glIsRenderbuffer");
			_glIsShader = getProc<Delegates.glIsShader>("glIsShader");
			_glIsTexture = getProc<Delegates.glIsTexture>("glIsTexture");
			_glLineWidth = getProc<Delegates.glLineWidth>("glLineWidth");
			_glLinkProgram = getProc<Delegates.glLinkProgram>("glLinkProgram");
			_glPixelStorei = getProc<Delegates.glPixelStorei>("glPixelStorei");
			_glPolygonOffset = getProc<Delegates.glPolygonOffset>("glPolygonOffset");
			_glReadPixels = getProc<Delegates.glReadPixels>("glReadPixels");
			_glReleaseShaderCompiler = getProc<Delegates.glReleaseShaderCompiler>("glReleaseShaderCompiler");
			_glRenderbufferStorage = getProc<Delegates.glRenderbufferStorage>("glRenderbufferStorage");
			_glSampleCoverage = getProc<Delegates.glSampleCoverage>("glSampleCoverage");
			_glScissor = getProc<Delegates.glScissor>("glScissor");
			_glShaderBinary = getProc<Delegates.glShaderBinary>("glShaderBinary");
			_glShaderSource = getProc<Delegates.glShaderSource>("glShaderSource");
			_glStencilFunc = getProc<Delegates.glStencilFunc>("glStencilFunc");
			_glStencilFuncSeparate = getProc<Delegates.glStencilFuncSeparate>("glStencilFuncSeparate");
			_glStencilMask = getProc<Delegates.glStencilMask>("glStencilMask");
			_glStencilMaskSeparate = getProc<Delegates.glStencilMaskSeparate>("glStencilMaskSeparate");
			_glStencilOp = getProc<Delegates.glStencilOp>("glStencilOp");
			_glStencilOpSeparate = getProc<Delegates.glStencilOpSeparate>("glStencilOpSeparate");
			_glTexImage2D = getProc<Delegates.glTexImage2D>("glTexImage2D");
			_glTexParameterf = getProc<Delegates.glTexParameterf>("glTexParameterf");
			_glTexParameterfv = getProc<Delegates.glTexParameterfv>("glTexParameterfv");
			_glTexParameteri = getProc<Delegates.glTexParameteri>("glTexParameteri");
			_glTexParameteriv = getProc<Delegates.glTexParameteriv>("glTexParameteriv");
			_glTexSubImage2D = getProc<Delegates.glTexSubImage2D>("glTexSubImage2D");
			_glUniform1f = getProc<Delegates.glUniform1f>("glUniform1f");
			_glUniform1fv = getProc<Delegates.glUniform1fv>("glUniform1fv");
			_glUniform1i = getProc<Delegates.glUniform1i>("glUniform1i");
			_glUniform1iv = getProc<Delegates.glUniform1iv>("glUniform1iv");
			_glUniform2f = getProc<Delegates.glUniform2f>("glUniform2f");
			_glUniform2fv = getProc<Delegates.glUniform2fv>("glUniform2fv");
			_glUniform2i = getProc<Delegates.glUniform2i>("glUniform2i");
			_glUniform2iv = getProc<Delegates.glUniform2iv>("glUniform2iv");
			_glUniform3f = getProc<Delegates.glUniform3f>("glUniform3f");
			_glUniform3fv = getProc<Delegates.glUniform3fv>("glUniform3fv");
			_glUniform3i = getProc<Delegates.glUniform3i>("glUniform3i");
			_glUniform3iv = getProc<Delegates.glUniform3iv>("glUniform3iv");
			_glUniform4f = getProc<Delegates.glUniform4f>("glUniform4f");
			_glUniform4fv = getProc<Delegates.glUniform4fv>("glUniform4fv");
			_glUniform4i = getProc<Delegates.glUniform4i>("glUniform4i");
			_glUniform4iv = getProc<Delegates.glUniform4iv>("glUniform4iv");
			_glUniformMatrix2fv = getProc<Delegates.glUniformMatrix2fv>("glUniformMatrix2fv");
			_glUniformMatrix3fv = getProc<Delegates.glUniformMatrix3fv>("glUniformMatrix3fv");
			_glUniformMatrix4fv = getProc<Delegates.glUniformMatrix4fv>("glUniformMatrix4fv");
			_glUseProgram = getProc<Delegates.glUseProgram>("glUseProgram");
			_glValidateProgram = getProc<Delegates.glValidateProgram>("glValidateProgram");
			_glVertexAttrib1f = getProc<Delegates.glVertexAttrib1f>("glVertexAttrib1f");
			_glVertexAttrib1fv = getProc<Delegates.glVertexAttrib1fv>("glVertexAttrib1fv");
			_glVertexAttrib2f = getProc<Delegates.glVertexAttrib2f>("glVertexAttrib2f");
			_glVertexAttrib2fv = getProc<Delegates.glVertexAttrib2fv>("glVertexAttrib2fv");
			_glVertexAttrib3f = getProc<Delegates.glVertexAttrib3f>("glVertexAttrib3f");
			_glVertexAttrib3fv = getProc<Delegates.glVertexAttrib3fv>("glVertexAttrib3fv");
			_glVertexAttrib4f = getProc<Delegates.glVertexAttrib4f>("glVertexAttrib4f");
			_glVertexAttrib4fv = getProc<Delegates.glVertexAttrib4fv>("glVertexAttrib4fv");
			_glVertexAttribPointer = getProc<Delegates.glVertexAttribPointer>("glVertexAttribPointer");
			_glViewport = getProc<Delegates.glViewport>("glViewport");
		}

		public static void glActiveTexture(uint texture)
		{
			_glActiveTexture(texture);
		}

		public static void glAttachShader(uint program, uint shader)
		{
			_glAttachShader(program, shader);
		}

		public static void glBindAttribLocation(uint program, uint index, string name)
		{
			_glBindAttribLocation(program, index, name);
		}

		public static void glBindBuffer(uint target, uint buffer)
		{
			_glBindBuffer(target, buffer);
		}

		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			_glBindFramebuffer(target, framebuffer);
		}

		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			_glBindRenderbuffer(target, renderbuffer);
		}

		public static void glBindTexture(uint target, uint texture)
		{
			_glBindTexture(target, texture);
		}

		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			_glBlendColor(red, green, blue, alpha);
		}

		public static void glBlendEquation(uint mode)
		{
			_glBlendEquation(mode);
		}

		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			_glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		public static void glBlendFunc(uint sfactor, uint dfactor)
		{
			_glBlendFunc(sfactor, dfactor);
		}

		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			_glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		public static void glBufferData(uint target, int size, void* data, uint usage)
		{
			_glBufferData(target, size, data, usage);
		}

		public static void glBufferSubData(uint target, int offset, int size, void* data)
		{
			_glBufferSubData(target, offset, size, data);
		}

		public static uint glCheckFramebufferStatus(uint target)
		{
			return _glCheckFramebufferStatus(target);
		}

		public static void glClear(uint mask)
		{
			_glClear(mask);
		}

		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			_glClearColor(red, green, blue, alpha);
		}

		public static void glClearDepthf(float d)
		{
			_glClearDepthf(d);
		}

		public static void glClearStencil(int s)
		{
			_glClearStencil(s);
		}

		public static void glColorMask(bool red, bool green, bool blue, bool alpha)
		{
			_glColorMask(red, green, blue, alpha);
		}

		public static void glCompileShader(uint shader)
		{
			_glCompileShader(shader);
		}

		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data)
		{
			_glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data)
		{
			_glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			_glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			_glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		public static uint glCreateProgram()
		{
			return _glCreateProgram();
		}

		public static uint glCreateShader(uint type)
		{
			return _glCreateShader(type);
		}

		public static void glCullFace(uint mode)
		{
			_glCullFace(mode);
		}

		public static void glDeleteBuffers(int n, uint* buffers)
		{
			_glDeleteBuffers(n, buffers);
		}

		public static void glDeleteFramebuffers(int n, uint* framebuffers)
		{
			_glDeleteFramebuffers(n, framebuffers);
		}

		public static void glDeleteProgram(uint program)
		{
			_glDeleteProgram(program);
		}

		public static void glDeleteRenderbuffers(int n, uint* renderbuffers)
		{
			_glDeleteRenderbuffers(n, renderbuffers);
		}

		public static void glDeleteShader(uint shader)
		{
			_glDeleteShader(shader);
		}

		public static void glDeleteTextures(int n, uint* textures)
		{
			_glDeleteTextures(n, textures);
		}

		public static void glDepthFunc(uint func)
		{
			_glDepthFunc(func);
		}

		public static void glDepthMask(bool flag)
		{
			_glDepthMask(flag);
		}

		public static void glDepthRangef(float n, float f)
		{
			_glDepthRangef(n, f);
		}

		public static void glDetachShader(uint program, uint shader)
		{
			_glDetachShader(program, shader);
		}

		public static void glDisable(uint cap)
		{
			_glDisable(cap);
		}

		public static void glDisableVertexAttribArray(uint index)
		{
			_glDisableVertexAttribArray(index);
		}

		public static void glDrawArrays(uint mode, int first, int count)
		{
			_glDrawArrays(mode, first, count);
		}

		public static void glDrawElements(uint mode, int count, uint type, void* indices)
		{
			_glDrawElements(mode, count, type, indices);
		}

		public static void glEnable(uint cap)
		{
			_glEnable(cap);
		}

		public static void glEnableVertexAttribArray(uint index)
		{
			_glEnableVertexAttribArray(index);
		}

		public static void glFinish()
		{
			_glFinish();
		}

		public static void glFlush()
		{
			_glFlush();
		}

		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			_glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			_glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		public static void glFrontFace(uint mode)
		{
			_glFrontFace(mode);
		}

		public static void glGenBuffers(int n, uint* buffers)
		{
			_glGenBuffers(n, buffers);
		}

		public static void glGenBuffers(int n, ref uint buffers)
		{
			fixed (uint* buffersPtr = &buffers)
			{
				_glGenBuffers(n, buffersPtr);
			}
		}

		public static void glGenerateMipmap(uint target)
		{
			_glGenerateMipmap(target);
		}

		public static void glGenFramebuffers(int n, uint* framebuffers)
		{
			_glGenFramebuffers(n, framebuffers);
		}

		public static void glGenFramebuffers(int n, ref uint framebuffers)
		{
			fixed (uint* framebuffersPtr = &framebuffers)
			{
				_glGenFramebuffers(n, framebuffersPtr);
			}
		}

		public static void glGenRenderbuffers(int n, uint* renderbuffers)
		{
			_glGenRenderbuffers(n, renderbuffers);
		}

		public static void glGenRenderbuffers(int n, ref uint renderbuffers)
		{
			fixed (uint* renderbuffersPtr = &renderbuffers)
			{
				_glGenRenderbuffers(n, renderbuffersPtr);
			}
		}

		public static void glGenTextures(int n, uint* textures)
		{
			_glGenTextures(n, textures);
		}

		public static void glGenTextures(int n, ref uint textures)
		{
			fixed (uint* texturesPtr = &textures)
			{
				_glGenTextures(n, texturesPtr);
			}
		}

		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			_glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			_glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			_glGetAttachedShaders(program, maxCount, count, shaders);
		}

		public static int glGetAttribLocation(uint program, string name)
		{
			return _glGetAttribLocation(program, name);
		}

		public static void glGetBooleanv(uint pname, bool* data)
		{
			_glGetBooleanv(pname, data);
		}

		public static void glGetBufferParameteriv(uint target, uint pname, int* @params)
		{
			_glGetBufferParameteriv(target, pname, @params);
		}

		public static uint glGetError()
		{
			return _glGetError();
		}

		public static void glGetFloatv(uint pname, float* data)
		{
			_glGetFloatv(pname, data);
		}

		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params)
		{
			_glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		public static void glGetIntegerv(uint pname, int* data)
		{
			_glGetIntegerv(pname, data);
		}

		public static void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog)
		{
			_glGetProgramInfoLog(program, bufSize, length, infoLog);
		}

		public static void glGetProgramiv(uint program, uint pname, int* @params)
		{
			_glGetProgramiv(program, pname, @params);
		}

		public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params)
		{
			_glGetRenderbufferParameteriv(target, pname, @params);
		}

		public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog)
		{
			_glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}

		public static void glGetShaderiv(uint shader, uint pname, int* @params)
		{
			_glGetShaderiv(shader, pname, @params);
		}

		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision)
		{
			_glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		public static void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source)
		{
			_glGetShaderSource(shader, bufSize, length, source);
		}

		public static IntPtr glGetString(uint name)
		{
			return _glGetString(name);
		}

		public static void glGetTexParameterfv(uint target, uint pname, float* @params)
		{
			_glGetTexParameterfv(target, pname, @params);
		}

		public static void glGetTexParameteriv(uint target, uint pname, int* @params)
		{
			_glGetTexParameteriv(target, pname, @params);
		}

		public static void glGetUniformfv(uint program, int location, float* @params)
		{
			_glGetUniformfv(program, location, @params);
		}

		public static void glGetUniformiv(uint program, int location, int* @params)
		{
			_glGetUniformiv(program, location, @params);
		}

		public static int glGetUniformLocation(uint program, string name)
		{
			return _glGetUniformLocation(program, name);
		}

		public static void glGetVertexAttribfv(uint index, uint pname, float* @params)
		{
			_glGetVertexAttribfv(index, pname, @params);
		}

		public static void glGetVertexAttribiv(uint index, uint pname, int* @params)
		{
			_glGetVertexAttribiv(index, pname, @params);
		}

		public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer)
		{
			_glGetVertexAttribPointerv(index, pname, pointer);
		}

		public static void glHint(uint target, uint mode)
		{
			_glHint(target, mode);
		}

		public static bool glIsBuffer(uint buffer)
		{
			return _glIsBuffer(buffer);
		}

		public static bool glIsEnabled(uint cap)
		{
			return _glIsEnabled(cap);
		}

		public static bool glIsFramebuffer(uint framebuffer)
		{
			return _glIsFramebuffer(framebuffer);
		}

		public static bool glIsProgram(uint program)
		{
			return _glIsProgram(program);
		}

		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return _glIsRenderbuffer(renderbuffer);
		}

		public static bool glIsShader(uint shader)
		{
			return _glIsShader(shader);
		}

		public static bool glIsTexture(uint texture)
		{
			return _glIsTexture(texture);
		}

		public static void glLineWidth(float width)
		{
			_glLineWidth(width);
		}

		public static void glLinkProgram(uint program)
		{
			_glLinkProgram(program);
		}

		public static void glPixelStorei(uint pname, int param)
		{
			_glPixelStorei(pname, param);
		}

		public static void glPolygonOffset(float factor, float units)
		{
			_glPolygonOffset(factor, units);
		}

		public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels)
		{
			_glReadPixels(x, y, width, height, format, type, pixels);
		}

		public static void glReleaseShaderCompiler()
		{
			_glReleaseShaderCompiler();
		}

		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			_glRenderbufferStorage(target, internalformat, width, height);
		}

		public static void glSampleCoverage(float value, bool invert)
		{
			_glSampleCoverage(value, invert);
		}

		public static void glScissor(int x, int y, int width, int height)
		{
			_glScissor(x, y, width, height);
		}

		public static void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length)
		{
			_glShaderBinary(count, shaders, binaryformat, binary, length);
		}

		public static void glShaderSource(uint shader, int count, string[] @string, int* length)
		{
			_glShaderSource(shader, count, @string, length);
		}

		public static void glStencilFunc(uint func, int @ref, uint mask)
		{
			_glStencilFunc(func, @ref, mask);
		}

		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			_glStencilFuncSeparate(face, func, @ref, mask);
		}

		public static void glStencilMask(uint mask)
		{
			_glStencilMask(mask);
		}

		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			_glStencilMaskSeparate(face, mask);
		}

		public static void glStencilOp(uint fail, uint zfail, uint zpass)
		{
			_glStencilOp(fail, zfail, zpass);
		}

		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			_glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels)
		{
			_glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		public static void glTexParameterf(uint target, uint pname, float param)
		{
			_glTexParameterf(target, pname, param);
		}

		public static void glTexParameterfv(uint target, uint pname, float* @params)
		{
			_glTexParameterfv(target, pname, @params);
		}

		public static void glTexParameteri(uint target, uint pname, int param)
		{
			_glTexParameteri(target, pname, param);
		}

		public static void glTexParameteriv(uint target, uint pname, int* @params)
		{
			_glTexParameteriv(target, pname, @params);
		}

		public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels)
		{
			_glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glUniform1f(int location, float v0)
		{
			_glUniform1f(location, v0);
		}

		public static void glUniform1fv(int location, int count, float* value)
		{
			_glUniform1fv(location, count, value);
		}

		public static void glUniform1i(int location, int v0)
		{
			_glUniform1i(location, v0);
		}

		public static void glUniform1iv(int location, int count, int* value)
		{
			_glUniform1iv(location, count, value);
		}

		public static void glUniform2f(int location, float v0, float v1)
		{
			_glUniform2f(location, v0, v1);
		}

		public static void glUniform2fv(int location, int count, float* value)
		{
			_glUniform2fv(location, count, value);
		}

		public static void glUniform2i(int location, int v0, int v1)
		{
			_glUniform2i(location, v0, v1);
		}

		public static void glUniform2iv(int location, int count, int* value)
		{
			_glUniform2iv(location, count, value);
		}

		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			_glUniform3f(location, v0, v1, v2);
		}

		public static void glUniform3fv(int location, int count, float* value)
		{
			_glUniform3fv(location, count, value);
		}

		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			_glUniform3i(location, v0, v1, v2);
		}

		public static void glUniform3iv(int location, int count, int* value)
		{
			_glUniform3iv(location, count, value);
		}

		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			_glUniform4f(location, v0, v1, v2, v3);
		}

		public static void glUniform4fv(int location, int count, float* value)
		{
			_glUniform4fv(location, count, value);
		}

		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			_glUniform4i(location, v0, v1, v2, v3);
		}

		public static void glUniform4iv(int location, int count, int* value)
		{
			_glUniform4iv(location, count, value);
		}

		public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value)
		{
			_glUniformMatrix2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value)
		{
			_glUniformMatrix3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value)
		{
			_glUniformMatrix4fv(location, count, transpose, value);
		}

		public static void glUseProgram(uint program)
		{
			_glUseProgram(program);
		}

		public static void glValidateProgram(uint program)
		{
			_glValidateProgram(program);
		}

		public static void glVertexAttrib1f(uint index, float x)
		{
			_glVertexAttrib1f(index, x);
		}

		public static void glVertexAttrib1fv(uint index, float* v)
		{
			_glVertexAttrib1fv(index, v);
		}

		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			_glVertexAttrib2f(index, x, y);
		}

		public static void glVertexAttrib2fv(uint index, float* v)
		{
			_glVertexAttrib2fv(index, v);
		}

		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			_glVertexAttrib3f(index, x, y, z);
		}

		public static void glVertexAttrib3fv(uint index, float* v)
		{
			_glVertexAttrib3fv(index, v);
		}

		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			_glVertexAttrib4f(index, x, y, z, w);
		}

		public static void glVertexAttrib4fv(uint index, float* v)
		{
			_glVertexAttrib4fv(index, v);
		}

		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer)
		{
			_glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		public static void glViewport(int x, int y, int width, int height)
		{
			_glViewport(x, y, width, height);
		}

	}
}
