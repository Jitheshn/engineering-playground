# 2. Add Two Numbers

**Platform:** LeetCode  
**Problem:** [2. Add Two Numbers](https://leetcode.com/problems/add-two-numbers/)  
**Primary category:** Linked List  
**Related topics:** Math, Linked List Traversal, Carry Handling  
**Language:** C#

## Problem Description

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in **reverse order**, and each node contains a single digit.

Add the two numbers and return their sum as a linked list, also with its digits stored in reverse order.

You may assume that the two numbers do not contain any leading zero, except for the number `0` itself.

### Example 1

**Input:**
```text
l1 = [2,4,3]
l2 = [5,6,4]
```

**Output:**
```text
[7,0,8]
```

**Explanation:** `342 + 465 = 807`.

### Example 2

**Input:**
```text
l1 = [0]
l2 = [0]
```

**Output:**
```text
[0]
```

## Approach

Traverse both linked lists from head to tail. Since the digits are stored in reverse order, this visits the numbers from least significant digit to most significant digit.

For each position:
1. Start with the carry from the previous position.
2. Add the current digit from each list, if that node exists.
3. Store the ones digit (`sum % 10`) in a new result node.
4. Carry the remaining value (`sum / 10`) to the next position.
5. Continue until both input lists are exhausted and there is no remaining carry.

See [`Solution.cs`](Solution.cs) for my original implementation.

## Complexity Analysis

Let `m` and `n` be the lengths of the two input linked lists.

- **Time complexity:** `O(max(m, n))` — each input node is visited once.
- **Auxiliary space complexity:** `O(1)` — excluding the result list.
- **Output space complexity:** `O(max(m, n))` — the result list may contain one additional node for a final carry.

## Submission Result

- **Runtime:** 1 ms
- **Runtime percentile:** Beats 96.21%
- **Memory:** 52.76 MB
- **Memory percentile:** Beats 51.36%

*These are the results shown for my submission at the time of submission. LeetCode measurements and percentiles may vary.*

## Files

- [`Solution.cs`](Solution.cs) — C# solution
- `README.md` — Problem description, approach, and complexity analysis

> Note: `ListNode` is provided by LeetCode for this problem, so it is not redefined in `Solution.cs`.
