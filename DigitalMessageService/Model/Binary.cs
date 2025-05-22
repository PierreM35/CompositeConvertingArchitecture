using DigitalMessageService.Abstractions;

namespace DigitalMessageService.Model
{
    public class Binary : Queue<bool>
    {
        public Binary() : base() { }
        public Binary(bool bit) : base([bit]) { }
        public Binary(IEnumerable<bool> bits) : base(bits) { }

        public void Append(Binary binary) => binary.ToList().ForEach(Enqueue);
        public T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));
       
        private Binary Cut(byte quantity)
        {
            var items = new List<bool>();
            for (int i = 0; i < quantity; i++)
                items.Add(Dequeue());

            return new(items);
        }
    }
}
