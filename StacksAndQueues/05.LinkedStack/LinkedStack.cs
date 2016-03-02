namespace _05.LinkedStack
{
    using System;

    public class LinkedStack<T>
    {
        private Node<T> firstNode;

        public int Count { get; private set; }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            var resultNode = this.firstNode;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return resultNode.Value;
        }

        public void Push(T element)
        {
            if (this.Count == 0)
            {
                this.firstNode = new Node<T>(element);
            }
            else
            {
                this.firstNode = new Node<T>(element, this.firstNode);
            }

            this.Count++;
        }

        public T[] ToArray()
        {
            var arrReturn = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                arrReturn[i] = this.firstNode.Value;
                this.firstNode = this.firstNode.NextNode;
            }

            return arrReturn;
        }

        private class Node<T>
        {
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }

            public Node<T> NextNode { get; set; }

            public T Value { get; private set; }
        }
    }
}