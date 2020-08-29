using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL41
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
		
		public const uint GL_FIXED = 0x140C;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint GL_LOW_FLOAT = 0x8DF0;
		public const uint GL_MEDIUM_FLOAT = 0x8DF1;
		public const uint GL_HIGH_FLOAT = 0x8DF2;
		public const uint GL_LOW_INT = 0x8DF3;
		public const uint GL_MEDIUM_INT = 0x8DF4;
		public const uint GL_HIGH_INT = 0x8DF5;
		public const uint GL_SHADER_COMPILER = 0x8DFA;
		public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint GL_RGB565 = 0x8D62;
		public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint GL_PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint GL_VERTEX_SHADER_BIT = 0x00000001;
		public const uint GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint GL_PROGRAM_SEPARABLE = 0x8258;
		public const uint GL_ACTIVE_PROGRAM = 0x8259;
		public const uint GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint GL_MAX_VIEWPORTS = 0x825B;
		public const uint GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint GL_UNDEFINED_VERTEX = 0x8260;
		
		#endregion
		
		#region Delegates
		
		private delegate void glReleaseShaderCompilerDelegate();
		private delegate void glShaderBinaryDelegate(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length);
		private delegate void glGetShaderPrecisionFormatDelegate(uint shadertype, uint precisiontype, int[] range, int[] precision);
		private delegate void glDepthRangefDelegate(float n, float f);
		private delegate void glClearDepthfDelegate(float d);
		private delegate void glGetProgramBinaryDelegate(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary);
		private delegate void glProgramBinaryDelegate(uint program, uint binaryFormat, IntPtr binary, int length);
		private delegate void glProgramParameteriDelegate(uint program, uint pname, int value);
		private delegate void glUseProgramStagesDelegate(uint pipeline, uint stages, uint program);
		private delegate void glActiveShaderProgramDelegate(uint pipeline, uint program);
		private delegate uint glCreateShaderProgramvDelegate(uint type, int count, char[] strings);
		private delegate void glBindProgramPipelineDelegate(uint pipeline);
		private delegate void glDeleteProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glGenProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate bool glIsProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineivDelegate(uint pipeline, uint pname, int[] @params);
		private delegate void glProgramUniform1iDelegate(uint program, int location, int v0);
		private delegate void glProgramUniform1ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform1fDelegate(uint program, int location, float v0);
		private delegate void glProgramUniform1fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform1dDelegate(uint program, int location, double v0);
		private delegate void glProgramUniform1dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform1uiDelegate(uint program, int location, uint v0);
		private delegate void glProgramUniform1uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform2iDelegate(uint program, int location, int v0, int v1);
		private delegate void glProgramUniform2ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform2fDelegate(uint program, int location, float v0, float v1);
		private delegate void glProgramUniform2fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform2dDelegate(uint program, int location, double v0, double v1);
		private delegate void glProgramUniform2dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform2uiDelegate(uint program, int location, uint v0, uint v1);
		private delegate void glProgramUniform2uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform3iDelegate(uint program, int location, int v0, int v1, int v2);
		private delegate void glProgramUniform3ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform3fDelegate(uint program, int location, float v0, float v1, float v2);
		private delegate void glProgramUniform3fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform3dDelegate(uint program, int location, double v0, double v1, double v2);
		private delegate void glProgramUniform3dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform3uiDelegate(uint program, int location, uint v0, uint v1, uint v2);
		private delegate void glProgramUniform3uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniform4iDelegate(uint program, int location, int v0, int v1, int v2, int v3);
		private delegate void glProgramUniform4ivDelegate(uint program, int location, int count, int[] value);
		private delegate void glProgramUniform4fDelegate(uint program, int location, float v0, float v1, float v2, float v3);
		private delegate void glProgramUniform4fvDelegate(uint program, int location, int count, float[] value);
		private delegate void glProgramUniform4dDelegate(uint program, int location, double v0, double v1, double v2, double v3);
		private delegate void glProgramUniform4dvDelegate(uint program, int location, int count, double[] value);
		private delegate void glProgramUniform4uiDelegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glProgramUniform4uivDelegate(uint program, int location, int count, uint[] value);
		private delegate void glProgramUniformMatrix2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x2fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x4fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x3fvDelegate(uint program, int location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x2dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x4dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x3dvDelegate(uint program, int location, int count, bool transpose, double[] value);
		private delegate void glValidateProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineInfoLogDelegate(uint pipeline, int bufSize, int[] length, char[] infoLog);
		private delegate void glVertexAttribL1dDelegate(uint index, double x);
		private delegate void glVertexAttribL2dDelegate(uint index, double x, double y);
		private delegate void glVertexAttribL3dDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttribL4dDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttribL1dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL2dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL3dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL4dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribLPointerDelegate(uint index, int size, uint type, int stride, IntPtr pointer);
		private delegate void glGetVertexAttribLdvDelegate(uint index, uint pname, double[] @params);
		private delegate void glViewportArrayvDelegate(uint first, int count, float[] v);
		private delegate void glViewportIndexedfDelegate(uint index, float x, float y, float w, float h);
		private delegate void glViewportIndexedfvDelegate(uint index, float[] v);
		private delegate void glScissorArrayvDelegate(uint first, int count, int[] v);
		private delegate void glScissorIndexedDelegate(uint index, int left, int bottom, int width, int height);
		private delegate void glScissorIndexedvDelegate(uint index, int[] v);
		private delegate void glDepthRangeArrayvDelegate(uint first, int count, double[] v);
		private delegate void glDepthRangeIndexedDelegate(uint index, double n, double f);
		private delegate void glGetFloati_vDelegate(uint target, uint index, float[] data);
		private delegate void glGetDoublei_vDelegate(uint target, uint index, double[] data);
		#endregion
		
		#region Commands
		
		public static void glReleaseShaderCompiler()
		{
			GetDelegateFor<glReleaseShaderCompilerDelegate>()();
		}
		
		public static void glShaderBinary(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length)
		{
			GetDelegateFor<glShaderBinaryDelegate>()(count, shaders, binaryformat, binary, length);
		}
		
		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
		{
			GetDelegateFor<glGetShaderPrecisionFormatDelegate>()(shadertype, precisiontype, range, precision);
		}
		
		public static void glDepthRangef(float n, float f)
		{
			GetDelegateFor<glDepthRangefDelegate>()(n, f);
		}
		
		public static void glClearDepthf(float d)
		{
			GetDelegateFor<glClearDepthfDelegate>()(d);
		}
		
		public static void glGetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary)
		{
			GetDelegateFor<glGetProgramBinaryDelegate>()(program, bufSize, length, binaryFormat, binary);
		}
		
		public static void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length)
		{
			GetDelegateFor<glProgramBinaryDelegate>()(program, binaryFormat, binary, length);
		}
		
		public static void glProgramParameteri(uint program, uint pname, int value)
		{
			GetDelegateFor<glProgramParameteriDelegate>()(program, pname, value);
		}
		
		public static void glUseProgramStages(uint pipeline, uint stages, uint program)
		{
			GetDelegateFor<glUseProgramStagesDelegate>()(pipeline, stages, program);
		}
		
		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			GetDelegateFor<glActiveShaderProgramDelegate>()(pipeline, program);
		}
		
		public static uint glCreateShaderProgramv(uint type, int count, char[] strings)
		{
			return (uint)GetDelegateFor<glCreateShaderProgramvDelegate>()(type, count, strings);
		}
		
		public static void glBindProgramPipeline(uint pipeline)
		{
			GetDelegateFor<glBindProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glDeleteProgramPipelines(int n, uint[] pipelines)
		{
			GetDelegateFor<glDeleteProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glGenProgramPipelines(int n, uint[] pipelines)
		{
			GetDelegateFor<glGenProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static bool glIsProgramPipeline(uint pipeline)
		{
			return (bool)GetDelegateFor<glIsProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params)
		{
			GetDelegateFor<glGetProgramPipelineivDelegate>()(pipeline, pname, @params);
		}
		
		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			GetDelegateFor<glProgramUniform1iDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1iv(uint program, int location, int count, int[] value)
		{
			GetDelegateFor<glProgramUniform1ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			GetDelegateFor<glProgramUniform1fDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1fv(uint program, int location, int count, float[] value)
		{
			GetDelegateFor<glProgramUniform1fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1d(uint program, int location, double v0)
		{
			GetDelegateFor<glProgramUniform1dDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1dv(uint program, int location, int count, double[] value)
		{
			GetDelegateFor<glProgramUniform1dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			GetDelegateFor<glProgramUniform1uiDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1uiv(uint program, int location, int count, uint[] value)
		{
			GetDelegateFor<glProgramUniform1uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			GetDelegateFor<glProgramUniform2iDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2iv(uint program, int location, int count, int[] value)
		{
			GetDelegateFor<glProgramUniform2ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			GetDelegateFor<glProgramUniform2fDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2fv(uint program, int location, int count, float[] value)
		{
			GetDelegateFor<glProgramUniform2fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2d(uint program, int location, double v0, double v1)
		{
			GetDelegateFor<glProgramUniform2dDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2dv(uint program, int location, int count, double[] value)
		{
			GetDelegateFor<glProgramUniform2dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			GetDelegateFor<glProgramUniform2uiDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2uiv(uint program, int location, int count, uint[] value)
		{
			GetDelegateFor<glProgramUniform2uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			GetDelegateFor<glProgramUniform3iDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3iv(uint program, int location, int count, int[] value)
		{
			GetDelegateFor<glProgramUniform3ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			GetDelegateFor<glProgramUniform3fDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3fv(uint program, int location, int count, float[] value)
		{
			GetDelegateFor<glProgramUniform3fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			GetDelegateFor<glProgramUniform3dDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3dv(uint program, int location, int count, double[] value)
		{
			GetDelegateFor<glProgramUniform3dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			GetDelegateFor<glProgramUniform3uiDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3uiv(uint program, int location, int count, uint[] value)
		{
			GetDelegateFor<glProgramUniform3uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			GetDelegateFor<glProgramUniform4iDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4iv(uint program, int location, int count, int[] value)
		{
			GetDelegateFor<glProgramUniform4ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			GetDelegateFor<glProgramUniform4fDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4fv(uint program, int location, int count, float[] value)
		{
			GetDelegateFor<glProgramUniform4fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			GetDelegateFor<glProgramUniform4dDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4dv(uint program, int location, int count, double[] value)
		{
			GetDelegateFor<glProgramUniform4dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			GetDelegateFor<glProgramUniform4uiDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4uiv(uint program, int location, int count, uint[] value)
		{
			GetDelegateFor<glProgramUniform4uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix2x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix3x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			GetDelegateFor<glProgramUniformMatrix4x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glValidateProgramPipeline(uint pipeline)
		{
			GetDelegateFor<glValidateProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, char[] infoLog)
		{
			GetDelegateFor<glGetProgramPipelineInfoLogDelegate>()(pipeline, bufSize, length, infoLog);
		}
		
		public static void glVertexAttribL1d(uint index, double x)
		{
			GetDelegateFor<glVertexAttribL1dDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			GetDelegateFor<glVertexAttribL2dDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			GetDelegateFor<glVertexAttribL3dDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			GetDelegateFor<glVertexAttribL4dDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1dv(uint index, double[] v)
		{
			GetDelegateFor<glVertexAttribL1dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2dv(uint index, double[] v)
		{
			GetDelegateFor<glVertexAttribL2dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3dv(uint index, double[] v)
		{
			GetDelegateFor<glVertexAttribL3dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4dv(uint index, double[] v)
		{
			GetDelegateFor<glVertexAttribL4dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			GetDelegateFor<glVertexAttribLPointerDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribLdv(uint index, uint pname, double[] @params)
		{
			GetDelegateFor<glGetVertexAttribLdvDelegate>()(index, pname, @params);
		}
		
		public static void glViewportArrayv(uint first, int count, float[] v)
		{
			GetDelegateFor<glViewportArrayvDelegate>()(first, count, v);
		}
		
		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			GetDelegateFor<glViewportIndexedfDelegate>()(index, x, y, w, h);
		}
		
		public static void glViewportIndexedfv(uint index, float[] v)
		{
			GetDelegateFor<glViewportIndexedfvDelegate>()(index, v);
		}
		
		public static void glScissorArrayv(uint first, int count, int[] v)
		{
			GetDelegateFor<glScissorArrayvDelegate>()(first, count, v);
		}
		
		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			GetDelegateFor<glScissorIndexedDelegate>()(index, left, bottom, width, height);
		}
		
		public static void glScissorIndexedv(uint index, int[] v)
		{
			GetDelegateFor<glScissorIndexedvDelegate>()(index, v);
		}
		
		public static void glDepthRangeArrayv(uint first, int count, double[] v)
		{
			GetDelegateFor<glDepthRangeArrayvDelegate>()(first, count, v);
		}
		
		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			GetDelegateFor<glDepthRangeIndexedDelegate>()(index, n, f);
		}
		
		public static void glGetFloati_v(uint target, uint index, float[] data)
		{
			GetDelegateFor<glGetFloati_vDelegate>()(target, index, data);
		}
		
		public static void glGetDoublei_v(uint target, uint index, double[] data)
		{
			GetDelegateFor<glGetDoublei_vDelegate>()(target, index, data);
		}
		
		#endregion
	}
}
