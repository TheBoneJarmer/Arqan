using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Arqan
{
	public static class GL10
	{
        #region Constants


        #endregion

        #region Commands

        [DllImport(XWGL.LIBGL, SetLastError = true)]
        public static extern unsafe sbyte* glGetString(uint name);

        [DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCullFace(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFrontFace(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glHint(uint target, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLineWidth(float width);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPointSize(float size);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPolygonMode(uint face, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScissor(int x, int y, int width, int height);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameterf(uint target, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameterfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameteri(uint target, uint pname, uint param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameteriv(uint target, uint pname, uint[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexImage1D(uint target, int level, uint internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawBuffer(uint buf);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClear(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearColor(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearStencil(int s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearDepth(double depth);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilMask(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthMask(bool flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDisable(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEnable(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFinish();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFlush();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBlendFunc(uint sfactor, uint dfactor);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLogicOp(uint opcode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilFunc(uint func, int @ref, uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilOp(uint fail, uint zfail, uint zpass);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthFunc(uint func);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelStoref(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelStorei(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glReadBuffer(uint src);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glReadPixels(float x, float y, float width, float height, uint format, uint type, IntPtr pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetBooleanv(uint pname, bool[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetDoublev(uint pname, double[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern uint glGetError();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetFloatv(uint pname, float[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetIntegerv(uint pname, int[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexImage(uint target, int level, uint format, uint type, float pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexParameterfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexParameteriv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glIsEnabled(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthRange(double near, double far);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glViewport(int x, int y, int width, int height);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNewList(uint list, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEndList();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCallList(uint list);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCallLists(int n, uint type, IntPtr lists);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDeleteLists(uint list, int range);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern uint glGenLists(int range);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glListBase(uint @base);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBegin(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3b(byte red, byte green, byte blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3d(double red, double green, double blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3f(float red, float green, float blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3i(int red, int green, int blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3s(short red, short green, short blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ub(byte red, byte green, byte blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ubv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ui(uint red, uint green, uint blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3uiv(uint[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3us(ushort red, ushort green, ushort blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3usv(ushort[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4b(byte red, byte green, byte blue, byte alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4d(double red, double green, double blue, double alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4f(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4i(int red, int green, int blue, int alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4s(short red, short green, short blue, short alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ubv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4uiv(uint[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4usv(ushort[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEdgeFlag(bool flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEdgeFlagv(bool[] flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEnd();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexd(double c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexdv(double[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexf(float c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexfv(float[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexi(int c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexiv(int[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexs(short c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexsv(short[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3b(byte nx, byte ny, byte nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3d(double nx, double ny, double nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3f(float nx, float ny, float nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3i(int nx, int ny, int nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3s(short nx, short ny, short nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2d(double x, double y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2f(float x, float y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2i(int x, int y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2s(short x, short y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3d(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3f(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3i(int x, int y, int z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3s(short x, short y, short z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4d(double x, double y, double z, double w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4f(float x, float y, float z, float w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4i(int x, int y, int z, int w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4s(short x, short y, short z, short w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectd(double x1, double y1, double x2, double y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectdv(double[] v1, double[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectf(float x1, float y1, float x2, float y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectfv(float[] v1, float[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRecti(int x1, int y1, int x2, int y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectiv(int[] v1, int[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRects(short x1, short y1, short x2, short y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectsv(short[] v1, short[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1d(double s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1f(float s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1i(int s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1s(short s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2d(double s, double t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2f(float s, float t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2i(int s, int t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2s(short s, short t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3d(double s, double t, double r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3f(float s, float t, float r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3i(int s, int t, int r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3s(short s, short t, short r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4d(double s, double t, double r, double q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4f(float s, float t, float r, float q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4i(int s, int t, int r, int q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4s(short s, short t, short r, short q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2d(double x, double y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2f(float x, float y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2i(int x, int y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2s(short x, short y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3d(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3f(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3i(int x, int y, int z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3s(short x, short y, short z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4d(double x, double y, double z, double w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4f(float x, float y, float z, float w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4i(int x, int y, int z, int w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4s(short x, short y, short z, short w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClipPlane(uint plane, double[] equation);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColorMaterial(uint face, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogfv(uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogi(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogiv(uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightf(uint light, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightfv(uint light, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLighti(uint light, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightiv(uint light, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModelf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModelfv(uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModeli(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModeliv(uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLineStipple(int factor, ushort pattern);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialf(uint face, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialfv(uint face, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMateriali(uint face, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialiv(uint face, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPolygonStipple(byte[] mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glShadeModel(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvf(uint target, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvi(uint target, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnviv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGend(uint coord, uint pname, double param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGendv(uint coord, uint pname, double[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGenf(uint coord, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGenfv(uint coord, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGeni(uint coord, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGeniv(uint coord, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFeedbackBuffer(int size, uint type, float[] buffer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glSelectBuffer(int size, uint[] buffer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern int glRenderMode(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glInitNames();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadName(uint name);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPassThrough(float token);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopName();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushName(uint name);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearAccum(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearIndex(float c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexMask(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glAccum(uint op, float value);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopAttrib();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushAttrib(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap1d(uint target, double u1, double u2, int stride, int order, double[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap1f(uint target, float u1, float u2, int stride, int order, float[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid1d(int un, double u1, double u2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid1f(int un, float u1, float u2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1d(double u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1dv(double[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1f(float u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1fv(float[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2d(double u, double v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2dv(double[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2f(float u, float v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2fv(float[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalMesh1(uint mode, int i1, int i2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalPoint1(int i);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalPoint2(int i, int j);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glAlphaFunc(uint func, float @ref);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelZoom(float xfactor, float yfactor);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelTransferf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelTransferi(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapfv(uint map, int mapsize, float[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapuiv(uint map, int mapsize, uint[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapusv(uint map, int mapsize, ushort[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyPixels(int x, int y, int width, int height, uint type);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetClipPlane(uint plane, double[] equation);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetLightfv(uint light, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetLightiv(uint light, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapdv(uint target, uint query, double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapfv(uint target, uint query, float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapiv(uint target, uint query, int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMaterialfv(uint face, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMaterialiv(uint face, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapfv(uint map, float[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapuiv(uint map, uint[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapusv(uint map, ushort[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPolygonStipple(byte[] mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexEnvfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexEnviv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGendv(uint coord, uint pname, double[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGenfv(uint coord, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGeniv(uint coord, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glIsList(uint list);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadIdentity();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadMatrixf(float[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadMatrixd(double[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMatrixMode(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMultMatrixf(float[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMultMatrixd(double[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopMatrix();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushMatrix();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRotated(double angle, double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRotatef(float angle, float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScaled(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScalef(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTranslated(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTranslatef(float x, float y, float z);
		#endregion
	}
}
