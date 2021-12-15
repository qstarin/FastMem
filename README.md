# FastMem

FastMem is a simple library providing helpers to copy blocks of memory as quickly as possible. It is optimized for, and has only been benchmarked on recent Intel x64 CPU's running Windows OS with compiled applications targeting x64. It is only compatible with Windows OS.

Blocks of memory up to 1024 bytes are copied using a technique shamelessly stolen from [MessagePack](https://github.com/neuecc/MessagePack-CSharp/blob/master/src/MessagePack/Internal/UnsafeMemory.Low.cs).

Memory is copied in 16 byte chunks, unless the total amount of memory to copy is less than 16 bytes. 16 byte chunks proved faster than 8 byte chunks.

If the block of memory to copy is greater than 1024 bytes then [memcpy](https://docs.microsoft.com/en-us/cpp/c-runtime-library/reference/memcpy-wmemcpy?view=vs-2017) is used. memcpy proved faster than [Buffer.BlockCopy](https://docs.microsoft.com/en-us/dotnet/api/system.buffer.blockcopy?view=netframework-4.7.2), [Mnemosyne](https://github.com/JonHanna/Mnemosyne), and [Array.Copy](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=netframework-4.7.2) as well as some other methods of manually unrolling memory copies.

Copy methods are not universally safe for overlapping regions of memory. Copying from a higher region of memory into a lower region of memory is safe, but copying from a lower region of memory into a higher region of memory is only safe if the start of the higher region is further away from the start of the lower region than the length to be copied.