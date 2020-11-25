using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL44
	{		
		#region Constants
		
		public const uint GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const uint GL_MAP_READ_BIT = 0x0001;
		public const uint GL_MAP_WRITE_BIT = 0x0002;
		public const uint GL_MAP_PERSISTENT_BIT = 0x0040;
		public const uint GL_MAP_COHERENT_BIT = 0x0080;
		public const uint GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint GL_CLIENT_STORAGE_BIT = 0x0200;
		public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint GL_BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint GL_CLEAR_TEXTURE = 0x9365;
		public const uint GL_LOCATION_COMPONENT = 0x934A;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint GL_QUERY_BUFFER = 0x9192;
		public const uint GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint GL_QUERY_BUFFER_BINDING = 0x9193;
		public const uint GL_QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
		public const uint GL_STENCIL_INDEX = 0x1901;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		
		#endregion
		
		#region Delegates
		
		private delegate void glBufferStorageDelegate(uint target, IntPtr size, IntPtr data, uint flags);
		private delegate void glClearTexImageDelegate(uint texture, int level, uint format, uint type, IntPtr data);
		private delegate void glClearTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);
		private delegate void glBindBuffersBaseDelegate(uint target, uint first, int count, uint[] buffers);
		private delegate void glBindBuffersRangeDelegate(uint target, uint first, int count, uint[] buffers, IntPtr offsets, IntPtr sizes);
		private delegate void glBindTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindSamplersDelegate(uint first, int count, uint[] samplers);
		private delegate void glBindImageTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindVertexBuffersDelegate(uint first, int count, uint[] buffers, IntPtr offsets, int[] strides);
		#endregion
		
		#region Commands
		
		public static void glBufferStorage(uint target, IntPtr size, IntPtr data, uint flags)
		{
			XWGL.GetDelegateFor<glBufferStorageDelegate>()(target, size, data, flags);
		}
		
		public static void glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data)
		{
			XWGL.GetDelegateFor<glClearTexImageDelegate>()(texture, level, format, type, data);
		}
		
		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data)
		{
			XWGL.GetDelegateFor<glClearTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		
		public static void glBindBuffersBase(uint target, uint first, int count, uint[] buffers)
		{
			XWGL.GetDelegateFor<glBindBuffersBaseDelegate>()(target, first, count, buffers);
		}
		
		public static void glBindBuffersRange(uint target, uint first, int count, uint[] buffers, IntPtr offsets, IntPtr sizes)
		{
			XWGL.GetDelegateFor<glBindBuffersRangeDelegate>()(target, first, count, buffers, offsets, sizes);
		}
		
		public static void glBindTextures(uint first, int count, uint[] textures)
		{
			XWGL.GetDelegateFor<glBindTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindSamplers(uint first, int count, uint[] samplers)
		{
			XWGL.GetDelegateFor<glBindSamplersDelegate>()(first, count, samplers);
		}
		
		public static void glBindImageTextures(uint first, int count, uint[] textures)
		{
			XWGL.GetDelegateFor<glBindImageTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindVertexBuffers(uint first, int count, uint[] buffers, IntPtr offsets, int[] strides)
		{
			XWGL.GetDelegateFor<glBindVertexBuffersDelegate>()(first, count, buffers, offsets, strides);
		}
		
		#endregion
	}
}
