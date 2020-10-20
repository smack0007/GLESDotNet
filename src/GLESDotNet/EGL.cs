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
	public static unsafe partial class EGL
	{
		public const int EGL_ALPHA_FORMAT = 0x3088;
		public const int EGL_ALPHA_FORMAT_NONPRE = 0x308B;
		public const int EGL_ALPHA_FORMAT_PRE = 0x308C;
		public const int EGL_ALPHA_MASK_SIZE = 0x303E;
		public const int EGL_ALPHA_SIZE = 0x3021;
		public const int EGL_BACK_BUFFER = 0x3084;
		public const int EGL_BAD_ACCESS = 0x3002;
		public const int EGL_BAD_ALLOC = 0x3003;
		public const int EGL_BAD_ATTRIBUTE = 0x3004;
		public const int EGL_BAD_CONFIG = 0x3005;
		public const int EGL_BAD_CONTEXT = 0x3006;
		public const int EGL_BAD_CURRENT_SURFACE = 0x3007;
		public const int EGL_BAD_DISPLAY = 0x3008;
		public const int EGL_BAD_MATCH = 0x3009;
		public const int EGL_BAD_NATIVE_PIXMAP = 0x300A;
		public const int EGL_BAD_NATIVE_WINDOW = 0x300B;
		public const int EGL_BAD_PARAMETER = 0x300C;
		public const int EGL_BAD_SURFACE = 0x300D;
		public const int EGL_BIND_TO_TEXTURE_RGB = 0x3039;
		public const int EGL_BIND_TO_TEXTURE_RGBA = 0x303A;
		public const int EGL_BLUE_SIZE = 0x3022;
		public const int EGL_BUFFER_DESTROYED = 0x3095;
		public const int EGL_BUFFER_PRESERVED = 0x3094;
		public const int EGL_BUFFER_SIZE = 0x3020;
		public const int EGL_CL_EVENT_HANDLE = 0x309C;
		public const int EGL_CLIENT_APIS = 0x308D;
		public const int EGL_COLOR_BUFFER_TYPE = 0x303F;
		public const int EGL_COLORSPACE = 0x3087;
		public const int EGL_COLORSPACE_LINEAR = 0x308A;
		public const int EGL_COLORSPACE_sRGB = 0x3089;
		public const int EGL_CONDITION_SATISFIED = 0x30F6;
		public const int EGL_CONFIG_CAVEAT = 0x3027;
		public const int EGL_CONFIG_ID = 0x3028;
		public const int EGL_CONFORMANT = 0x3042;
		public const int EGL_CONTEXT_CLIENT_TYPE = 0x3097;
		public const int EGL_CONTEXT_CLIENT_VERSION = 0x3098;
		public const int EGL_CONTEXT_LOST = 0x300E;
		public const int EGL_CONTEXT_MAJOR_VERSION = 0x3098;
		public const int EGL_CONTEXT_MINOR_VERSION = 0x30FB;
		public const int EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const int EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT = 0x00000001;
		public const int EGL_CONTEXT_OPENGL_DEBUG = 0x31B0;
		public const int EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE = 0x31B1;
		public const int EGL_CONTEXT_OPENGL_PROFILE_MASK = 0x30FD;
		public const int EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY = 0x31BD;
		public const int EGL_CONTEXT_OPENGL_ROBUST_ACCESS = 0x31B2;
		public const int EGL_CORE_NATIVE_ENGINE = 0x305B;
		public const int EGL_DEFAULT_DISPLAY = 0;
		public const int EGL_DEPTH_SIZE = 0x3025;
		public const int EGL_DISPLAY_SCALING = 10000;
		public const int EGL_DONT_CARE = -1;
		public const int EGL_DRAW = 0x3059;
		public const int EGL_EGL_PROTOTYPES = 1;
		public const int EGL_EXTENSIONS = 0x3055;
		public const int EGL_FALSE = 0;
		public const ulong EGL_FOREVER = 0xFFFFFFFFFFFFFFFF;
		public const int EGL_GL_COLORSPACE = 0x309D;
		public const int EGL_GL_COLORSPACE_LINEAR = 0x308A;
		public const int EGL_GL_COLORSPACE_SRGB = 0x3089;
		public const int EGL_GL_RENDERBUFFER = 0x30B9;
		public const int EGL_GL_TEXTURE_2D = 0x30B1;
		public const int EGL_GL_TEXTURE_3D = 0x30B2;
		public const int EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x30B4;
		public const int EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x30B6;
		public const int EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x30B8;
		public const int EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x30B3;
		public const int EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x30B5;
		public const int EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x30B7;
		public const int EGL_GL_TEXTURE_LEVEL = 0x30BC;
		public const int EGL_GL_TEXTURE_ZOFFSET = 0x30BD;
		public const int EGL_GREEN_SIZE = 0x3023;
		public const int EGL_HEIGHT = 0x3056;
		public const int EGL_HORIZONTAL_RESOLUTION = 0x3090;
		public const int EGL_IMAGE_PRESERVED = 0x30D2;
		public const int EGL_LARGEST_PBUFFER = 0x3058;
		public const int EGL_LEVEL = 0x3029;
		public const int EGL_LOSE_CONTEXT_ON_RESET = 0x31BF;
		public const int EGL_LUMINANCE_BUFFER = 0x308F;
		public const int EGL_LUMINANCE_SIZE = 0x303D;
		public const int EGL_MATCH_NATIVE_PIXMAP = 0x3041;
		public const int EGL_MAX_PBUFFER_HEIGHT = 0x302A;
		public const int EGL_MAX_PBUFFER_PIXELS = 0x302B;
		public const int EGL_MAX_PBUFFER_WIDTH = 0x302C;
		public const int EGL_MAX_SWAP_INTERVAL = 0x303C;
		public const int EGL_MIN_SWAP_INTERVAL = 0x303B;
		public const int EGL_MIPMAP_LEVEL = 0x3083;
		public const int EGL_MIPMAP_TEXTURE = 0x3082;
		public const int EGL_MULTISAMPLE_RESOLVE = 0x3099;
		public const int EGL_MULTISAMPLE_RESOLVE_BOX = 0x309B;
		public const int EGL_MULTISAMPLE_RESOLVE_BOX_BIT = 0x0200;
		public const int EGL_MULTISAMPLE_RESOLVE_DEFAULT = 0x309A;
		public const int EGL_NATIVE_RENDERABLE = 0x302D;
		public const int EGL_NATIVE_VISUAL_ID = 0x302E;
		public const int EGL_NATIVE_VISUAL_TYPE = 0x302F;
		public const int EGL_NO_CONTEXT = 0;
		public const int EGL_NO_DISPLAY = 0;
		public const int EGL_NO_IMAGE = 0;
		public const int EGL_NO_RESET_NOTIFICATION = 0x31BE;
		public const int EGL_NO_SURFACE = 0;
		public const int EGL_NO_SYNC = 0;
		public const int EGL_NO_TEXTURE = 0x305C;
		public const int EGL_NON_CONFORMANT_CONFIG = 0x3051;
		public const int EGL_NONE = 0x3038;
		public const int EGL_NOT_INITIALIZED = 0x3001;
		public const int EGL_OPENGL_API = 0x30A2;
		public const int EGL_OPENGL_BIT = 0x0008;
		public const int EGL_OPENGL_ES_API = 0x30A0;
		public const int EGL_OPENGL_ES_BIT = 0x0001;
		public const int EGL_OPENGL_ES2_BIT = 0x0004;
		public const int EGL_OPENGL_ES3_BIT = 0x00000040;
		public const int EGL_OPENVG_API = 0x30A1;
		public const int EGL_OPENVG_BIT = 0x0002;
		public const int EGL_OPENVG_IMAGE = 0x3096;
		public const int EGL_PBUFFER_BIT = 0x0001;
		public const int EGL_PIXEL_ASPECT_RATIO = 0x3092;
		public const int EGL_PIXMAP_BIT = 0x0002;
		public const int EGL_READ = 0x305A;
		public const int EGL_RED_SIZE = 0x3024;
		public const int EGL_RENDER_BUFFER = 0x3086;
		public const int EGL_RENDERABLE_TYPE = 0x3040;
		public const int EGL_RGB_BUFFER = 0x308E;
		public const int EGL_SAMPLE_BUFFERS = 0x3032;
		public const int EGL_SAMPLES = 0x3031;
		public const int EGL_SIGNALED = 0x30F2;
		public const int EGL_SINGLE_BUFFER = 0x3085;
		public const int EGL_SLOW_CONFIG = 0x3050;
		public const int EGL_STENCIL_SIZE = 0x3026;
		public const int EGL_SUCCESS = 0x3000;
		public const int EGL_SURFACE_TYPE = 0x3033;
		public const int EGL_SWAP_BEHAVIOR = 0x3093;
		public const int EGL_SWAP_BEHAVIOR_PRESERVED_BIT = 0x0400;
		public const int EGL_SYNC_CL_EVENT = 0x30FE;
		public const int EGL_SYNC_CL_EVENT_COMPLETE = 0x30FF;
		public const int EGL_SYNC_CONDITION = 0x30F8;
		public const int EGL_SYNC_FENCE = 0x30F9;
		public const int EGL_SYNC_FLUSH_COMMANDS_BIT = 0x0001;
		public const int EGL_SYNC_PRIOR_COMMANDS_COMPLETE = 0x30F0;
		public const int EGL_SYNC_STATUS = 0x30F1;
		public const int EGL_SYNC_TYPE = 0x30F7;
		public const int EGL_TEXTURE_2D = 0x305F;
		public const int EGL_TEXTURE_FORMAT = 0x3080;
		public const int EGL_TEXTURE_RGB = 0x305D;
		public const int EGL_TEXTURE_RGBA = 0x305E;
		public const int EGL_TEXTURE_TARGET = 0x3081;
		public const int EGL_TIMEOUT_EXPIRED = 0x30F5;
		public const int EGL_TRANSPARENT_BLUE_VALUE = 0x3035;
		public const int EGL_TRANSPARENT_GREEN_VALUE = 0x3036;
		public const int EGL_TRANSPARENT_RED_VALUE = 0x3037;
		public const int EGL_TRANSPARENT_RGB = 0x3052;
		public const int EGL_TRANSPARENT_TYPE = 0x3034;
		public const int EGL_TRUE = 1;
		public const int EGL_UNKNOWN = -1;
		public const int EGL_UNSIGNALED = 0x30F3;
		public const int EGL_VENDOR = 0x3053;
		public const int EGL_VERSION = 0x3054;
		public const int EGL_VERTICAL_RESOLUTION = 0x3091;
		public const int EGL_VG_ALPHA_FORMAT = 0x3088;
		public const int EGL_VG_ALPHA_FORMAT_NONPRE = 0x308B;
		public const int EGL_VG_ALPHA_FORMAT_PRE = 0x308C;
		public const int EGL_VG_ALPHA_FORMAT_PRE_BIT = 0x0040;
		public const int EGL_VG_COLORSPACE = 0x3087;
		public const int EGL_VG_COLORSPACE_LINEAR = 0x308A;
		public const int EGL_VG_COLORSPACE_LINEAR_BIT = 0x0020;
		public const int EGL_VG_COLORSPACE_sRGB = 0x3089;
		public const int EGL_WIDTH = 0x3057;
		public const int EGL_WINDOW_BIT = 0x0004;

		private static class Delegates
		{
			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglBindAPI(int api);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, ulong timeout);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, int target, IntPtr buffer, IntPtr* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, int buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, void* native_pixmap, IntPtr* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, void* native_window, IntPtr* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreateSync(IntPtr dpy, int type, IntPtr* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglDestroyImage(IntPtr dpy, IntPtr image);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglDestroySurface(IntPtr dpy, IntPtr surface);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglDestroySync(IntPtr dpy, IntPtr sync);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetCurrentContext();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetCurrentDisplay();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetCurrentSurface(int readdraw);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetDisplay(IntPtr display_id);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate int eglGetError();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetPlatformDisplay(int platform, void* native_display, IntPtr* attrib_list);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate IntPtr eglGetProcAddress(string procname);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglInitialize(IntPtr dpy, int* major, int* minor);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate int eglQueryAPI();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate string eglQueryString(IntPtr dpy, int name);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglReleaseThread();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglSwapInterval(IntPtr dpy, int interval);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglTerminate(IntPtr dpy);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglWaitClient();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglWaitGL();

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglWaitNative(int engine);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
			public delegate bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

		}

		private static Delegates.eglBindAPI _eglBindAPI;

		private static Delegates.eglBindTexImage _eglBindTexImage;

		private static Delegates.eglChooseConfig _eglChooseConfig;

		private static Delegates.eglClientWaitSync _eglClientWaitSync;

		private static Delegates.eglCopyBuffers _eglCopyBuffers;

		private static Delegates.eglCreateContext _eglCreateContext;

		private static Delegates.eglCreateImage _eglCreateImage;

		private static Delegates.eglCreatePbufferFromClientBuffer _eglCreatePbufferFromClientBuffer;

		private static Delegates.eglCreatePbufferSurface _eglCreatePbufferSurface;

		private static Delegates.eglCreatePixmapSurface _eglCreatePixmapSurface;

		private static Delegates.eglCreatePlatformPixmapSurface _eglCreatePlatformPixmapSurface;

		private static Delegates.eglCreatePlatformWindowSurface _eglCreatePlatformWindowSurface;

		private static Delegates.eglCreateSync _eglCreateSync;

		private static Delegates.eglCreateWindowSurface _eglCreateWindowSurface;

		private static Delegates.eglDestroyContext _eglDestroyContext;

		private static Delegates.eglDestroyImage _eglDestroyImage;

		private static Delegates.eglDestroySurface _eglDestroySurface;

		private static Delegates.eglDestroySync _eglDestroySync;

		private static Delegates.eglGetConfigAttrib _eglGetConfigAttrib;

		private static Delegates.eglGetConfigs _eglGetConfigs;

		private static Delegates.eglGetCurrentContext _eglGetCurrentContext;

		private static Delegates.eglGetCurrentDisplay _eglGetCurrentDisplay;

		private static Delegates.eglGetCurrentSurface _eglGetCurrentSurface;

		private static Delegates.eglGetDisplay _eglGetDisplay;

		private static Delegates.eglGetError _eglGetError;

		private static Delegates.eglGetPlatformDisplay _eglGetPlatformDisplay;

		private static Delegates.eglGetProcAddress _eglGetProcAddress;

		private static Delegates.eglGetSyncAttrib _eglGetSyncAttrib;

		private static Delegates.eglInitialize _eglInitialize;

		private static Delegates.eglMakeCurrent _eglMakeCurrent;

		private static Delegates.eglQueryAPI _eglQueryAPI;

		private static Delegates.eglQueryContext _eglQueryContext;

		private static Delegates.eglQueryString _eglQueryString;

		private static Delegates.eglQuerySurface _eglQuerySurface;

		private static Delegates.eglReleaseTexImage _eglReleaseTexImage;

		private static Delegates.eglReleaseThread _eglReleaseThread;

		private static Delegates.eglSurfaceAttrib _eglSurfaceAttrib;

		private static Delegates.eglSwapBuffers _eglSwapBuffers;

		private static Delegates.eglSwapInterval _eglSwapInterval;

		private static Delegates.eglTerminate _eglTerminate;

		private static Delegates.eglWaitClient _eglWaitClient;

		private static Delegates.eglWaitGL _eglWaitGL;

		private static Delegates.eglWaitNative _eglWaitNative;

		private static Delegates.eglWaitSync _eglWaitSync;

		static EGL()
		{
			LoadFunctions(LoadAssembly());
		}

		private static void LoadFunctions(Func<string, IntPtr> getProcAddress)
		{
			T getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));

			_eglBindAPI = getProc<Delegates.eglBindAPI>("eglBindAPI");
			_eglBindTexImage = getProc<Delegates.eglBindTexImage>("eglBindTexImage");
			_eglChooseConfig = getProc<Delegates.eglChooseConfig>("eglChooseConfig");
			_eglClientWaitSync = getProc<Delegates.eglClientWaitSync>("eglClientWaitSync");
			_eglCopyBuffers = getProc<Delegates.eglCopyBuffers>("eglCopyBuffers");
			_eglCreateContext = getProc<Delegates.eglCreateContext>("eglCreateContext");
			_eglCreateImage = getProc<Delegates.eglCreateImage>("eglCreateImage");
			_eglCreatePbufferFromClientBuffer = getProc<Delegates.eglCreatePbufferFromClientBuffer>("eglCreatePbufferFromClientBuffer");
			_eglCreatePbufferSurface = getProc<Delegates.eglCreatePbufferSurface>("eglCreatePbufferSurface");
			_eglCreatePixmapSurface = getProc<Delegates.eglCreatePixmapSurface>("eglCreatePixmapSurface");
			_eglCreatePlatformPixmapSurface = getProc<Delegates.eglCreatePlatformPixmapSurface>("eglCreatePlatformPixmapSurface");
			_eglCreatePlatformWindowSurface = getProc<Delegates.eglCreatePlatformWindowSurface>("eglCreatePlatformWindowSurface");
			_eglCreateSync = getProc<Delegates.eglCreateSync>("eglCreateSync");
			_eglCreateWindowSurface = getProc<Delegates.eglCreateWindowSurface>("eglCreateWindowSurface");
			_eglDestroyContext = getProc<Delegates.eglDestroyContext>("eglDestroyContext");
			_eglDestroyImage = getProc<Delegates.eglDestroyImage>("eglDestroyImage");
			_eglDestroySurface = getProc<Delegates.eglDestroySurface>("eglDestroySurface");
			_eglDestroySync = getProc<Delegates.eglDestroySync>("eglDestroySync");
			_eglGetConfigAttrib = getProc<Delegates.eglGetConfigAttrib>("eglGetConfigAttrib");
			_eglGetConfigs = getProc<Delegates.eglGetConfigs>("eglGetConfigs");
			_eglGetCurrentContext = getProc<Delegates.eglGetCurrentContext>("eglGetCurrentContext");
			_eglGetCurrentDisplay = getProc<Delegates.eglGetCurrentDisplay>("eglGetCurrentDisplay");
			_eglGetCurrentSurface = getProc<Delegates.eglGetCurrentSurface>("eglGetCurrentSurface");
			_eglGetDisplay = getProc<Delegates.eglGetDisplay>("eglGetDisplay");
			_eglGetError = getProc<Delegates.eglGetError>("eglGetError");
			_eglGetPlatformDisplay = getProc<Delegates.eglGetPlatformDisplay>("eglGetPlatformDisplay");
			_eglGetProcAddress = getProc<Delegates.eglGetProcAddress>("eglGetProcAddress");
			_eglGetSyncAttrib = getProc<Delegates.eglGetSyncAttrib>("eglGetSyncAttrib");
			_eglInitialize = getProc<Delegates.eglInitialize>("eglInitialize");
			_eglMakeCurrent = getProc<Delegates.eglMakeCurrent>("eglMakeCurrent");
			_eglQueryAPI = getProc<Delegates.eglQueryAPI>("eglQueryAPI");
			_eglQueryContext = getProc<Delegates.eglQueryContext>("eglQueryContext");
			_eglQueryString = getProc<Delegates.eglQueryString>("eglQueryString");
			_eglQuerySurface = getProc<Delegates.eglQuerySurface>("eglQuerySurface");
			_eglReleaseTexImage = getProc<Delegates.eglReleaseTexImage>("eglReleaseTexImage");
			_eglReleaseThread = getProc<Delegates.eglReleaseThread>("eglReleaseThread");
			_eglSurfaceAttrib = getProc<Delegates.eglSurfaceAttrib>("eglSurfaceAttrib");
			_eglSwapBuffers = getProc<Delegates.eglSwapBuffers>("eglSwapBuffers");
			_eglSwapInterval = getProc<Delegates.eglSwapInterval>("eglSwapInterval");
			_eglTerminate = getProc<Delegates.eglTerminate>("eglTerminate");
			_eglWaitClient = getProc<Delegates.eglWaitClient>("eglWaitClient");
			_eglWaitGL = getProc<Delegates.eglWaitGL>("eglWaitGL");
			_eglWaitNative = getProc<Delegates.eglWaitNative>("eglWaitNative");
			_eglWaitSync = getProc<Delegates.eglWaitSync>("eglWaitSync");
		}

		public static bool eglBindAPI(int api)
		{
			return _eglBindAPI(api);
		}

		public static bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			return _eglBindTexImage(dpy, surface, buffer);
		}

		public static bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config)
		{
			return _eglChooseConfig(dpy, attrib_list, configs, config_size, num_config);
		}

        public static bool eglChooseConfig(IntPtr dpy, int[] attrib_list, out IntPtr configs, int config_size, out int num_config)
        {
            fixed (int* attrib_listPtr = attrib_list)
            fixed (IntPtr* configsPtr = &configs)
            fixed (int* num_configPtr = &num_config)
            {
                return _eglChooseConfig(dpy, attrib_listPtr, configsPtr, config_size, num_configPtr);
            }
        }

		public static int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, ulong timeout)
		{
			return _eglClientWaitSync(dpy, sync, flags, timeout);
		}

		public static bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target)
		{
			return _eglCopyBuffers(dpy, surface, target);
		}

		public static IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list)
		{
			return _eglCreateContext(dpy, config, share_context, attrib_list);
		}

        public static IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int[] attrib_list)
        {
            fixed (int* attrib_listPtr = attrib_list)
            {
                return _eglCreateContext(dpy, config, share_context, attrib_listPtr);
            }
        }

		public static IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, int target, IntPtr buffer, IntPtr* attrib_list)
		{
			return _eglCreateImage(dpy, ctx, target, buffer, attrib_list);
		}

		public static IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, int buftype, IntPtr buffer, IntPtr config, int* attrib_list)
		{
			return _eglCreatePbufferFromClientBuffer(dpy, buftype, buffer, config, attrib_list);
		}

		public static IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list)
		{
			return _eglCreatePbufferSurface(dpy, config, attrib_list);
		}

		public static IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list)
		{
			return _eglCreatePixmapSurface(dpy, config, pixmap, attrib_list);
		}

		public static IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, void* native_pixmap, IntPtr* attrib_list)
		{
			return _eglCreatePlatformPixmapSurface(dpy, config, native_pixmap, attrib_list);
		}

		public static IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list)
		{
			return _eglCreatePlatformPixmapSurface(dpy, config, (void*)native_pixmap, attrib_list);
		}

		public static IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, void* native_window, IntPtr* attrib_list)
		{
			return _eglCreatePlatformWindowSurface(dpy, config, native_window, attrib_list);
		}

		public static IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list)
		{
			return _eglCreatePlatformWindowSurface(dpy, config, (void*)native_window, attrib_list);
		}

		public static IntPtr eglCreateSync(IntPtr dpy, int type, IntPtr* attrib_list)
		{
			return _eglCreateSync(dpy, type, attrib_list);
		}

		public static IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list)
		{
			return _eglCreateWindowSurface(dpy, config, win, attrib_list);
		}

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
        }

		public static bool eglDestroyContext(IntPtr dpy, IntPtr ctx)
		{
			return _eglDestroyContext(dpy, ctx);
		}

		public static bool eglDestroyImage(IntPtr dpy, IntPtr image)
		{
			return _eglDestroyImage(dpy, image);
		}

		public static bool eglDestroySurface(IntPtr dpy, IntPtr surface)
		{
			return _eglDestroySurface(dpy, surface);
		}

		public static bool eglDestroySync(IntPtr dpy, IntPtr sync)
		{
			return _eglDestroySync(dpy, sync);
		}

		public static bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value)
		{
			return _eglGetConfigAttrib(dpy, config, attribute, value);
		}

		public static bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config)
		{
			return _eglGetConfigs(dpy, configs, config_size, num_config);
		}

		public static IntPtr eglGetCurrentContext()
		{
			return _eglGetCurrentContext();
		}

		public static IntPtr eglGetCurrentDisplay()
		{
			return _eglGetCurrentDisplay();
		}

		public static IntPtr eglGetCurrentSurface(int readdraw)
		{
			return _eglGetCurrentSurface(readdraw);
		}

		public static IntPtr eglGetDisplay(IntPtr display_id)
		{
			return _eglGetDisplay(display_id);
		}

		public static int eglGetError()
		{
			return _eglGetError();
		}

		public static IntPtr eglGetPlatformDisplay(int platform, void* native_display, IntPtr* attrib_list)
		{
			return _eglGetPlatformDisplay(platform, native_display, attrib_list);
		}

		public static IntPtr eglGetPlatformDisplay(int platform, IntPtr native_display, IntPtr* attrib_list)
		{
			return _eglGetPlatformDisplay(platform, (void*)native_display, attrib_list);
		}

		public static IntPtr eglGetProcAddress(string procname)
		{
			return _eglGetProcAddress(procname);
		}

		public static bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value)
		{
			return _eglGetSyncAttrib(dpy, sync, attribute, value);
		}

		public static bool eglInitialize(IntPtr dpy, int* major, int* minor)
		{
			return _eglInitialize(dpy, major, minor);
		}

        public static bool eglInitialize(IntPtr dpy, out int major, out int minor)
        {
            fixed (int* majorPtr = &major)
            fixed (int* minorPtr = &minor)
            {
                return _eglInitialize(dpy, majorPtr, minorPtr);
            }
        }

		public static bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
		{
			return _eglMakeCurrent(dpy, draw, read, ctx);
		}

		public static int eglQueryAPI()
		{
			return _eglQueryAPI();
		}

		public static bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value)
		{
			return _eglQueryContext(dpy, ctx, attribute, value);
		}

		public static string eglQueryString(IntPtr dpy, int name)
		{
			return _eglQueryString(dpy, name);
		}

		public static bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value)
		{
			return _eglQuerySurface(dpy, surface, attribute, value);
		}

		public static bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			return _eglReleaseTexImage(dpy, surface, buffer);
		}

		public static bool eglReleaseThread()
		{
			return _eglReleaseThread();
		}

		public static bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value)
		{
			return _eglSurfaceAttrib(dpy, surface, attribute, value);
		}

		public static bool eglSwapBuffers(IntPtr dpy, IntPtr surface)
		{
			return _eglSwapBuffers(dpy, surface);
		}

		public static bool eglSwapInterval(IntPtr dpy, int interval)
		{
			return _eglSwapInterval(dpy, interval);
		}

		public static bool eglTerminate(IntPtr dpy)
		{
			return _eglTerminate(dpy);
		}

		public static bool eglWaitClient()
		{
			return _eglWaitClient();
		}

		public static bool eglWaitGL()
		{
			return _eglWaitGL();
		}

		public static bool eglWaitNative(int engine)
		{
			return _eglWaitNative(engine);
		}

		public static bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags)
		{
			return _eglWaitSync(dpy, sync, flags);
		}

	}
}
