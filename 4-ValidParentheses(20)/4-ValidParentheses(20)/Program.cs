using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ValidParentheses_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "[[[]";
            
            Console.WriteLine(IsValid(k).ToString());
            Console.ReadLine();
        }

        public static bool IsValid(string s)
        {
            Stack<char> sign = new Stack<char>();

            foreach (var item in s.ToCharArray())
                if (item == '(')
                    sign.Push(')');
                else if (item == '[')
                    sign.Push(']');
                else if (item == '{')
                    sign.Push('}');
                else if (sign.Count == 0 || sign.Pop() != item)
                    return false;

            return sign.Count == 0;
        }
    }
}
//for (int i = 0; i < s.Length - i; i++)
//{
//    if (s[i] is '(' && s[s.Length - i - 1] is ')')
//    {
//        continue;
//    }
//    else if (s[i] is '(' && s[i + 1] is ')')
//    {
//        i++;
//        continue;
//    }
//    else if (s[i] is '{' && s[s.Length - i - 1] is '}')
//    {
//        continue;
//    }
//    else if (s[i] is '{' && s[i + 1] is '}')
//    {
//        i++;
//        continue;
//    }
//    else if (s[i] is '[' && s[s.Length - i - 1] is ']')
//    {
//        continue;
//    }
//    else if (s[i] is '[' && s[i + 1] is ']')
//    {
//        i++;
//        continue;
//    }
//    else
//    {
//        return false;
//    }
//}
//return true;

//if (s.Length % 2 == 1)
//{
//    return false;
//}
//else if (s[0] == ')' || s[0] == ']' || s[0] == '}')
//{
//    return false;
//}
//else
//{
//    for (int i = 0; i < s.Length - 1; i++)
//    {
//        if (s[i] == '(')
//        {
//            if (s[i + 1] == ')')
//            {
//                i++;
//                continue;
//            }

//            else if ((s.Length - 1 - i) > i && s[s.Length - 1] == ')')
//            {
//                continue;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        else if (s[i] == '[')
//        {
//            if (s[i + 1] == ']')
//            {
//                i++;
//                continue;
//            }
//            else if ((s.Length - 1 - i) > i && s[s.Length - 1] == ']')
//            {
//                continue;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        else if (s[i] == '{')
//        {
//            if (s[i + 1] == '}')
//            {
//                i++;
//                continue;
//            }
//            else if ((s.Length - 1 - i) > i && s[s.Length - 1] == '}')
//            {
//                continue;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        else
//        {
//            return false;
//        }
//    }
//    return true;
//}
