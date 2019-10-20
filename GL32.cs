using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GL32
	{
		private static T GetDelegateFor<T>() where T : class
		{
			Type delegateType = typeof(T);
			string name = delegateType.Name.Replace("Delegate","");
			IntPtr proc = WGL.wglGetProcAddress(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		
		#region Constants
		
		public const uint GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint GL_LINES_ADJACENCY = 0x000A;
		public const uint GL_LINE_STRIP_ADJACENCY = 0x000B;
		public const uint GL_TRIANGLES_ADJACENCY = 0x000C;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const uint GL_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const uint GL_GEOMETRY_SHADER = 0x8DD9;
		public const uint GL_GEOMETRY_VERTICES_OUT = 0x8916;
		public const uint GL_GEOMETRY_INPUT_TYPE = 0x8917;
		public const uint GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const uint GL_CONTEXT_PROFILE_MASK = 0x9126;
		public const uint GL_DEPTH_CLAMP = 0x864F;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint GL_PROVOKING_VERTEX = 0x8E4F;
		public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint GL_OBJECT_TYPE = 0x9112;
		public const uint GL_SYNC_CONDITION = 0x9113;
		public const uint GL_SYNC_STATUS = 0x9114;
		public const uint GL_SYNC_FLAGS = 0x9115;
		public const uint GL_SYNC_FENCE = 0x9116;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint GL_UNSIGNALED = 0x9118;
		public const uint GL_SIGNALED = 0x9119;
		public const uint GL_ALREADY_SIGNALED = 0x911A;
		public const uint GL_TIMEOUT_EXPIRED = 0x911B;
		public const uint GL_CONDITION_SATISFIED = 0x911C;
		public const uint GL_WAIT_FAILED = 0x911D;
		public const uint GL_TIMEOUT_IGNORED = 0xFFFFFFFF;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint GL_SAMPLE_POSITION = 0x8E50;
		public const uint GL_SAMPLE_MASK = 0x8E51;
		public const uint GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const uint GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint GL_TEXTURE_SAMPLES = 0x9106;
		public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint GL_MAX_INTEGER_SAMPLES = 0x9110;
		
		#endregion
		
		#region Delegates
		
		private delegate void glDrawElementsBaseVertexDelegate(uint mode, int count, uint type, IntPtr indices, int basevertex);
		private delegate void glDrawRangeElementsBaseVertexDelegate(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);
		private delegate void glDrawElementsInstancedBaseVertexDelegate(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);
		private delegate void glMultiDrawElementsBaseVertexDelegate(uint mode, int[] count, uint type, IntPtr indices, int drawcount, int[] basevertex);
		private delegate void glProvokingVertexDelegate(uint mode);
		private delegate IntPtr glFenceSyncDelegate(uint condition, uint flags);
		private delegate bool glIsSyncDelegate(IntPtr sync);
		private delegate void glDeleteSyncDelegate(IntPtr sync);
		private delegate uint glClientWaitSyncDelegate(IntPtr sync, uint flags, UInt64 timeout);
		private delegate void glWaitSyncDelegate(IntPtr sync, uint flags, UInt64 timeout);
		private delegate void glGetInteger64vDelegate(uint pname, Int64[] data);
		private delegate void glGetSyncivDelegate(IntPtr sync, uint pname, int bufSize, int[] length, int[] values);
		private delegate void glGetInteger64i_vDelegate(uint target, uint index, Int64[] data);
		private delegate void glGetBufferParameteri64vDelegate(uint target, uint pname, Int64[] @params);
		private delegate void glFramebufferTextureDelegate(uint target, uint attachment, uint texture, int level);
		private delegate void glTexImage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexImage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glGetMultisamplefvDelegate(uint pname, uint index, float[] val);
		private delegate void glSampleMaskiDelegate(uint maskNumber, uint mask);
		#endregion
		
		#region Commands
		
		public static void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex)
		{
			GetDelegateFor<glDrawElementsBaseVertexDelegate>()(mode, count, type, indices, basevertex);
		}
		
		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex)
		{
			GetDelegateFor<glDrawRangeElementsBaseVertexDelegate>()(mode, start, end, count, type, indices, basevertex);
		}
		
		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex)
		{
			GetDelegateFor<glDrawElementsInstancedBaseVertexDelegate>()(mode, count, type, indices, instancecount, basevertex);
		}
		
		public static void glMultiDrawElementsBaseVertex(uint mode, int[] count, uint type, IntPtr indices, int drawcount, int[] basevertex)
		{
			GetDelegateFor<glMultiDrawElementsBaseVertexDelegate>()(mode, count, type, indices, drawcount, basevertex);
		}
		
		public static void glProvokingVertex(uint mode)
		{
			GetDelegateFor<glProvokingVertexDelegate>()(mode);
		}
		
		public static IntPtr glFenceSync(uint condition, uint flags)
		{
			return (IntPtr)GetDelegateFor<glFenceSyncDelegate>()(condition, flags);
		}
		
		public static bool glIsSync(IntPtr sync)
		{
			return (bool)GetDelegateFor<glIsSyncDelegate>()(sync);
		}
		
		public static void glDeleteSync(IntPtr sync)
		{
			GetDelegateFor<glDeleteSyncDelegate>()(sync);
		}
		
		public static uint glClientWaitSync(IntPtr sync, uint flags, UInt64 timeout)
		{
			return (uint)GetDelegateFor<glClientWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glWaitSync(IntPtr sync, uint flags, UInt64 timeout)
		{
			GetDelegateFor<glWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glGetInteger64v(uint pname, Int64[] data)
		{
			GetDelegateFor<glGetInteger64vDelegate>()(pname, data);
		}
		
		public static void glGetSynciv(IntPtr sync, uint pname, int bufSize, int[] length, int[] values)
		{
			GetDelegateFor<glGetSyncivDelegate>()(sync, pname, bufSize, length, values);
		}
		
		public static void glGetInteger64i_v(uint target, uint index, Int64[] data)
		{
			GetDelegateFor<glGetInteger64i_vDelegate>()(target, index, data);
		}
		
		public static void glGetBufferParameteri64v(uint target, uint pname, Int64[] @params)
		{
			GetDelegateFor<glGetBufferParameteri64vDelegate>()(target, pname, @params);
		}
		
		public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			GetDelegateFor<glFramebufferTextureDelegate>()(target, attachment, texture, level);
		}
		
		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			GetDelegateFor<glTexImage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			GetDelegateFor<glTexImage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glGetMultisamplefv(uint pname, uint index, float[] val)
		{
			GetDelegateFor<glGetMultisamplefvDelegate>()(pname, index, val);
		}
		
		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			GetDelegateFor<glSampleMaskiDelegate>()(maskNumber, mask);
		}
		
		#endregion
	}
}
