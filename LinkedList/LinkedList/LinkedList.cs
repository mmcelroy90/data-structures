using System;

namespace LinkedList
{
    class LinkedList
    {
        public Node headNode;

        public LinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                var tempNode = new Node(data)
                {
                    nextNode = headNode
                };
                headNode = tempNode;
            }
        }

        public void AddSorted(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else if(data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void Remove(int data)
        {
            if(headNode.data == data && headNode.nextNode == null)
            {
                headNode = null;
            }
            else if(headNode.data == data && headNode.nextNode != null)
            {
                headNode = headNode.nextNode;
            }
            else
            {
                headNode.Remove(data, headNode);
            }
        }

        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
            else
            {
                Console.Write("Empty LinkedList!");
            }
            Console.WriteLine();
        }
    }
}
