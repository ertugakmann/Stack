using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private Node top;
        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public Stack(int data)
        {
            Node newNode = new Node(data);
            top = newNode;
            count = 1;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);

            if(count == 0)
            {
                newNode = top;
            }
            else
            {
                newNode.next = top;
                top = newNode;
                newNode = top;
            }
            count++;
        }

        public void PrintAll()
        {
            Node temp = top;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void PrintTop()
        {
            Console.WriteLine("The top of Stack : " + top.data);
        }

        public void PrintCount()
        {
            Console.WriteLine("The count of Stack : " + count);
        }
    }
}