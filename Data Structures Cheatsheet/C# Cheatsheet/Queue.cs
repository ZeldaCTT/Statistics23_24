//In C#, you can use the Queue<T> class.

Queue<int> myQueue = new Queue<int>();
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);

// Loop over the queue
foreach (int item in myQueue)
{
    Console.WriteLine(item);
}

// Add an element
myQueue.Enqueue(4);

// Remove an element
int removedItem = myQueue.Dequeue();

// Check existence of an element
bool exists = myQueue.Contains(2);
