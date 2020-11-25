using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	[Obsolete("Please use the static class GL")]
	public static class GL14
	{	
		#region Constants
		
		public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_SRC_RGB = 0x80C9;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24 = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32 = 0x81A7;
		public const uint GL_MIRRORED_REPEAT = 0x8370;
		public const uint GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const uint GL_TEXTURE_LOD_BIAS = 0x8501;
		public const uint GL_INCR_WRAP = 0x8507;
		public const uint GL_DECR_WRAP = 0x8508;
		public const uint GL_TEXTURE_DEPTH_SIZE = 0x884A;
		public const uint GL_TEXTURE_COMPARE_MODE = 0x884C;
		public const uint GL_TEXTURE_COMPARE_FUNC = 0x884D;
		public const uint GL_POINT_SIZE_MIN = 0x8126;
		public const uint GL_POINT_SIZE_MAX = 0x8127;
		public const uint GL_POINT_DISTANCE_ATTENUATION = 0x8129;
		public const uint GL_GENERATE_MIPMAP = 0x8191;
		public const uint GL_GENERATE_MIPMAP_HINT = 0x8192;
		public const uint GL_FOG_COORDINATE_SOURCE = 0x8450;
		public const uint GL_FOG_COORDINATE = 0x8451;
		public const uint GL_FRAGMENT_DEPTH = 0x8452;
		public const uint GL_CURRENT_FOG_COORDINATE = 0x8453;
		public const uint GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
		public const uint GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
		public const uint GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
		public const uint GL_FOG_COORDINATE_ARRAY = 0x8457;
		public const uint GL_COLOR_SUM = 0x8458;
		public const uint GL_CURRENT_SECONDARY_COLOR = 0x8459;
		public const uint GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
		public const uint GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
		public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
		public const uint GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
		public const uint GL_SECONDARY_COLOR_ARRAY = 0x845E;
		public const uint GL_TEXTURE_FILTER_CONTROL = 0x8500;
		public const uint GL_DEPTH_TEXTURE_MODE = 0x884B;
		public const uint GL_COMPARE_R_TO_TEXTURE = 0x884E;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_MIN = 0x8007;
		public const uint GL_MAX = 0x8008;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		
		#endregion
		
		#region Delegates
		
		private delegate void glBlendFuncSeparateDelegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		private delegate void glMultiDrawArraysDelegate(uint mode, int[] first, int[] count, int drawcount);
		private delegate void glMultiDrawElementsDelegate(uint mode, int[] count, uint type, IntPtr indices, int drawcount);
		private delegate void glPointParameterfDelegate(uint pname, float param);
		private delegate void glPointParameterfvDelegate(uint pname, float[] @params);
		private delegate void glPointParameteriDelegate(uint pname, int param);
		private delegate void glPointParameterivDelegate(uint pname, int[] @params);
		private delegate void glFogCoordfDelegate(float coord);
		private delegate void glFogCoordfvDelegate(float[] coord);
		private delegate void glFogCoorddDelegate(double coord);
		private delegate void glFogCoorddvDelegate(double[] coord);
		private delegate void glFogCoordPointerDelegate(uint type, int stride, IntPtr pointer);
		private delegate void glSecondaryColor3bDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3bvDelegate(byte[] v);
		private delegate void glSecondaryColor3dDelegate(double red, double green, double blue);
		private delegate void glSecondaryColor3dvDelegate(double[] v);
		private delegate void glSecondaryColor3fDelegate(float red, float green, float blue);
		private delegate void glSecondaryColor3fvDelegate(float[] v);
		private delegate void glSecondaryColor3iDelegate(int red, int green, int blue);
		private delegate void glSecondaryColor3ivDelegate(int[] v);
		private delegate void glSecondaryColor3sDelegate(short red, short green, short blue);
		private delegate void glSecondaryColor3svDelegate(short[] v);
		private delegate void glSecondaryColor3ubDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3ubvDelegate(byte[] v);
		private delegate void glSecondaryColor3uiDelegate(uint red, uint green, uint blue);
		private delegate void glSecondaryColor3uivDelegate(uint[] v);
		private delegate void glSecondaryColor3usDelegate(ushort red, ushort green, ushort blue);
		private delegate void glSecondaryColor3usvDelegate(ushort[] v);
		private delegate void glSecondaryColorPointerDelegate(int size, uint type, int stride, IntPtr pointer);
		private delegate void glWindowPos2dDelegate(double x, double y);
		private delegate void glWindowPos2dvDelegate(double[] v);
		private delegate void glWindowPos2fDelegate(float x, float y);
		private delegate void glWindowPos2fvDelegate(float[] v);
		private delegate void glWindowPos2iDelegate(int x, int y);
		private delegate void glWindowPos2ivDelegate(int[] v);
		private delegate void glWindowPos2sDelegate(short x, short y);
		private delegate void glWindowPos2svDelegate(short[] v);
		private delegate void glWindowPos3dDelegate(double x, double y, double z);
		private delegate void glWindowPos3dvDelegate(double[] v);
		private delegate void glWindowPos3fDelegate(float x, float y, float z);
		private delegate void glWindowPos3fvDelegate(float[] v);
		private delegate void glWindowPos3iDelegate(int x, int y, int z);
		private delegate void glWindowPos3ivDelegate(int[] v);
		private delegate void glWindowPos3sDelegate(short x, short y, short z);
		private delegate void glWindowPos3svDelegate(short[] v);
		private delegate void glBlendColorDelegate(float red, float green, float blue, float alpha);
		private delegate void glBlendEquationDelegate(uint mode);
		#endregion
		
		#region Commands
		
		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			XWGL.GetDelegateFor<glBlendFuncSeparateDelegate>()(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		
		public static void glMultiDrawArrays(uint mode, int[] first, int[] count, int drawcount)
		{
			XWGL.GetDelegateFor<glMultiDrawArraysDelegate>()(mode, first, count, drawcount);
		}
		
		public static void glMultiDrawElements(uint mode, int[] count, uint type, IntPtr indices, int drawcount)
		{
			XWGL.GetDelegateFor<glMultiDrawElementsDelegate>()(mode, count, type, indices, drawcount);
		}
		
		public static void glPointParameterf(uint pname, float param)
		{
			XWGL.GetDelegateFor<glPointParameterfDelegate>()(pname, param);
		}
		
		public static void glPointParameterfv(uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glPointParameterfvDelegate>()(pname, @params);
		}
		
		public static void glPointParameteri(uint pname, int param)
		{
			XWGL.GetDelegateFor<glPointParameteriDelegate>()(pname, param);
		}
		
		public static void glPointParameteriv(uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glPointParameterivDelegate>()(pname, @params);
		}
		
		public static void glFogCoordf(float coord)
		{
			XWGL.GetDelegateFor<glFogCoordfDelegate>()(coord);
		}
		
		public static void glFogCoordfv(float[] coord)
		{
			XWGL.GetDelegateFor<glFogCoordfvDelegate>()(coord);
		}
		
		public static void glFogCoordd(double coord)
		{
			XWGL.GetDelegateFor<glFogCoorddDelegate>()(coord);
		}
		
		public static void glFogCoorddv(double[] coord)
		{
			XWGL.GetDelegateFor<glFogCoorddvDelegate>()(coord);
		}
		
		public static void glFogCoordPointer(uint type, int stride, IntPtr pointer)
		{
			XWGL.GetDelegateFor<glFogCoordPointerDelegate>()(type, stride, pointer);
		}
		
		public static void glSecondaryColor3b(byte red, byte green, byte blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3bDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3bv(byte[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3bvDelegate>()(v);
		}
		
		public static void glSecondaryColor3d(double red, double green, double blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3dDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3dv(double[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3dvDelegate>()(v);
		}
		
		public static void glSecondaryColor3f(float red, float green, float blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3fDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3fv(float[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3fvDelegate>()(v);
		}
		
		public static void glSecondaryColor3i(int red, int green, int blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3iDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3iv(int[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ivDelegate>()(v);
		}
		
		public static void glSecondaryColor3s(short red, short green, short blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3sDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3sv(short[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3svDelegate>()(v);
		}
		
		public static void glSecondaryColor3ub(byte red, byte green, byte blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ubDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3ubv(byte[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ubvDelegate>()(v);
		}
		
		public static void glSecondaryColor3ui(uint red, uint green, uint blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3uiDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3uiv(uint[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3uivDelegate>()(v);
		}
		
		public static void glSecondaryColor3us(ushort red, ushort green, ushort blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3usDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3usv(ushort[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3usvDelegate>()(v);
		}
		
		public static void glSecondaryColorPointer(int size, uint type, int stride, IntPtr pointer)
		{
			XWGL.GetDelegateFor<glSecondaryColorPointerDelegate>()(size, type, stride, pointer);
		}
		
		public static void glWindowPos2d(double x, double y)
		{
			XWGL.GetDelegateFor<glWindowPos2dDelegate>()(x, y);
		}
		
		public static void glWindowPos2dv(double[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2dvDelegate>()(v);
		}
		
		public static void glWindowPos2f(float x, float y)
		{
			XWGL.GetDelegateFor<glWindowPos2fDelegate>()(x, y);
		}
		
		public static void glWindowPos2fv(float[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2fvDelegate>()(v);
		}
		
		public static void glWindowPos2i(int x, int y)
		{
			XWGL.GetDelegateFor<glWindowPos2iDelegate>()(x, y);
		}
		
		public static void glWindowPos2iv(int[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2ivDelegate>()(v);
		}
		
		public static void glWindowPos2s(short x, short y)
		{
			XWGL.GetDelegateFor<glWindowPos2sDelegate>()(x, y);
		}
		
		public static void glWindowPos2sv(short[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2svDelegate>()(v);
		}
		
		public static void glWindowPos3d(double x, double y, double z)
		{
			XWGL.GetDelegateFor<glWindowPos3dDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3dv(double[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3dvDelegate>()(v);
		}
		
		public static void glWindowPos3f(float x, float y, float z)
		{
			XWGL.GetDelegateFor<glWindowPos3fDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3fv(float[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3fvDelegate>()(v);
		}
		
		public static void glWindowPos3i(int x, int y, int z)
		{
			XWGL.GetDelegateFor<glWindowPos3iDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3iv(int[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3ivDelegate>()(v);
		}
		
		public static void glWindowPos3s(short x, short y, short z)
		{
			XWGL.GetDelegateFor<glWindowPos3sDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3sv(short[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3svDelegate>()(v);
		}
		
		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			XWGL.GetDelegateFor<glBlendColorDelegate>()(red, green, blue, alpha);
		}
		
		public static void glBlendEquation(uint mode)
		{
			XWGL.GetDelegateFor<glBlendEquationDelegate>()(mode);
		}
		
		#endregion
	}
}
