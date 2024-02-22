using System.Threading.Channels;

namespace EventsHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WatchList<int> list = new WatchList<int>();
            list.ItemAdded += (sender, e) =>
            {
                Console.WriteLine($"Елемент {e.Item} було додано до листа.");
            };
            list.ItemInserted += (sender, e) =>
            {
                Console.WriteLine($"Елемент {e.Item} було вставлено до листа на позицію {e.Index}.");
            };
            list.ItemRemoved += (sender, e) =>
            {
                Console.WriteLine($"Елемент {e.Item} було видалено.");
            };

            list.Add(27);
            list.Add(22);
            list.Add(211);

            list.Insert(0, 11111);
            list.Remove(27);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}