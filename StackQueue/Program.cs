using System;
namespace StackQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node firstNode = new Node(56);
            Node secondNode = new Node(30);
            Node thirdNode = new Node(70);

            //Stack stack = new Stack();  //Stack
            //stack.Push(firstNode);
            //stack.Push(secondNode);
            //stack.Push(thirdNode);
            //stack.DisplayStack();

            //stack.Pop();
            //stack.DisplayStack();
            Queue queue = new Queue();  //Adding Element in Queue
            queue.Enqueue(firstNode);
            queue.Enqueue(secondNode);
            queue.Enqueue(thirdNode);
            queue.DisplayQueue();
            queue.Dequeue();
            queue.DisplayQueue();
        }

    }
}