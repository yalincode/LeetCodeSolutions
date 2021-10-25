using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("You can check Palindrome Number. (If they are Palindrome, answer is true)For example, 121 is palindrome while 123 is not.");
            
            StartAgain:
            int y = Convert.ToInt32(Console.ReadLine());
            Solution solution = new Solution();
            solution.IsPalindrome(y);

            Console.WriteLine(solution.IsPalindrome(y));

            goto StartAgain;
            

        }
        public class Solution
        {

            public bool IsPalindrome(int x)
            {
                if (x < 0)
                {
                    return false;
                }

                int rev = 0;
                int num = x;

                while (num != 0)
                {
                    rev *= 10;
                    rev += (num % 10);
                    num /= 10;
                }

                return (x == rev);
            }
        }


    }
}

        
    

