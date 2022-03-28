using System;
namespace StackQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node firstNode = new Node(70);
            Node secondNode = new Node(30);
            Node thirdNode = new Node(56);

            Stack stack = new Stack();  //Stack
            stack.Push(firstNode);
            stack.Push(secondNode);
            stack.Push(thirdNode);
            stack.DisplayStack();


        }

    }
}