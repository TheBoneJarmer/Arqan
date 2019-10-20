using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TilarGL
{
	public static class GL30
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
		
		public const uint GL_COMPARE_REF_TO_TEXTURE = 0x884E;
		public const uint GL_CLIP_DISTANCE0 = 0x3000;
		public const uint GL_CLIP_DISTANCE1 = 0x3001;
		public const uint GL_CLIP_DISTANCE2 = 0x3002;
		public const uint GL_CLIP_DISTANCE3 = 0x3003;
		public const uint GL_CLIP_DISTANCE4 = 0x3004;
		public const uint GL_CLIP_DISTANCE5 = 0x3005;
		public const uint GL_CLIP_DISTANCE6 = 0x3006;
		public const uint GL_CLIP_DISTANCE7 = 0x3007;
		public const uint GL_MAX_CLIP_DISTANCES = 0x0D32;
		public const uint GL_MAJOR_VERSION = 0x821B;
		public const uint GL_MINOR_VERSION = 0x821C;
		public const uint GL_NUM_EXTENSIONS = 0x821D;
		public const uint GL_CONTEXT_FLAGS = 0x821E;
		public const uint GL_COMPRESSED_RED = 0x8225;
		public const uint GL_COMPRESSED_RG = 0x8226;
		public const uint GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint GL_RGBA32F = 0x8814;
		public const uint GL_RGB32F = 0x8815;
		public const uint GL_RGBA16F = 0x881A;
		public const uint GL_RGB16F = 0x881B;
		public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const uint GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const uint GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const uint GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const uint GL_CLAMP_READ_COLOR = 0x891C;
		public const uint GL_FIXED_ONLY = 0x891D;
		public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const uint GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const uint GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint GL_R11F_G11F_B10F = 0x8C3A;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint GL_RGB9_E5 = 0x8C3D;
		public const uint GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const uint GL_TEXTURE_SHARED_SIZE = 0x8C3F;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const uint GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const uint GL_PRIMITIVES_GENERATED = 0x8C87;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint GL_RASTERIZER_DISCARD = 0x8C89;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const uint GL_INTERLEAVED_ATTRIBS = 0x8C8C;
		public const uint GL_SEPARATE_ATTRIBS = 0x8C8D;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const uint GL_RGBA32UI = 0x8D70;
		public const uint GL_RGB32UI = 0x8D71;
		public const uint GL_RGBA16UI = 0x8D76;
		public const uint GL_RGB16UI = 0x8D77;
		public const uint GL_RGBA8UI = 0x8D7C;
		public const uint GL_RGB8UI = 0x8D7D;
		public const uint GL_RGBA32I = 0x8D82;
		public const uint GL_RGB32I = 0x8D83;
		public const uint GL_RGBA16I = 0x8D88;
		public const uint GL_RGB16I = 0x8D89;
		public const uint GL_RGBA8I = 0x8D8E;
		public const uint GL_RGB8I = 0x8D8F;
		public const uint GL_RED_INTEGER = 0x8D94;
		public const uint GL_GREEN_INTEGER = 0x8D95;
		public const uint GL_BLUE_INTEGER = 0x8D96;
		public const uint GL_RGB_INTEGER = 0x8D98;
		public const uint GL_RGBA_INTEGER = 0x8D99;
		public const uint GL_BGR_INTEGER = 0x8D9A;
		public const uint GL_BGRA_INTEGER = 0x8D9B;
		public const uint GL_SAMPLER_1D_ARRAY = 0x8DC0;
		public const uint GL_SAMPLER_2D_ARRAY = 0x8DC1;
		public const uint GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const uint GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const uint GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const uint GL_UNSIGNED_INT_VEC2 = 0x8DC6;
		public const uint GL_UNSIGNED_INT_VEC3 = 0x8DC7;
		public const uint GL_UNSIGNED_INT_VEC4 = 0x8DC8;
		public const uint GL_INT_SAMPLER_1D = 0x8DC9;
		public const uint GL_INT_SAMPLER_2D = 0x8DCA;
		public const uint GL_INT_SAMPLER_3D = 0x8DCB;
		public const uint GL_INT_SAMPLER_CUBE = 0x8DCC;
		public const uint GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const uint GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const uint GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const uint GL_QUERY_WAIT = 0x8E13;
		public const uint GL_QUERY_NO_WAIT = 0x8E14;
		public const uint GL_QUERY_BY_REGION_WAIT = 0x8E15;
		public const uint GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const uint GL_BUFFER_ACCESS_FLAGS = 0x911F;
		public const uint GL_BUFFER_MAP_LENGTH = 0x9120;
		public const uint GL_BUFFER_MAP_OFFSET = 0x9121;
		public const uint GL_DEPTH_COMPONENT32F = 0x8CAC;
		public const uint GL_DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint GL_DEPTH_STENCIL = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const uint GL_DEPTH24_STENCIL8 = 0x88F0;
		public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint GL_TEXTURE_RED_TYPE = 0x8C10;
		public const uint GL_TEXTURE_GREEN_TYPE = 0x8C11;
		public const uint GL_TEXTURE_BLUE_TYPE = 0x8C12;
		public const uint GL_TEXTURE_ALPHA_TYPE = 0x8C13;
		public const uint GL_TEXTURE_DEPTH_TYPE = 0x8C16;
		public const uint GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const uint GL_READ_FRAMEBUFFER = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const uint GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const uint GL_COLOR_ATTACHMENT16 = 0x8CF0;
		public const uint GL_COLOR_ATTACHMENT17 = 0x8CF1;
		public const uint GL_COLOR_ATTACHMENT18 = 0x8CF2;
		public const uint GL_COLOR_ATTACHMENT19 = 0x8CF3;
		public const uint GL_COLOR_ATTACHMENT20 = 0x8CF4;
		public const uint GL_COLOR_ATTACHMENT21 = 0x8CF5;
		public const uint GL_COLOR_ATTACHMENT22 = 0x8CF6;
		public const uint GL_COLOR_ATTACHMENT23 = 0x8CF7;
		public const uint GL_COLOR_ATTACHMENT24 = 0x8CF8;
		public const uint GL_COLOR_ATTACHMENT25 = 0x8CF9;
		public const uint GL_COLOR_ATTACHMENT26 = 0x8CFA;
		public const uint GL_COLOR_ATTACHMENT27 = 0x8CFB;
		public const uint GL_COLOR_ATTACHMENT28 = 0x8CFC;
		public const uint GL_COLOR_ATTACHMENT29 = 0x8CFD;
		public const uint GL_COLOR_ATTACHMENT30 = 0x8CFE;
		public const uint GL_COLOR_ATTACHMENT31 = 0x8CFF;
		public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
		public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
		public const uint GL_FRAMEBUFFER = 0x8D40;
		public const uint GL_RENDERBUFFER = 0x8D41;
		public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint GL_STENCIL_INDEX1 = 0x8D46;
		public const uint GL_STENCIL_INDEX4 = 0x8D47;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_STENCIL_INDEX16 = 0x8D49;
		public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint GL_MAX_SAMPLES = 0x8D57;
		public const uint GL_INDEX = 0x8222;
		public const uint GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
		public const uint GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
		public const uint GL_FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint GL_HALF_FLOAT = 0x140B;
		public const uint GL_MAP_READ_BIT = 0x0001;
		public const uint GL_MAP_WRITE_BIT = 0x0002;
		public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint GL_RG = 0x8227;
		public const uint GL_RG_INTEGER = 0x8228;
		public const uint GL_R8 = 0x8229;
		public const uint GL_R16 = 0x822A;
		public const uint GL_RG8 = 0x822B;
		public const uint GL_RG16 = 0x822C;
		public const uint GL_R16F = 0x822D;
		public const uint GL_R32F = 0x822E;
		public const uint GL_RG16F = 0x822F;
		public const uint GL_RG32F = 0x8230;
		public const uint GL_R8I = 0x8231;
		public const uint GL_R8UI = 0x8232;
		public const uint GL_R16I = 0x8233;
		public const uint GL_R16UI = 0x8234;
		public const uint GL_R32I = 0x8235;
		public const uint GL_R32UI = 0x8236;
		public const uint GL_RG8I = 0x8237;
		public const uint GL_RG8UI = 0x8238;
		public const uint GL_RG16I = 0x8239;
		public const uint GL_RG16UI = 0x823A;
		public const uint GL_RG32I = 0x823B;
		public const uint GL_RG32UI = 0x823C;
		public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint GL_CLAMP_VERTEX_COLOR = 0x891A;
		public const uint GL_CLAMP_FRAGMENT_COLOR = 0x891B;
		public const uint GL_ALPHA_INTEGER = 0x8D97;
		
		#endregion
		
		#region Delegates
		
		private delegate void glColorMaskiDelegate(uint index, bool r, bool g, bool b, bool a);
		private delegate void glGetBooleani_vDelegate(uint target, uint index, bool[] data);
		private delegate void glGetIntegeri_vDelegate(uint target, uint index, int[] data);
		private delegate void glEnableiDelegate(uint target, uint index);
		private delegate void glDisableiDelegate(uint target, uint index);
		private delegate bool glIsEnablediDelegate(uint target, uint index);
		private delegate void glBeginTransformFeedbackDelegate(uint primitiveMode);
		private delegate void glEndTransformFeedbackDelegate();
		private delegate void glBindBufferRangeDelegate(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
		private delegate void glBindBufferBaseDelegate(uint target, uint index, uint buffer);
		private delegate void glTransformFeedbackVaryingsDelegate(uint program, int count, char[] varyings, uint bufferMode);
		private delegate void glGetTransformFeedbackVaryingDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name);
		private delegate void glClampColorDelegate(uint target, uint clamp);
		private delegate void glBeginConditionalRenderDelegate(uint id, uint mode);
		private delegate void glEndConditionalRenderDelegate();
		private delegate void glVertexAttribIPointerDelegate(uint index, int size, uint type, int stride, IntPtr pointer);
		private delegate void glGetVertexAttribIivDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribIuivDelegate(uint index, uint pname, uint[] @params);
		private delegate void glVertexAttribI1iDelegate(uint index, int x);
		private delegate void glVertexAttribI2iDelegate(uint index, int x, int y);
		private delegate void glVertexAttribI3iDelegate(uint index, int x, int y, int z);
		private delegate void glVertexAttribI4iDelegate(uint index, int x, int y, int z, int w);
		private delegate void glVertexAttribI1uiDelegate(uint index, uint x);
		private delegate void glVertexAttribI2uiDelegate(uint index, uint x, uint y);
		private delegate void glVertexAttribI3uiDelegate(uint index, uint x, uint y, uint z);
		private delegate void glVertexAttribI4uiDelegate(uint index, uint x, uint y, uint z, uint w);
		private delegate void glVertexAttribI1ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI2ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI3ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI4ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI1uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI2uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI3uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4bvDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4svDelegate(uint index, short[] v);
		private delegate void glVertexAttribI4ubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4usvDelegate(uint index, ushort[] v);
		private delegate void glGetUniformuivDelegate(uint program, int location, uint[] @params);
		private delegate void glBindFragDataLocationDelegate(uint program, uint color, char[] name);
		private delegate int glGetFragDataLocationDelegate(uint program, char[] name);
		private delegate void glUniform1uiDelegate(int location, uint v0);
		private delegate void glUniform2uiDelegate(int location, uint v0, uint v1);
		private delegate void glUniform3uiDelegate(int location, uint v0, uint v1, uint v2);
		private delegate void glUniform4uiDelegate(int location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glUniform1uivDelegate(int location, int count, uint[] value);
		private delegate void glUniform2uivDelegate(int location, int count, uint[] value);
		private delegate void glUniform3uivDelegate(int location, int count, uint[] value);
		private delegate void glUniform4uivDelegate(int location, int count, uint[] value);
		private delegate void glTexParameterIivDelegate(uint target, uint pname, int[] @params);
		private delegate void glTexParameterIuivDelegate(uint target, uint pname, uint[] @params);
		private delegate void glGetTexParameterIivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetTexParameterIuivDelegate(uint target, uint pname, uint[] @params);
		private delegate void glClearBufferivDelegate(uint buffer, int drawbuffer, int[] value);
		private delegate void glClearBufferuivDelegate(uint buffer, int drawbuffer, uint[] value);
		private delegate void glClearBufferfvDelegate(uint buffer, int drawbuffer, float[] value);
		private delegate void glClearBufferfiDelegate(uint buffer, int drawbuffer, float depth, int stencil);
		private delegate bool glIsRenderbufferDelegate(uint renderbuffer);
		private delegate void glBindRenderbufferDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glGenRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glRenderbufferStorageDelegate(uint target, uint internalformat, int width, int height);
		private delegate void glGetRenderbufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsFramebufferDelegate(uint framebuffer);
		private delegate void glBindFramebufferDelegate(uint target, uint framebuffer);
		private delegate void glDeleteFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glGenFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate uint glCheckFramebufferStatusDelegate(uint target);
		private delegate void glFramebufferTexture1DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture2DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture3DDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glFramebufferRenderbufferDelegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glGetFramebufferAttachmentParameterivDelegate(uint target, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateMipmapDelegate(uint target);
		private delegate void glBlitFramebufferDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glRenderbufferStorageMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glFramebufferTextureLayerDelegate(uint target, uint attachment, uint texture, int level, int layer);
		private delegate void glMapBufferRangeDelegate(uint target, IntPtr offset, IntPtr length, uint access);
		private delegate void glFlushMappedBufferRangeDelegate(uint target, IntPtr offset, IntPtr length);
		private delegate void glBindVertexArrayDelegate(uint array);
		private delegate void glDeleteVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glGenVertexArraysDelegate(int n, uint[] arrays);
		private delegate bool glIsVertexArrayDelegate(uint array);
		#endregion
		
		#region Commands
		
		public static void glColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			GetDelegateFor<glColorMaskiDelegate>()(index, r, g, b, a);
		}
		
		public static void glGetBooleani_v(uint target, uint index, bool[] data)
		{
			GetDelegateFor<glGetBooleani_vDelegate>()(target, index, data);
		}
		
		public static void glGetIntegeri_v(uint target, uint index, int[] data)
		{
			GetDelegateFor<glGetIntegeri_vDelegate>()(target, index, data);
		}
		
		public static void glEnablei(uint target, uint index)
		{
			GetDelegateFor<glEnableiDelegate>()(target, index);
		}
		
		public static void glDisablei(uint target, uint index)
		{
			GetDelegateFor<glDisableiDelegate>()(target, index);
		}
		
		public static bool glIsEnabledi(uint target, uint index)
		{
			return (bool)GetDelegateFor<glIsEnablediDelegate>()(target, index);
		}
		
		public static void glBeginTransformFeedback(uint primitiveMode)
		{
			GetDelegateFor<glBeginTransformFeedbackDelegate>()(primitiveMode);
		}
		
		public static void glEndTransformFeedback()
		{
			GetDelegateFor<glEndTransformFeedbackDelegate>()();
		}
		
		public static void glBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size)
		{
			GetDelegateFor<glBindBufferRangeDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			GetDelegateFor<glBindBufferBaseDelegate>()(target, index, buffer);
		}
		
		public static void glTransformFeedbackVaryings(uint program, int count, char[] varyings, uint bufferMode)
		{
			GetDelegateFor<glTransformFeedbackVaryingsDelegate>()(program, count, varyings, bufferMode);
		}
		
		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name)
		{
			GetDelegateFor<glGetTransformFeedbackVaryingDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glClampColor(uint target, uint clamp)
		{
			GetDelegateFor<glClampColorDelegate>()(target, clamp);
		}
		
		public static void glBeginConditionalRender(uint id, uint mode)
		{
			GetDelegateFor<glBeginConditionalRenderDelegate>()(id, mode);
		}
		
		public static void glEndConditionalRender()
		{
			GetDelegateFor<glEndConditionalRenderDelegate>()();
		}
		
		public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			GetDelegateFor<glVertexAttribIPointerDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribIiv(uint index, uint pname, int[] @params)
		{
			GetDelegateFor<glGetVertexAttribIivDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribIuiv(uint index, uint pname, uint[] @params)
		{
			GetDelegateFor<glGetVertexAttribIuivDelegate>()(index, pname, @params);
		}
		
		public static void glVertexAttribI1i(uint index, int x)
		{
			GetDelegateFor<glVertexAttribI1iDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2i(uint index, int x, int y)
		{
			GetDelegateFor<glVertexAttribI2iDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3i(uint index, int x, int y, int z)
		{
			GetDelegateFor<glVertexAttribI3iDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			GetDelegateFor<glVertexAttribI4iDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1ui(uint index, uint x)
		{
			GetDelegateFor<glVertexAttribI1uiDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2ui(uint index, uint x, uint y)
		{
			GetDelegateFor<glVertexAttribI2uiDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			GetDelegateFor<glVertexAttribI3uiDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			GetDelegateFor<glVertexAttribI4uiDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1iv(uint index, int[] v)
		{
			GetDelegateFor<glVertexAttribI1ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2iv(uint index, int[] v)
		{
			GetDelegateFor<glVertexAttribI2ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3iv(uint index, int[] v)
		{
			GetDelegateFor<glVertexAttribI3ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4iv(uint index, int[] v)
		{
			GetDelegateFor<glVertexAttribI4ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI1uiv(uint index, uint[] v)
		{
			GetDelegateFor<glVertexAttribI1uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2uiv(uint index, uint[] v)
		{
			GetDelegateFor<glVertexAttribI2uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3uiv(uint index, uint[] v)
		{
			GetDelegateFor<glVertexAttribI3uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4uiv(uint index, uint[] v)
		{
			GetDelegateFor<glVertexAttribI4uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4bv(uint index, byte[] v)
		{
			GetDelegateFor<glVertexAttribI4bvDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4sv(uint index, short[] v)
		{
			GetDelegateFor<glVertexAttribI4svDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4ubv(uint index, byte[] v)
		{
			GetDelegateFor<glVertexAttribI4ubvDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4usv(uint index, ushort[] v)
		{
			GetDelegateFor<glVertexAttribI4usvDelegate>()(index, v);
		}
		
		public static void glGetUniformuiv(uint program, int location, uint[] @params)
		{
			GetDelegateFor<glGetUniformuivDelegate>()(program, location, @params);
		}
		
		public static void glBindFragDataLocation(uint program, uint color, char[] name)
		{
			GetDelegateFor<glBindFragDataLocationDelegate>()(program, color, name);
		}
		
		public static int glGetFragDataLocation(uint program, char[] name)
		{
			return (int)GetDelegateFor<glGetFragDataLocationDelegate>()(program, name);
		}
		
		public static void glUniform1ui(int location, uint v0)
		{
			GetDelegateFor<glUniform1uiDelegate>()(location, v0);
		}
		
		public static void glUniform2ui(int location, uint v0, uint v1)
		{
			GetDelegateFor<glUniform2uiDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3ui(int location, uint v0, uint v1, uint v2)
		{
			GetDelegateFor<glUniform3uiDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			GetDelegateFor<glUniform4uiDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1uiv(int location, int count, uint[] value)
		{
			GetDelegateFor<glUniform1uivDelegate>()(location, count, value);
		}
		
		public static void glUniform2uiv(int location, int count, uint[] value)
		{
			GetDelegateFor<glUniform2uivDelegate>()(location, count, value);
		}
		
		public static void glUniform3uiv(int location, int count, uint[] value)
		{
			GetDelegateFor<glUniform3uivDelegate>()(location, count, value);
		}
		
		public static void glUniform4uiv(int location, int count, uint[] value)
		{
			GetDelegateFor<glUniform4uivDelegate>()(location, count, value);
		}
		
		public static void glTexParameterIiv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glTexParameterIivDelegate>()(target, pname, @params);
		}
		
		public static void glTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			GetDelegateFor<glTexParameterIuivDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIiv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glGetTexParameterIivDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			GetDelegateFor<glGetTexParameterIuivDelegate>()(target, pname, @params);
		}
		
		public static void glClearBufferiv(uint buffer, int drawbuffer, int[] value)
		{
			GetDelegateFor<glClearBufferivDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferuiv(uint buffer, int drawbuffer, uint[] value)
		{
			GetDelegateFor<glClearBufferuivDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferfv(uint buffer, int drawbuffer, float[] value)
		{
			GetDelegateFor<glClearBufferfvDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			GetDelegateFor<glClearBufferfiDelegate>()(buffer, drawbuffer, depth, stencil);
		}
		
		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return (bool)GetDelegateFor<glIsRenderbufferDelegate>()(renderbuffer);
		}
		
		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			GetDelegateFor<glBindRenderbufferDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			GetDelegateFor<glDeleteRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glGenRenderbuffers(int n, uint[] renderbuffers)
		{
			GetDelegateFor<glGenRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			GetDelegateFor<glRenderbufferStorageDelegate>()(target, internalformat, width, height);
		}
		
		public static void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glGetRenderbufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static bool glIsFramebuffer(uint framebuffer)
		{
			return (bool)GetDelegateFor<glIsFramebufferDelegate>()(framebuffer);
		}
		
		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			GetDelegateFor<glBindFramebufferDelegate>()(target, framebuffer);
		}
		
		public static void glDeleteFramebuffers(int n, uint[] framebuffers)
		{
			GetDelegateFor<glDeleteFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glGenFramebuffers(int n, uint[] framebuffers)
		{
			GetDelegateFor<glGenFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static uint glCheckFramebufferStatus(uint target)
		{
			return (uint)GetDelegateFor<glCheckFramebufferStatusDelegate>()(target);
		}
		
		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			GetDelegateFor<glFramebufferTexture1DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			GetDelegateFor<glFramebufferTexture2DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			GetDelegateFor<glFramebufferTexture3DDelegate>()(target, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			GetDelegateFor<glFramebufferRenderbufferDelegate>()(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params)
		{
			GetDelegateFor<glGetFramebufferAttachmentParameterivDelegate>()(target, attachment, pname, @params);
		}
		
		public static void glGenerateMipmap(uint target)
		{
			GetDelegateFor<glGenerateMipmapDelegate>()(target);
		}
		
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			GetDelegateFor<glBlitFramebufferDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			GetDelegateFor<glRenderbufferStorageMultisampleDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			GetDelegateFor<glFramebufferTextureLayerDelegate>()(target, attachment, texture, level, layer);
		}
		
		public static void glMapBufferRange(uint target, IntPtr offset, IntPtr length, uint access)
		{
			GetDelegateFor<glMapBufferRangeDelegate>()(target, offset, length, access);
		}
		
		public static void glFlushMappedBufferRange(uint target, IntPtr offset, IntPtr length)
		{
			GetDelegateFor<glFlushMappedBufferRangeDelegate>()(target, offset, length);
		}
		
		public static void glBindVertexArray(uint array)
		{
			GetDelegateFor<glBindVertexArrayDelegate>()(array);
		}
		
		public static void glDeleteVertexArrays(int n, uint[] arrays)
		{
			GetDelegateFor<glDeleteVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glGenVertexArrays(int n, uint[] arrays)
		{
			GetDelegateFor<glGenVertexArraysDelegate>()(n, arrays);
		}
		
		public static bool glIsVertexArray(uint array)
		{
			return (bool)GetDelegateFor<glIsVertexArrayDelegate>()(array);
		}
		
		#endregion
	}
}
