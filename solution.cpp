```cpp
#include <bits/stdc++.h>
using namespace std;

class RandomizedSet {
    vector<int> nums;
    unordered_map<int, int> numMap;
public:
    RandomizedSet() {
        srand(time(0));
    }
    
    bool insert(int val) {
        if(numMap.count(val)) return false;
        nums.push_back(val);
        numMap[val] = nums.size() - 1;
        return true;
    }
    
    bool remove(int val) {
        if(!numMap.count(val)) return false;
        int last = nums.back();
        numMap[last] = numMap[val];
        nums[numMap[val]] = last;
        nums.pop_back();
        numMap.erase(val);
        return true;
    }
    
    int search(int val) {
        if(numMap.count(val)) return numMap[val];
        else return -1;
    }
    
    int getRandom() {
        return nums[rand() % nums.size()];
    }
};

int main() {
    RandomizedSet* obj = new RandomizedSet();
    bool param_1 = obj->insert(1);
    bool param_2 = obj->remove(2);
    int param_3 = obj->search(1);
    int param_4 = obj->getRandom();
    return 0;
}
```