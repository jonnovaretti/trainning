// Name: Binary search
// Url: https://leetcode.com/problems/binary-search/
// Level: Easy
// Method: binary search
// Time: O(logn)
// Space: O(1)

var indexFound = BinarySearch(new int[] { 5 }, 5);

Console.WriteLine("The target is in the index {0}", indexFound);

int BinarySearch(int[] nums, int target)
{
    int start = 0;
    int end = nums.Length - 1;

    while (start <= end)
    {
        int mid = nums.Length / 2;

        if (nums[mid] > target) end = mid - 1;
        else if (nums[mid] < target) start = mid + 1;
        else return mid;
    }

    return -1;
}
