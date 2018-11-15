using System;
using System.Linq;
using NUnit.Framework;


namespace FastMem.Tests.x64.Windows
{
    [TestFixture]
    public class CopyBytesReverse
    {
        static private readonly byte[] _bytes = {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
        30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
        58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85,
        86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };

        [Test]
        public void CopyBytes_Rev_10()
        {
            var length = 10;
            var a = new byte[length];
            FastMem.Copy.Bytes.CopyReverse(a, _bytes, length);
            Assert.AreEqual(_bytes.Take(length).ToArray(), a);
        }

        [Test]
        public void CopyBytes_Rev_10_10()
        {
            var length = 10;
            var srcOffset = 10;
            var a = new byte[length];
            FastMem.Copy.Bytes.CopyReverse(a, _bytes, length, 0, srcOffset);
            Assert.AreEqual(_bytes.Skip(srcOffset).Take(length).ToArray(), a);
        }

        [Test]
        public void CopyBytes_Rev_10_10_10()
        {
            var length = 10;
            var srcOffset = 10;
            var dstOffset = 10;
            var a = new byte[length + dstOffset];
            FastMem.Copy.Bytes.CopyReverse(a, _bytes, length, dstOffset, srcOffset);
            Assert.AreEqual(_bytes.Skip(srcOffset).Take(length).ToArray(), a.Skip(dstOffset).ToArray());
        }
    }
}
