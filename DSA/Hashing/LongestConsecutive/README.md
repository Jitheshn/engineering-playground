# Longest Consecutive Sequence

## Problem Statement

Given an unsorted array of integers `nums`, return the length of the longest consecutive elements sequence.

A consecutive sequence is a sequence of integers in which each number is exactly one greater than the previous number. The elements do not need to appear next to each other in the input array.

**Example 1**

Input:
```text
nums = [100, 4, 200, 1, 3, 2]
```

Output:
```text
4
```

Explanation: The longest consecutive sequence is `[1, 2, 3, 4]`, so the answer is `4`.

**Example 2**

Input:
```text
nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
```

Output:
```text
9
```

Explanation: The longest consecutive sequence is `[0, 1, 2, 3, 4, 5, 6, 7, 8]`, so the answer is `9`.

## Pattern Identification

- **Data Structure:** Hash Set
- **Pattern:** Sequence detection using constant-time lookups
- **Key idea:** Only start counting from a number that does not have a predecessor (`num - 1`) in the set.

## Approach

1. Handle the edge cases: if the input is `null` or empty, return `0`.
2. Add all array values to a `HashSet<int>`. This removes duplicates and allows average O(1) membership checks.
3. Iterate through each unique number in the set.
4. Check whether the current number is the beginning of a consecutive sequence:
   - If `num - 1` exists, the current number is part of a sequence that started earlier, so skip it.
   - If `num - 1` does not exist, this number is the start of a new sequence.
5. Starting from that number, keep checking whether the next number (`currentNum + 1`) exists in the set. Increase the current streak for each match.
6. Update the longest streak and return it after processing all numbers.

This avoids recounting the same sequence from every element. Each sequence is expanded only from its starting value.

## C# Implementation

See [`Solution.cs`](./Solution.cs).

```csharp
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> numSet = [.. nums];
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
```

## Complexity Analysis

Let `n` be the number of elements in the input array.

- **Time Complexity:** O(n) average.
  - Building the hash set takes O(n) average time.
  - The outer loop visits each unique value once.
  - The inner `while` loops collectively advance through each consecutive sequence without repeatedly scanning it from every element. Hash set lookups are O(1) on average.
- **Space Complexity:** O(n), for the hash set containing the unique input values.

## Key Takeaways

- A hash set is useful when fast membership checks are needed.
- Checking for the absence of a predecessor identifies the start of a sequence.
- Starting expansion only at sequence beginnings prevents unnecessary repeated work.
- The approach achieves average O(n) time without sorting the input.
