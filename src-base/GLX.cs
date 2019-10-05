using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GLX
	{
		[DllImport("libGL.so", SetLastError = true)]
		public static extern IntPtr glXGetCurrentContext();
		[DllImport("libGL.so", SetLastError = true)]
		public static extern int glXMakeCurrent(IntPtr hdc, IntPtr hrc);
		[DllImport("libGL.so", SetLastError = true)]
		public static extern IntPtr glXCreateContext(IntPtr hdc);
		[DllImport("libGL.so", SetLastError = true)]
		public static extern int glXDeleteContext(IntPtr hrc);
		[DllImport("libGL.so", SetLastError = true)]
		public static extern IntPtr glXGetProcAddress(string name);
		[DllImport("libGL.so", SetLastError = true)]
		public static extern bool glXShareLists(IntPtr hrc1, IntPtr hrc2);
	}
}
