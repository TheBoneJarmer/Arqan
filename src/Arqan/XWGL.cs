using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class XWGL
	{
		#if Windows

		public const string LIBGL = "opengl32.dll";
		public const string LIBGLFW = "glfw3.dll";

		[DllImport(XWGL.LIBGL, SetLastError = true)]
		private static extern IntPtr wglGetProcAddress(string name);

		#else

		public const string LIBGL = "libGL.so";
		public const string LIBGLFW = "libglfw.so";

		[DllImport(XWGL.LIBGL, SetLastError = true)]
		private static extern IntPtr glXGetProcAddress(string name);

		#endif

		public static IntPtr GetProcAddress(string name)
		{
			#if Windows

			return wglGetProcAddress(name);

			#else

			return glXGetProcAddress(name);
			
			#endif
		}
	}
}
