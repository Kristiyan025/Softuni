using System;

namespace Exs_02_Create_Linked_List
{
    public class CoolLinkedList
    {

        private class CoolNode
        {

            public CoolNode(object value)
            {
                this.Value = value;
            }

            public object Value { get; private set; }

            public CoolNode Next { get; set; }

            public CoolNode Prev { get; set; }

        }

        private CoolNode head;
        private CoolNode tail;

        public object Head
        {
            get
            {
                ValidateIfIsEmpty();
                return this.head.Value;
            }
        }

        public object Tail
        {
            get
            {
                ValidateIfIsEmpty();
                return this.tail.Value;
            }
        }

        /*
        public object GetHead()
        {
            if(this.head == null)
            {
                throw new InvalidOperationException("Linked List is empty");
            }
            return this.head.Value;
        }

        public object GetTail()
        {
            if(this.tail == null)
            {
                throw new InvalidOperationException("Linked List is empty");
            }
            return this.tail.Value;
        }
        */
        
        public int Count { get; private set; }

        public void AddHead(object value)
        {
            var newNode = new CoolNode(value);

            if(this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldHead = this.head;
                oldHead.Prev = newNode;
                newNode.Next = oldHead;
                this.head = newNode;
            }

            this.Count++;
        }

        public void AddTail(object value)
        {
            var newNode = new CoolNode(value);

            if(this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldTail = this.tail;
                oldTail.Next = newNode;
                newNode.Prev = oldTail;
                this.tail = newNode;
            }

            this.Count++;
        }

        public object RemoveHead()
        {
            ValidateIfIsEmpty();

            var oldHead = this.head;
            if(this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newHead = this.head.Next;
                this.head = newHead;
                this.head.Prev = null;
            }

            this.Count--;
            return oldHead.Value;
        }

        public object RemoveTail()
        {
            ValidateIfIsEmpty();

            var oldTail = this.tail;
            if(this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newTail = oldTail.Prev;
                this.tail = newTail;
                this.tail.Next = null;
            }

            this.Count--;
            return oldTail.Value;
        }

        public void ForEach(Action<object> action, bool reverse = false)
        {
            var current = reverse ? this.tail : this.head;
            while (current != null)
            {
                action(current.Value);
                current = reverse ? current.Prev : current.Next;
            }
        }

        public object[] ToArray()
        {
            var array = new object[this.Count];
            int i = 0;
            this.ForEach(x =>
            {
                array[i] = x;
                i++;
            });
            return array;
        }

        public void Remove(object value)
        {
            var current = this.head;
            while (current != null)
            {
                if(current.Value.Equals(value))
                {
                    this.Count--;
                    var prev = current.Prev;
                    var next = current.Next;
                    if(current != this.head)
                    {
                        prev.Next = next;
                    }
                    else
                    {
                        this.head = next;
                    }
                    if (current != this.tail)
                    {
                        next.Prev = prev;
                    }
                    else
                    {
                        this.tail = prev;
                    }
                }
                current = current.Next;
            }
        }

        public bool Contains(object value)
        {
            bool contains = false;
            var current = this.head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    contains = true;
                    break;
                }
                current =  current.Next;
            }
            return contains;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        private void ValidateIfIsEmpty()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Linked List is empty.");
            }
        }

    }
}
