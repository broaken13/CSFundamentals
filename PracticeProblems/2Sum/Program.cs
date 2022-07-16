/*
Found on leetcode at https://leetcode.com/problems/two-sum/

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/

public class Program {
    public static void Main() {
        int[] nums = new int[] { 1, 3, 7, 14 };
        int target = 10;
        var sol = new Solution();
        var answer = sol.TwoSum(nums, target);
        Console.WriteLine("Expecting an answer of [1,2]");
        Console.WriteLine($"Got an answer of [{answer[0]}, {answer[1]}]");
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numberIndexMapping = new Dictionary<int, int>();
        numberIndexMapping.Add(nums[0], 0);
        for (int i = 1; i < nums.Length; i++){
            if (numberIndexMapping.ContainsKey(target - nums[i])) {
                return new int[] { i, numberIndexMapping[target - nums[i]]};
            } else {
                numberIndexMapping[nums[i]] = i;
            }
        }

        return new int[] { -1, -2 };
    }
}
