using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyQueue<T>
    {
        private T[] data;
        private int end = -1;

        public MyQueue(int capacity)
        {
            data = new T[capacity];
        }

        private void Shift()
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
        }

        public void Enqueue(T element)
        {
            if (!IsFull())
                data[++end] = element;
        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T result = data[0];
                end--;
                Shift();
                return result;
            }
            else
                throw new InvalidOperationException();

        }

        public T Read()
        {
            if (!IsEmpty())
            {
                T result = data[0];
                return result;
            }
            else
                throw new InvalidOperationException();
        }

        public bool IsFull()
        {
            return end == data.Length;
        }

        public bool IsEmpty()
        {
            return end == -1;
        }
    }
}
