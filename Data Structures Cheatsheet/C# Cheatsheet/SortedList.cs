//In C#, you can use SortedList for a sorted list and SortedSet for a sorted set. The basic operations are similar to lists and sets.

SortedList<string, int> mySortedList = new SortedList<string, int>
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 }
};

// Add an element
mySortedList.Add("four", 4);

// Remove an element
mySortedList.Remove("two");

// Get an element
int value = mySortedList["three"];

// Check existence of an element
bool exists = mySortedList.ContainsKey("one");
