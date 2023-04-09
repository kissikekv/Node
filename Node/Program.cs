using System;
using System.Globalization;

namespace Node;
class Program
{

    public class ListNode
    {
        private class Node
        {
            public int Data;
            public Node Next;
            //свойства С#
        }
        //индексер
        public int this[int index]
        {
            get
            {
                var temp = _tail; // вынеси в отедельный метод
                int couter = 0;
                while (couter < index)
                {
                    temp = temp.Next;
                    couter++;
                }
                return temp.Data;
            }
            set
            {
                var temp = _tail;
                int couter = 0;
                while (couter < index)
                {
                    temp = temp.Next;
                    couter++;
                }
                temp.Data = value;                
            }
        }

        private Node _tail;
        private int _count;
        //throw exception
        private void Message()
        {
            Console.WriteLine("список не существует");
        }

        public void Add(int data)
        {
            var temp = _tail;
            Node node = new Node() { Data = data };
            if (_tail == null)
            {
                _tail = node;
            }
            else // не нужен, сделай без елс
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            _count++;
        }

        public bool Remove(int data)
        {
            var temp = _tail;
            Node previous = null;
            if (_tail != null)
            {
                while (temp != null)
                {
                    if (temp.Data.Equals(data))
                    {
                        if (previous != null)
                        {
                            previous.Next = temp.Next;
                            _count--;
                            return true;
                        }
                        else
                        {
                            _count--;
                            _tail = _tail.Next; // temp
                            return true;
                        }
                    }
                    previous = temp;
                    temp = temp.Next;
                }
            }
            else
            {
                Message(); //  не надо ошибок тут
                return false;
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
            else
            {
                Message(); // не надо ошибок, пиши сразу правильно
            }
        }

        public int Length
        {
            get
            {
                if (_tail != null)
                {
                    return _count; //  в свойство гет и приват сет
                }
                else
                {
                    return 0;
                }
            }
        }
        public void Clear()
        {
            if (_tail != null)
            {
                _tail = null; //  сразу в налл
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
