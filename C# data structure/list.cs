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

        public void enque(int value)
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
        public int show(int index)
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
        public int deque(int index)
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
                delete(index);
                return Curr.value;

            }
            delete(index);
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
            obj.enque(90);
            obj.enque(100);
            obj.enque(101);
            obj.enque(102);
            obj.enque(103);

            for (int i = 0; i < 5; i++)
            {
                int hold9 = obj.show(i);
                Console.WriteLine(hold9);
            }
            Console.WriteLine("======================");

           

            int hold = obj.deque(0);
            Console.WriteLine(hold);

            int hold1 = obj.deque(0);
            Console.WriteLine(hold1);


            Console.WriteLine("=============================");

            for (int i = 0; i < 5; i++)
            {
                int hold0 = obj.show(i);
                if (hold0 != 0)
                {
                    Console.WriteLine(hold0);
                }
            }

        }
    }
}
