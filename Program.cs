using System;
using System.Threading;

namespace PotokiWork
{
    class Program
    {
        static void mythread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 1 call - " + i);
            }
        }

        static void mythread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 2 call - " + i);
            }
        }


        static void Main(string[] args)
        {
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);

            thread1.Start();
            thread2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 3 call - " + i);
            }

            Console.ReadLine();
        }

    }
}
