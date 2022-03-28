using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
     class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }
        public void DisplayStack()
        {
            
            linkedList.Display();
        }
        public void Top()
        {
            var item = linkedList.Head;
            Console.WriteLine(item.data);
        }
    }
}
