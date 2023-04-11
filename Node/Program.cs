using System;
using System.Globalization;

namespace Node;
class Program
{

    public class ListNode
    {
        private class Node
            {
                public int Data {get; set;}
                public Node Next {get; set;}
            }

            private Node _tail;
            public int _count;            

            private Node GetIndex(int index)
            {
                var temp = _tail;
                int counter = 0;
                while (counter < index)
                {
                    temp = temp.Next;                                       
                    counter++;
                }
                return temp;
            }

            public int this[int index]
            {
                get
                {
                    return GetIndex(index).Data;
                }
                set
                {
                    GetIndex(index).Data = value;
                }
            }
            
            public void Add(int data)
            {
                Count++;
                var temp = _tail;
                Node node = new Node() { Data = data };
                if (temp == null)
                {
                    _tail = node;
                    return;
                }
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }

            public bool Remove(int data)
            {
                var temp = _tail;
                if (_tail != null)
                {
                    Node previous = null;                    
                    while (temp != null)
                    {
                        if (temp.Data.Equals(data))
                        {
                            if (previous != null)
                            {
                                previous.Next = temp.Next;
                                Count--;
                                return true;
                            }
                            else
                            {
                                Count--;
                                _tail = _tail.Next; // temp
                                return true;
                            }
                        }
                        previous = temp;
                        temp = temp.Next;
                    }
                }
                return false;
            }

            public void Print()
            {
                if (_tail != null)
                {
                    var temp = _tail;
                    while (temp != null)
                    {
                        Console.WriteLine(temp.Data);
                        temp = temp.Next;
                    }
                }
            }

            public int Count
            {
                get
                {
                    return _count;
                }
                private set
                {
                    _count = value;
                }
            }

            public void Clear()
            {
                _tail = null;
            }
    }

    public static void Main(string[] args)
    {
        ListNode list = new ListNode();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        //list.Remove(1);
        list.Print();
        //Console.WriteLine(list.Length);
        Console.WriteLine(list[0]);
        list[3] = 1;
        Console.WriteLine("blyaaaaaaaaaaa");
        list.Print();
    }
}
