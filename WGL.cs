using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class WGL
	{
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern IntPtr wglGetCurrentContext();
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern int wglMakeCurrent(IntPtr hdc, IntPtr hrc);
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern IntPtr wglCreateContext(IntPtr hdc);
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern int wglDeleteContext(IntPtr hrc);
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern IntPtr wglGetProcAddress(string name);
		[DllImport("opengl32.dll", SetLastError = true)]
		public static extern bool wglShareLists(IntPtr hrc1, IntPtr hrc2);
	}
}
