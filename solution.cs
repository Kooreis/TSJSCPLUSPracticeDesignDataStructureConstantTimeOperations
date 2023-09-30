insert(val) {
        if (this.map.has(val)) {
            return false;
        }
        this.map.set(val, this.arr.length);
        this.arr.push(val);
        return true;
    }