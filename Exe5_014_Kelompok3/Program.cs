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
                    Console.WriteLine("1. Memasukkan Data");
                    Console.WriteLine("2. Menghapus Data");
                    Console.WriteLine("3. Menampilkan Data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nMasukkan Pilihan Anda(1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                                break;
                            }
                        case '2':
                            {
                                q.delete();
                                break;
                            }
                        case '3':
                            {
                                q.display();
                                break;
                            }
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Opsi Tidak Benar");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Periksa Nilai yang Dimasukkan. ");
                }
            }
        }
    }
}