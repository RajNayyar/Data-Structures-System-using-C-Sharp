using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class LinkedList : DataStructure
    {
        public void CreateNode()
        {
            if (this.head == null)
            {
                this.head = new LinkedList();
                Console.WriteLine("Enter Data for the node");
                head.data = int.Parse(Console.ReadLine());
                this.temp = this.head;
                this.size++;
            }
            else
            {
                Console.WriteLine("Enter Data for the node");
                DataStructure freshnode = new LinkedList();
                freshnode.next = null;


                freshnode.data = int.Parse(Console.ReadLine());
                this.temp.next = freshnode;
                this.temp = temp.next;
                this.size++;
            }
        }

        public void InsertAtStart()
        {
            DataStructure freshnode = new LinkedList();
            freshnode.next = this.head;
            Console.WriteLine("Enter the data for new node");
            freshnode.data = int.Parse(Console.ReadLine());
            this.head = freshnode;
            this.size++;
        }
        public override void InsertAtEnd()
        {
            DataStructure freshnode = new LinkedList();
            this.temp = this.head;
            while (temp.next != null)
            {
                this.temp = this.temp.next;

            }
            Console.WriteLine("Enter the data for new node");
            freshnode.data = int.Parse(Console.ReadLine());
            freshnode.next = null;
            temp.next = freshnode;
            this.size++;
        }

        public void InsertAtBetween()
        {
            DataStructure freshnode = new LinkedList();
            Console.WriteLine("Enter position where you want to insert your element");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the data for new node");
            freshnode.data = int.Parse(Console.ReadLine());
            this.temp = this.head;
            int count = 1;
            while (count != n)
            {
                this.temp = this.temp.next;
                count = count + 1;
            }
            freshnode.next = this.temp.next;
            this.temp.next = freshnode;
            this.size++;
        }
        public override void Display()
        {


            this.temp = this.head;
            while (this.temp != null)
            {
                if (this.temp.next != null)
                {
                    Console.Write(this.temp.data + "->");
                    this.temp = this.temp.next;
                }
                else
                {
                    Console.Write(this.temp.data + "\n");
                    this.temp = this.temp.next;
                }
            }

        }

        public override void RemoveAtEnd()
        {
            this.temp = this.head;
            while (this.temp.next.next != null)
            {
                this.temp = this.temp.next;
            }
            temp.next = null;
            this.size--;
        }
        public void RemoveAtBetween()
        {
            this.temp = this.head;
            Console.Write("Enter where you want to remove");
            int pos = int.Parse(Console.ReadLine());
            int count = 1;
            while(pos!=count)
            {
                count++;
               // Console.WriteLine(temp.data);
               this.temp = this.temp.next;
            }
            this.temp.next = this.temp.next.next;
            this.size--;
        }
        public void RemoveAtStart()
        {
            this.head = this.head.next;
            this.size--;
        }

        public override void Sorter()
        {
            for (int itr = 0; itr <= this.size; itr++)
            {
                DataStructure travhead = this.head;
                DataStructure travhead1 = this.head.next;
                for (int itr2 = 1; itr2 < this.size; itr2++)
                {
                    if (travhead.data > travhead1.data)
                    {
                        int temp = travhead.data;
                        travhead.data = travhead1.data;
                        travhead1.data = temp;
                    }
                    travhead = travhead1;
                    travhead1 = travhead1.next;
                }
            }
        }

    }
}
