using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GL12
	{
		private static T GetDelegateFor<T>() where T : class
		{
			Type delegateType = typeof(T);
			string name = delegateType.Name.Replace("Delegate","");
			IntPtr proc = <METHOD_GETPROCADDRESS>(name);
			Delegate del = Marshal.GetDelegateForFunctionPointer(proc, delegateType);
			
			return del as T;
		}
		
		#region Constants
		
		public const uint GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_PACK_SKIP_IMAGES = 0x806B;
		public const uint GL_PACK_IMAGE_HEIGHT = 0x806C;
		public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
		public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint GL_TEXTURE_3D = 0x806F;
		public const uint GL_PROXY_TEXTURE_3D = 0x8070;
		public const uint GL_TEXTURE_DEPTH = 0x8071;
		public const uint GL_TEXTURE_WRAP_R = 0x8072;
		public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint GL_BGR = 0x80E0;
		public const uint GL_BGRA = 0x80E1;
		public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint GL_CLAMP_TO_EDGE = 0x812F;
		public const uint GL_TEXTURE_MIN_LOD = 0x813A;
		public const uint GL_TEXTURE_MAX_LOD = 0x813B;
		public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
		public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
		public const uint GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint GL_RESCALE_NORMAL = 0x803A;
		public const uint GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
		public const uint GL_SINGLE_COLOR = 0x81F9;
		public const uint GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
		public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
		
		#endregion
		
		#region Delegates
		
		private delegate void glDrawRangeElementsDelegate(uint mode, uint start, uint end, int count, uint type, IntPtr indices);
		private delegate void glTexImage3DDelegate(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		private delegate void glTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		private delegate void glCopyTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		#endregion
		
		#region Commands
		
		public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices)
		{
			GetDelegateFor<glDrawRangeElementsDelegate>()(mode, start, end, count, type, indices);
		}
		
		public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
		{
			GetDelegateFor<glTexImage3DDelegate>()(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			GetDelegateFor<glTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			GetDelegateFor<glCopyTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		#endregion
	}
}
