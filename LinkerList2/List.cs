using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkerList2
{
    public class List
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public List() 
        {
            Head = null;
            Tail = null;
        }
        public List(Node head, Node tail)
        {
            Head = head;
            Tail = tail;
        }

        public void PushBack(Student student)
        {
            if (Head != null)
            {
                Head = new Node(student);
                Tail = new Node(student);
                return;
            }

            var pointer = Tail;
            pointer = pointer.Next;
            pointer.student = student;
            Tail = pointer.Next;
            
        }

        public void Print()
        {
            var pointer = Head;
            if (pointer == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            while (pointer != null)
            {
                pointer.student.Print();
                pointer = pointer.Next;
            }
        }

        public void DeleteFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }
            Head = Head.Next;
            Head.Previous = null;
        }

        public void DeleteLast()
        {
            if (Head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }
            Tail = Tail.Previous;
            Tail.Next = null;
        }

        public void DeleteById(int id)
        {
            if (Head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            var pointer = Head;
            while (pointer != null)
            {
                if (pointer.student.Id == id)
                {
                    if (pointer.Previous == null)
                    {
                        DeleteFirst();
                        return;
                    }

                    if (pointer.Next == null)
                    {
                        DeleteLast();
                        return;
                    }

                    pointer.Previous.Next = pointer.Next;
                    pointer.Next.Previous = pointer.Previous;
                }
                pointer = pointer.Next;
            }
        }

        public void SearchByName(string name)
        {
            if (Head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            var pointer = Head;
            while (pointer != null)
            {
                if (pointer.student.Name == name)
                {
                    pointer.student.Print();
                }
                pointer = pointer.Next;
            }
        }

        public void UpdateName(string name)
        {

        }
    }
}
