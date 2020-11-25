using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL15
	{
		private static T GetDelegateFor<T>() where T : class
		{
			Type delegateType = typeof(T);
			string name = delegateType.Name.Replace("Delegate","");
			IntPtr proc = XWGL.GetProcAddress(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		
		#region Constants
		
		public const uint GL_BUFFER_SIZE = 0x8764;
		public const uint GL_BUFFER_USAGE = 0x8765;
		public const uint GL_QUERY_COUNTER_BITS = 0x8864;
		public const uint GL_CURRENT_QUERY = 0x8865;
		public const uint GL_QUERY_RESULT = 0x8866;
		public const uint GL_QUERY_RESULT_AVAILABLE = 0x8867;
		public const uint GL_ARRAY_BUFFER = 0x8892;
		public const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint GL_READ_ONLY = 0x88B8;
		public const uint GL_WRITE_ONLY = 0x88B9;
		public const uint GL_READ_WRITE = 0x88BA;
		public const uint GL_BUFFER_ACCESS = 0x88BB;
		public const uint GL_BUFFER_MAPPED = 0x88BC;
		public const uint GL_BUFFER_MAP_POINTER = 0x88BD;
		public const uint GL_STREAM_DRAW = 0x88E0;
		public const uint GL_STREAM_READ = 0x88E1;
		public const uint GL_STREAM_COPY = 0x88E2;
		public const uint GL_STATIC_DRAW = 0x88E4;
		public const uint GL_STATIC_READ = 0x88E5;
		public const uint GL_STATIC_COPY = 0x88E6;
		public const uint GL_DYNAMIC_DRAW = 0x88E8;
		public const uint GL_DYNAMIC_READ = 0x88E9;
		public const uint GL_DYNAMIC_COPY = 0x88EA;
		public const uint GL_SAMPLES_PASSED = 0x8914;
		public const uint GL_SRC1_ALPHA = 0x8589;
		public const uint GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
		public const uint GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
		public const uint GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
		public const uint GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
		public const uint GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
		public const uint GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
		public const uint GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
		public const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
		public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
		public const uint GL_FOG_COORD_SRC = 0x8450;
		public const uint GL_FOG_COORD = 0x8451;
		public const uint GL_CURRENT_FOG_COORD = 0x8453;
		public const uint GL_FOG_COORD_ARRAY_TYPE = 0x8454;
		public const uint GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
		public const uint GL_FOG_COORD_ARRAY_POINTER = 0x8456;
		public const uint GL_FOG_COORD_ARRAY = 0x8457;
		public const uint GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
		public const uint GL_SRC0_RGB = 0x8580;
		public const uint GL_SRC1_RGB = 0x8581;
		public const uint GL_SRC2_RGB = 0x8582;
		public const uint GL_SRC0_ALPHA = 0x8588;
		public const uint GL_SRC2_ALPHA = 0x858A;
		
		#endregion
		
		#region Delegates
		
		private delegate void glGenQueriesDelegate(int n, uint[] ids);
		private delegate void glDeleteQueriesDelegate(int n, uint[] ids);
		private delegate bool glIsQueryDelegate(uint id);
		private delegate void glBeginQueryDelegate(uint target, uint id);
		private delegate void glEndQueryDelegate(uint target);
		private delegate void glGetQueryivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetQueryObjectivDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetQueryObjectuivDelegate(uint id, uint pname, uint[] @params);
		private delegate void glBindBufferDelegate(uint target, uint buffer);
		private delegate void glDeleteBuffersDelegate(int n, uint[] buffers);
		private delegate void glGenBuffersDelegate(int n, uint[] buffers);
		private delegate bool glIsBufferDelegate(uint buffer);
		private delegate void glBufferDataDelegate1(uint target, int size, float[] data, uint usage);
		private delegate void glBufferDataDelegate2(uint target, int size, uint[] data, uint usage);
		private delegate void glBufferSubDataDelegate(uint target, int offset, int size, float[] data);
		private delegate void glGetBufferSubDataDelegate(uint target, IntPtr offset, IntPtr size, IntPtr data);
		private delegate void glMapBufferDelegate(uint target, uint access);
		private delegate bool glUnmapBufferDelegate(uint target);
		private delegate void glGetBufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetBufferPointervDelegate(uint target, uint pname, IntPtr @params);
		#endregion
		
		#region Commands
		
		public static void glGenQueries(int n, uint[] ids)
		{
			GetDelegateFor<glGenQueriesDelegate>()(n, ids);
		}
		
		public static void glDeleteQueries(int n, uint[] ids)
		{
			GetDelegateFor<glDeleteQueriesDelegate>()(n, ids);
		}
		
		public static bool glIsQuery(uint id)
		{
			return (bool)GetDelegateFor<glIsQueryDelegate>()(id);
		}
		
		public static void glBeginQuery(uint target, uint id)
		{
			GetDelegateFor<glBeginQueryDelegate>()(target, id);
		}
		
		public static void glEndQuery(uint target)
		{
			GetDelegateFor<glEndQueryDelegate>()(target);
		}
		
		public static void glGetQueryiv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glGetQueryivDelegate>()(target, pname, @params);
		}
		
		public static void glGetQueryObjectiv(uint id, uint pname, int[] @params)
		{
			GetDelegateFor<glGetQueryObjectivDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectuiv(uint id, uint pname, uint[] @params)
		{
			GetDelegateFor<glGetQueryObjectuivDelegate>()(id, pname, @params);
		}
		
		public static void glBindBuffer(uint target, uint buffer)
		{
			GetDelegateFor<glBindBufferDelegate>()(target, buffer);
		}
		
		public static void glDeleteBuffers(int n, uint[] buffers)
		{
			GetDelegateFor<glDeleteBuffersDelegate>()(n, buffers);
		}
		
		public static void glGenBuffers(int n, uint[] buffers)
		{
			GetDelegateFor<glGenBuffersDelegate>()(n, buffers);
		}
		
		public static bool glIsBuffer(uint buffer)
		{
			return (bool)GetDelegateFor<glIsBufferDelegate>()(buffer);
		}
		
		public static void glBufferData(uint target, int size, float[] data, uint usage)
		{
			GetDelegateFor<glBufferDataDelegate1>()(target, size, data, usage);
		}

		public static void glBufferData(uint target, int size, uint[] data, uint usage)
		{
			GetDelegateFor<glBufferDataDelegate2>()(target, size, data, usage);
		}
		
		public static void glBufferSubData(uint target, int offset, int size, float[] data)
		{
			GetDelegateFor<glBufferSubDataDelegate>()(target, offset, size, data);
		}
		
		public static void glGetBufferSubData(uint target, IntPtr offset, IntPtr size, IntPtr data)
		{
			GetDelegateFor<glGetBufferSubDataDelegate>()(target, offset, size, data);
		}
		
		public static void glMapBuffer(uint target, uint access)
		{
			GetDelegateFor<glMapBufferDelegate>()(target, access);
		}
		
		public static bool glUnmapBuffer(uint target)
		{
			return (bool)GetDelegateFor<glUnmapBufferDelegate>()(target);
		}
		
		public static void glGetBufferParameteriv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glGetBufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetBufferPointerv(uint target, uint pname, IntPtr @params)
		{
			GetDelegateFor<glGetBufferPointervDelegate>()(target, pname, @params);
		}
		
		#endregion
	}
}
