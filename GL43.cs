using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL43
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
		
		public const uint GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const uint GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const uint GL_COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint GL_COMPRESSED_R11_EAC = 0x9270;
		public const uint GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint GL_COMPRESSED_RG11_EAC = 0x9272;
		public const uint GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint GL_MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint GL_COMPUTE_SHADER = 0x91B9;
		public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint GL_DEBUG_SOURCE_API = 0x8246;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint GL_DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER = 0x824B;
		public const uint GL_DEBUG_TYPE_ERROR = 0x824C;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint GL_DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint GL_DEBUG_TYPE_OTHER = 0x8251;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW = 0x9148;
		public const uint GL_DEBUG_TYPE_MARKER = 0x8268;
		public const uint GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint GL_DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint GL_BUFFER = 0x82E0;
		public const uint GL_SHADER = 0x82E1;
		public const uint GL_PROGRAM = 0x82E2;
		public const uint GL_VERTEX_ARRAY = 0x8074;
		public const uint GL_QUERY = 0x82E3;
		public const uint GL_PROGRAM_PIPELINE = 0x82E4;
		public const uint GL_SAMPLER = 0x82E6;
		public const uint GL_MAX_LABEL_LENGTH = 0x82E8;
		public const uint GL_DEBUG_OUTPUT = 0x92E0;
		public const uint GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint GL_MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint GL_INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint GL_INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint GL_INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint GL_INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint GL_MAX_WIDTH = 0x827E;
		public const uint GL_MAX_HEIGHT = 0x827F;
		public const uint GL_MAX_DEPTH = 0x8280;
		public const uint GL_MAX_LAYERS = 0x8281;
		public const uint GL_MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint GL_COLOR_COMPONENTS = 0x8283;
		public const uint GL_DEPTH_COMPONENTS = 0x8284;
		public const uint GL_STENCIL_COMPONENTS = 0x8285;
		public const uint GL_COLOR_RENDERABLE = 0x8286;
		public const uint GL_DEPTH_RENDERABLE = 0x8287;
		public const uint GL_STENCIL_RENDERABLE = 0x8288;
		public const uint GL_FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint GL_FRAMEBUFFER_BLEND = 0x828B;
		public const uint GL_READ_PIXELS = 0x828C;
		public const uint GL_READ_PIXELS_FORMAT = 0x828D;
		public const uint GL_READ_PIXELS_TYPE = 0x828E;
		public const uint GL_TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint GL_TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint GL_MIPMAP = 0x8293;
		public const uint GL_MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint GL_AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint GL_COLOR_ENCODING = 0x8296;
		public const uint GL_SRGB_READ = 0x8297;
		public const uint GL_SRGB_WRITE = 0x8298;
		public const uint GL_FILTER = 0x829A;
		public const uint GL_VERTEX_TEXTURE = 0x829B;
		public const uint GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const uint GL_TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint GL_GEOMETRY_TEXTURE = 0x829E;
		public const uint GL_FRAGMENT_TEXTURE = 0x829F;
		public const uint GL_COMPUTE_TEXTURE = 0x82A0;
		public const uint GL_TEXTURE_SHADOW = 0x82A1;
		public const uint GL_TEXTURE_GATHER = 0x82A2;
		public const uint GL_TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint GL_SHADER_IMAGE_LOAD = 0x82A4;
		public const uint GL_SHADER_IMAGE_STORE = 0x82A5;
		public const uint GL_SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint GL_IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint GL_IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint GL_IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint GL_CLEAR_BUFFER = 0x82B4;
		public const uint GL_TEXTURE_VIEW = 0x82B5;
		public const uint GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint GL_FULL_SUPPORT = 0x82B7;
		public const uint GL_CAVEAT_SUPPORT = 0x82B8;
		public const uint GL_IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint GL_IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint GL_IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint GL_IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint GL_IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint GL_IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint GL_IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint GL_IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint GL_IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint GL_IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint GL_VIEW_CLASS_128_BITS = 0x82C4;
		public const uint GL_VIEW_CLASS_96_BITS = 0x82C5;
		public const uint GL_VIEW_CLASS_64_BITS = 0x82C6;
		public const uint GL_VIEW_CLASS_48_BITS = 0x82C7;
		public const uint GL_VIEW_CLASS_32_BITS = 0x82C8;
		public const uint GL_VIEW_CLASS_24_BITS = 0x82C9;
		public const uint GL_VIEW_CLASS_16_BITS = 0x82CA;
		public const uint GL_VIEW_CLASS_8_BITS = 0x82CB;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint GL_UNIFORM = 0x92E1;
		public const uint GL_UNIFORM_BLOCK = 0x92E2;
		public const uint GL_PROGRAM_INPUT = 0x92E3;
		public const uint GL_PROGRAM_OUTPUT = 0x92E4;
		public const uint GL_BUFFER_VARIABLE = 0x92E5;
		public const uint GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint GL_VERTEX_SUBROUTINE = 0x92E8;
		public const uint GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const uint GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint GL_ACTIVE_RESOURCES = 0x92F5;
		public const uint GL_MAX_NAME_LENGTH = 0x92F6;
		public const uint GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint GL_NAME_LENGTH = 0x92F9;
		public const uint GL_TYPE = 0x92FA;
		public const uint GL_ARRAY_SIZE = 0x92FB;
		public const uint GL_OFFSET = 0x92FC;
		public const uint GL_BLOCK_INDEX = 0x92FD;
		public const uint GL_ARRAY_STRIDE = 0x92FE;
		public const uint GL_MATRIX_STRIDE = 0x92FF;
		public const uint GL_IS_ROW_MAJOR = 0x9300;
		public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint GL_BUFFER_BINDING = 0x9302;
		public const uint GL_BUFFER_DATA_SIZE = 0x9303;
		public const uint GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint GL_ACTIVE_VARIABLES = 0x9305;
		public const uint GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint GL_LOCATION = 0x930E;
		public const uint GL_LOCATION_INDEX = 0x930F;
		public const uint GL_IS_PER_PATCH = 0x92E7;
		public const uint GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint GL_VERTEX_BINDING_BUFFER = 0x8F4F;
		public const uint GL_DISPLAY_LIST = 0x82E7;
		public const uint GL_STACK_UNDERFLOW = 0x0504;
		public const uint GL_STACK_OVERFLOW = 0x0503;
		
		#endregion
		
		#region Delegates
		
		private delegate void glClearBufferDataDelegate(uint target, uint internalformat, uint format, uint type, IntPtr data);
		private delegate void glClearBufferSubDataDelegate(uint target, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, IntPtr data);
		private delegate void glDispatchComputeDelegate(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		private delegate void glDispatchComputeIndirectDelegate(IntPtr indirect);
		private delegate void glCopyImageSubDataDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private delegate void glFramebufferParameteriDelegate(uint target, uint pname, int param);
		private delegate void glGetFramebufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetInternalformati64vDelegate(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params);
		private delegate void glInvalidateTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
		private delegate void glInvalidateTexImageDelegate(uint texture, int level);
		private delegate void glInvalidateBufferSubDataDelegate(uint buffer, IntPtr offset, IntPtr length);
		private delegate void glInvalidateBufferDataDelegate(uint buffer);
		private delegate void glInvalidateFramebufferDelegate(uint target, int numAttachments, uint[] attachments);
		private delegate void glInvalidateSubFramebufferDelegate(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glMultiDrawArraysIndirectDelegate(uint mode, IntPtr indirect, int drawcount, int stride);
		private delegate void glMultiDrawElementsIndirectDelegate(uint mode, uint type, IntPtr indirect, int drawcount, int stride);
		private delegate void glGetProgramInterfaceivDelegate(uint program, uint programInterface, uint pname, int[] @params);
		private delegate uint glGetProgramResourceIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glGetProgramResourceNameDelegate(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name);
		private delegate void glGetProgramResourceivDelegate(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params);
		private delegate int glGetProgramResourceLocationDelegate(uint program, uint programInterface, char[] name);
		private delegate int glGetProgramResourceLocationIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glShaderStorageBlockBindingDelegate(uint program, uint storageBlockIndex, uint storageBlockBinding);
		private delegate void glTexBufferRangeDelegate(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
		private delegate void glTexStorage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexStorage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureViewDelegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private delegate void glBindVertexBufferDelegate(uint bindingindex, uint buffer, IntPtr offset, int stride);
		private delegate void glVertexAttribFormatDelegate(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexAttribIFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribLFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribBindingDelegate(uint attribindex, uint bindingindex);
		private delegate void glVertexBindingDivisorDelegate(uint bindingindex, uint divisor);
		private delegate void glDebugMessageControlDelegate(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertDelegate(uint source, uint type, uint id, uint severity, int length, char[] buf);
		private delegate void glDebugMessageCallbackDelegate(IntPtr callback, IntPtr userParam);
		private delegate uint glGetDebugMessageLogDelegate(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog);
		private delegate void glPushDebugGroupDelegate(uint source, uint id, int length, char[] message);
		private delegate void glPopDebugGroupDelegate();
		private delegate void glObjectLabelDelegate(uint identifier, uint name, int length, char[] label);
		private delegate void glGetObjectLabelDelegate(uint identifier, uint name, int bufSize, int[] length, char[] label);
		private delegate void glObjectPtrLabelDelegate(IntPtr ptr, int length, char[] label);
		private delegate void glGetObjectPtrLabelDelegate(IntPtr ptr, int bufSize, int[] length, char[] label);
		private delegate void glGetPointervDelegate(uint pname, IntPtr @params);
		#endregion
		
		#region Commands
		
		public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data)
		{
			GetDelegateFor<glClearBufferDataDelegate>()(target, internalformat, format, type, data);
		}
		
		public static void glClearBufferSubData(uint target, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, IntPtr data)
		{
			GetDelegateFor<glClearBufferSubDataDelegate>()(target, internalformat, offset, size, format, type, data);
		}
		
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			GetDelegateFor<glDispatchComputeDelegate>()(num_groups_x, num_groups_y, num_groups_z);
		}
		
		public static void glDispatchComputeIndirect(IntPtr indirect)
		{
			GetDelegateFor<glDispatchComputeIndirectDelegate>()(indirect);
		}
		
		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			GetDelegateFor<glCopyImageSubDataDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		public static void glFramebufferParameteri(uint target, uint pname, int param)
		{
			GetDelegateFor<glFramebufferParameteriDelegate>()(target, pname, param);
		}
		
		public static void glGetFramebufferParameteriv(uint target, uint pname, int[] @params)
		{
			GetDelegateFor<glGetFramebufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params)
		{
			GetDelegateFor<glGetInternalformati64vDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			GetDelegateFor<glInvalidateTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		
		public static void glInvalidateTexImage(uint texture, int level)
		{
			GetDelegateFor<glInvalidateTexImageDelegate>()(texture, level);
		}
		
		public static void glInvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length)
		{
			GetDelegateFor<glInvalidateBufferSubDataDelegate>()(buffer, offset, length);
		}
		
		public static void glInvalidateBufferData(uint buffer)
		{
			GetDelegateFor<glInvalidateBufferDataDelegate>()(buffer);
		}
		
		public static void glInvalidateFramebuffer(uint target, int numAttachments, uint[] attachments)
		{
			GetDelegateFor<glInvalidateFramebufferDelegate>()(target, numAttachments, attachments);
		}
		
		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			GetDelegateFor<glInvalidateSubFramebufferDelegate>()(target, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride)
		{
			GetDelegateFor<glMultiDrawArraysIndirectDelegate>()(mode, indirect, drawcount, stride);
		}
		
		public static void glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride)
		{
			GetDelegateFor<glMultiDrawElementsIndirectDelegate>()(mode, type, indirect, drawcount, stride);
		}
		
		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params)
		{
			GetDelegateFor<glGetProgramInterfaceivDelegate>()(program, programInterface, pname, @params);
		}
		
		public static uint glGetProgramResourceIndex(uint program, uint programInterface, char[] name)
		{
			return (uint)GetDelegateFor<glGetProgramResourceIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name)
		{
			GetDelegateFor<glGetProgramResourceNameDelegate>()(program, programInterface, index, bufSize, length, name);
		}
		
		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params)
		{
			GetDelegateFor<glGetProgramResourceivDelegate>()(program, programInterface, index, propCount, props, bufSize, length, @params);
		}
		
		public static int glGetProgramResourceLocation(uint program, uint programInterface, char[] name)
		{
			return (int)GetDelegateFor<glGetProgramResourceLocationDelegate>()(program, programInterface, name);
		}
		
		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, char[] name)
		{
			return (int)GetDelegateFor<glGetProgramResourceLocationIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			GetDelegateFor<glShaderStorageBlockBindingDelegate>()(program, storageBlockIndex, storageBlockBinding);
		}
		
		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size)
		{
			GetDelegateFor<glTexBufferRangeDelegate>()(target, internalformat, buffer, offset, size);
		}
		
		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			GetDelegateFor<glTexStorage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			GetDelegateFor<glTexStorage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			GetDelegateFor<glTextureViewDelegate>()(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			GetDelegateFor<glBindVertexBufferDelegate>()(bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			GetDelegateFor<glVertexAttribFormatDelegate>()(attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			GetDelegateFor<glVertexAttribIFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			GetDelegateFor<glVertexAttribLFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			GetDelegateFor<glVertexAttribBindingDelegate>()(attribindex, bindingindex);
		}
		
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			GetDelegateFor<glVertexBindingDivisorDelegate>()(bindingindex, divisor);
		}
		
		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			GetDelegateFor<glDebugMessageControlDelegate>()(source, type, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char[] buf)
		{
			GetDelegateFor<glDebugMessageInsertDelegate>()(source, type, id, severity, length, buf);
		}
		
		public static void glDebugMessageCallback(IntPtr callback, IntPtr userParam)
		{
			GetDelegateFor<glDebugMessageCallbackDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog)
		{
			return (uint)GetDelegateFor<glGetDebugMessageLogDelegate>()(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		public static void glPushDebugGroup(uint source, uint id, int length, char[] message)
		{
			GetDelegateFor<glPushDebugGroupDelegate>()(source, id, length, message);
		}
		
		public static void glPopDebugGroup()
		{
			GetDelegateFor<glPopDebugGroupDelegate>()();
		}
		
		public static void glObjectLabel(uint identifier, uint name, int length, char[] label)
		{
			GetDelegateFor<glObjectLabelDelegate>()(identifier, name, length, label);
		}
		
		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int[] length, char[] label)
		{
			GetDelegateFor<glGetObjectLabelDelegate>()(identifier, name, bufSize, length, label);
		}
		
		public static void glObjectPtrLabel(IntPtr ptr, int length, char[] label)
		{
			GetDelegateFor<glObjectPtrLabelDelegate>()(ptr, length, label);
		}
		
		public static void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, char[] label)
		{
			GetDelegateFor<glGetObjectPtrLabelDelegate>()(ptr, bufSize, length, label);
		}
		
		public static void glGetPointerv(uint pname, IntPtr @params)
		{
			GetDelegateFor<glGetPointervDelegate>()(pname, @params);
		}
		
		#endregion
	}
}
