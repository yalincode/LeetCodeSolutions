using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MergeTwoSortedList_21_
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var curr = head;//AYNI REFERANSI GÖSTEREN BAŞKA NODE

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {

                    curr.next = l2;
                    l2 = l2.next;
                }

                curr = curr.next;//ifler içerisinde kullanılan curr.next curr yapılır ve sonraki iterasyonda next node un alınması sağlanır.
            }

            curr.next = l1 == null ? l2 : l1;

            return head.next;//head in başında dumy node vardı o nodu almadan bir sonraki elemandan geriye döndürüyoruz.
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
