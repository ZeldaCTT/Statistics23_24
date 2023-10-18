//In C#, you can use the List<T> class, which is similar to an array but more flexible.

List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

// Loop over the list
foreach (int item in myList)
{
    Console.WriteLine(item);
}

// Add an element
myList.Add(6);

// Remove an element
myList.Remove(3);

// Get/Set an element
int element = myList[0];
myList[1] = 42;

// Check existence of an element
bool exists = myList.Contains(4);
