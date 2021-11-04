using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSortAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[1000];
            
            for (int i = 0; i < 1000; i++)
            {
                int newCount = rnd.Next(1, 10001);
                if (!array.Contains(newCount))
                {
                    array[i] = newCount;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 999; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int swap = array[j];
                        int swap2=array[j+1];
                        array[j] = swap2;
                        array[j+1] = swap;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
