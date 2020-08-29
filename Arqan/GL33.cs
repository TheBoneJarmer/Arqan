using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL33
	{
		private static T GetDelegateFor<T>() where T : class
		{
			Type delegateType = typeof(T);
			string name = delegateType.Name.Replace("Delegate","");
			IntPtr proc = XWGL.wglGetProcAddress(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		
		#region Constants
		
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const uint GL_SRC1_COLOR = 0x88F9;
		public const uint GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint GL_ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint GL_SAMPLER_BINDING = 0x8919;
		public const uint GL_RGB10_A2UI = 0x906F;
		public const uint GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint GL_TIME_ELAPSED = 0x88BF;
		public const uint GL_TIMESTAMP = 0x8E28;
		public const uint GL_INT_2_10_10_10_REV = 0x8D9F;
		
		#endregion
		
		#region Delegates
		
		private delegate void glBindFragDataLocationIndexedDelegate(uint program, uint colorNumber, uint index, char[] name);
		private delegate int glGetFragDataIndexDelegate(uint program, char[] name);
		private delegate void glGenSamplersDelegate(int count, uint[] samplers);
		private delegate void glDeleteSamplersDelegate(int count, uint[] samplers);
		private delegate bool glIsSamplerDelegate(uint sampler);
		private delegate void glBindSamplerDelegate(uint unit, uint sampler);
		private delegate void glSamplerParameteriDelegate(uint sampler, uint pname, int param);
		private delegate void glSamplerParameterivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterfDelegate(uint sampler, uint pname, float param);
		private delegate void glSamplerParameterfvDelegate(uint sampler, uint pname, float[] param);
		private delegate void glSamplerParameterIivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] param);
		private delegate void glGetSamplerParameterivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterIivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterfvDelegate(uint sampler, uint pname, float[] @params);
		private delegate void glGetSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] @params);
		private delegate void glQueryCounterDelegate(uint id, uint target);
		private delegate void glGetQueryObjecti64vDelegate(uint id, uint pname, Int64[] @params);
		private delegate void glGetQueryObjectui64vDelegate(uint id, uint pname, UInt64[] @params);
		private delegate void glVertexAttribDivisorDelegate(uint index, uint divisor);
		private delegate void glVertexAttribP1uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP1uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP2uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP2uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP3uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP3uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP4uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP4uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexP2uiDelegate(uint type, uint value);
		private delegate void glVertexP2uivDelegate(uint type, uint[] value);
		private delegate void glVertexP3uiDelegate(uint type, uint value);
		private delegate void glVertexP3uivDelegate(uint type, uint[] value);
		private delegate void glVertexP4uiDelegate(uint type, uint value);
		private delegate void glVertexP4uivDelegate(uint type, uint[] value);
		private delegate void glTexCoordP1uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP1uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP2uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP2uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP3uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP3uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP4uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP4uivDelegate(uint type, uint[] coords);
		private delegate void glMultiTexCoordP1uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP1uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP2uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP2uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP3uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP3uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP4uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP4uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glNormalP3uiDelegate(uint type, uint coords);
		private delegate void glNormalP3uivDelegate(uint type, uint[] coords);
		private delegate void glColorP3uiDelegate(uint type, uint color);
		private delegate void glColorP3uivDelegate(uint type, uint[] color);
		private delegate void glColorP4uiDelegate(uint type, uint color);
		private delegate void glColorP4uivDelegate(uint type, uint[] color);
		private delegate void glSecondaryColorP3uiDelegate(uint type, uint color);
		private delegate void glSecondaryColorP3uivDelegate(uint type, uint[] color);
		#endregion
		
		#region Commands
		
		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char[] name)
		{
			GetDelegateFor<glBindFragDataLocationIndexedDelegate>()(program, colorNumber, index, name);
		}
		
		public static int glGetFragDataIndex(uint program, char[] name)
		{
			return (int)GetDelegateFor<glGetFragDataIndexDelegate>()(program, name);
		}
		
		public static void glGenSamplers(int count, uint[] samplers)
		{
			GetDelegateFor<glGenSamplersDelegate>()(count, samplers);
		}
		
		public static void glDeleteSamplers(int count, uint[] samplers)
		{
			GetDelegateFor<glDeleteSamplersDelegate>()(count, samplers);
		}
		
		public static bool glIsSampler(uint sampler)
		{
			return (bool)GetDelegateFor<glIsSamplerDelegate>()(sampler);
		}
		
		public static void glBindSampler(uint unit, uint sampler)
		{
			GetDelegateFor<glBindSamplerDelegate>()(unit, sampler);
		}
		
		public static void glSamplerParameteri(uint sampler, uint pname, int param)
		{
			GetDelegateFor<glSamplerParameteriDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameteriv(uint sampler, uint pname, int[] param)
		{
			GetDelegateFor<glSamplerParameterivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterf(uint sampler, uint pname, float param)
		{
			GetDelegateFor<glSamplerParameterfDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterfv(uint sampler, uint pname, float[] param)
		{
			GetDelegateFor<glSamplerParameterfvDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIiv(uint sampler, uint pname, int[] param)
		{
			GetDelegateFor<glSamplerParameterIivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param)
		{
			GetDelegateFor<glSamplerParameterIuivDelegate>()(sampler, pname, param);
		}
		
		public static void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params)
		{
			GetDelegateFor<glGetSamplerParameterivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params)
		{
			GetDelegateFor<glGetSamplerParameterIivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params)
		{
			GetDelegateFor<glGetSamplerParameterfvDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params)
		{
			GetDelegateFor<glGetSamplerParameterIuivDelegate>()(sampler, pname, @params);
		}
		
		public static void glQueryCounter(uint id, uint target)
		{
			GetDelegateFor<glQueryCounterDelegate>()(id, target);
		}
		
		public static void glGetQueryObjecti64v(uint id, uint pname, Int64[] @params)
		{
			GetDelegateFor<glGetQueryObjecti64vDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectui64v(uint id, uint pname, UInt64[] @params)
		{
			GetDelegateFor<glGetQueryObjectui64vDelegate>()(id, pname, @params);
		}
		
		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			GetDelegateFor<glVertexAttribDivisorDelegate>()(index, divisor);
		}
		
		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			GetDelegateFor<glVertexAttribP1uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value)
		{
			GetDelegateFor<glVertexAttribP1uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			GetDelegateFor<glVertexAttribP2uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value)
		{
			GetDelegateFor<glVertexAttribP2uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			GetDelegateFor<glVertexAttribP3uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value)
		{
			GetDelegateFor<glVertexAttribP3uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			GetDelegateFor<glVertexAttribP4uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value)
		{
			GetDelegateFor<glVertexAttribP4uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexP2ui(uint type, uint value)
		{
			GetDelegateFor<glVertexP2uiDelegate>()(type, value);
		}
		
		public static void glVertexP2uiv(uint type, uint[] value)
		{
			GetDelegateFor<glVertexP2uivDelegate>()(type, value);
		}
		
		public static void glVertexP3ui(uint type, uint value)
		{
			GetDelegateFor<glVertexP3uiDelegate>()(type, value);
		}
		
		public static void glVertexP3uiv(uint type, uint[] value)
		{
			GetDelegateFor<glVertexP3uivDelegate>()(type, value);
		}
		
		public static void glVertexP4ui(uint type, uint value)
		{
			GetDelegateFor<glVertexP4uiDelegate>()(type, value);
		}
		
		public static void glVertexP4uiv(uint type, uint[] value)
		{
			GetDelegateFor<glVertexP4uivDelegate>()(type, value);
		}
		
		public static void glTexCoordP1ui(uint type, uint coords)
		{
			GetDelegateFor<glTexCoordP1uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP1uiv(uint type, uint[] coords)
		{
			GetDelegateFor<glTexCoordP1uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2ui(uint type, uint coords)
		{
			GetDelegateFor<glTexCoordP2uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2uiv(uint type, uint[] coords)
		{
			GetDelegateFor<glTexCoordP2uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3ui(uint type, uint coords)
		{
			GetDelegateFor<glTexCoordP3uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3uiv(uint type, uint[] coords)
		{
			GetDelegateFor<glTexCoordP3uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4ui(uint type, uint coords)
		{
			GetDelegateFor<glTexCoordP4uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4uiv(uint type, uint[] coords)
		{
			GetDelegateFor<glTexCoordP4uivDelegate>()(type, coords);
		}
		
		public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords)
		{
			GetDelegateFor<glMultiTexCoordP1uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP1uiv(uint texture, uint type, uint[] coords)
		{
			GetDelegateFor<glMultiTexCoordP1uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords)
		{
			GetDelegateFor<glMultiTexCoordP2uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2uiv(uint texture, uint type, uint[] coords)
		{
			GetDelegateFor<glMultiTexCoordP2uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords)
		{
			GetDelegateFor<glMultiTexCoordP3uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3uiv(uint texture, uint type, uint[] coords)
		{
			GetDelegateFor<glMultiTexCoordP3uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords)
		{
			GetDelegateFor<glMultiTexCoordP4uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4uiv(uint texture, uint type, uint[] coords)
		{
			GetDelegateFor<glMultiTexCoordP4uivDelegate>()(texture, type, coords);
		}
		
		public static void glNormalP3ui(uint type, uint coords)
		{
			GetDelegateFor<glNormalP3uiDelegate>()(type, coords);
		}
		
		public static void glNormalP3uiv(uint type, uint[] coords)
		{
			GetDelegateFor<glNormalP3uivDelegate>()(type, coords);
		}
		
		public static void glColorP3ui(uint type, uint color)
		{
			GetDelegateFor<glColorP3uiDelegate>()(type, color);
		}
		
		public static void glColorP3uiv(uint type, uint[] color)
		{
			GetDelegateFor<glColorP3uivDelegate>()(type, color);
		}
		
		public static void glColorP4ui(uint type, uint color)
		{
			GetDelegateFor<glColorP4uiDelegate>()(type, color);
		}
		
		public static void glColorP4uiv(uint type, uint[] color)
		{
			GetDelegateFor<glColorP4uivDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3ui(uint type, uint color)
		{
			GetDelegateFor<glSecondaryColorP3uiDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3uiv(uint type, uint[] color)
		{
			GetDelegateFor<glSecondaryColorP3uivDelegate>()(type, color);
		}
		
		#endregion
	}
}
