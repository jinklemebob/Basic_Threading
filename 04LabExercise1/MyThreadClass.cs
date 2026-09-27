using System;
using System.Threading;

namespace _04LabExercise1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(
                    "Name of Thread: " + thread.Name + " Process = " + i
                );

                Thread.Sleep(1500);
            }
        }
    }
}