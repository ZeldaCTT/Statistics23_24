//In JavaScript, there is no built -in linked list, but you can implement one using custom objects or classes.

class ListNode {

    constructor(data) {

        this.data = data;

        this.next = null;

    }

}

class LinkedList {

    constructor() {

        this.head = null;

        this.size = 0;

    }



    add(data) {

        const node = new ListNode(data);

        if (!this.head) {

            this.head = node;

        } else {

            let current = this.head;

            while (current.next) {

                current = current.next;

            }

            current.next = node;

        }

        this.size++;

    }





    remove(data) {

        let current = this.head;

        let previous = null;



        while (current) {

            if (current.data == data) {

                if (!previous) {

                    this.head = current.next;

                } else {

                    previous.next = current.next;

                }

                this.size--;

                return current.data;

            }

            previous = current;

            current = current.next;

        }



        return null;

    }



    retrieve(elem) {

        let current = this.head;

        for (let i = 0; i < elem; i++) {

            if (!current) return null;

            current = current.next;

        }

        return current.data;

    }



    exists(data) {

        var current = this.head;

        while (current) {

            if (current.data == data) {

                return true;

            }

            current = current.next;

        }

        return false;

    }

    isEmpty() {

        if (this.size == 0) return true;

        return false;

    }

    getSize() {

        return this.size;

    }

}