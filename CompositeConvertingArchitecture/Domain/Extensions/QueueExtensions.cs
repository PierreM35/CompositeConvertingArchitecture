
namespace CompositeConvertingArchitecture.Domain.Extensions
{
    public static class QueueExtensions
    {
        public static IEnumerable<T> Dequeue<T>(this Queue<T> queue, int quantity)
        {
            var items = new List<T>();
            for (int i = 0; i < quantity; i++) 
                items.Add(queue.Dequeue());

            return items;
        }
    }
}
