﻿using System;
using System.Runtime.InteropServices;


namespace FastMem
{
    static public partial class Windows
    {
        static private partial class Extern
        {
            [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
            static public extern unsafe IntPtr memmove(IntPtr dest, IntPtr src, UIntPtr count);
        }

        static public unsafe void memmove(byte* dst, byte* src, int length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)length);
        static public unsafe void memmove(byte* dst, byte* src, uint length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)length);
        static public unsafe void memmove(char* dst, char* src, int length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)(length << 1));
        static public unsafe void memmove(char* dst, char* src, uint length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)(length << 1));
        static public unsafe void memmove(void* dst, void* src, int length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)length);
        static public unsafe void memmove(void* dst, void* src, uint length) => Extern.memmove((IntPtr)dst, (IntPtr)src, (UIntPtr)length);

        static public unsafe void memmove(byte[] dst, byte[] src, int length, int dstOffset = 0, int srcOffset = 0)
        {
            fixed (void* pd = &dst[dstOffset])
            fixed (void* ps = &src[srcOffset])
                Extern.memmove((IntPtr)pd, (IntPtr)ps, (UIntPtr)length);
        }

        static public unsafe void memmove(byte[] dst, byte[] src, uint length, uint dstOffset = 0, uint srcOffset = 0)
        {
            fixed (void* pd = &dst[dstOffset])
            fixed (void* ps = &src[srcOffset])
                Extern.memmove((IntPtr)pd, (IntPtr)ps, (UIntPtr)length);
        }

        static public unsafe void memmove(char[] dst, char[] src, int length, int dstOffset = 0, int srcOffset = 0)
        {
            fixed (void* pd = &dst[dstOffset])
            fixed (void* ps = &src[srcOffset])
                Extern.memmove((IntPtr)pd, (IntPtr)ps, (UIntPtr)(length << 1));
        }

        static public unsafe void memmove(char[] dst, char[] src, uint length, uint dstOffset = 0, uint srcOffset = 0)
        {
            fixed (void* pd = &dst[dstOffset])
            fixed (void* ps = &src[srcOffset])
                Extern.memmove((IntPtr)pd, (IntPtr)ps, (UIntPtr)(length << 1));
        }

    }
}
