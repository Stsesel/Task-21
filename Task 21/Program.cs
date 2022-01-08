using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_21
{
    class Program
    {
        const int y = 4, x = 6;
        static int[,] path = new int[y, x]
        {
            {100, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0},
            {1, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 100},
        };

        
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(path[j, i]);
                }
            }
            
            Console.ReadKey();
        }

        static void Gardner1()
        {
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (path [j, i] >=0)
                    {
                        int delay = path[j,i];
                        path[j, i] = -1;
                        Thread.Sleep(delay);
                    }
                }
            }
        }

        static void Gardner2()
        {
            for (int j = y-1; j >= 0; j--)
            {
                for (int i = x-1; i >= 0; i--)
                {
                    if (path[j, i] >= 0)
                    {
                        int delay = path[j, i];
                        path[j, i] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
    }
}  




