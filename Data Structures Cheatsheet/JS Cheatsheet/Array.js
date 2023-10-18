let myArray = [1, 2, 3, 4, 5];

// Loop over the array
myArray.forEach(item => {
    console.log(item);
});

// Add an element
myArray.push(6);

// Remove an element
myArray = myArray.filter(item => item !== 3);

// Get/Set an element
let element = myArray[0];
myArray[1] = 42;

// Check existence of an element
let exists = myArray.includes(4);