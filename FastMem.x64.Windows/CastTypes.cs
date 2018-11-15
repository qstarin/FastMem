using System;
using System.Runtime.InteropServices;


namespace FastMem
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct S01
    {
        public byte B01;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct S02
    {
        public byte B01;
        public byte B02;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct S04
    {
        public byte B01;
        public byte B02;
        public byte B03;
        public byte B04;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct S08
    {
        public byte B01;
        public byte B02;
        public byte B03;
        public byte B04;
        public byte B05;
        public byte B06;
        public byte B07;
        public byte B08;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct S16
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
    }
}
