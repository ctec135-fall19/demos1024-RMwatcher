using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks
            // declaration
            Stack<student> stackOfStudents = new Stack<student>();

            // push objects onto stack
            stackOfStudents.Push(new student("Bill"));
            stackOfStudents.Push(new student("JIll"));
            stackOfStudents.Push(new student("Jack"));

            // traversal
            foreach (student s in stackOfStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            // pops
            int size = stackOfStudents.Count;
            for (int i = 0; i < size; i++) {
                Console.WriteLine(stackOfStudents.Pop().Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            // queue
            Queue<student> studentQueue = new Queue<student>();

            // put items in the queue
            studentQueue.Enqueue(new student("Bill"));
            studentQueue.Enqueue(new student("Jill"));
            studentQueue.Enqueue(new student("Jack"));

            // traversal
            foreach (student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            size = studentQueue.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();
        }
    }
}
