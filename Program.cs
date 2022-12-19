using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class node
    {
        public int key;
        public node next;

        public node (int key)
        {
            this.key = key;
            this.next = null;
        }
    }

    class Queue
    {
        public node muhammad, mubaroq;
        
        public Queue() { this.muhammad = this.mubaroq = null; }

        // Method to add an key to the queue.
        public void insert(int key)
        {
            // create a new ll node
            node temp = new node(key);

            // if queue is empty, the new node is front and rear both
            if (this.mubaroq == null)
            {
                this.muhammad = this.mubaroq = temp;
                return;
            }

            // tambah node baru ke akhir urutan dan ubah mubaroq
            this.mubaroq.next = temp;
            this.mubaroq = temp;
        }

        // metode untuk menghapus key dari queue
        public void delete()
        {
            // jika queue kosong, return jd null
            if (this.muhammad == null)
                return;
            this.muhammad = this.muhammad.next;

            if (this.muhammad == null)
                this.mubaroq = null;

        }
        public void display()
        {
            
            node current = muhammad;

            if (muhammad == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("Nodes of exercise5: ");
            while (current != null)
            { 
                Console.Write(current.key + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

    }

    public class test
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.insert(10);
            q.insert(20);
            q.delete();
            q.delete();
            q.insert(30);
            q.insert
        }
    }
}
