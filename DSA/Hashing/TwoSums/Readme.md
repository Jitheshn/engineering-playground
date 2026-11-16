
# Two Sum – C#

## Problem

Given an integer array `nums` and an integer `target`, return the indices of two numbers whose sum equals the target.

### Constraints
- Exactly one valid solution exists.
- The same element cannot be used twice.
- The answer can be returned in any order.

## Approach: One-Pass Hash Dictionary

Use a `Dictionary<int, int>` to store numbers and their corresponding indices.

For every element:
1. Calculate the complement: `target - nums[i]`.
2. Check whether the complement exists in the dictionary.
3. If found, return both indices.
4. Otherwise, insert the current number and its index.

## Solution

See `Solution.cs`.

## Example

**Input:**
```text
nums = [2, 7, 11, 15]
target = 9
```

**Output:**
```text
[0, 1]
```

## Complexity Analysis

| Metric | Complexity |
|---|---|
| Time | O(n) average |
| Space | O(n) |

## Optimizations

- Dictionary preallocation using `new(nums.Length)` reduces resizing.
- `TryGetValue()` performs efficient lookup.
- `TryAdd()` avoids overwriting existing keys.
- Early return stops execution once a solution is found.

## Key Takeaway

The Two Sum problem demonstrates how a hash dictionary improves brute-force O(n²) time complexity to O(n) average time complexity.

**General pattern:**

Find complement → Check dictionary → Insert current element.
