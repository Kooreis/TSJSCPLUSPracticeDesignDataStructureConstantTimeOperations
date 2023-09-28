Here is a JavaScript solution using a combination of an array and a map to achieve constant time complexity for insert, delete, search, and getRandom operations.

```javascript
class RandomizedSet {
    constructor() {
        this.map = new Map();
        this.arr = [];
    }

    insert(val) {
        if (this.map.has(val)) {
            return false;
        }
        this.map.set(val, this.arr.length);
        this.arr.push(val);
        return true;
    }

    delete(val) {
        if (!this.map.has(val)) {
            return false;
        }
        let index = this.map.get(val);
        let lastElement = this.arr[this.arr.length - 1];
        this.arr[index] = lastElement;
        this.map.set(lastElement, index);
        this.arr.pop();
        this.map.delete(val);
        return true;
    }

    search(val) {
        return this.map.has(val);
    }

    getRandom() {
        let randomIndex = Math.floor(Math.random() * this.arr.length);
        return this.arr[randomIndex];
    }
}

let set = new RandomizedSet();
set.insert(1);
set.insert(2);
set.insert(3);
console.log(set.search(2)); // true
console.log(set.getRandom()); // random number from 1, 2, 3
set.delete(1);
console.log(set.search(1)); // false
```

This code defines a class `RandomizedSet` with four methods: `insert`, `delete`, `search`, and `getRandom`. The `insert` method adds a value to the set, the `delete` method removes a value from the set, the `search` method checks if a value is in the set, and the `getRandom` method returns a random value from the set. All these operations are performed in constant time.