LinkedList<int> myLinkedList = new LinkedList<int>();
myLinkedList.AddLast(1);
myLinkedList.AddLast(2);
myLinkedList.AddLast(3);

// Loop over the linked list
foreach (int item in myLinkedList)
{
    Console.WriteLine(item);
}

// Add an element
myLinkedList.AddLast(4);

// Remove an element
LinkedListNode<int> node = myLinkedList.Find(2);
if (node != null)
{
    myLinkedList.Remove(node);
}

// Check existence of an element
bool exists = myLinkedList.Contains(3);
