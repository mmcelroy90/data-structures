using System;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node nextNode;

        public Node(int num)
        {
            data = num;
            nextNode = null;
        }

        public void AddToEnd(int data)
        {
            if(nextNode == null)
            {
                nextNode = new Node(data);
            }
            else
            {
                nextNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if(nextNode == null)
            {
                nextNode = new Node(data);
            }
            else if(data < nextNode.data)
            {
                var temp = new Node(data)
                {
                    nextNode = nextNode
                };
                nextNode = temp;
            }
            else
            {
                nextNode.AddToEnd(data);
            }
        }

        public void Remove(int data, Node previousNode)
        {
            if(nextNode == null)
            {
                return;
            }
            else if(nextNode.data == data && nextNode.nextNode == null)
            {
                nextNode = null;
            }
            else if(nextNode.data == data && nextNode.nextNode != null)
            {
                previousNode.nextNode = nextNode.nextNode;
            }
            else
            {
                nextNode.Remove(data, nextNode);
            }
        }

        public void Print()
        {
            Console.Write($"{data} -> ");
            if(nextNode != null)
            {
                nextNode.Print();
            }
        }
    }
}
