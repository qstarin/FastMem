using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FastMem
{
    static public partial class Bytes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe void Copy(byte* dst, byte* src, int length)
        {
            if (length <= Fixed.MaxLength)
                Fixed.Switch(dst, src, length);
            else
                Windows.memcpy(dst, src, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public void Copy(byte[] dst, byte[] src, int length, int dstOffset = 0, int srcOffset = 0)
        {
            if (length <= Fixed.MaxLength)
                Fixed.Switch(dst, src, length, dstOffset, srcOffset);
            else
                Windows.memcpy(dst, src, length, dstOffset, srcOffset);
        }
    }

    static public partial class Chars
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe void Copy(char* dst, char* src, int length)
        {
            if (length <= Fixed.MaxLength)
                Fixed.Switch(dst, src, length);
            else
                Windows.memcpy(dst, src, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public void Copy(char[] dst, char[] src, int length, int dstOffset = 0, int srcOffset = 0)
        {
            if (length <= Fixed.MaxLength)
                Fixed.Switch(dst, src, length, dstOffset, srcOffset);
            else
                Windows.memcpy(dst, src, length, dstOffset, srcOffset);
        }
    }
}
