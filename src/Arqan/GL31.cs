using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	[Obsolete("Please use the static class GL")]
	public static class GL31
	{		
		#region Constants
		
		public const uint GL_SAMPLER_2D_RECT = 0x8B63;
		public const uint GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const uint GL_SAMPLER_BUFFER = 0x8DC2;
		public const uint GL_INT_SAMPLER_2D_RECT = 0x8DCD;
		public const uint GL_INT_SAMPLER_BUFFER = 0x8DD0;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const uint GL_TEXTURE_BUFFER = 0x8C2A;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const uint GL_TEXTURE_RECTANGLE = 0x84F5;
		public const uint GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const uint GL_R8_SNORM = 0x8F94;
		public const uint GL_RG8_SNORM = 0x8F95;
		public const uint GL_RGB8_SNORM = 0x8F96;
		public const uint GL_RGBA8_SNORM = 0x8F97;
		public const uint GL_R16_SNORM = 0x8F98;
		public const uint GL_RG16_SNORM = 0x8F99;
		public const uint GL_RGB16_SNORM = 0x8F9A;
		public const uint GL_RGBA16_SNORM = 0x8F9B;
		public const uint GL_SIGNED_NORMALIZED = 0x8F9C;
		public const uint GL_PRIMITIVE_RESTART = 0x8F9D;
		public const uint GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const uint GL_COPY_READ_BUFFER = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER = 0x8F37;
		public const uint GL_UNIFORM_BUFFER = 0x8A11;
		public const uint GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint GL_UNIFORM_BUFFER_START = 0x8A29;
		public const uint GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint GL_UNIFORM_TYPE = 0x8A37;
		public const uint GL_UNIFORM_SIZE = 0x8A38;
		public const uint GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint GL_UNIFORM_OFFSET = 0x8A3B;
		public const uint GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint GL_INVALID_INDEX = 0xFFFFFFFF;
		
		#endregion
		
		#region Delegates
		
		private delegate void glDrawArraysInstancedDelegate(uint mode, int first, int count, int instancecount);
		private delegate void glDrawElementsInstancedDelegate(uint mode, int count, uint type, IntPtr indices, int instancecount);
		private delegate void glTexBufferDelegate(uint target, uint internalformat, uint buffer);
		private delegate void glPrimitiveRestartIndexDelegate(uint index);
		private delegate void glCopyBufferSubDataDelegate(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
		private delegate void glGetUniformIndicesDelegate(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices);
		private delegate void glGetActiveUniformsivDelegate(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params);
		private delegate void glGetActiveUniformNameDelegate(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName);
		private delegate uint glGetUniformBlockIndexDelegate(uint program, char[] uniformBlockName);
		private delegate void glGetActiveUniformBlockivDelegate(uint program, uint uniformBlockIndex, uint pname, int[] @params);
		private delegate void glGetActiveUniformBlockNameDelegate(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName);
		private delegate void glUniformBlockBindingDelegate(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
		private delegate void glBindBufferRangeDelegate(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
		private delegate void glBindBufferBaseDelegate(uint target, uint index, uint buffer);
		private delegate void glGetIntegeri_vDelegate(uint target, uint index, int[] data);
		#endregion
		
		#region Commands
		
		public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawArraysInstancedDelegate>()(mode, first, count, instancecount);
		}
		
		public static void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawElementsInstancedDelegate>()(mode, count, type, indices, instancecount);
		}
		
		public static void glTexBuffer(uint target, uint internalformat, uint buffer)
		{
			XWGL.GetDelegateFor<glTexBufferDelegate>()(target, internalformat, buffer);
		}
		
		public static void glPrimitiveRestartIndex(uint index)
		{
			XWGL.GetDelegateFor<glPrimitiveRestartIndexDelegate>()(index);
		}
		
		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			XWGL.GetDelegateFor<glCopyBufferSubDataDelegate>()(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		
		public static void glGetUniformIndices(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices)
		{
			XWGL.GetDelegateFor<glGetUniformIndicesDelegate>()(program, uniformCount, uniformNames, uniformIndices);
		}
		
		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetActiveUniformsivDelegate>()(program, uniformCount, uniformIndices, pname, @params);
		}
		
		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName)
		{
			XWGL.GetDelegateFor<glGetActiveUniformNameDelegate>()(program, uniformIndex, bufSize, length, uniformName);
		}
		
		public static uint glGetUniformBlockIndex(uint program, char[] uniformBlockName)
		{
			return (uint)XWGL.GetDelegateFor<glGetUniformBlockIndexDelegate>()(program, uniformBlockName);
		}
		
		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetActiveUniformBlockivDelegate>()(program, uniformBlockIndex, pname, @params);
		}
		
		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName)
		{
			XWGL.GetDelegateFor<glGetActiveUniformBlockNameDelegate>()(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}
		
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			XWGL.GetDelegateFor<glUniformBlockBindingDelegate>()(program, uniformBlockIndex, uniformBlockBinding);
		}
		
		public static void glBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size)
		{
			XWGL.GetDelegateFor<glBindBufferRangeDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			XWGL.GetDelegateFor<glBindBufferBaseDelegate>()(target, index, buffer);
		}
		
		public static void glGetIntegeri_v(uint target, uint index, int[] data)
		{
			XWGL.GetDelegateFor<glGetIntegeri_vDelegate>()(target, index, data);
		}
		
		#endregion
	}
}
