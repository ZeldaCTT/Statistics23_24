int[] myArray = new int[] { 1, 2, 3, 4, 5 };

// Loop over the array
foreach (int item in myArray)
{
    Console.WriteLine(item);
}

// Add an element
myArray = myArray.Concat(new int[] { 6 }).ToArray();

// Remove an element
myArray = myArray.Where(item => item != 3).ToArray();

// Get/Set an element
int element = myArray[0];
myArray[1] = 42;

// Check existence of an element
bool exists = myArray.Contains(4);
