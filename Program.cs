namespace Day_5_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic_stack
            //Dynamic_Stack ds1 = new Dynamic_Stack(15);

            //for (int i = 0; i < ds1.size; i++)
            //{
            //    ds1.push(i);
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Queue
            //Queue q1 = new Queue(10);

            //Console.WriteLine($"The current array size is {q1.Size}");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Enqueue(1);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Enqueue(2);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Enqueue(3);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Enqueue(4);
            //q1.Enqueue(5);
            //q1.Enqueue(6);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Enqueue(7);
            //q1.Enqueue(8);
            //q1.Enqueue(9);
            //q1.Enqueue(10);

            //Console.ForegroundColor = ConsoleColor.Red;
            //q1.Enqueue(11);
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Dequeue();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Dequeue();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Dequeue();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Dequeue();
            //q1.Dequeue();
            //q1.Dequeue();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"The current element count is {q1.Count}");
            //Console.ForegroundColor = ConsoleColor.White;

            //q1.Dequeue();
            //q1.Dequeue();
            //q1.Dequeue();
            //q1.Dequeue();

            //Console.ForegroundColor = ConsoleColor.Red;
            //q1.Dequeue();
            //q1.Dequeue();
            #endregion

            #region circular_Queue
            Circular_Queue q1 = new Circular_Queue(5);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"the current array size is {q1.size}");
            Console.WriteLine($"the current element count is {q1.count}");
            Console.ForegroundColor = ConsoleColor.White;


            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            Console.WriteLine($"the array head  is {q1.head} and tail is {q1.tail}");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"the current element count is {q1.count}");
            Console.ForegroundColor = ConsoleColor.White;

            q1.Enqueue(4);
            q1.Enqueue(5);

            Console.WriteLine($"the array head  is {q1.head} and tail is {q1.tail}");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"the current element count is {q1.count}");
            Console.ForegroundColor = ConsoleColor.White;

            q1.Enqueue(6);


            Console.WriteLine($"the array head  is {q1.head} and tail is {q1.tail}");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"the current element count is {q1.count}");
            Console.ForegroundColor = ConsoleColor.White;

            q1.Dequeue();
            q1.Dequeue();

            Console.WriteLine($"the array head  is {q1.head} and tail is {q1.tail}");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"the current element count is {q1.count}");
            Console.ForegroundColor = ConsoleColor.White;



            #endregion

            Console.ReadLine();
        }
    }
}
