using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140014_Kelompok3
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        Node DhiyaUlhaq, Khairunnisa;
        public Queue()
        {
            DhiyaUlhaq = null;
            Khairunnisa = null;
        }
        public void insert()
        {
            string nm;
            Node newNode = new Node();
            Console.WriteLine("Masukkan Element: ");
            nm = Console.ReadLine();
            newNode.name = nm;
            newNode.next = null;
            if(DhiyaUlhaq == null)
            {
                DhiyaUlhaq = newNode;
                Khairunnisa = newNode;
            }
            Khairunnisa.next = newNode;
            Khairunnisa = newNode;
        }
        public void delete()
        {
            if(DhiyaUlhaq == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            DhiyaUlhaq = DhiyaUlhaq.next;
            if (DhiyaUlhaq == null)
                Khairunnisa = null;
        }
        public void display()
        {
            if (DhiyaUlhaq == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delet operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("M\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered. ");
                }
            }
        }
    }
}