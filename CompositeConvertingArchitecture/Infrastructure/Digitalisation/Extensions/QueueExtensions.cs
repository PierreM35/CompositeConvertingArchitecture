namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions
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

        public static void Enqueue<T>(this Queue<T> queue, IEnumerable<T> items) 
            => items.ToList().ForEach(queue.Enqueue);
    }
}
