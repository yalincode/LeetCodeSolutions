using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LongestCommonPrefix_14_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Solution s = new Solution();
            Console.WriteLine(s.LongestCommonPrefix(strs));
            Solution2 s2 = new Solution2();
            Console.WriteLine(s2.LongestCommonPrefix(strs));
            Console.ReadKey();

        }
    }
    public class Solution
    {
        
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)//Index of bu şekilde kullanıldığında eğer strs prefix sözcüğünü içeriyorsa ilk ındex in numarasını verir yani 0 ve bu şekilde döngüye girmez.
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) return "";
                }
            }
                
            return prefix;
        }
    }

    public class Solution2
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
                return "";
            string res = strs[0];
            int i = res.Length;
            foreach (string word in strs)
            {
                int j = 0;
                foreach (char c in word)
                {
                    if (j >= i || res[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return res.Substring(0, i);
        }

    }


}
