using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_tasks
{
    public class Circular_Queue
    {
        #region Variables
        public int[] array;
        public int head;
        public int tail;
        public int count;
        public int size;
        #endregion

        #region Ctors
        public Circular_Queue()
        {
            head = 0;
            tail = 0;
            count = 0;
            size = 5;
            array = new int[size];
        }

        public Circular_Queue(int _size)
        {
            this.size = _size;
            array = new int[size];
            head = 0;
            tail = 0;
            count = 0;
        }
        #endregion

        #region Functions

        public bool IsFull()
        {
            return count == size;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(int item)
        {
            if (!IsFull())
            {
                array[tail] = item;
                tail = (tail + 1) % size;
                count++;
                Console.WriteLine(item);
            }
            else { Console.WriteLine("The queue is full"); }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty");
            }

            int returnValue = array[head];
            head = (head + 1) % size;
            count--;

            Console.WriteLine(returnValue);
            return returnValue;
        }

        #endregion

    }
}
