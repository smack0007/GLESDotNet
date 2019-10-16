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
	public static unsafe partial class EGL
	{
		public const string Library = "libegl";

		public const uint EGL_ALPHA_FORMAT = 0x3088;
		public const uint EGL_ALPHA_FORMAT_NONPRE = 0x308B;
		public const uint EGL_ALPHA_FORMAT_PRE = 0x308C;
		public const uint EGL_ALPHA_MASK_SIZE = 0x303E;
		public const uint EGL_ALPHA_SIZE = 0x3021;
		public const uint EGL_BACK_BUFFER = 0x3084;
		public const uint EGL_BAD_ACCESS = 0x3002;
		public const uint EGL_BAD_ALLOC = 0x3003;
		public const uint EGL_BAD_ATTRIBUTE = 0x3004;
		public const uint EGL_BAD_CONFIG = 0x3005;
		public const uint EGL_BAD_CONTEXT = 0x3006;
		public const uint EGL_BAD_CURRENT_SURFACE = 0x3007;
		public const uint EGL_BAD_DISPLAY = 0x3008;
		public const uint EGL_BAD_MATCH = 0x3009;
		public const uint EGL_BAD_NATIVE_PIXMAP = 0x300A;
		public const uint EGL_BAD_NATIVE_WINDOW = 0x300B;
		public const uint EGL_BAD_PARAMETER = 0x300C;
		public const uint EGL_BAD_SURFACE = 0x300D;
		public const uint EGL_BIND_TO_TEXTURE_RGB = 0x3039;
		public const uint EGL_BIND_TO_TEXTURE_RGBA = 0x303A;
		public const uint EGL_BLUE_SIZE = 0x3022;
		public const uint EGL_BUFFER_DESTROYED = 0x3095;
		public const uint EGL_BUFFER_PRESERVED = 0x3094;
		public const uint EGL_BUFFER_SIZE = 0x3020;
		public const uint EGL_CL_EVENT_HANDLE = 0x309C;
		public const uint EGL_CLIENT_APIS = 0x308D;
		public const uint EGL_COLOR_BUFFER_TYPE = 0x303F;
		public const uint EGL_COLORSPACE = 0x3087;
		public const uint EGL_COLORSPACE_LINEAR = 0x308A;
		public const uint EGL_COLORSPACE_sRGB = 0x3089;
		public const uint EGL_CONDITION_SATISFIED = 0x30F6;
		public const uint EGL_CONFIG_CAVEAT = 0x3027;
		public const uint EGL_CONFIG_ID = 0x3028;
		public const uint EGL_CONFORMANT = 0x3042;
		public const uint EGL_CONTEXT_CLIENT_TYPE = 0x3097;
		public const uint EGL_CONTEXT_CLIENT_VERSION = 0x3098;
		public const uint EGL_CONTEXT_LOST = 0x300E;
		public const uint EGL_CONTEXT_MAJOR_VERSION = 0x3098;
		public const uint EGL_CONTEXT_MINOR_VERSION = 0x30FB;
		public const uint EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT = 0x00000001;
		public const uint EGL_CONTEXT_OPENGL_DEBUG = 0x31B0;
		public const uint EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE = 0x31B1;
		public const uint EGL_CONTEXT_OPENGL_PROFILE_MASK = 0x30FD;
		public const uint EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY = 0x31BD;
		public const uint EGL_CONTEXT_OPENGL_ROBUST_ACCESS = 0x31B2;
		public const uint EGL_CORE_NATIVE_ENGINE = 0x305B;
		public const uint EGL_DEFAULT_DISPLAY = 0;
		public const uint EGL_DEPTH_SIZE = 0x3025;
		public const uint EGL_DISPLAY_SCALING = 10000;
		public const uint EGL_DONT_CARE = unchecked((uint)-1);
		public const uint EGL_DRAW = 0x3059;
		public const uint EGL_EGL_PROTOTYPES = 1;
		public const uint EGL_EXTENSIONS = 0x3055;
		public const uint EGL_FALSE = 0;
		public const ulong EGL_FOREVER = 0xFFFFFFFFFFFFFFFF;
		public const uint EGL_GL_COLORSPACE = 0x309D;
		public const uint EGL_GL_COLORSPACE_LINEAR = 0x308A;
		public const uint EGL_GL_COLORSPACE_SRGB = 0x3089;
		public const uint EGL_GL_RENDERBUFFER = 0x30B9;
		public const uint EGL_GL_TEXTURE_2D = 0x30B1;
		public const uint EGL_GL_TEXTURE_3D = 0x30B2;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x30B4;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x30B6;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x30B8;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x30B3;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x30B5;
		public const uint EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x30B7;
		public const uint EGL_GL_TEXTURE_LEVEL = 0x30BC;
		public const uint EGL_GL_TEXTURE_ZOFFSET = 0x30BD;
		public const uint EGL_GREEN_SIZE = 0x3023;
		public const uint EGL_HEIGHT = 0x3056;
		public const uint EGL_HORIZONTAL_RESOLUTION = 0x3090;
		public const uint EGL_IMAGE_PRESERVED = 0x30D2;
		public const uint EGL_LARGEST_PBUFFER = 0x3058;
		public const uint EGL_LEVEL = 0x3029;
		public const uint EGL_LOSE_CONTEXT_ON_RESET = 0x31BF;
		public const uint EGL_LUMINANCE_BUFFER = 0x308F;
		public const uint EGL_LUMINANCE_SIZE = 0x303D;
		public const uint EGL_MATCH_NATIVE_PIXMAP = 0x3041;
		public const uint EGL_MAX_PBUFFER_HEIGHT = 0x302A;
		public const uint EGL_MAX_PBUFFER_PIXELS = 0x302B;
		public const uint EGL_MAX_PBUFFER_WIDTH = 0x302C;
		public const uint EGL_MAX_SWAP_INTERVAL = 0x303C;
		public const uint EGL_MIN_SWAP_INTERVAL = 0x303B;
		public const uint EGL_MIPMAP_LEVEL = 0x3083;
		public const uint EGL_MIPMAP_TEXTURE = 0x3082;
		public const uint EGL_MULTISAMPLE_RESOLVE = 0x3099;
		public const uint EGL_MULTISAMPLE_RESOLVE_BOX = 0x309B;
		public const uint EGL_MULTISAMPLE_RESOLVE_BOX_BIT = 0x0200;
		public const uint EGL_MULTISAMPLE_RESOLVE_DEFAULT = 0x309A;
		public const uint EGL_NATIVE_RENDERABLE = 0x302D;
		public const uint EGL_NATIVE_VISUAL_ID = 0x302E;
		public const uint EGL_NATIVE_VISUAL_TYPE = 0x302F;
		public const uint EGL_NO_CONTEXT = 0;
		public const uint EGL_NO_DISPLAY = 0;
		public const uint EGL_NO_IMAGE = 0;
		public const uint EGL_NO_RESET_NOTIFICATION = 0x31BE;
		public const uint EGL_NO_SURFACE = 0;
		public const uint EGL_NO_SYNC = 0;
		public const uint EGL_NO_TEXTURE = 0x305C;
		public const uint EGL_NON_CONFORMANT_CONFIG = 0x3051;
		public const uint EGL_NONE = 0x3038;
		public const uint EGL_NOT_INITIALIZED = 0x3001;
		public const uint EGL_OPENGL_API = 0x30A2;
		public const uint EGL_OPENGL_BIT = 0x0008;
		public const uint EGL_OPENGL_ES_API = 0x30A0;
		public const uint EGL_OPENGL_ES_BIT = 0x0001;
		public const uint EGL_OPENGL_ES2_BIT = 0x0004;
		public const uint EGL_OPENGL_ES3_BIT = 0x00000040;
		public const uint EGL_OPENVG_API = 0x30A1;
		public const uint EGL_OPENVG_BIT = 0x0002;
		public const uint EGL_OPENVG_IMAGE = 0x3096;
		public const uint EGL_PBUFFER_BIT = 0x0001;
		public const uint EGL_PIXEL_ASPECT_RATIO = 0x3092;
		public const uint EGL_PIXMAP_BIT = 0x0002;
		public const uint EGL_READ = 0x305A;
		public const uint EGL_RED_SIZE = 0x3024;
		public const uint EGL_RENDER_BUFFER = 0x3086;
		public const uint EGL_RENDERABLE_TYPE = 0x3040;
		public const uint EGL_RGB_BUFFER = 0x308E;
		public const uint EGL_SAMPLE_BUFFERS = 0x3032;
		public const uint EGL_SAMPLES = 0x3031;
		public const uint EGL_SIGNALED = 0x30F2;
		public const uint EGL_SINGLE_BUFFER = 0x3085;
		public const uint EGL_SLOW_CONFIG = 0x3050;
		public const uint EGL_STENCIL_SIZE = 0x3026;
		public const uint EGL_SUCCESS = 0x3000;
		public const uint EGL_SURFACE_TYPE = 0x3033;
		public const uint EGL_SWAP_BEHAVIOR = 0x3093;
		public const uint EGL_SWAP_BEHAVIOR_PRESERVED_BIT = 0x0400;
		public const uint EGL_SYNC_CL_EVENT = 0x30FE;
		public const uint EGL_SYNC_CL_EVENT_COMPLETE = 0x30FF;
		public const uint EGL_SYNC_CONDITION = 0x30F8;
		public const uint EGL_SYNC_FENCE = 0x30F9;
		public const uint EGL_SYNC_FLUSH_COMMANDS_BIT = 0x0001;
		public const uint EGL_SYNC_PRIOR_COMMANDS_COMPLETE = 0x30F0;
		public const uint EGL_SYNC_STATUS = 0x30F1;
		public const uint EGL_SYNC_TYPE = 0x30F7;
		public const uint EGL_TEXTURE_2D = 0x305F;
		public const uint EGL_TEXTURE_FORMAT = 0x3080;
		public const uint EGL_TEXTURE_RGB = 0x305D;
		public const uint EGL_TEXTURE_RGBA = 0x305E;
		public const uint EGL_TEXTURE_TARGET = 0x3081;
		public const uint EGL_TIMEOUT_EXPIRED = 0x30F5;
		public const uint EGL_TRANSPARENT_BLUE_VALUE = 0x3035;
		public const uint EGL_TRANSPARENT_GREEN_VALUE = 0x3036;
		public const uint EGL_TRANSPARENT_RED_VALUE = 0x3037;
		public const uint EGL_TRANSPARENT_RGB = 0x3052;
		public const uint EGL_TRANSPARENT_TYPE = 0x3034;
		public const uint EGL_TRUE = 1;
		public const uint EGL_UNKNOWN = unchecked((uint)-1);
		public const uint EGL_UNSIGNALED = 0x30F3;
		public const uint EGL_VENDOR = 0x3053;
		public const uint EGL_VERSION = 0x3054;
		public const uint EGL_VERTICAL_RESOLUTION = 0x3091;
		public const uint EGL_VG_ALPHA_FORMAT = 0x3088;
		public const uint EGL_VG_ALPHA_FORMAT_NONPRE = 0x308B;
		public const uint EGL_VG_ALPHA_FORMAT_PRE = 0x308C;
		public const uint EGL_VG_ALPHA_FORMAT_PRE_BIT = 0x0040;
		public const uint EGL_VG_COLORSPACE = 0x3087;
		public const uint EGL_VG_COLORSPACE_LINEAR = 0x308A;
		public const uint EGL_VG_COLORSPACE_LINEAR_BIT = 0x0020;
		public const uint EGL_VG_COLORSPACE_sRGB = 0x3089;
		public const uint EGL_WIDTH = 0x3057;
		public const uint EGL_WINDOW_BIT = 0x0004;

		[DllImport(Library, EntryPoint = "eglBindAPI")]
		public static extern bool eglBindAPI(uint api);

		[DllImport(Library, EntryPoint = "eglBindTexImage")]
		public static extern bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

		[DllImport(Library, EntryPoint = "eglChooseConfig")]
		public static extern bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

		[DllImport(Library, EntryPoint = "eglClientWaitSync")]
		public static extern int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, ulong timeout);

		[DllImport(Library, EntryPoint = "eglCopyBuffers")]
		public static extern bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

		[DllImport(Library, EntryPoint = "eglCreateContext")]
		public static extern IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreateImage")]
		public static extern IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreatePbufferFromClientBuffer")]
		public static extern IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreatePbufferSurface")]
		public static extern IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreatePixmapSurface")]
		public static extern IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreatePlatformPixmapSurface")]
		public static extern IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, void* native_pixmap, IntPtr* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreatePlatformWindowSurface")]
		public static extern IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, void* native_window, IntPtr* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreateSync")]
		public static extern IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

		[DllImport(Library, EntryPoint = "eglCreateWindowSurface")]
		public static extern IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

		[DllImport(Library, EntryPoint = "eglDestroyContext")]
		public static extern bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

		[DllImport(Library, EntryPoint = "eglDestroyImage")]
		public static extern bool eglDestroyImage(IntPtr dpy, IntPtr image);

		[DllImport(Library, EntryPoint = "eglDestroySurface")]
		public static extern bool eglDestroySurface(IntPtr dpy, IntPtr surface);

		[DllImport(Library, EntryPoint = "eglDestroySync")]
		public static extern bool eglDestroySync(IntPtr dpy, IntPtr sync);

		[DllImport(Library, EntryPoint = "eglGetConfigAttrib")]
		public static extern bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

		[DllImport(Library, EntryPoint = "eglGetConfigs")]
		public static extern bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

		[DllImport(Library, EntryPoint = "eglGetCurrentContext")]
		public static extern IntPtr eglGetCurrentContext();

		[DllImport(Library, EntryPoint = "eglGetCurrentDisplay")]
		public static extern IntPtr eglGetCurrentDisplay();

		[DllImport(Library, EntryPoint = "eglGetCurrentSurface")]
		public static extern IntPtr eglGetCurrentSurface(int readdraw);

		[DllImport(Library, EntryPoint = "eglGetDisplay")]
		public static extern IntPtr eglGetDisplay(IntPtr display_id);

		[DllImport(Library, EntryPoint = "eglGetError")]
		public static extern int eglGetError();

		[DllImport(Library, EntryPoint = "eglGetPlatformDisplay")]
		public static extern IntPtr eglGetPlatformDisplay(uint platform, void* native_display, IntPtr* attrib_list);

		[DllImport(Library, EntryPoint = "eglGetProcAddress")]
		public static extern IntPtr eglGetProcAddress(char* procname);

		[DllImport(Library, EntryPoint = "eglGetSyncAttrib")]
		public static extern bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

		[DllImport(Library, EntryPoint = "eglInitialize")]
		public static extern bool eglInitialize(IntPtr dpy, int* major, int* minor);

		[DllImport(Library, EntryPoint = "eglMakeCurrent")]
		public static extern bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

		[DllImport(Library, EntryPoint = "eglQueryAPI")]
		public static extern uint eglQueryAPI();

		[DllImport(Library, EntryPoint = "eglQueryContext")]
		public static extern bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

		[DllImport(Library, EntryPoint = "eglQueryString")]
		public static extern string eglQueryString(IntPtr dpy, int name);

		[DllImport(Library, EntryPoint = "eglQuerySurface")]
		public static extern bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

		[DllImport(Library, EntryPoint = "eglReleaseTexImage")]
		public static extern bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

		[DllImport(Library, EntryPoint = "eglReleaseThread")]
		public static extern bool eglReleaseThread();

		[DllImport(Library, EntryPoint = "eglSurfaceAttrib")]
		public static extern bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

		[DllImport(Library, EntryPoint = "eglSwapBuffers")]
		public static extern bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

		[DllImport(Library, EntryPoint = "eglSwapInterval")]
		public static extern bool eglSwapInterval(IntPtr dpy, int interval);

		[DllImport(Library, EntryPoint = "eglTerminate")]
		public static extern bool eglTerminate(IntPtr dpy);

		[DllImport(Library, EntryPoint = "eglWaitClient")]
		public static extern bool eglWaitClient();

		[DllImport(Library, EntryPoint = "eglWaitGL")]
		public static extern bool eglWaitGL();

		[DllImport(Library, EntryPoint = "eglWaitNative")]
		public static extern bool eglWaitNative(int engine);

		[DllImport(Library, EntryPoint = "eglWaitSync")]
		public static extern bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

	}
}
