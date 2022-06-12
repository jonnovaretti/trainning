// Name: Eating min speed
// Url: https://leetcode.com/problems/koko-eating-bananas/
// Level: Medium
// Method: binary search
// Time: O(n*log n)
// Space: (1)

var minSpeed = MinEatingSpeed(new int[] { 3, 6, 7, 11 }, 8);

Console.WriteLine("The min speed to eat bananas is {0}", minSpeed);

int MinEatingSpeed(int[] piles, int h)
{
    int start = 1;
    int end = piles.Max();

    while (start < end)
    {
        int mid = (start + end) / 2;
        int hours = 0;

        foreach (var pile in piles)
            hours += (int)Math.Ceiling((decimal)pile / mid);

        if (hours <= h)
            end = mid;
        else
            start = mid + 1;
    }

    return end;
}
