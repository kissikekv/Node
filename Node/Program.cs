using System.Globalization;

namespace Node;
class Program
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node(int data = 0)
        {
            Data = data;
        }
    }

    public class ListNode
    {
        Node head;
        Node tail;
        int count = 0;

        public bool IsExist(object obj)
        {
            return obj != null;
        }
        private void Message()
        {
            Console.WriteLine("список не существует!");
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if (!IsExist(tail))
            {
                tail = node;
            }
            else
            {
                head.Next = node;
            }
            head = node;
            count++;
        }
        public bool Remove(int data)
        {
            var temp = tail;
            Node previous = null;
            if (IsExist(tail))
            {
                while (temp != null)
                {
                    if (temp.Data == data)
                    {
                        if (IsExist(previous))
                        {
                            previous.Next = temp.Next;
                            count--;
                            return true;
                        }
                        else
                        {
                            count--;
                            tail = tail.Next;
                            return true;
                        }
                    }
                    previous = temp;
                    temp = temp.Next;
                }
            }
            else
            {
                Message();
                return false;
            }
            return false;
        }
        public void Print()
        {
            if (IsExist(tail))
            {
                var temp = tail;
                while (IsExist(temp))
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
            else
            {
                Message();
            }
        }
        public void Length()
        {
            if (IsExist(tail))
            {
                Console.WriteLine(count);
            }
            else
            {
                Message();
            }
        }
        public void Clear()
        {
            if (IsExist(tail))
            {
                tail = null;
            }
            else
            {
                Message();
            }
        }
    }

    public static void Main(string[] args)
    {
        ListNode list = new ListNode();
        list.Add(1);
        list.Length();
        //Console.WriteLine();
        list.Remove(1);
        list.Print();
        //Console.WriteLine();
        //list.Clear();
        //list.Length();
    }
}
