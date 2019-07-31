using System.Collections.Generic;

namespace Exs_01_Box
{
    public class Box<T>
    {

        private List<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public int Count { get => list.Count; }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            var element = this.list[this.Count - 1];
            this.list.RemoveAt(this.Count - 1);
            return element;
        }

    }
}
