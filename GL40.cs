using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GL40
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
		
		public const uint GL_SAMPLE_SHADING = 0x8C36;
		public const uint GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const uint GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint GL_MAX_VERTEX_STREAMS = 0x8E71;
		public const uint GL_DOUBLE_VEC2 = 0x8FFC;
		public const uint GL_DOUBLE_VEC3 = 0x8FFD;
		public const uint GL_DOUBLE_VEC4 = 0x8FFE;
		public const uint GL_DOUBLE_MAT2 = 0x8F46;
		public const uint GL_DOUBLE_MAT3 = 0x8F47;
		public const uint GL_DOUBLE_MAT4 = 0x8F48;
		public const uint GL_DOUBLE_MAT2x3 = 0x8F49;
		public const uint GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const uint GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const uint GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const uint GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const uint GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const uint GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint GL_MAX_SUBROUTINES = 0x8DE7;
		public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint GL_PATCHES = 0x000E;
		public const uint GL_PATCH_VERTICES = 0x8E72;
		public const uint GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint GL_TESS_GEN_MODE = 0x8E76;
		public const uint GL_TESS_GEN_SPACING = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const uint GL_ISOLINES = 0x8E7A;
		public const uint GL_QUADS = 0x0007;
		public const uint GL_FRACTIONAL_ODD = 0x8E7B;
		public const uint GL_FRACTIONAL_EVEN = 0x8E7C;
		public const uint GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const uint GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const uint GL_TESS_CONTROL_SHADER = 0x8E88;
		public const uint GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		
		#endregion
		
		#region Delegates
		
		private delegate void glMinSampleShadingDelegate(float value);
		private delegate void glBlendEquationiDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateiDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glBlendFunciDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateiDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glDrawArraysIndirectDelegate(uint mode, IntPtr indirect);
		private delegate void glDrawElementsIndirectDelegate(uint mode, uint type, IntPtr indirect);
		private delegate void glUniform1dDelegate(int location, double x);
		private delegate void glUniform2dDelegate(int location, double x, double y);
		private delegate void glUniform3dDelegate(int location, double x, double y, double z);
		private delegate void glUniform4dDelegate(int location, double x, double y, double z, double w);
		private delegate void glUniform1dvDelegate(int location, int count, double[] value);
		private delegate void glUniform2dvDelegate(int location, int count, double[] value);
		private delegate void glUniform3dvDelegate(int location, int count, double[] value);
		private delegate void glUniform4dvDelegate(int location, int count, double[] value);
		private delegate void glUniformMatrix2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x4dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x2dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x3dvDelegate(int location, int count, bool transpose, double[] value);
		private delegate void glGetUniformdvDelegate(uint program, int location, double[] @params);
		private delegate int glGetSubroutineUniformLocationDelegate(uint program, uint shadertype, char[] name);
		private delegate uint glGetSubroutineIndexDelegate(uint program, uint shadertype, char[] name);
		private delegate void glGetActiveSubroutineUniformivDelegate(uint program, uint shadertype, uint index, uint pname, int[] values);
		private delegate void glGetActiveSubroutineUniformNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glGetActiveSubroutineNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glUniformSubroutinesuivDelegate(uint shadertype, int count, uint[] indices);
		private delegate void glGetUniformSubroutineuivDelegate(uint shadertype, int location, uint[] @params);
		private delegate void glGetProgramStageivDelegate(uint program, uint shadertype, uint pname, int[] values);
		private delegate void glPatchParameteriDelegate(uint pname, int value);
		private delegate void glPatchParameterfvDelegate(uint pname, float[] values);
		private delegate void glBindTransformFeedbackDelegate(uint target, uint id);
		private delegate void glDeleteTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glGenTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate bool glIsTransformFeedbackDelegate(uint id);
		private delegate void glPauseTransformFeedbackDelegate();
		private delegate void glResumeTransformFeedbackDelegate();
		private delegate void glDrawTransformFeedbackDelegate(uint mode, uint id);
		private delegate void glDrawTransformFeedbackStreamDelegate(uint mode, uint id, uint stream);
		private delegate void glBeginQueryIndexedDelegate(uint target, uint index, uint id);
		private delegate void glEndQueryIndexedDelegate(uint target, uint index);
		private delegate void glGetQueryIndexedivDelegate(uint target, uint index, uint pname, int[] @params);
		#endregion
		
		#region Commands
		
		public static void glMinSampleShading(float value)
		{
			GetDelegateFor<glMinSampleShadingDelegate>()(value);
		}
		
		public static void glBlendEquationi(uint buf, uint mode)
		{
			GetDelegateFor<glBlendEquationiDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha)
		{
			GetDelegateFor<glBlendEquationSeparateiDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glBlendFunci(uint buf, uint src, uint dst)
		{
			GetDelegateFor<glBlendFunciDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			GetDelegateFor<glBlendFuncSeparateiDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glDrawArraysIndirect(uint mode, IntPtr indirect)
		{
			GetDelegateFor<glDrawArraysIndirectDelegate>()(mode, indirect);
		}
		
		public static void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect)
		{
			GetDelegateFor<glDrawElementsIndirectDelegate>()(mode, type, indirect);
		}
		
		public static void glUniform1d(int location, double x)
		{
			GetDelegateFor<glUniform1dDelegate>()(location, x);
		}
		
		public static void glUniform2d(int location, double x, double y)
		{
			GetDelegateFor<glUniform2dDelegate>()(location, x, y);
		}
		
		public static void glUniform3d(int location, double x, double y, double z)
		{
			GetDelegateFor<glUniform3dDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4d(int location, double x, double y, double z, double w)
		{
			GetDelegateFor<glUniform4dDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1dv(int location, int count, double[] value)
		{
			GetDelegateFor<glUniform1dvDelegate>()(location, count, value);
		}
		
		public static void glUniform2dv(int location, int count, double[] value)
		{
			GetDelegateFor<glUniform2dvDelegate>()(location, count, value);
		}
		
		public static void glUniform3dv(int location, int count, double[] value)
		{
			GetDelegateFor<glUniform3dvDelegate>()(location, count, value);
		}
		
		public static void glUniform4dv(int location, int count, double[] value)
		{
			GetDelegateFor<glUniform4dvDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix2x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix2x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix3x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix3x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix4x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glUniformMatrix4x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glGetUniformdv(uint program, int location, double[] @params)
		{
			GetDelegateFor<glGetUniformdvDelegate>()(program, location, @params);
		}
		
		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, char[] name)
		{
			return (int)GetDelegateFor<glGetSubroutineUniformLocationDelegate>()(program, shadertype, name);
		}
		
		public static uint glGetSubroutineIndex(uint program, uint shadertype, char[] name)
		{
			return (uint)GetDelegateFor<glGetSubroutineIndexDelegate>()(program, shadertype, name);
		}
		
		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values)
		{
			GetDelegateFor<glGetActiveSubroutineUniformivDelegate>()(program, shadertype, index, pname, values);
		}
		
		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			GetDelegateFor<glGetActiveSubroutineUniformNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			GetDelegateFor<glGetActiveSubroutineNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glUniformSubroutinesuiv(uint shadertype, int count, uint[] indices)
		{
			GetDelegateFor<glUniformSubroutinesuivDelegate>()(shadertype, count, indices);
		}
		
		public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint[] @params)
		{
			GetDelegateFor<glGetUniformSubroutineuivDelegate>()(shadertype, location, @params);
		}
		
		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int[] values)
		{
			GetDelegateFor<glGetProgramStageivDelegate>()(program, shadertype, pname, values);
		}
		
		public static void glPatchParameteri(uint pname, int value)
		{
			GetDelegateFor<glPatchParameteriDelegate>()(pname, value);
		}
		
		public static void glPatchParameterfv(uint pname, float[] values)
		{
			GetDelegateFor<glPatchParameterfvDelegate>()(pname, values);
		}
		
		public static void glBindTransformFeedback(uint target, uint id)
		{
			GetDelegateFor<glBindTransformFeedbackDelegate>()(target, id);
		}
		
		public static void glDeleteTransformFeedbacks(int n, uint[] ids)
		{
			GetDelegateFor<glDeleteTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glGenTransformFeedbacks(int n, uint[] ids)
		{
			GetDelegateFor<glGenTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static bool glIsTransformFeedback(uint id)
		{
			return (bool)GetDelegateFor<glIsTransformFeedbackDelegate>()(id);
		}
		
		public static void glPauseTransformFeedback()
		{
			GetDelegateFor<glPauseTransformFeedbackDelegate>()();
		}
		
		public static void glResumeTransformFeedback()
		{
			GetDelegateFor<glResumeTransformFeedbackDelegate>()();
		}
		
		public static void glDrawTransformFeedback(uint mode, uint id)
		{
			GetDelegateFor<glDrawTransformFeedbackDelegate>()(mode, id);
		}
		
		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			GetDelegateFor<glDrawTransformFeedbackStreamDelegate>()(mode, id, stream);
		}
		
		public static void glBeginQueryIndexed(uint target, uint index, uint id)
		{
			GetDelegateFor<glBeginQueryIndexedDelegate>()(target, index, id);
		}
		
		public static void glEndQueryIndexed(uint target, uint index)
		{
			GetDelegateFor<glEndQueryIndexedDelegate>()(target, index);
		}
		
		public static void glGetQueryIndexediv(uint target, uint index, uint pname, int[] @params)
		{
			GetDelegateFor<glGetQueryIndexedivDelegate>()(target, index, pname, @params);
		}
		
		#endregion
	}
}
