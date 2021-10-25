using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int x = 0;
            int y = 0;

            char[] gelenRakam = s.ToCharArray();

            for (int i = 0; i < gelenRakam.Length; i++)
            {

                switch (gelenRakam[i])
                {
                    case 'M':
                        y = 1000;
                        break;
                    case 'D':
                        y = 500;
                        break;
                    case 'C':
                        y = 100;
                        break;
                    case 'L':
                        y = 50;
                        break;
                    case 'X':
                        y = 10;
                        break;
                    case 'V':
                        y = 5;
                        break;
                    case 'I':
                        y = 1;
                        break;

                }
                x += y;
            }
            if (s.Contains("CD") || s.Contains("CM"))
                x -= 200;
            if (s.Contains("XL") || s.Contains("XC"))
                x -= 20;
            if (s.Contains("IV") || s.Contains("IX"))
                x -= 2;
            return x;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string gelen = Console.ReadLine();
            Solution c = new Solution();
            int k = c.RomanToInt(gelen);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
