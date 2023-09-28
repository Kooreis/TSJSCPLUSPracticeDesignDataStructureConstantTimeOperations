Here is a TypeScript solution using a Map and an Array to achieve constant time complexity for insert, delete, search, and getRandom operations:

```typescript
class RandomizedSet {
    private map: Map<number, number>;
    private arr: number[];

    constructor() {
        this.map = new Map();
        this.arr = [];
    }

    insert(val: number): boolean {
        if (this.map.has(val)) {
            return false;
        }
        this.map.set(val, this.arr.length);
        this.arr.push(val);
        return true;
    }

    remove(val: number): boolean {
        if (!this.map.has(val)) {
            return false;
        }
        const lastElement = this.arr[this.arr.length - 1];
        const idx = this.map.get(val);
        this.arr[idx] = lastElement;
        this.map.set(lastElement, idx);
        this.arr.pop();
        this.map.delete(val);
        return true;
    }

    search(val: number): boolean {
        return this.map.has(val);
    }

    getRandom(): number {
        const randomIdx = Math.floor(Math.random() * this.arr.length);
        return this.arr[randomIdx];
    }
}

const set = new RandomizedSet();
console.log(set.insert(1)); // true
console.log(set.insert(2)); // true
console.log(set.search(1)); // true
console.log(set.remove(1)); // true
console.log(set.search(1)); // false
console.log(set.getRandom()); // 2
```

In this solution, a Map is used to store the values and their corresponding indices in the array. The array is used to store the values. This allows for constant time complexity for insert, delete, and search operations. The getRandom method generates a random index and returns the value at that index in the array, which also has a constant time complexity.