using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class WatchList<T> : List<T>
    {
        public event EventHandler<ChangesInList<T>>? ItemRemoved;
        public event EventHandler<ChangesInList<T>>? ItemInserted;
        public event EventHandler<ChangesInList<T>>? ItemAdded;

        private void OnItemAdded(T item)
        {
            ItemAdded?.Invoke(this, new ChangesInList<T>(item));
        }
        private void OnItemRemoved(T item)
        {
            ItemRemoved?.Invoke(this, new ChangesInList<T>(item));
        }
        private void OnItemInserted(int index, T item)
        {
            ItemInserted?.Invoke(this, new ChangesInList<T>(item, index));
        }

        public new void Add(T item)
        {
            base.Add(item);
            OnItemAdded(item);
        }
        public new void Remove(T item)
        {
            base.Remove(item);
            OnItemRemoved(item);
        }
        public new void Insert(int index, T item)
        {
            base.Insert(index, item);
            OnItemInserted(index, item);
        }
    }
}
