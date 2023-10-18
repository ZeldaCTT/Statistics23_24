Dictionary<string, int> myDictionary = new Dictionary<string, int>
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 }
};

// Loop over the dictionary
foreach (var pair in myDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// Add an element
myDictionary["four"] = 4;

// Remove an element
myDictionary.Remove("two");

// Get an element
int value;
if (myDictionary.TryGetValue("three", out value))
{
    Console.WriteLine($"Value of 'three': {value}");
}

// Check existence of an element
bool exists = myDictionary.ContainsKey("one");
