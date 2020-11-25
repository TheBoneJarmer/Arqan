using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	[Obsolete("Please use the static class GL")]
	public static class GL20
	{	
		#region Constants
		
		public const uint GL_BLEND_EQUATION_RGB = 0x8009;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint GL_STENCIL_BACK_FUNC = 0x8800;
		public const uint GL_STENCIL_BACK_FAIL = 0x8801;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint GL_MAX_DRAW_BUFFERS = 0x8824;
		public const uint GL_DRAW_BUFFER0 = 0x8825;
		public const uint GL_DRAW_BUFFER1 = 0x8826;
		public const uint GL_DRAW_BUFFER2 = 0x8827;
		public const uint GL_DRAW_BUFFER3 = 0x8828;
		public const uint GL_DRAW_BUFFER4 = 0x8829;
		public const uint GL_DRAW_BUFFER5 = 0x882A;
		public const uint GL_DRAW_BUFFER6 = 0x882B;
		public const uint GL_DRAW_BUFFER7 = 0x882C;
		public const uint GL_DRAW_BUFFER8 = 0x882D;
		public const uint GL_DRAW_BUFFER9 = 0x882E;
		public const uint GL_DRAW_BUFFER10 = 0x882F;
		public const uint GL_DRAW_BUFFER11 = 0x8830;
		public const uint GL_DRAW_BUFFER12 = 0x8831;
		public const uint GL_DRAW_BUFFER13 = 0x8832;
		public const uint GL_DRAW_BUFFER14 = 0x8833;
		public const uint GL_DRAW_BUFFER15 = 0x8834;
		public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const uint GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint GL_FRAGMENT_SHADER = 0x8B30;
		public const uint GL_VERTEX_SHADER = 0x8B31;
		public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const uint GL_MAX_VARYING_FLOATS = 0x8B4B;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint GL_SHADER_TYPE = 0x8B4F;
		public const uint GL_FLOAT_VEC2 = 0x8B50;
		public const uint GL_FLOAT_VEC3 = 0x8B51;
		public const uint GL_FLOAT_VEC4 = 0x8B52;
		public const uint GL_INT_VEC2 = 0x8B53;
		public const uint GL_INT_VEC3 = 0x8B54;
		public const uint GL_INT_VEC4 = 0x8B55;
		public const uint GL_BOOL = 0x8B56;
		public const uint GL_BOOL_VEC2 = 0x8B57;
		public const uint GL_BOOL_VEC3 = 0x8B58;
		public const uint GL_BOOL_VEC4 = 0x8B59;
		public const uint GL_FLOAT_MAT2 = 0x8B5A;
		public const uint GL_FLOAT_MAT3 = 0x8B5B;
		public const uint GL_FLOAT_MAT4 = 0x8B5C;
		public const uint GL_SAMPLER_1D = 0x8B5D;
		public const uint GL_SAMPLER_2D = 0x8B5E;
		public const uint GL_SAMPLER_3D = 0x8B5F;
		public const uint GL_SAMPLER_CUBE = 0x8B60;
		public const uint GL_SAMPLER_1D_SHADOW = 0x8B61;
		public const uint GL_SAMPLER_2D_SHADOW = 0x8B62;
		public const uint GL_DELETE_STATUS = 0x8B80;
		public const uint GL_COMPILE_STATUS = 0x8B81;
		public const uint GL_LINK_STATUS = 0x8B82;
		public const uint GL_VALIDATE_STATUS = 0x8B83;
		public const uint GL_INFO_LOG_LENGTH = 0x8B84;
		public const uint GL_ATTACHED_SHADERS = 0x8B85;
		public const uint GL_ACTIVE_UNIFORMS = 0x8B86;
		public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint GL_CURRENT_PROGRAM = 0x8B8D;
		public const uint GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const uint GL_LOWER_LEFT = 0x8CA1;
		public const uint GL_UPPER_LEFT = 0x8CA2;
		public const uint GL_STENCIL_BACK_REF = 0x8CA3;
		public const uint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
		public const uint GL_POINT_SPRITE = 0x8861;
		public const uint GL_COORD_REPLACE = 0x8862;
		public const uint GL_MAX_TEXTURE_COORDS = 0x8871;
		
		#endregion
		
		#region Delegates
		
		private delegate void glBlendEquationSeparateDelegate(uint modeRGB, uint modeAlpha);
		private delegate void glDrawBuffersDelegate(int n, uint[] bufs);
		private delegate void glStencilOpSeparateDelegate(uint face, uint sfail, uint dpfail, uint dppass);
		private delegate void glStencilFuncSeparateDelegate(uint face, uint func, int @ref, uint mask);
		private delegate void glStencilMaskSeparateDelegate(uint face, uint mask);
		private delegate void glAttachShaderDelegate(uint program, uint shader);
		private delegate void glBindAttribLocationDelegate(uint program, uint index, string[] name);
		private delegate void glCompileShaderDelegate(uint shader);
		private delegate uint glCreateProgramDelegate();
		private delegate uint glCreateShaderDelegate(uint type);
		private delegate void glDeleteProgramDelegate(uint program);
		private delegate void glDeleteShaderDelegate(uint shader);
		private delegate void glDetachShaderDelegate(uint program, uint shader);
		private delegate void glDisableVertexAttribArrayDelegate(uint index);
		private delegate void glEnableVertexAttribArrayDelegate(uint index);
		private delegate void glGetActiveAttribDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name);
		private delegate void glGetActiveUniformDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name);
		private delegate void glGetAttachedShadersDelegate(uint program, int maxCount, int[] count, uint[] shaders);
		private delegate uint glGetAttribLocationDelegate(uint program, string name);
		private delegate void glGetProgramivDelegate(uint program, uint pname, int[] @params);
		private delegate void glGetProgramInfoLogDelegate(uint program, int bufSize, ref int length, byte[] infoLog);
		private delegate void glGetShaderivDelegate(uint shader, uint pname, ref int @params);

        private delegate void glGetShaderInfoLogDelegate(uint shader, int bufSize, ref int length, byte[] infoLog);

        private delegate void glGetShaderSourceDelegate(uint shader, int bufSize, int[] length, char[] source);
		private delegate uint glGetUniformLocationDelegate(uint program, string name);
		private delegate void glGetUniformfvDelegate(uint program, uint location, float[] @params);
		private delegate void glGetUniformivDelegate(uint program, uint location, int[] @params);
		private delegate void glGetVertexAttribdvDelegate(uint index, uint pname, double[] @params);
		private delegate void glGetVertexAttribfvDelegate(uint index, uint pname, float[] @params);
		private delegate void glGetVertexAttribivDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribPointervDelegate(uint index, uint pname, IntPtr pointer);
		private delegate bool glIsProgramDelegate(uint program);
		private delegate bool glIsShaderDelegate(uint shader);
		private delegate void glLinkProgramDelegate(uint program);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, ThrowOnUnmappableChar = true)]
        private delegate void glShaderSourceDelegate(uint shader, int count, string[] @string, int[] length);

		private delegate void glUseProgramDelegate(uint program);
		private delegate void glUniform1fDelegate(uint location, float v0);
		private delegate void glUniform2fDelegate(uint location, float v0, float v1);
		private delegate void glUniform3fDelegate(uint location, float v0, float v1, float v2);
		private delegate void glUniform4fDelegate(uint location, float v0, float v1, float v2, float v3);
		private delegate void glUniform1iDelegate(uint location, int v0);
		private delegate void glUniform2iDelegate(uint location, int v0, int v1);
		private delegate void glUniform3iDelegate(uint location, int v0, int v1, int v2);
		private delegate void glUniform4iDelegate(uint location, int v0, int v1, int v2, int v3);
		private delegate void glUniform1fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform2fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform3fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform4fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform1ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform2ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform3ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform4ivDelegate(uint location, int count, int[] value);
		private delegate void glUniformMatrix2fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glValidateProgramDelegate(uint program);
		private delegate void glVertexAttrib1dDelegate(uint index, double x);
		private delegate void glVertexAttrib1dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib1fDelegate(uint index, float x);
		private delegate void glVertexAttrib1fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib1sDelegate(uint index, short x);
		private delegate void glVertexAttrib1svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib2dDelegate(uint index, double x, double y);
		private delegate void glVertexAttrib2dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib2fDelegate(uint index, float x, float y);
		private delegate void glVertexAttrib2fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib2sDelegate(uint index, short x, short y);
		private delegate void glVertexAttrib2svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib3dDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttrib3dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib3fDelegate(uint index, float x, float y, float z);
		private delegate void glVertexAttrib3fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib3sDelegate(uint index, short x, short y, short z);
		private delegate void glVertexAttrib3svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NbvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NivDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4NsvDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NubDelegate(uint index, byte x, byte y, byte z, byte w);
		private delegate void glVertexAttrib4NubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NuivDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4NusvDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib4bvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4dDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttrib4dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib4fDelegate(uint index, float x, float y, float z, float w);
		private delegate void glVertexAttrib4fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib4ivDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4sDelegate(uint index, short x, short y, short z, short w);
		private delegate void glVertexAttrib4svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4ubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4usvDelegate(uint index, ushort[] v);
		private delegate void glVertexAttribPointerDelegate(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

        private delegate void glReadPixelsDelegate(float x, float y, float width, float height, uint format, uint type, IntPtr pixels);
		#endregion
		
		#region Commands
		
		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			XWGL.GetDelegateFor<glBlendEquationSeparateDelegate>()(modeRGB, modeAlpha);
		}
		
		public static void glDrawBuffers(int n, uint[] bufs)
		{
			XWGL.GetDelegateFor<glDrawBuffersDelegate>()(n, bufs);
		}
		
		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			XWGL.GetDelegateFor<glStencilOpSeparateDelegate>()(face, sfail, dpfail, dppass);
		}
		
		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			XWGL.GetDelegateFor<glStencilFuncSeparateDelegate>()(face, func, @ref, mask);
		}
		
		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			XWGL.GetDelegateFor<glStencilMaskSeparateDelegate>()(face, mask);
		}
		
		public static void glAttachShader(uint program, uint shader)
		{
			XWGL.GetDelegateFor<glAttachShaderDelegate>()(program, shader);
		}
		
		public static void glBindAttribLocation(uint program, uint index, string[] name)
		{
			XWGL.GetDelegateFor<glBindAttribLocationDelegate>()(program, index, name);
		}
		
		public static void glCompileShader(uint shader)
		{
			XWGL.GetDelegateFor<glCompileShaderDelegate>()(shader);
		}
		
		public static uint glCreateProgram()
		{
			return (uint)XWGL.GetDelegateFor<glCreateProgramDelegate>()();
		}
		
		public static uint glCreateShader(uint type)
		{
			return (uint)XWGL.GetDelegateFor<glCreateShaderDelegate>()(type);
		}
		
		public static void glDeleteProgram(uint program)
		{
			XWGL.GetDelegateFor<glDeleteProgramDelegate>()(program);
		}
		
		public static void glDeleteShader(uint shader)
		{
			XWGL.GetDelegateFor<glDeleteShaderDelegate>()(shader);
		}
		
		public static void glDetachShader(uint program, uint shader)
		{
			XWGL.GetDelegateFor<glDetachShaderDelegate>()(program, shader);
		}
		
		public static void glDisableVertexAttribArray(uint index)
		{
			XWGL.GetDelegateFor<glDisableVertexAttribArrayDelegate>()(index);
		}
		
		public static void glEnableVertexAttribArray(uint index)
		{
			XWGL.GetDelegateFor<glEnableVertexAttribArrayDelegate>()(index);
		}
		
		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name)
		{
			XWGL.GetDelegateFor<glGetActiveAttribDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glGetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name)
		{
			XWGL.GetDelegateFor<glGetActiveUniformDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glGetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders)
		{
			XWGL.GetDelegateFor<glGetAttachedShadersDelegate>()(program, maxCount, count, shaders);
		}
		
		public static uint glGetAttribLocation(uint program, string name)
		{
			return (uint)XWGL.GetDelegateFor<glGetAttribLocationDelegate>()(program, name);
		}
		
		public static void glGetProgramiv(uint program, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetProgramivDelegate>()(program, pname, @params);
		}
		
		public static void glGetProgramInfoLog(uint program, int bufSize, ref int length, byte[] infoLog)
		{
			XWGL.GetDelegateFor<glGetProgramInfoLogDelegate>()(program, bufSize, ref length, infoLog);
		}
		
		public static void glGetShaderiv(uint shader, uint pname, ref int @params)
		{
			XWGL.GetDelegateFor<glGetShaderivDelegate>()(shader, pname, ref @params);
		}
		
		public static void glGetShaderInfoLog(uint shader, int bufSize, ref int length, byte[] infoLog)
		{
			XWGL.GetDelegateFor<glGetShaderInfoLogDelegate>()(shader, bufSize, ref length, infoLog);
		}
		
		public static void glGetShaderSource(uint shader, int bufSize, int[] length, char[] source)
		{
			XWGL.GetDelegateFor<glGetShaderSourceDelegate>()(shader, bufSize, length, source);
		}
		
		public static uint glGetUniformLocation(uint program, string name)
		{
			return (uint)XWGL.GetDelegateFor<glGetUniformLocationDelegate>()(program, name);
		}
		
		public static void glGetUniformfv(uint program, uint location, float[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformfvDelegate>()(program, location, @params);
		}
		
		public static void glGetUniformiv(uint program, uint location, int[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformivDelegate>()(program, location, @params);
		}
		
		public static void glGetVertexAttribdv(uint index, uint pname, double[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribdvDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribfv(uint index, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribfvDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribiv(uint index, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribivDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribPointerv(uint index, uint pname, IntPtr pointer)
		{
			XWGL.GetDelegateFor<glGetVertexAttribPointervDelegate>()(index, pname, pointer);
		}
		
		public static bool glIsProgram(uint program)
		{
			return (bool)XWGL.GetDelegateFor<glIsProgramDelegate>()(program);
		}
		
		public static bool glIsShader(uint shader)
		{
			return (bool)XWGL.GetDelegateFor<glIsShaderDelegate>()(shader);
		}
		
		public static void glLinkProgram(uint program)
		{
			XWGL.GetDelegateFor<glLinkProgramDelegate>()(program);
		}
		
		public static void glShaderSource(uint shader, int count, string[] @string, int[] length)
		{
			XWGL.GetDelegateFor<glShaderSourceDelegate>()(shader, count, @string, length);
		}
		
		public static void glUseProgram(uint program)
		{
			XWGL.GetDelegateFor<glUseProgramDelegate>()(program);
		}
		
		public static void glUniform1f(uint location, float v0)
		{
			XWGL.GetDelegateFor<glUniform1fDelegate>()(location, v0);
		}
		
		public static void glUniform2f(uint location, float v0, float v1)
		{
			XWGL.GetDelegateFor<glUniform2fDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3f(uint location, float v0, float v1, float v2)
		{
			XWGL.GetDelegateFor<glUniform3fDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4f(uint location, float v0, float v1, float v2, float v3)
		{
			XWGL.GetDelegateFor<glUniform4fDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1i(uint location, int v0)
		{
			XWGL.GetDelegateFor<glUniform1iDelegate>()(location, v0);
		}
		
		public static void glUniform2i(uint location, int v0, int v1)
		{
			XWGL.GetDelegateFor<glUniform2iDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3i(uint location, int v0, int v1, int v2)
		{
			XWGL.GetDelegateFor<glUniform3iDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4i(uint location, int v0, int v1, int v2, int v3)
		{
			XWGL.GetDelegateFor<glUniform4iDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform1fvDelegate>()(location, count, value);
		}
		
		public static void glUniform2fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform2fvDelegate>()(location, count, value);
		}
		
		public static void glUniform3fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform3fvDelegate>()(location, count, value);
		}
		
		public static void glUniform4fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform4fvDelegate>()(location, count, value);
		}
		
		public static void glUniform1iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform1ivDelegate>()(location, count, value);
		}
		
		public static void glUniform2iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform2ivDelegate>()(location, count, value);
		}
		
		public static void glUniform3iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform3ivDelegate>()(location, count, value);
		}
		
		public static void glUniform4iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform4ivDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glValidateProgram(uint program)
		{
			XWGL.GetDelegateFor<glValidateProgramDelegate>()(program);
		}
		
		public static void glVertexAttrib1d(uint index, double x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1dDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1f(uint index, float x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1fDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1s(uint index, short x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1sDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2d(uint index, double x, double y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2dDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2fDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2s(uint index, short x, short y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2sDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3d(uint index, double x, double y, double z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3dDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3fDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3s(uint index, short x, short y, short z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3sDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nbv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NbvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Niv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nsv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NsvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NubDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4Nubv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NubvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nuiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NuivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nusv(uint index, ushort[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NusvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4bv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4bvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4dDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4fDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4ivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4sDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4ubv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4ubvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4uivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4usv(uint index, ushort[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4usvDelegate>()(index, v);
		}
		
		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer)
		{
			XWGL.GetDelegateFor<glVertexAttribPointerDelegate>()(index, size, type, normalized, stride, pointer);
		}

        public static void glReadPixels(float x, float y, float width, float height, uint format, uint type, IntPtr pixels)
        {
            XWGL.GetDelegateFor<glReadPixelsDelegate>()(x, y, width, height, format, type, pixels);
        }
		
		#endregion
	}
}
