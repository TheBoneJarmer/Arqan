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
		#else
		public const string LIBGL = "libGL.so";
		public const string LIBGLFW = "libglfw.so";
		#endif

		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern IntPtr wglGetCurrentContext();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern int wglMakeCurrent(IntPtr hdc, IntPtr hrc);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern IntPtr wglCreateContext(IntPtr hdc);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern int wglDeleteContext(IntPtr hrc);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern IntPtr wglGetProcAddress(string name);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool wglShareLists(IntPtr hrc1, IntPtr hrc2);
	}
}
