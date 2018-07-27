using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Queue : DataStructure
    {
        public override void InsertAtEnd()
        {
            if (this.head == null)
            {
                this.head = new Queue();
                Console.WriteLine("enter data for enqueue");
                this.head.data = int.Parse(Console.ReadLine());
                this.temp = this.head;
            }
            else
            {
                DataStructure freshnode = new Queue();
                freshnode.next = null;
                Console.WriteLine("enter data for enqueue");
                freshnode.data = int.Parse(Console.ReadLine());
                this.temp.next = freshnode;
                this.temp = this.temp.next;
            }
            this.size++;
        }
       
        public override void RemoveAtEnd()
        {
            this.head = this.head.next;
            this.size--;
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
                    if(this.temp.next==null)
                    {
                        Console.WriteLine("Peek/Front: "+ this.head.data);
                        break;
                    }
                }
            }
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

