using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class ChangesInList<T> : EventArgs
    {
        public T Item { get; }
        public int Index { get; }

        public ChangesInList(T item, int index = -1)
        {
            Item = item;
            Index = index;
        }
    }
}
