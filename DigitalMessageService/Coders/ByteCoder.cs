﻿using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
{
    public class ByteCoder(byte bitNumber) : Coder<byte>(bitNumber)
    {
        public override Binary Encode(byte value)
        {
            if (value > Math.Pow(2, BitsQuantity) - 1)
                throw new ArgumentException($"Value {value} not convertible into {BitsQuantity} bites");

            throw new NotImplementedException();
        }

        public override byte Decode(Binary binary)
        {
            if (binary.Count != BitsQuantity)
                throw new ArgumentException($"Awaited binary must have {BitsQuantity} bits. Has {binary.Count}.");

            throw new NotImplementedException();
        }
    }
}
