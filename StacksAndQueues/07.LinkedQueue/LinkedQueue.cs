using System;

namespace _07.LinkedQueue
{
    public class LinkedQueue<T>
    {
        private QuequNode<T> head;
        private QuequNode<T> tail;
        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = new QuequNode<T>(element);
                this.tail = this.head;
            }
            else
            {
                var newElement = new QuequNode<T>(element);
                newElement.NextNode = this.head;
                this.head.PrevNode = newElement;
                this.head = newElement;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var resultEl = this.tail.Value;
            this.tail = this.tail.PrevNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }
            this.Count--;
            return resultEl;
        }

        public T[] ToArray()
        {
            var resultArr = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[i] = this.tail.Value;
                this.tail = this.tail.PrevNode;
            }
            return resultArr;
        }

        public class QuequNode<T>
        {
            public QuequNode(T value)
            {
                this.Value = value;
            }

            public T Value { get;}

            public QuequNode<T> NextNode { get; set; }

            public QuequNode<T> PrevNode { get; set; }
        }
    }
}
