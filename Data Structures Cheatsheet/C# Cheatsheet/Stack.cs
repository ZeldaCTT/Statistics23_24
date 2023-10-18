Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

// Loop over the stack
foreach (int item in myStack)
{
    Console.WriteLine(item);
}

// Add an element
myStack.Push(4);

// Remove an element
int removedItem = myStack.Pop();

// Check existence of an element
bool exists = myStack.Contains(2);
