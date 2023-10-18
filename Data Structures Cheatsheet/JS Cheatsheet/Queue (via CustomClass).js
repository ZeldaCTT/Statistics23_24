//In JavaScript, you can implement a queue using an array and follow similar principles to the Array section.

class Queue {

    constructor() { //constructor of the class

        this.items = {};

        this.head = 0;

        this.tail = 0;

    }

    enqueue(item) { //adds item to the end of the queue

        this.items[this.tail] = item;

        this.tail++;

    }

    dequeue() { //removes top item from the queue

        const item = this.items[this.head];

        delete this.items[this.head];

        this.head++;

        return item;

    }

    first() { //returns first item in the queue

        return this.items[this.head];

    }

    isEmpty() { //checks if queue is empty

        return this.tail === this.head;

    }

    contains(elem) { //checks if elem is inside the queue

        return this.items.includes(elem);

    }

}