using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Stack: DataStructure
    {
        public override void InsertAtEnd()
        {
            
         if(this.head == null)
            {
                this.head = new Stack();
                this.head.next = null;
                Console.WriteLine("enter data for push");
                this.head.data = int.Parse(Console.ReadLine());
               
            }
            else
            {
               Stack freshnode = new Stack();
                freshnode.next = this.head;
                Console.WriteLine("enter data for push");
                freshnode.data = int.Parse(Console.ReadLine());
                this.head = freshnode;
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
                    Console.Write(this.temp.data + "\n"+"Top: "+head.data+"\n");
                    this.temp = this.temp.next;
                }
            }
           
        }
        public override void Sorter()
        {
         for(int itr=0;itr<=this.size;itr++)
            {
                DataStructure travhead = this.head;
                DataStructure travhead1 = this.head.next;
                for (int itr2=1;itr2<this.size;itr2++)
                {
                    if(travhead.data >travhead1.data)
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
