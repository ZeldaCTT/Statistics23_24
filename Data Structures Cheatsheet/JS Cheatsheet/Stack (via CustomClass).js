//In JavaScript, you can implement a stack using an array and follow similar principles to the Array section.
class Stack {

    constructor() { //constructor of the class

        this.items = [];

    }

    push(item) { //add item to stack

        this.items.push(item);

    }

    pop() { //remove item from stack

        return this.items.pop();

    }

    first() { //returns first elem of the stack

        return this.items[this.items.length - 1];

    }

    isEmpty() { //checks if stack is empty

        return this.items.length === 0;

    }

    contains(elem) { //checks if stack contains elem

        return this.items.includes(elem);

    }

}