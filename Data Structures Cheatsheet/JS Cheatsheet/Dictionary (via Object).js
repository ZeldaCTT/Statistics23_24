let myObject = {
    one: 1,
    two: 2,
    three: 3
};

// Loop over the object
for (let key in myObject) {
    console.log(`${key}: ${myObject[key]}`);
}

// Add an element
myObject.four = 4;

// Remove an element
delete myObject.two;

// Get an element
let value = myObject.three;
console.log(`Value of 'three': ${value}`);

// Check existence of an element
let exists = 'one' in myObject;
