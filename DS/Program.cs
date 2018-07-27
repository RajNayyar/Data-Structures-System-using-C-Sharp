using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int _option = 0;
            int _furtherOption = 1;
            int _size;
            while (true)
            {
                Console.WriteLine("Press 1 to implement LinkedList\n2 to implement Stack\n3 to implement queue\n4 to exit");
                _option = int.Parse(Console.ReadLine());
                if (_option == 1)
                {
                    LinkedList list = new LinkedList();
                    Console.WriteLine("First Create a Linked List:");
                    Console.WriteLine("Enter The size of linked list");
                    _size = int.Parse(Console.ReadLine());
                    for (int j = 0; j < _size; j++)
                    {
                        list.CreateNode();              //function 
                    }
                    list.Display();
                    while (true)
                    {
                        Console.WriteLine("Enter 1 to insert in between, 2 to insert at end and 3 to insert at begining\nEnter 4 to delete in between, 5 to delete at end and 6 to delete at begining,\n7 to SORT\n8 to exit");
                        _furtherOption = int.Parse(Console.ReadLine());

                        if (_furtherOption == 1)
                        {
                            list.InsertAtBetween();
                            list.Display();
                        }
                        else if (_furtherOption == 2)
                        {
                            list.InsertAtEnd();
                            list.Display();//function//function//function
                        }
                        else if (_furtherOption == 3)
                        {

                            list.InsertAtStart();
                            list.Display();//function//function
                        }
                        else if (_furtherOption == 4)
                        {
                            list.RemoveAtBetween();
                            list.Display();
                        }
                        else if (_furtherOption == 5)
                        {
                            list.RemoveAtEnd();
                            list.Display();//function//function//function
                        }
                        else if (_furtherOption == 6)
                        {
                            //
                            list.RemoveAtStart();
                            list.Display();//function//function
                        }
                        else if (_furtherOption == 7)
                        {
                            list.Sorter();
       
                            list.Display();
                        }
                        else if (_furtherOption == 8)
                        {
                            break;
                        }
                    }

                }
                else if (_option == 2)
                {
                    DataStructure stack = new Stack();
                    while (true)
                    {

                        Console.WriteLine("Press 1 to push\n2 to pop\n3 to Sort\n4 to end");
                        _furtherOption = int.Parse(Console.ReadLine());
                        if (stack.head == null)
                        {
                            Console.WriteLine("Stack Empty. Push elements");
                        }

                        if (_furtherOption == 1)
                        {
                            //Console.WriteLine("Working");
                            stack.InsertAtEnd();
                            stack.Display();
                        }
                        if (_furtherOption == 2)
                        {
                            if (stack.head != null)
                            {
                                stack.RemoveAtEnd();
                                stack.Display();
                            }
                            else
                            {
                                Console.WriteLine("Can't pop\nStack empty");
                            }
                        }
                        else if (_furtherOption == 3)
                        {
                            stack.Sorter();
                            stack.Display();
                        }
                        else if (_furtherOption == 4)
                        {
                            break;
                        }

                    }
                }
                else if (_option == 3)
                {
                    DataStructure queue = new Queue();
                    while (true)
                    {
                        Console.WriteLine("Press 1 to enqueue\n2 to dequeue\n3 to sort\n4 to exit");
                        _furtherOption = int.Parse(Console.ReadLine());
                        if (_furtherOption == 1)
                        {
                            queue.InsertAtEnd();
                            queue.Display();
                        }
                        if (_furtherOption == 2)
                        {
                            if (queue.head == null)
                            {
                                Console.WriteLine("Queue Empty. please enqueue");
                            }
                            else
                            {
                                queue.RemoveAtEnd();
                                queue.Display();
                            }
                        }

                        else if (_furtherOption == 3)
                        {
                            queue.Sorter();
                            queue.Display();
                        }
                        else if (_furtherOption == 4)
                        {
                            break;
                        }
                    }
                    // Console.ReadKey();


                }
            }


        }
    }
}