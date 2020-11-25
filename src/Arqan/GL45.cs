using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL45
	{		
		#region Constants
		
		public const uint GL_CONTEXT_LOST = 0x0507;
		public const uint GL_LOWER_LEFT = 0x8CA1;
		public const uint GL_UPPER_LEFT = 0x8CA2;
		public const uint GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint GL_ZERO_TO_ONE = 0x935F;
		public const uint GL_CLIP_ORIGIN = 0x935C;
		public const uint GL_CLIP_DEPTH_MODE = 0x935D;
		public const uint GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const uint GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint GL_MAX_CULL_DISTANCES = 0x82F9;
		public const uint GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint GL_TEXTURE_TARGET = 0x1006;
		public const uint GL_QUERY_TARGET = 0x82EA;
		public const uint GL_TEXTURE_BINDING_1D = 0x8068;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D = 0x8069;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint GL_BACK = 0x0405;
		public const uint GL_NO_ERROR = 0;
		public const uint GL_GUILTY_CONTEXT_RESET = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint GL_LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint GL_NO_RESET_NOTIFICATION = 0x8261;
		public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint GL_NONE = 0;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
		
		#endregion
		
		#region Delegates
		
		private delegate void glClipControlDelegate(uint origin, uint depth);
		private delegate void glCreateTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glTransformFeedbackBufferBaseDelegate(uint xfb, uint index, uint buffer);
		private delegate void glTransformFeedbackBufferRangeDelegate(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size);
		private delegate void glGetTransformFeedbackivDelegate(uint xfb, uint pname, int[] param);
		private delegate void glGetTransformFeedbacki_vDelegate(uint xfb, uint pname, uint index, int[] param);
		private delegate void glGetTransformFeedbacki64_vDelegate(uint xfb, uint pname, uint index, Int64[] param);
		private delegate void glCreateBuffersDelegate(int n, uint[] buffers);
		private delegate void glNamedBufferStorageDelegate(uint buffer, IntPtr size, IntPtr data, uint flags);
		private delegate void glNamedBufferDataDelegate(uint buffer, IntPtr size, IntPtr data, uint usage);
		private delegate void glNamedBufferSubDataDelegate(uint buffer, IntPtr offset, IntPtr size, IntPtr data);
		private delegate void glCopyNamedBufferSubDataDelegate(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
		private delegate void glClearNamedBufferDataDelegate(uint buffer, uint internalformat, uint format, uint type, IntPtr data);
		private delegate void glClearNamedBufferSubDataDelegate(uint buffer, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, IntPtr data);
		private delegate void glMapNamedBufferDelegate(uint buffer, uint access);
		private delegate void glMapNamedBufferRangeDelegate(uint buffer, IntPtr offset, IntPtr length, uint access);
		private delegate bool glUnmapNamedBufferDelegate(uint buffer);
		private delegate void glFlushMappedNamedBufferRangeDelegate(uint buffer, IntPtr offset, IntPtr length);
		private delegate void glGetNamedBufferParameterivDelegate(uint buffer, uint pname, int[] @params);
		private delegate void glGetNamedBufferParameteri64vDelegate(uint buffer, uint pname, Int64[] @params);
		private delegate void glGetNamedBufferPointervDelegate(uint buffer, uint pname, IntPtr @params);
		private delegate void glGetNamedBufferSubDataDelegate(uint buffer, IntPtr offset, IntPtr size, IntPtr data);
		private delegate void glCreateFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glNamedFramebufferRenderbufferDelegate(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glNamedFramebufferParameteriDelegate(uint framebuffer, uint pname, int param);
		private delegate void glNamedFramebufferTextureDelegate(uint framebuffer, uint attachment, uint texture, int level);
		private delegate void glNamedFramebufferTextureLayerDelegate(uint framebuffer, uint attachment, uint texture, int level, int layer);
		private delegate void glNamedFramebufferDrawBufferDelegate(uint framebuffer, uint buf);
		private delegate void glNamedFramebufferDrawBuffersDelegate(uint framebuffer, int n, uint[] bufs);
		private delegate void glNamedFramebufferReadBufferDelegate(uint framebuffer, uint src);
		private delegate void glInvalidateNamedFramebufferDataDelegate(uint framebuffer, int numAttachments, uint[] attachments);
		private delegate void glInvalidateNamedFramebufferSubDataDelegate(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glClearNamedFramebufferivDelegate(uint framebuffer, uint buffer, int drawbuffer, int[] value);
		private delegate void glClearNamedFramebufferuivDelegate(uint framebuffer, uint buffer, int drawbuffer, uint[] value);
		private delegate void glClearNamedFramebufferfvDelegate(uint framebuffer, uint buffer, int drawbuffer, float[] value);
		private delegate void glClearNamedFramebufferfiDelegate(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
		private delegate void glBlitNamedFramebufferDelegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate uint glCheckNamedFramebufferStatusDelegate(uint framebuffer, uint target);
		private delegate void glGetNamedFramebufferParameterivDelegate(uint framebuffer, uint pname, int[] param);
		private delegate void glGetNamedFramebufferAttachmentParameterivDelegate(uint framebuffer, uint attachment, uint pname, int[] @params);
		private delegate void glCreateRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glNamedRenderbufferStorageDelegate(uint renderbuffer, uint internalformat, int width, int height);
		private delegate void glNamedRenderbufferStorageMultisampleDelegate(uint renderbuffer, int samples, uint internalformat, int width, int height);
		private delegate void glGetNamedRenderbufferParameterivDelegate(uint renderbuffer, uint pname, int[] @params);
		private delegate void glCreateTexturesDelegate(uint target, int n, uint[] textures);
		private delegate void glTextureBufferDelegate(uint texture, uint internalformat, uint buffer);
		private delegate void glTextureBufferRangeDelegate(uint texture, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
		private delegate void glTextureStorage1DDelegate(uint texture, int levels, uint internalformat, int width);
		private delegate void glTextureStorage2DDelegate(uint texture, int levels, uint internalformat, int width, int height);
		private delegate void glTextureStorage3DDelegate(uint texture, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTextureStorage2DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTextureStorage3DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		private delegate void glTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		private delegate void glTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		private delegate void glCompressedTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		private delegate void glCompressedTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		private delegate void glCompressedTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		private delegate void glCopyTextureSubImage1DDelegate(uint texture, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glCopyTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glTextureParameterfDelegate(uint texture, uint pname, float param);
		private delegate void glTextureParameterfvDelegate(uint texture, uint pname, float[] param);
		private delegate void glTextureParameteriDelegate(uint texture, uint pname, int param);
		private delegate void glTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glTextureParameterivDelegate(uint texture, uint pname, int[] param);
		private delegate void glGenerateTextureMipmapDelegate(uint texture);
		private delegate void glBindTextureUnitDelegate(uint unit, uint texture);
		private delegate void glGetTextureImageDelegate(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);
		private delegate void glGetCompressedTextureImageDelegate(uint texture, int level, int bufSize, IntPtr pixels);
		private delegate void glGetTextureLevelParameterfvDelegate(uint texture, int level, uint pname, float[] @params);
		private delegate void glGetTextureLevelParameterivDelegate(uint texture, int level, uint pname, int[] @params);
		private delegate void glGetTextureParameterfvDelegate(uint texture, uint pname, float[] @params);
		private delegate void glGetTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glGetTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glGetTextureParameterivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glCreateVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glDisableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glEnableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glVertexArrayElementBufferDelegate(uint vaobj, uint buffer);
		private delegate void glVertexArrayVertexBufferDelegate(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
		private delegate void glVertexArrayVertexBuffersDelegate(uint vaobj, uint first, int count, uint[] buffers, IntPtr offsets, int[] strides);
		private delegate void glVertexArrayAttribBindingDelegate(uint vaobj, uint attribindex, uint bindingindex);
		private delegate void glVertexArrayAttribFormatDelegate(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexArrayAttribIFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayAttribLFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayBindingDivisorDelegate(uint vaobj, uint bindingindex, uint divisor);
		private delegate void glGetVertexArrayivDelegate(uint vaobj, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexedivDelegate(uint vaobj, uint index, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexed64ivDelegate(uint vaobj, uint index, uint pname, Int64[] param);
		private delegate void glCreateSamplersDelegate(int n, uint[] samplers);
		private delegate void glCreateProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glCreateQueriesDelegate(uint target, int n, uint[] ids);
		private delegate void glGetQueryBufferObjecti64vDelegate(uint id, uint buffer, uint pname, IntPtr offset);
		private delegate void glGetQueryBufferObjectivDelegate(uint id, uint buffer, uint pname, IntPtr offset);
		private delegate void glGetQueryBufferObjectui64vDelegate(uint id, uint buffer, uint pname, IntPtr offset);
		private delegate void glGetQueryBufferObjectuivDelegate(uint id, uint buffer, uint pname, IntPtr offset);
		private delegate void glMemoryBarrierByRegionDelegate(uint barriers);
		private delegate void glGetTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);
		private delegate void glGetCompressedTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);
		private delegate uint glGetGraphicsResetStatusDelegate();
		private delegate void glGetnCompressedTexImageDelegate(uint target, int lod, int bufSize, IntPtr pixels);
		private delegate void glGetnTexImageDelegate(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);
		private delegate void glGetnUniformdvDelegate(uint program, int location, int bufSize, double[] @params);
		private delegate void glGetnUniformfvDelegate(uint program, int location, int bufSize, float[] @params);
		private delegate void glGetnUniformivDelegate(uint program, int location, int bufSize, int[] @params);
		private delegate void glGetnUniformuivDelegate(uint program, int location, int bufSize, uint[] @params);
		private delegate void glReadnPixelsDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);
		private delegate void glGetnMapdvDelegate(uint target, uint query, int bufSize, double[] v);
		private delegate void glGetnMapfvDelegate(uint target, uint query, int bufSize, float[] v);
		private delegate void glGetnMapivDelegate(uint target, uint query, int bufSize, int[] v);
		private delegate void glGetnPixelMapfvDelegate(uint map, int bufSize, float[] values);
		private delegate void glGetnPixelMapuivDelegate(uint map, int bufSize, uint[] values);
		private delegate void glGetnPixelMapusvDelegate(uint map, int bufSize, ushort[] values);
		private delegate void glGetnPolygonStippleDelegate(int bufSize, byte[] pattern);
		private delegate void glGetnColorTableDelegate(uint target, uint format, uint type, int bufSize, IntPtr table);
		private delegate void glGetnConvolutionFilterDelegate(uint target, uint format, uint type, int bufSize, IntPtr image);
		private delegate void glGetnSeparableFilterDelegate(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span);
		private delegate void glGetnHistogramDelegate(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		private delegate void glGetnMinmaxDelegate(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		private delegate void glTextureBarrierDelegate();
		#endregion
		
		#region Commands
		
		public static void glClipControl(uint origin, uint depth)
		{
			XWGL.GetDelegateFor<glClipControlDelegate>()(origin, depth);
		}
		
		public static void glCreateTransformFeedbacks(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glCreateTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			XWGL.GetDelegateFor<glTransformFeedbackBufferBaseDelegate>()(xfb, index, buffer);
		}
		
		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size)
		{
			XWGL.GetDelegateFor<glTransformFeedbackBufferRangeDelegate>()(xfb, index, buffer, offset, size);
		}
		
		public static void glGetTransformFeedbackiv(uint xfb, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbackivDelegate>()(xfb, pname, param);
		}
		
		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbacki_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, Int64[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbacki64_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glCreateBuffers(int n, uint[] buffers)
		{
			XWGL.GetDelegateFor<glCreateBuffersDelegate>()(n, buffers);
		}
		
		public static void glNamedBufferStorage(uint buffer, IntPtr size, IntPtr data, uint flags)
		{
			XWGL.GetDelegateFor<glNamedBufferStorageDelegate>()(buffer, size, data, flags);
		}
		
		public static void glNamedBufferData(uint buffer, IntPtr size, IntPtr data, uint usage)
		{
			XWGL.GetDelegateFor<glNamedBufferDataDelegate>()(buffer, size, data, usage);
		}
		
		public static void glNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			XWGL.GetDelegateFor<glNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			XWGL.GetDelegateFor<glCopyNamedBufferSubDataDelegate>()(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		
		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data)
		{
			XWGL.GetDelegateFor<glClearNamedBufferDataDelegate>()(buffer, internalformat, format, type, data);
		}
		
		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, IntPtr data)
		{
			XWGL.GetDelegateFor<glClearNamedBufferSubDataDelegate>()(buffer, internalformat, offset, size, format, type, data);
		}
		
		public static void glMapNamedBuffer(uint buffer, uint access)
		{
			XWGL.GetDelegateFor<glMapNamedBufferDelegate>()(buffer, access);
		}
		
		public static void glMapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, uint access)
		{
			XWGL.GetDelegateFor<glMapNamedBufferRangeDelegate>()(buffer, offset, length, access);
		}
		
		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return (bool)XWGL.GetDelegateFor<glUnmapNamedBufferDelegate>()(buffer);
		}
		
		public static void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length)
		{
			XWGL.GetDelegateFor<glFlushMappedNamedBufferRangeDelegate>()(buffer, offset, length);
		}
		
		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferParameterivDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, Int64[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferParameteri64vDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferPointervDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			XWGL.GetDelegateFor<glGetNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCreateFramebuffers(int n, uint[] framebuffers)
		{
			XWGL.GetDelegateFor<glCreateFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			XWGL.GetDelegateFor<glNamedFramebufferRenderbufferDelegate>()(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			XWGL.GetDelegateFor<glNamedFramebufferParameteriDelegate>()(framebuffer, pname, param);
		}
		
		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			XWGL.GetDelegateFor<glNamedFramebufferTextureDelegate>()(framebuffer, attachment, texture, level);
		}
		
		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			XWGL.GetDelegateFor<glNamedFramebufferTextureLayerDelegate>()(framebuffer, attachment, texture, level, layer);
		}
		
		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			XWGL.GetDelegateFor<glNamedFramebufferDrawBufferDelegate>()(framebuffer, buf);
		}
		
		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs)
		{
			XWGL.GetDelegateFor<glNamedFramebufferDrawBuffersDelegate>()(framebuffer, n, bufs);
		}
		
		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			XWGL.GetDelegateFor<glNamedFramebufferReadBufferDelegate>()(framebuffer, src);
		}
		
		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments)
		{
			XWGL.GetDelegateFor<glInvalidateNamedFramebufferDataDelegate>()(framebuffer, numAttachments, attachments);
		}
		
		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glInvalidateNamedFramebufferSubDataDelegate>()(framebuffer, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferuivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferfvDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferfiDelegate>()(framebuffer, buffer, drawbuffer, depth, stencil);
		}
		
		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			XWGL.GetDelegateFor<glBlitNamedFramebufferDelegate>()(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			return (uint)XWGL.GetDelegateFor<glCheckNamedFramebufferStatusDelegate>()(framebuffer, target);
		}
		
		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetNamedFramebufferParameterivDelegate>()(framebuffer, pname, param);
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedFramebufferAttachmentParameterivDelegate>()(framebuffer, attachment, pname, @params);
		}
		
		public static void glCreateRenderbuffers(int n, uint[] renderbuffers)
		{
			XWGL.GetDelegateFor<glCreateRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glNamedRenderbufferStorageDelegate>()(renderbuffer, internalformat, width, height);
		}
		
		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glNamedRenderbufferStorageMultisampleDelegate>()(renderbuffer, samples, internalformat, width, height);
		}
		
		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedRenderbufferParameterivDelegate>()(renderbuffer, pname, @params);
		}
		
		public static void glCreateTextures(uint target, int n, uint[] textures)
		{
			XWGL.GetDelegateFor<glCreateTexturesDelegate>()(target, n, textures);
		}
		
		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			XWGL.GetDelegateFor<glTextureBufferDelegate>()(texture, internalformat, buffer);
		}
		
		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, IntPtr offset, IntPtr size)
		{
			XWGL.GetDelegateFor<glTextureBufferRangeDelegate>()(texture, internalformat, buffer, offset, size);
		}
		
		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			XWGL.GetDelegateFor<glTextureStorage1DDelegate>()(texture, levels, internalformat, width);
		}
		
		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glTextureStorage2DDelegate>()(texture, levels, internalformat, width, height);
		}
		
		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			XWGL.GetDelegateFor<glTextureStorage3DDelegate>()(texture, levels, internalformat, width, height, depth);
		}
		
		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTextureStorage2DMultisampleDelegate>()(texture, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTextureStorage3DMultisampleDelegate>()(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, type, pixels);
		}
		
		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage1DDelegate>()(texture, level, xoffset, x, y, width);
		}
		
		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glTextureParameterf(uint texture, uint pname, float param)
		{
			XWGL.GetDelegateFor<glTextureParameterfDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterfv(uint texture, uint pname, float[] param)
		{
			XWGL.GetDelegateFor<glTextureParameterfvDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameteri(uint texture, uint pname, int param)
		{
			XWGL.GetDelegateFor<glTextureParameteriDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameteriv(uint texture, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glTextureParameterivDelegate>()(texture, pname, param);
		}
		
		public static void glGenerateTextureMipmap(uint texture)
		{
			XWGL.GetDelegateFor<glGenerateTextureMipmapDelegate>()(texture);
		}
		
		public static void glBindTextureUnit(uint unit, uint texture)
		{
			XWGL.GetDelegateFor<glBindTextureUnitDelegate>()(unit, texture);
		}
		
		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetTextureImageDelegate>()(texture, level, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetCompressedTextureImageDelegate>()(texture, level, bufSize, pixels);
		}
		
		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureLevelParameterfvDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureLevelParameterivDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureParameterfv(uint texture, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterfvDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameteriv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterivDelegate>()(texture, pname, @params);
		}
		
		public static void glCreateVertexArrays(int n, uint[] arrays)
		{
			XWGL.GetDelegateFor<glCreateVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			XWGL.GetDelegateFor<glDisableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			XWGL.GetDelegateFor<glEnableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			XWGL.GetDelegateFor<glVertexArrayElementBufferDelegate>()(vaobj, buffer);
		}
		
		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			XWGL.GetDelegateFor<glVertexArrayVertexBufferDelegate>()(vaobj, bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, IntPtr offsets, int[] strides)
		{
			XWGL.GetDelegateFor<glVertexArrayVertexBuffersDelegate>()(vaobj, first, count, buffers, offsets, strides);
		}
		
		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribBindingDelegate>()(vaobj, attribindex, bindingindex);
		}
		
		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribFormatDelegate>()(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribIFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribLFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			XWGL.GetDelegateFor<glVertexArrayBindingDivisorDelegate>()(vaobj, bindingindex, divisor);
		}
		
		public static void glGetVertexArrayiv(uint vaobj, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayivDelegate>()(vaobj, pname, param);
		}
		
		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayIndexedivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, Int64[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayIndexed64ivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glCreateSamplers(int n, uint[] samplers)
		{
			XWGL.GetDelegateFor<glCreateSamplersDelegate>()(n, samplers);
		}
		
		public static void glCreateProgramPipelines(int n, uint[] pipelines)
		{
			XWGL.GetDelegateFor<glCreateProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glCreateQueries(uint target, int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glCreateQueriesDelegate>()(target, n, ids);
		}
		
		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, IntPtr offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjecti64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, IntPtr offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, IntPtr offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectui64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, IntPtr offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectuivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glMemoryBarrierByRegion(uint barriers)
		{
			XWGL.GetDelegateFor<glMemoryBarrierByRegionDelegate>()(barriers);
		}
		
		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetCompressedTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}
		
		public static uint glGetGraphicsResetStatus()
		{
			return (uint)XWGL.GetDelegateFor<glGetGraphicsResetStatusDelegate>()();
		}
		
		public static void glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetnCompressedTexImageDelegate>()(target, lod, bufSize, pixels);
		}
		
		public static void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			XWGL.GetDelegateFor<glGetnTexImageDelegate>()(target, level, format, type, bufSize, pixels);
		}
		
		public static void glGetnUniformdv(uint program, int location, int bufSize, double[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformdvDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformfv(uint program, int location, int bufSize, float[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformfvDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformiv(uint program, int location, int bufSize, int[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformivDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformuivDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data)
		{
			XWGL.GetDelegateFor<glReadnPixelsDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnMapdv(uint target, uint query, int bufSize, double[] v)
		{
			XWGL.GetDelegateFor<glGetnMapdvDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapfv(uint target, uint query, int bufSize, float[] v)
		{
			XWGL.GetDelegateFor<glGetnMapfvDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapiv(uint target, uint query, int bufSize, int[] v)
		{
			XWGL.GetDelegateFor<glGetnMapivDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnPixelMapfv(uint map, int bufSize, float[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapfvDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapuiv(uint map, int bufSize, uint[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapuivDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapusv(uint map, int bufSize, ushort[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapusvDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPolygonStipple(int bufSize, byte[] pattern)
		{
			XWGL.GetDelegateFor<glGetnPolygonStippleDelegate>()(bufSize, pattern);
		}
		
		public static void glGetnColorTable(uint target, uint format, uint type, int bufSize, IntPtr table)
		{
			XWGL.GetDelegateFor<glGetnColorTableDelegate>()(target, format, type, bufSize, table);
		}
		
		public static void glGetnConvolutionFilter(uint target, uint format, uint type, int bufSize, IntPtr image)
		{
			XWGL.GetDelegateFor<glGetnConvolutionFilterDelegate>()(target, format, type, bufSize, image);
		}
		
		public static void glGetnSeparableFilter(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span)
		{
			XWGL.GetDelegateFor<glGetnSeparableFilterDelegate>()(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}
		
		public static void glGetnHistogram(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values)
		{
			XWGL.GetDelegateFor<glGetnHistogramDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glGetnMinmax(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values)
		{
			XWGL.GetDelegateFor<glGetnMinmaxDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glTextureBarrier()
		{
			XWGL.GetDelegateFor<glTextureBarrierDelegate>()();
		}
		
		#endregion
	}
}
