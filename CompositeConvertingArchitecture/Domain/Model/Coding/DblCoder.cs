using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Model.Coding
{
    public class DblCoder(byte bitNumber) : Coder<double>(bitNumber)
    {
        public override double Decode(Code code)
        {
            throw new NotImplementedException();
        }

        public override Code Encode(double value)
        {
            throw new NotImplementedException();
        }
    }
}
