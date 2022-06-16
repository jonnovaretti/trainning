//***********************************************************

// Name: Time based key value store
// Url: https://leetcode.com/problems/time-based-key-value-store/
// Level: Medium
// Method: binary search
// Time: O(log n)
// Space: O(n+m)

var timeMap = new TimeMap();

timeMap.Set("love", "high", 10);
timeMap.Set("love", "low", 20);
var r3 = timeMap.Get("love", 5);
Console.WriteLine("The value found is {0}", r3);
var r4 = timeMap.Get("love", 10);
Console.WriteLine("The value found is {0}", r4);
var r5 = timeMap.Get("love", 15);
Console.WriteLine("The value found is {0}", r5);
var r11 = timeMap.Get("love", 20);
Console.WriteLine("The value found is {0}", r11);
var r25 = timeMap.Get("love", 25);
Console.WriteLine("The value found is {0}", r11);

//***********************************************************

public class TimeMap
{
    public Dictionary<string, List<(int, string)>> dic = new Dictionary<string, List<(int, string)>>();

    public void Set(string key, string value, int timestamp)
    {
        if (dic.ContainsKey(key))
        {
            dic[key].Add((timestamp, value));
        }
        else
        {
            var tuples = new List<(int, string)>();
            tuples.Add((timestamp, value));

            dic.Add(key, tuples);
        }
    }

    public string Get(string key, int timestamp)
    {
        if (dic.ContainsKey(key))
        {
            var tuples = dic[key];
            return BinarySearchTime(timestamp, tuples);
        }

        return "";
    }

    public string BinarySearchTime(int num, List<(int, string)> list)
    {
        int left = 0, right = list.Count - 1;

        while (left < right)
        {
            var mid = (right + left) / 2;

            if (list[mid].Item1 < num)
                left = mid + 1;
            else if (list[mid].Item1 > num)
                right = mid - 1;
            else
                return list[mid].Item2;
        }

        return list[left].Item1 > num && left > 0 ? list[left - 1].Item2 : list[left].Item2;
    }
}
