using System;

namespace Exs_01_Create_Custom_List
{

    public class CustomList
    {

        private int capacity;

        public CustomList()
        {
            this.Items = new object[0];
            this.Count = 0;
            this.capacity = 0;
        }

        public object[] Items { get; set; }

        public int Count { get; private set; }

        public int Indexer { get; set; }

        public void Add(object value)
        {
            this.Resize();
            this.Items[this.Count] = value;
            this.Count++;
        }

        public void Remove(object value)
        {
            IsListEmpty();
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Items[i].Equals(value))
                {
                    this.Shift(i);
                }
            }
            this.Shrink();
        }

        public object RemoveAt(int index)
        {
            IndexOutOfRange(index);
            IsListEmpty();
            var value = this.Items[index];
            this.Shift(index);
            this.Shrink();
            return value;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Items[i].Equals(value)) return true;
            }
            return false;
        }

        public void Clear()
        {
            this.Count = 0;
            this.capacity = 0;
            this.Items = new object[0];
        }

        private void Resize()
        {
            if(this.Count == this.capacity)
            {
                var temp = new object[this.capacity == 0 ? 1 : this.capacity * 2];
                this.capacity *= 2;
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.Items[i];
                }
                this.Items = temp;
            }
        }

        private void Shrink()
        {
            if(this.Count == this.capacity / 2)
            {
                var temp = new object[this.Count];
                this.capacity = this.Count;
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.Items[i];
                }
                this.Items = temp;
            }
        }

        private void Shift(int index)
        {
            for (int i = index + 1; i < this.Count; i++)
            {
                this.Items[i] = this.Items[i + 1];
            }
            this.Count--;
        }

        private void IndexOutOfRange(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new InvalidOperationException("Index out of range!");
            }
        }
        private void IsListEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Custom List is empty!");
            }
        }

    }
}
