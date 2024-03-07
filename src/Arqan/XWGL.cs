using System;
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

		#elif OSX
		public const string LIBGL = "libGL.dylib";
		public const string LIBGLFW = "libglfw.dylib";

		[DllImport(XWGL.LIBGL, SetLastError = true)]
		private static extern IntPtr glXGetProcAddress(string name);


		#else

		public const string LIBGL = "libGL.so";
		public const string LIBGLFW = "libglfw.so";

		[DllImport(XWGL.LIBGL, SetLastError = true)]
		private static extern IntPtr glXGetProcAddress(string name);

		#endif

		internal static T GetDelegateFor<T>() where T : class
		{
			var delegateType = typeof(T);
			var name = delegateType.Name.Replace("Delegate","");
			var proc = XWGL.GetProcAddress(name);
			var del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		internal static T GetDelegateFor<T>(string name) where T : class
		{
			var delegateType = typeof(T);
			var proc = XWGL.GetProcAddress(name);
			var del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}

		private static IntPtr GetProcAddress(string name)
		{
			#if Windows

			return wglGetProcAddress(name);

			#else

			return glXGetProcAddress(name);
			
			#endif
		}
	}
}
