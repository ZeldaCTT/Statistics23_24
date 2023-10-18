//In C#, you can use SortedList for a sorted list and SortedSet for a sorted set. The basic operations are similar to lists and sets.

SortedSet<int> mySortedSet = new SortedSet<int> { 1, 3, 2, 5, 4 };

// Add an element
mySortedSet.Add(6);

// Remove an element
mySortedSet.Remove(2);

// Get an element
int firstElement = mySortedSet.First();

// Check existence of an element
bool exists = mySortedSet.Contains(4);
