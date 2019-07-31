namespace Exs_01_Create_Stack
{
    using System;

    public class CoolStack
    {

        private object[] values;

        private int count;

        public int Count { get => this.count; }

        public CoolStack(int initialCapacity)
        {
            this.values = new object[initialCapacity];
            this.count = 0;
        }

        public CoolStack()
            : this(16)
        {

        }

        public void Push(object value)
        {
            if (this.count == this.values.Length)
            {
                this.values = new object[this.count * 2];
            }
            values[this.count] = value;
            this.count++;
        }

        public object Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("CoolStack is empty");
            }
            var lastIndex = this.count - 1;
            var last = this.values[lastIndex];
            this.count--;
            return last;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.values[i]);
            }
        }

    }
}

