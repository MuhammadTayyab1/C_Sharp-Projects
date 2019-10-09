using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds_class_25
{
    class Node
    {
        public int value = 0;

        public Node next = null;
    }
    class Merilist
    {
        Node Curr = null;
        Node Start;
        int length = 0;

        public void insert(int value)
        {
            if (Start == null)
            {
                Start = new Node();
                Curr = Start;
                Curr.value = value;
            }
            else
            {
                Curr = Start;

                while (true)
                {

                    if (Curr.next == null)
                    {
                        Curr.next = new Node();
                        Curr = Curr.next;
                        Curr.value = value;

                        break;
                    }
                    Curr = Curr.next;
                }
            }
        }

        public int get(int index)
        {
            Curr = Start;
            int maxlength = 0;

            for (int i = 0; i < index; i++)
            {
                if (Curr.next != null)
                {
                    Curr = Curr.next;
                    maxlength++;
                }
                else
                {
                    break;
                }
            }
            if (maxlength < index)
            {
                return 0;
            }
            else
            {
                return Curr.value;
            }

            return Curr.value;
        }

        public void delete(int ind)
        {
            Curr = Start;
            int max = 0;

            for (int i = 0; i < ind - 1; i++)
            {
                if (Curr.next != null)
                {
                    Curr = Curr.next;
                    max++;
                }
            }

            if (ind == 0)
            {
                Node temp = Start.next;
                Start = null;
                Start = temp;
            }
            else

                if (Curr.next != null && Curr.next.next != null)
                {
                    Node temp = Curr.next;

                    Curr.next = temp.next;

                    temp = null;

                }
                else
                    if (ind == max + 1)
                    {
                        Curr = Curr.next;
                        Curr.next = null;

                    }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Merilist obj = new Merilist();
            // add
            obj.insert(90);
            obj.insert(100);
            obj.insert(101);
            obj.insert(102);
            obj.insert(103);

            for (int i = 0; i < 5; i++)
            {
                int hold = obj.get(i);
                Console.WriteLine(hold);
            }
            Console.WriteLine("======================");

            // del
            obj.delete(3);

            // View
            for (int i = 0; i < 5; i++)
            {
                int hold = obj.get(i);
                Console.WriteLine(hold);
            }

        }
    }
}
