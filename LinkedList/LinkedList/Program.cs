namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            var linkedList = new LinkedList();

            linkedList.AddToEnd(9);
            linkedList.AddToEnd(11);
            linkedList.AddToBeginning(2);
            linkedList.AddSorted(7);
            linkedList.Remove(9);
            linkedList.Remove(2);
            linkedList.AddSorted(8);
            linkedList.Print();
        }
    }
}
