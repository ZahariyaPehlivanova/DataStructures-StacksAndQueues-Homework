namespace _03.ArrayBasedClass
{
    using System;

    public class ArrayStack<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;
        
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; set; }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("The stack is empty!");
            }
            
            this.Count--;
            return this.elements[this.Count];
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            for (int i = this.Count - 1, j = 0; i >= 0; i--, j++) 
            {
                arr[j] = this.elements[i];
            }

            return arr;
        }

        private void Grow()
        {
            var newElements = new T[this.elements.Length * 2];
            Array.Copy(this.elements, newElements, this.Count);
            this.elements = newElements;
        }
    }
}
