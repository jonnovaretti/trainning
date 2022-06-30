// Name: Minimum moves to equal array
// Url: https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii
// Level: Medium
// Method: find medium
// Time: O(nlogn)
// Space: O(1)

var moves = MinMoves2(new int[] { 1, 4, 2, 10, 9 });

Console.WriteLine("Total moves {0}", moves);

int MinMoves2(int[] nums)
{
    int mid, count = 0;

    Array.Sort(nums);

    mid = nums[nums.Length / 2];

    foreach (var num in nums)
        count += Math.Abs(mid - num);

    return count;
}
