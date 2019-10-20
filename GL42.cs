using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GL42
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
		
		public const uint GL_COPY_READ_BUFFER_BINDING = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint GL_NUM_SAMPLE_COUNTS = 0x9380;
		public const uint GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint GL_UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint GL_COMMAND_BARRIER_BIT = 0x00000040;
		public const uint GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint GL_MAX_IMAGE_UNITS = 0x8F38;
		public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint GL_IMAGE_BINDING_NAME = 0x8F3A;
		public const uint GL_IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint GL_IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint GL_IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint GL_IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint GL_IMAGE_1D = 0x904C;
		public const uint GL_IMAGE_2D = 0x904D;
		public const uint GL_IMAGE_3D = 0x904E;
		public const uint GL_IMAGE_2D_RECT = 0x904F;
		public const uint GL_IMAGE_CUBE = 0x9050;
		public const uint GL_IMAGE_BUFFER = 0x9051;
		public const uint GL_IMAGE_1D_ARRAY = 0x9052;
		public const uint GL_IMAGE_2D_ARRAY = 0x9053;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint GL_IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint GL_INT_IMAGE_1D = 0x9057;
		public const uint GL_INT_IMAGE_2D = 0x9058;
		public const uint GL_INT_IMAGE_3D = 0x9059;
		public const uint GL_INT_IMAGE_2D_RECT = 0x905A;
		public const uint GL_INT_IMAGE_CUBE = 0x905B;
		public const uint GL_INT_IMAGE_BUFFER = 0x905C;
		public const uint GL_INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint GL_INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint GL_MAX_IMAGE_SAMPLES = 0x906D;
		public const uint GL_IMAGE_BINDING_FORMAT = 0x906E;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
		public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
		public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
		public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
		public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		
		#endregion
		
		#region Delegates
		
		private delegate void glDrawArraysInstancedBaseInstanceDelegate(uint mode, int first, int count, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseInstanceDelegate(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseVertexBaseInstanceDelegate(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);
		private delegate void glGetInternalformativDelegate(uint target, uint internalformat, uint pname, int bufSize, int[] @params);
		private delegate void glGetActiveAtomicCounterBufferivDelegate(uint program, uint bufferIndex, uint pname, int[] @params);
		private delegate void glBindImageTextureDelegate(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
		private delegate void glMemoryBarrierDelegate(uint barriers);
		private delegate void glTexStorage1DDelegate(uint target, int levels, uint internalformat, int width);
		private delegate void glTexStorage2DDelegate(uint target, int levels, uint internalformat, int width, int height);
		private delegate void glTexStorage3DDelegate(uint target, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glDrawTransformFeedbackInstancedDelegate(uint mode, uint id, int instancecount);
		private delegate void glDrawTransformFeedbackStreamInstancedDelegate(uint mode, uint id, uint stream, int instancecount);
		#endregion
		
		#region Commands
		
		public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			GetDelegateFor<glDrawArraysInstancedBaseInstanceDelegate>()(mode, first, count, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance)
		{
			GetDelegateFor<glDrawElementsInstancedBaseInstanceDelegate>()(mode, count, type, indices, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			GetDelegateFor<glDrawElementsInstancedBaseVertexBaseInstanceDelegate>()(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		
		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params)
		{
			GetDelegateFor<glGetInternalformativDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params)
		{
			GetDelegateFor<glGetActiveAtomicCounterBufferivDelegate>()(program, bufferIndex, pname, @params);
		}
		
		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			GetDelegateFor<glBindImageTextureDelegate>()(unit, texture, level, layered, layer, access, format);
		}
		
		public static void glMemoryBarrier(uint barriers)
		{
			GetDelegateFor<glMemoryBarrierDelegate>()(barriers);
		}
		
		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			GetDelegateFor<glTexStorage1DDelegate>()(target, levels, internalformat, width);
		}
		
		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			GetDelegateFor<glTexStorage2DDelegate>()(target, levels, internalformat, width, height);
		}
		
		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			GetDelegateFor<glTexStorage3DDelegate>()(target, levels, internalformat, width, height, depth);
		}
		
		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			GetDelegateFor<glDrawTransformFeedbackInstancedDelegate>()(mode, id, instancecount);
		}
		
		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			GetDelegateFor<glDrawTransformFeedbackStreamInstancedDelegate>()(mode, id, stream, instancecount);
		}
		
		#endregion
	}
}
