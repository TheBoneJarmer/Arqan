using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL13
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
		
		public const uint GL_TEXTURE0 = 0x84C0;
		public const uint GL_TEXTURE1 = 0x84C1;
		public const uint GL_TEXTURE2 = 0x84C2;
		public const uint GL_TEXTURE3 = 0x84C3;
		public const uint GL_TEXTURE4 = 0x84C4;
		public const uint GL_TEXTURE5 = 0x84C5;
		public const uint GL_TEXTURE6 = 0x84C6;
		public const uint GL_TEXTURE7 = 0x84C7;
		public const uint GL_TEXTURE8 = 0x84C8;
		public const uint GL_TEXTURE9 = 0x84C9;
		public const uint GL_TEXTURE10 = 0x84CA;
		public const uint GL_TEXTURE11 = 0x84CB;
		public const uint GL_TEXTURE12 = 0x84CC;
		public const uint GL_TEXTURE13 = 0x84CD;
		public const uint GL_TEXTURE14 = 0x84CE;
		public const uint GL_TEXTURE15 = 0x84CF;
		public const uint GL_TEXTURE16 = 0x84D0;
		public const uint GL_TEXTURE17 = 0x84D1;
		public const uint GL_TEXTURE18 = 0x84D2;
		public const uint GL_TEXTURE19 = 0x84D3;
		public const uint GL_TEXTURE20 = 0x84D4;
		public const uint GL_TEXTURE21 = 0x84D5;
		public const uint GL_TEXTURE22 = 0x84D6;
		public const uint GL_TEXTURE23 = 0x84D7;
		public const uint GL_TEXTURE24 = 0x84D8;
		public const uint GL_TEXTURE25 = 0x84D9;
		public const uint GL_TEXTURE26 = 0x84DA;
		public const uint GL_TEXTURE27 = 0x84DB;
		public const uint GL_TEXTURE28 = 0x84DC;
		public const uint GL_TEXTURE29 = 0x84DD;
		public const uint GL_TEXTURE30 = 0x84DE;
		public const uint GL_TEXTURE31 = 0x84DF;
		public const uint GL_ACTIVE_TEXTURE = 0x84E0;
		public const uint GL_MULTISAMPLE = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint GL_SAMPLE_COVERAGE = 0x80A0;
		public const uint GL_SAMPLE_BUFFERS = 0x80A8;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint GL_COMPRESSED_RGB = 0x84ED;
		public const uint GL_COMPRESSED_RGBA = 0x84EE;
		public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint GL_CLAMP_TO_BORDER = 0x812D;
		public const uint GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
		public const uint GL_MAX_TEXTURE_UNITS = 0x84E2;
		public const uint GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
		public const uint GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
		public const uint GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
		public const uint GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
		public const uint GL_MULTISAMPLE_BIT = 0x20000000;
		public const uint GL_NORMAL_MAP = 0x8511;
		public const uint GL_REFLECTION_MAP = 0x8512;
		public const uint GL_COMPRESSED_ALPHA = 0x84E9;
		public const uint GL_COMPRESSED_LUMINANCE = 0x84EA;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
		public const uint GL_COMPRESSED_INTENSITY = 0x84EC;
		public const uint GL_COMBINE = 0x8570;
		public const uint GL_COMBINE_RGB = 0x8571;
		public const uint GL_COMBINE_ALPHA = 0x8572;
		public const uint GL_SOURCE0_RGB = 0x8580;
		public const uint GL_SOURCE1_RGB = 0x8581;
		public const uint GL_SOURCE2_RGB = 0x8582;
		public const uint GL_SOURCE0_ALPHA = 0x8588;
		public const uint GL_SOURCE1_ALPHA = 0x8589;
		public const uint GL_SOURCE2_ALPHA = 0x858A;
		public const uint GL_OPERAND0_RGB = 0x8590;
		public const uint GL_OPERAND1_RGB = 0x8591;
		public const uint GL_OPERAND2_RGB = 0x8592;
		public const uint GL_OPERAND0_ALPHA = 0x8598;
		public const uint GL_OPERAND1_ALPHA = 0x8599;
		public const uint GL_OPERAND2_ALPHA = 0x859A;
		public const uint GL_RGB_SCALE = 0x8573;
		public const uint GL_ADD_SIGNED = 0x8574;
		public const uint GL_INTERPOLATE = 0x8575;
		public const uint GL_SUBTRACT = 0x84E7;
		public const uint GL_CONSTANT = 0x8576;
		public const uint GL_PRIMARY_COLOR = 0x8577;
		public const uint GL_PREVIOUS = 0x8578;
		public const uint GL_DOT3_RGB = 0x86AE;
		public const uint GL_DOT3_RGBA = 0x86AF;
		
		#endregion
		
		#region Delegates
		
		private delegate void glActiveTextureDelegate(uint texture);
		private delegate void glSampleCoverageDelegate(float value, bool invert);
		private delegate void glCompressedTexImage3DDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		private delegate void glCompressedTexImage2DDelegate(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		private delegate void glCompressedTexImage1DDelegate(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		private delegate void glCompressedTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		private delegate void glCompressedTexSubImage2DDelegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		private delegate void glCompressedTexSubImage1DDelegate(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		private delegate void glGetCompressedTexImageDelegate(uint target, int level, IntPtr img);
		private delegate void glClientActiveTextureDelegate(uint texture);
		private delegate void glMultiTexCoord1dDelegate(uint target, double s);
		private delegate void glMultiTexCoord1dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord1fDelegate(uint target, float s);
		private delegate void glMultiTexCoord1fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord1iDelegate(uint target, int s);
		private delegate void glMultiTexCoord1ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord1sDelegate(uint target, short s);
		private delegate void glMultiTexCoord1svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord2dDelegate(uint target, double s, double t);
		private delegate void glMultiTexCoord2dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord2fDelegate(uint target, float s, float t);
		private delegate void glMultiTexCoord2fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord2iDelegate(uint target, int s, int t);
		private delegate void glMultiTexCoord2ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord2sDelegate(uint target, short s, short t);
		private delegate void glMultiTexCoord2svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord3dDelegate(uint target, double s, double t, double r);
		private delegate void glMultiTexCoord3dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord3fDelegate(uint target, float s, float t, float r);
		private delegate void glMultiTexCoord3fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord3iDelegate(uint target, int s, int t, int r);
		private delegate void glMultiTexCoord3ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord3sDelegate(uint target, short s, short t, short r);
		private delegate void glMultiTexCoord3svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord4dDelegate(uint target, double s, double t, double r, double q);
		private delegate void glMultiTexCoord4dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord4fDelegate(uint target, float s, float t, float r, float q);
		private delegate void glMultiTexCoord4fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord4iDelegate(uint target, int s, int t, int r, int q);
		private delegate void glMultiTexCoord4ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord4sDelegate(uint target, short s, short t, short r, short q);
		private delegate void glMultiTexCoord4svDelegate(uint target, short[] v);
		private delegate void glLoadTransposeMatrixfDelegate(float[] m);
		private delegate void glLoadTransposeMatrixdDelegate(double[] m);
		private delegate void glMultTransposeMatrixfDelegate(float[] m);
		private delegate void glMultTransposeMatrixdDelegate(double[] m);
		#endregion
		
		#region Commands
		
		public static void glActiveTexture(uint texture)
		{
			GetDelegateFor<glActiveTextureDelegate>()(texture);
		}
		
		public static void glSampleCoverage(float value, bool invert)
		{
			GetDelegateFor<glSampleCoverageDelegate>()(value, invert);
		}
		
		public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexImage3DDelegate>()(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		
		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexImage2DDelegate>()(target, level, internalformat, width, height, border, imageSize, data);
		}
		
		public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexImage1DDelegate>()(target, level, internalformat, width, border, imageSize, data);
		}
		
		public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexSubImage2DDelegate>()(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			GetDelegateFor<glCompressedTexSubImage1DDelegate>()(target, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glGetCompressedTexImage(uint target, int level, IntPtr img)
		{
			GetDelegateFor<glGetCompressedTexImageDelegate>()(target, level, img);
		}
		
		public static void glClientActiveTexture(uint texture)
		{
			GetDelegateFor<glClientActiveTextureDelegate>()(texture);
		}
		
		public static void glMultiTexCoord1d(uint target, double s)
		{
			GetDelegateFor<glMultiTexCoord1dDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1dv(uint target, double[] v)
		{
			GetDelegateFor<glMultiTexCoord1dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1f(uint target, float s)
		{
			GetDelegateFor<glMultiTexCoord1fDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1fv(uint target, float[] v)
		{
			GetDelegateFor<glMultiTexCoord1fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1i(uint target, int s)
		{
			GetDelegateFor<glMultiTexCoord1iDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1iv(uint target, int[] v)
		{
			GetDelegateFor<glMultiTexCoord1ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1s(uint target, short s)
		{
			GetDelegateFor<glMultiTexCoord1sDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1sv(uint target, short[] v)
		{
			GetDelegateFor<glMultiTexCoord1svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2d(uint target, double s, double t)
		{
			GetDelegateFor<glMultiTexCoord2dDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2dv(uint target, double[] v)
		{
			GetDelegateFor<glMultiTexCoord2dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2f(uint target, float s, float t)
		{
			GetDelegateFor<glMultiTexCoord2fDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2fv(uint target, float[] v)
		{
			GetDelegateFor<glMultiTexCoord2fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2i(uint target, int s, int t)
		{
			GetDelegateFor<glMultiTexCoord2iDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2iv(uint target, int[] v)
		{
			GetDelegateFor<glMultiTexCoord2ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2s(uint target, short s, short t)
		{
			GetDelegateFor<glMultiTexCoord2sDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2sv(uint target, short[] v)
		{
			GetDelegateFor<glMultiTexCoord2svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3d(uint target, double s, double t, double r)
		{
			GetDelegateFor<glMultiTexCoord3dDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3dv(uint target, double[] v)
		{
			GetDelegateFor<glMultiTexCoord3dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3f(uint target, float s, float t, float r)
		{
			GetDelegateFor<glMultiTexCoord3fDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3fv(uint target, float[] v)
		{
			GetDelegateFor<glMultiTexCoord3fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3i(uint target, int s, int t, int r)
		{
			GetDelegateFor<glMultiTexCoord3iDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3iv(uint target, int[] v)
		{
			GetDelegateFor<glMultiTexCoord3ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3s(uint target, short s, short t, short r)
		{
			GetDelegateFor<glMultiTexCoord3sDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3sv(uint target, short[] v)
		{
			GetDelegateFor<glMultiTexCoord3svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4d(uint target, double s, double t, double r, double q)
		{
			GetDelegateFor<glMultiTexCoord4dDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4dv(uint target, double[] v)
		{
			GetDelegateFor<glMultiTexCoord4dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4f(uint target, float s, float t, float r, float q)
		{
			GetDelegateFor<glMultiTexCoord4fDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4fv(uint target, float[] v)
		{
			GetDelegateFor<glMultiTexCoord4fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4i(uint target, int s, int t, int r, int q)
		{
			GetDelegateFor<glMultiTexCoord4iDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4iv(uint target, int[] v)
		{
			GetDelegateFor<glMultiTexCoord4ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4s(uint target, short s, short t, short r, short q)
		{
			GetDelegateFor<glMultiTexCoord4sDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4sv(uint target, short[] v)
		{
			GetDelegateFor<glMultiTexCoord4svDelegate>()(target, v);
		}
		
		public static void glLoadTransposeMatrixf(float[] m)
		{
			GetDelegateFor<glLoadTransposeMatrixfDelegate>()(m);
		}
		
		public static void glLoadTransposeMatrixd(double[] m)
		{
			GetDelegateFor<glLoadTransposeMatrixdDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixf(float[] m)
		{
			GetDelegateFor<glMultTransposeMatrixfDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixd(double[] m)
		{
			GetDelegateFor<glMultTransposeMatrixdDelegate>()(m);
		}
		
		#endregion
	}
}
