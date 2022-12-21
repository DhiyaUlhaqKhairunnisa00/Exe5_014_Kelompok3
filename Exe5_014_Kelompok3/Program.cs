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
    }
}