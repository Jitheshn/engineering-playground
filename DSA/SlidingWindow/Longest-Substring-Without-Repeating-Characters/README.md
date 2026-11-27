# Longest Substring Without Repeating Characters

**LeetCode:** [3. Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/)

**Difficulty:** Medium

**Pattern:** Sliding Window

## Problem

Given a string `s`, find the length of the longest substring without repeating characters.

## Approach: Optimized Sliding Window

Use two pointers (`start` and `end`) to maintain a sliding window containing unique characters.

Maintain a `lastSeen` array to track the most recent index of every character.

### Key Logic

```csharp
int prev = lastSeen[s[end]];

if (prev >= start)
    start = prev + 1;
```

- Retrieve the previous occurrence of the current character.
- If it exists within the current window, move `start` immediately after that occurrence.
- Update the character's latest index.
- Calculate the current window length and update the maximum.

### Why `prev >= start`?

This condition ensures that we only move the starting pointer when the previous occurrence belongs to the current window.

Without this check, we might accidentally move the window backwards.

### Example

**Input:**

```text
s = "abcabcbb"
```

**Sliding Window:**

| Character | Current Window | Max Length |
|---|---|---:|
| a | a | 1 |
| b | ab | 2 |
| c | abc | 3 |
| a | bca | 3 |
| b | cab | 3 |
| c | abc | 3 |

**Output:**

```text
3
```

## Complexity Analysis

- **Time Complexity:** O(n) – Each character is processed once.
- **Space Complexity:** O(1) – Fixed-size array of 128 characters (ASCII assumption).

## Key Takeaway

Instead of shrinking the sliding window one character at a time, we directly jump the `start` pointer to the position after the previous occurrence.

This optimization makes the sliding window approach efficient with a single pass through the string.
