// Name: Car fleet
// Url: https://leetcode.com/problems/car-fleet/
// Level: Medium
// Method: sort and stack
// Time: O(nlogn)
// Space: O(n)

var carFleetQuantity = CarFleet(14, new int[] { 10, 8, 0, 5, 3 }, new int[] { 2, 4, 9, 3, 6 });

Console.WriteLine("The quantity of car fleet is {0}", carFleetQuantity);

int CarFleet(int target, int[] position, int[] speed)
{
    var totalCars = position.Length - 1;
    var stack = new Stack<decimal>();

    Array.Sort(position, speed);

    for (int i = totalCars; i > 0; i--)
    {
        var pos = position[i];
        var sp = speed[i];
        var sum = (decimal)(target - pos) / (decimal)sp;

        if (stack.Count == 0)
            stack.Push(sum);

        if (sum > stack.Peek())
            stack.Push(sum);
    }

    return stack.Count;
}
