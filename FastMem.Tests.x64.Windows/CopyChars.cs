using System;
using System.Linq;
using NUnit.Framework;


namespace FastMem.Tests.x64.Windows
{
    [TestFixture]
    public class CopyChars
    {
        static private readonly char[] _chars = {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
        'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        [Test]
        public void CopyBytes_10()
        {
            var length = 10;
            var a = new char[length];
            FastMem.Copy.Chars.Copy(a, _chars, length);
            Assert.AreEqual(_chars.Take(length).ToArray(), a);
        }

        [Test]
        public void CopyBytes_10_10()
        {
            var length = 10;
            var srcOffset = 10;
            var a = new char[length];
            FastMem.Copy.Chars.Copy(a, _chars, length, 0, srcOffset);
            Assert.AreEqual(_chars.Skip(srcOffset).Take(length).ToArray(), a);
        }

        [Test]
        public void CopyBytes_10_10_10()
        {
            var length = 10;
            var srcOffset = 10;
            var dstOffset = 10;
            var a = new char[length + dstOffset];
            FastMem.Copy.Chars.Copy(a, _chars, length, dstOffset, srcOffset);
            Assert.AreEqual(_chars.Skip(srcOffset).Take(length).ToArray(), a.Skip(dstOffset).ToArray());
        }
    }
}
