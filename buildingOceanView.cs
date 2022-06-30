// Name: Building view
// Url: https://leetcode.com/problems/buildings-with-an-ocean-view/
// Level: Medium
// Method: greedy
// Time: O(n)
// Space: O(n)

var oceanViews = FindBuildings(new int[] { 4, 2, 3, 1 });

Console.WriteLine("Is able to see the ocean {0}", string.Join(',', oceanViews));

int[] FindBuildings(int[] heights)
{
    var buildings = new List<int>();
    var heightest = heights[heights.Length - 1];

    buildings.Add(heights.Length - 1);

    for (int i = heights.Length - 2; i >= 0; i--)
    {
        if (heights[i] > heightest)
        {
            buildings.Insert(0, i);
            heightest = heights[i];
        }
    }

    return buildings.ToArray();
}
