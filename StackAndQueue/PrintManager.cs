using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class PrintManager<T>
    {
        private MyQueue<T> queue = new MyQueue<T>(10);

        public void AddPrintTask(T element)
        {
            queue.Enqueue(element);
        }

        private void Print(T element)
        {
            Console.WriteLine("Printing: " + element);
        }

        public void Run()
        {
            while (!queue.IsEmpty())
                Print(queue.Dequeue());
        }
    }
}
