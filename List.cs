using System;
using System.Text;

namespace MyList
{
    public struct Review
    {
        public string name;
        public DateTime time;
        public string dish;
        public string phoneNumber;
        public int rate;
        public override string ToString()
        {
            return $"{name} {time} {dish} {phoneNumber} {rate}";
        }
        public static bool operator ==(Review review1, Review review2)
        {
            return review1.name == review2.name && review1.dish == review2.dish && review1.phoneNumber == review2.phoneNumber && review1.rate == review2.rate && review1.time == review2.time;
        }
        public static bool operator !=(Review review1, Review review2) => !(review1 == review2);
    }
    public class ListNode
    {
        public Review data;
        public ListNode next;
        public ListNode()
        {
            data = default;
            next = null;
        }
        public ListNode(Review data)
        {
            this.data = data;
            next = null;
        }
    }

    public class MyList
    {
        public ListNode head;
        public MyList()
        {
            head = null; //def
        }
        public void Add(Review review)
        {
            if (head == null)
            {
                head = new ListNode(review);
            }
            else
            {
                ListNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                ListNode new_node = new ListNode(review);
                temp.next = new_node;
            }
        }
        public void Copy(MyList other)
        {
            ListNode cur = head;
            while (cur != null)
            {
                var tmp = cur.data;
                cur = cur.next;
                Delete(tmp);
            }
            cur = other.head;
            while (cur != null)
            {
                Add(cur.data);
                cur = cur.next;
            }
        }
        public void Delete(Review review)
        {
            if (head == null) { return; }
            else
            {
                ListNode temp = head;
                ListNode temp1 = temp;
                while (temp != null && temp.data != review)
                {
                    temp1 = temp;
                    temp = temp.next;
                }
                if (temp == null) { return; }
                else if (temp == head)
                {
                    head = head.next;
                }
                else
                {
                    temp1.next = temp.next;
                }
            }
        }
        public bool Search(Review review)
        {
            ListNode cur = head;
            while (cur != null && cur.data != review)
            {
                cur = cur.next;
            }
            return (cur != null);
        }
        public bool SearchForTree(Review review)
        {
            ListNode cur = head;
            while (cur != null && cur.data.phoneNumber != review.phoneNumber)
            {
                cur = cur.next;
            }
            return cur != null;
        }
        public void Print()
        {
            var cur = head;
            while (cur != null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
        }
    }
}
