using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL21
	{	
		#region Constants
		
		public const uint GL_PIXEL_PACK_BUFFER = 0x88EB;
		public const uint GL_PIXEL_UNPACK_BUFFER = 0x88EC;
		public const uint GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const uint GL_FLOAT_MAT2x3 = 0x8B65;
		public const uint GL_FLOAT_MAT2x4 = 0x8B66;
		public const uint GL_FLOAT_MAT3x2 = 0x8B67;
		public const uint GL_FLOAT_MAT3x4 = 0x8B68;
		public const uint GL_FLOAT_MAT4x2 = 0x8B69;
		public const uint GL_FLOAT_MAT4x3 = 0x8B6A;
		public const uint GL_SRGB = 0x8C40;
		public const uint GL_SRGB8 = 0x8C41;
		public const uint GL_SRGB_ALPHA = 0x8C42;
		public const uint GL_SRGB8_ALPHA8 = 0x8C43;
		public const uint GL_COMPRESSED_SRGB = 0x8C48;
		public const uint GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const uint GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
		public const uint GL_SLUMINANCE_ALPHA = 0x8C44;
		public const uint GL_SLUMINANCE8_ALPHA8 = 0x8C45;
		public const uint GL_SLUMINANCE = 0x8C46;
		public const uint GL_SLUMINANCE8 = 0x8C47;
		public const uint GL_COMPRESSED_SLUMINANCE = 0x8C4A;
		public const uint GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
		
		#endregion
		
		#region Delegates
		
		private delegate void glUniformMatrix2x3fvDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x2fvDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix2x4fvDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x2fvDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x4fvDelegate(int location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x3fvDelegate(int location, int count, bool transpose, float[] value);
		#endregion
		
		#region Commands
		
		public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x3fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x3fvDelegate>()(location, count, transpose, value);
		}
		
		#endregion
	}
}
