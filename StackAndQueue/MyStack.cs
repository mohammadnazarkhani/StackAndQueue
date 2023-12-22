using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyStack<T>
    {
        private T[] data;
        private int top = -1;

        public MyStack(int capacity)
        {
            data = new T[capacity];
        }

        public void Push(T element)
        {
            if (!IsFull())
                data[++top] = element;
            else
                throw new ArgumentOutOfRangeException();
        }

        public T Pop()
        {
            if (!IsEmpty())
                return data[top--];
            else
                throw new InvalidOperationException();
        }

        public T Read()
        {
            return data[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == data.Length - 1;
        }
    }
}
