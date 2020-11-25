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

		internal static T GetDelegateFor<T>() where T : class
		{
			Type delegateType = typeof(T);
			string name = delegateType.Name.Replace("Delegate","");
			IntPtr proc = XWGL.GetProcAddress(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		internal static T GetDelegateFor<T>(string name) where T : class
		{
			Type delegateType = typeof(T);
			IntPtr proc = XWGL.GetProcAddress(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}

		internal static IntPtr GetProcAddress(string name)
		{
			#if Windows

			return wglGetProcAddress(name);

			#else

			return glXGetProcAddress(name);
			
			#endif
		}
	}
}
