using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace FastMem
{
    [StructLayout(LayoutKind.Sequential)]
    public struct S01
    {
        public byte B01;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override bool Equals(object obj) => !(obj is null) && obj is S01 o && this == o;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override int GetHashCode() => B01.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public bool operator ==(S01 x, S01 y) => x.B01 == y.B01;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public bool operator !=(S01 x, S01 y) => x.B01 != y.B01;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public bool operator <(S01 x, S01 y) => x.B01 < y.B01;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public bool operator >(S01 x, S01 y) => x.B01 > y.B01;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct S02
    {
        public byte B01;
        public byte B02;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override bool Equals(object obj) => !(obj is null) && obj is S02 o && this == o;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override unsafe int GetHashCode() { fixed (void* p = &this) return ((short*)p)->GetHashCode(); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator ==(S02 x, S02 y) => *(short*)&x == *(short*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator !=(S02 x, S02 y) => *(short*)&x != *(short*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator <(S02 x, S02 y) => *(short*)&x < *(short*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator >(S02 x, S02 y) => *(short*)&x > *(short*)&y;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct S04
    {
        public byte B01;
        public byte B02;
        public byte B03;
        public byte B04;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override bool Equals(object obj) => !(obj is null) && obj is S04 o && this == o;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override unsafe int GetHashCode() { fixed (void* p = &this) return ((int*)p)->GetHashCode(); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator ==(S04 x, S04 y) => *(int*)&x == *(int*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator !=(S04 x, S04 y) => *(int*)&x != *(int*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator <(S04 x, S04 y) => *(int*)&x < *(int*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator >(S04 x, S04 y) => *(int*)&x > *(int*)&y;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct S08
    {
        public byte B01;
        public byte B02;
        public byte B03;
        public byte B04;
        public byte B05;
        public byte B06;
        public byte B07;
        public byte B08;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override bool Equals(object obj) => !(obj is null) && obj is S08 o && this == o;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public override unsafe int GetHashCode() { fixed (void* p = &this) return ((long*)p)->GetHashCode(); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator ==(S08 x, S08 y) => *(long*)&x == *(long*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator !=(S08 x, S08 y) => *(long*)&x != *(long*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator <(S08 x, S08 y) => *(long*)&x < *(long*)&y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static public unsafe bool operator >(S08 x, S08 y) => *(long*)&x > *(long*)&y;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct S16
    {
        public byte B01;
        public byte B02;
        public byte B03;
        public byte B04;
        public byte B05;
        public byte B06;
        public byte B07;
        public byte B08;
        public byte B09;
        public byte B10;
        public byte B11;
        public byte B12;
        public byte B13;
        public byte B14;
        public byte B15;
        public byte B16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) => !(obj is null) && obj is S16 o && this == o;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override unsafe int GetHashCode()
        {
            fixed (void* p = &this) {
                var lp = (long*)p;
                unchecked {
                    var hash = 527 + lp->GetHashCode();
                    return (hash << 5) - hash + (lp + 1)->GetHashCode();
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe bool operator ==(S16 x, S16 y)
        {
            long* xp1 = (long*)&x;
            long* yp1 = (long*)&y;
            return *xp1 == *yp1 && *(xp1 + 1) == *(yp1 + 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe bool operator !=(S16 x, S16 y)
        {
            long* xp1 = (long*)&x;
            long* yp1 = (long*)&y;
            return *xp1 != *yp1 || *(xp1 + 1) != *(yp1 + 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe bool operator <(S16 x, S16 y)
        {
            long* xp1 = (long*)&x;
            long* yp1 = (long*)&y;
            var diff = *xp1 - *yp1;
            return diff < 0 || (diff == 0 && *(xp1 + 1) < *(yp1 + 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public unsafe bool operator >(S16 x, S16 y)
        {
            long* xp1 = (long*)&x;
            long* yp1 = (long*)&y;
            var diff = *xp1 - *yp1;
            return diff > 0 || (diff == 0 && *(xp1 + 1) > *(yp1 + 1));
        }
    }
}
