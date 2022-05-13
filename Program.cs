using System.Text;
using System.Text.RegularExpressions;
using static Solution;

// replace char using Builder
// builderNum[i] = Convert.ToChar(substraction.ToString()); 

// convert array char in string
// return new string(chars);

var resultInt = 0;
Solution solution = new Solution();

// ************************ Explore Multidimentional Array

var lands = new char[][]{
  new char[] {'1','1','1'},
  new char[] {'0','1','0'},
  new char[] {'1','1','1'}
};

resultInt = solution.NumIslands(lands);

Console.WriteLine("Total island " + resultInt);

// *********************** Manipulate String

var emails = new string[] { "test.email+alex@leetcode.com", "test.email.leet+alex@code.com" };

resultInt = solution.NumUniqueEmails(emails);

Console.WriteLine("Total unique emails " + resultInt);

// ********************** Range Array, Slide window

var fruits = new int[] { 1, 2, 1 };

resultInt = solution.TotalFruit(fruits);

Console.WriteLine("Total fruits " + resultInt);

// ******************** Range Array

resultInt = solution.LengthOfLongestSubstring("DSFASDAWDASDVasfdsfhfghsfgwdwde");

Console.WriteLine("Longest substring " + resultInt);

// ******************** String nums

var resultString = solution.Multiply("4785", "22");

Console.WriteLine("The multiply is " + resultString);

// ******************** Matrix, rotation

var matrix = new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } };
solution.Rotate(matrix);

Console.WriteLine("The array rotation is " + resultString);

// ******************* Array jumps

var canJump = solution.CanJump(new int[] { 1, 323, 444, 111, 2 });

Console.WriteLine("The jumps is " + canJump);


// ******************* Sum individualized

var resultArray = solution.PlusOne(new int[] { 1, 2, 9 });

Console.WriteLine("The sum is " + String.Join('\0', resultArray));

// ******************* Window with string

var window = solution.MinWindow("ADOBECODABCNC", "ABC");

Console.WriteLine("The min window is: " + window);

// ****************** window with string

var sizeWindow = solution.LengthOfLongestSubstringTwoDistinct("eceba");

Console.WriteLine("The sizeWindow " + sizeWindow);

// ****************** Substitution string time closest

var time = solution.ExpressiveWords("vvkkkejjjjjj", new string[] { "vkej", "vvkej" });

Console.WriteLine("The next time closest " + time);

// ****************** Find replace

var replacedString = solution.FindReplaceString("abcde",
                                                new int[] { 2, 2 },
                                                new string[] { "cdef", "bc" },
                                                new string[] { "f", "fe" });

Console.WriteLine("The find replace string is " + replacedString);

// ****************** slide window - max seats

var maxSeats = solution.MaxDistToClosest(new int[] { 0, 1, 0, 0, 0, 1, 1, 0, 1, 1 });

Console.WriteLine("Max seats is " + maxSeats);

// ****************** fill with water

var water = solution.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 4 });

Console.WriteLine("Total water used " + water);

// ****************** longest length window with string

var longest = solution.LengthOfLongestSubstringKDistinctV2("bacc", 3);

Console.WriteLine("The sizeWindow " + longest);

// ****************** jagged sorted

var minRooms = solution.MinMeetingRooms(new int[][] { new int[] { 2, 11 }, new int[] { 6, 16 }, new int[] { 11, 16 },
                                                      new int[] { 9, 15 } });

Console.WriteLine("The number of rooms " + minRooms);

// ****************** binary search 

var indexes = solution.SearchTargetBinarySearch(new int[] { -1, 0, 1, 2, 3, 5, 7, 7, 9, 10, 11 }, 7);

Console.WriteLine("Binary search indexes " + string.Join(',', indexes));

// ***************** Merge array jagged

var newInterval = solution.Insert(new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } }, new int[] { 2, 7 });

for (int x = newInterval.Length - 1; x >= 0; x--)
{
    Console.Write("[");
    for (int y = 0; y < newInterval[x].Length; y++)
    {
        Console.Write(newInterval[x][y]);
        if (y == 0) Console.Write(",");
    }
    Console.Write("]");
}

Console.WriteLine(" ");

// *************** Anagram

var isAnagram = solution.IsAnagram("anagram", "nagaram");

Console.WriteLine("Is anagram " + isAnagram);

// *************** Anagram

var theMedian = solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { 1, 3, 4, 5, 8 });

Console.WriteLine("The median is " + theMedian);

// *************** Backspace char

var isEquals = solution.BackspaceCompare("y#fo##f", "y#f#o##f");

Console.WriteLine("The strings are equal " + isEquals);

// *************** Candies 

var candies = solution.Candy(new int[] { 1, 2, 5, 5, 11, 20, 15 });

Console.WriteLine("Total candies is " + candies);

// *************** Merge sort count smaller on right

var arrayPos = solution.CountSmaller(new int[] { 5, 2, 6, 1 });

// *************** is Isomorphic

var isIsomorphic = solution.IsIsomorphic("dsdsddoooooo", "dwrdccpppppp");

Console.WriteLine("Are they isomorphic " + isIsomorphic);

// *************** rotate string number

var isStrobogrammatic = solution.IsStrobogrammatic("691169");

Console.WriteLine("Is strobogrammatic string " + isStrobogrammatic);

// ************** bulls and cows

var resultGame = solution.GetHint("1122", "1222");

Console.WriteLine("The hint of the game is " + resultGame);

// ************* schedule meetings

MyCalendar myCalendarTwo = new MyCalendar();
myCalendarTwo.Book(10, 20);
myCalendarTwo.Book(50, 60);
myCalendarTwo.Book(10, 40);
myCalendarTwo.Book(15, 30);
myCalendarTwo.Book(5, 15);
myCalendarTwo.Book(5, 10);
myCalendarTwo.Book(25, 55);

// ************ mapping char to string

var totalJewels = solution.NumJewelsInStones("aA", "aaAAaBbbb");

Console.WriteLine("Total num of jewels is {0}", totalJewels);

// Level: Easy
// Method: HashMap or CharMapArray
// Time: O(j.Length + s.Length)
// Space: O(s.Length)

// ************ guessing number

var solutionGuess = new Solution(564);
var guessed = solutionGuess.GuessNumber(1000);

Console.WriteLine("The guessed number is ", guessed);

// Level: Easy
// Method: 
// Time: 
// Space: 

// ************ longest palindro
// Level: Easy
// Method: Expand around center
// Time: O(n²)
// Space: O(1)

var longestPalindrome = solution.LongestPalindrome("abgdaabbaaccabbabssswwsddsda");

Console.WriteLine("The longest palindrome is " + longestPalindrome);

// *********** LRU Cache
// Level: Medium
// Method: LinkedList, Hashmap
// Time: O(1)
// Space: (2n)

Solution lRUCache = new Solution(2, "");
lRUCache.Get(2); // cache is {1=1}
lRUCache.Put(2, 6); // cache is {1=1, 2=2}
lRUCache.Get(1);    // return 1
lRUCache.Put(1, 5); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
lRUCache.Put(1, 2);    // returns -1 (not found)
lRUCache.Get(1);    // return -1 (not found)
lRUCache.Get(2);    // return 3

// *********** Factorial - 0 trailing Z function
// Level: Easy
// Method: mathematic
// Time: O(n²)
// Space O(1)
// https://www.codechef.com/submit/FCTRL

var factorial = 60;

var totalZeroTrailing = Factorial(factorial);
Console.WriteLine("Total zero trailing for {0} is {1}", factorial, totalZeroTrailing);

int Factorial(int num)
{
    var i = 1;
    var trailing = 0;
    int result = 0;

    do
    {
        result = Convert.ToInt32(Math.Floor(num / Math.Pow(5, i)));
        trailing += result;

        i++;
    } while (result > 0);

    return trailing;
}

//*************************************************************************

// ************ Sum triangle
// Level: Easy
// Method: Dinamic programming
// Time: 
// Space 
// https://www.codechef.com/submit/SUMTR

MaxTriangleSum();

int MaxTriangleSum()
{
    int[] inputs = new int[] { 2, 3, 1, 2, 1, 1, 2, 3, 4, 1, 1, 2, 4, 1, 2, 2, 3, 1, 1 };

    for (int x = 0; x < inputs.Length; x++)
    {
        int tests = inputs[x++];
        int[][] grid;

        while (--tests >= 0)
        {
            int i = 0;
            int lines = inputs[x++];
            grid = new int[lines][];

            while (i < lines)
            {
                int col = 0;
                grid[i] = new int[i + 1];

                while (col <= i)
                {
                    grid[i][col] = inputs[x++];
                    col++;
                }

                i++;
            }

            for (int c = 0; c < grid.Length; c++)
            {
                string line = "";
                for (int v = 0; v < grid[c].Length; v++)
                    line += " " + grid[c][v];

                Console.WriteLine(line);
            }

            var r = FindMaxSum(grid, 0, 0);

            return r;
        }
    }

    return 8;
}

int FindMaxSum(int[][] grid, int i, int j)
{
    if (i >= grid.Length)
        return 0;
    if (j >= grid[i].Length)
        return 0;

    var val1 = grid[i][j];
    var val2 = FindMaxSum(grid, i, j + 2);

    FindMaxSum(grid, i, j + 1);

    return val1 + val2;
}

// ****************************  Reverse string
// Level: Easy
// Method: Recursion
// Time: O(n)
// Space O(1)

var reversed = Reverse("asdfggh");

Console.WriteLine("The reversed word is " + reversed);

string Reverse(string word)
{
    return ReverseW(word, word.Length);
}

string ReverseW(string word, int size)
{
    if (size - 1 < 0)
        return "";

    return word[size - 1] + ReverseW(word, size - 1);
}

// ********************* Remove element from linked list
// Level: Easy
// Method: Linkedlist
// Time: O(n)
// Space: O(1)

ListNode head = new ListNode(1,
                new ListNode(3,
                new ListNode(5,
                new ListNode(1,
                new ListNode(2,
                new ListNode(1,
                new ListNode(4)))))));

var list = RemoveElements(head, 1);

ListNode RemoveElements(ListNode head, int val)
{
    if (head == null) return null;

    ListNode next = RemoveElements(head.next, val);

    if (head.val == val) return next;

    head.next = next;

    return head;
}

// ************************** Regex matching
// Level: Hard
// Method: Recursive
// Time: O((T+P)2T+2P​)
// Space: O(T2+P2)

var isMatch = IsMatch("aaa", "a");
if (isMatch) throw new ApplicationException("Was expected to be false");

isMatch = IsMatch("aba", "ab*");
if (isMatch) throw new ApplicationException("Was expected to be false");

isMatch = IsMatch("aaaaaaaaaaaaab", "a..a*.");
if (!isMatch) throw new ApplicationException("Was expected to be true");

isMatch = IsMatch("abbbba", "ab*a");
if (!isMatch) throw new ApplicationException("Was expected to be true");

isMatch = IsMatch("aaaaaaaaaaaaa", "a..a*");
if (!isMatch) throw new ApplicationException("Was expected to be true");

bool IsMatch(string text, string pattern)
{
    if (!pattern.Any()) return !text.Any();

    bool first_match = (text.Any() &&
                           (pattern[0] == text[0] || pattern[0] == '.'));

    if (pattern.Length >= 2 && pattern[1] == '*')
    {
        var isMatchAfterStar = IsMatch(text, pattern.Substring(2));
        var isMatchNextChat = first_match && IsMatch(text.Substring(1), pattern);

        return isMatchAfterStar || isMatchNextChat;
    }
    else
        return first_match && IsMatch(text.Substring(1), pattern.Substring(1));
}

// *********************** Swap pairs linked list
// Level: Medium
// Method: Recursive
// Time: O(n)
// Space: O(1)

ListNode headSwap = new ListNode(1,
                new ListNode(4,
                new ListNode(7,
                new ListNode(3,
                new ListNode(9)))));

var headReturn = SwapPairs(headSwap);

ListNode SwapPairs(ListNode node)
{
    if (node == null || node.next == null)
        return node;

    var aux = node.next;
    node.next = aux.next;
    aux.next = node;

    node.next = SwapPairsRecursive(head);

    return aux;
}

ListNode SwapPairsRecursive(ListNode node)
{
    if (node == null || node.next == null)
        return node;

    var aux = node.next;
    node.next = aux.next;
    aux.next = node;

    node.next = SwapPairsRecursive(node.next);

    return aux;
}

// ***************** Binary tree traversal - BFS
// Level: Medium
// Method: Recursive
// Time: O(n)
// Space: O(n)

TreeNode tree = new TreeNode(5,
                        new TreeNode(3, new TreeNode(6, new TreeNode(4), new TreeNode(1))),
                        new TreeNode(11, new TreeNode(0, new TreeNode(9), new TreeNode(14, new TreeNode(5), new TreeNode(7)))));

var treeList = LevelOrder(tree);

IList<IList<int>> LevelOrder(TreeNode node)
{
    if (node == null)
        return new List<IList<int>>();

    var nums = new List<IList<int>>();
    LevelOrderRecur(node, nums, 0);

    return nums;
}

void LevelOrderRecur(TreeNode node, List<IList<int>> nums, int level)
{
    if (level == nums.Count)
        nums.Add(new List<int>());

    nums[level].Add(node.val);

    if (node.left != null)
        LevelOrderRecur(node.left, nums, level + 1);

    if (node.right != null)
        LevelOrderRecur(node.right, nums, level + 1);
}


// ******************* Find single
// Level: Easy
// Method: Array
// Time: O(n)
// Space: O(n)

var single = SingleNumber(new int[] { 1, 2, 2 });

int SingleNumber(int[] nums)
{
    Array.Sort(nums);

    int single = nums[0];

    for (int i = 0; i < nums.Length; i++)
    {
        if (i > 0 && i + 1 < nums.Length && (nums[i - 1] != nums[i] && nums[i] != nums[i + 1]))
            single = nums[i];
        else if (i > 0 && i == nums.Length - 1 && nums[i - 1] != nums[i])
            single = nums[i];
    }

    return single;
}

//**************** Stone weight
// Level: Easy
// Method: PriorityQueue - MaxHeap
// Time: O(n logn)
// Space: O(n)

var stone = LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });

Console.WriteLine("The stone weight at the end of the game is {0}", stone);

int LastStoneWeight(int[] stones)
{
    var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

    foreach (var stone in stones)
        maxHeap.Enqueue(stone, stone);

    while (maxHeap.Count > 1)
    {
        var num1 = maxHeap.Dequeue();
        var num2 = maxHeap.Dequeue();

        if (num1 != num2)
        {
            var r = num1 - num2;
            maxHeap.Enqueue(r, r);

            if (maxHeap.Count == 1)
                return r;
        }
    }

    return maxHeap.Count == 1 ? maxHeap.Dequeue() : 0;
}

// ************ Subarray sum
// Level: Easy
// Method: Slide window
// UNSOLVED

var totalSubarray = SubarraySum(new int[] { 1, 2, 1 }, 3);

int SubarraySum(int[] nums, int k)
{
    int sum = 0, totalSubarray = 0;
    int left = 0, right = 0, n = nums.Length;

    while (left < n && right < n)
    {
        sum += nums[right];

        if (sum == k)
            totalSubarray++;

        if (sum <= k && right + 1 < n)
            right++;
        else
            sum -= nums[left++];
    }

    return totalSubarray;
}


//**************** Palindrome II
// Level: Easy
// Method: 
// Time: O(n logn)
// Space: O(n)

var isPalindrome = ValidPalindrome("aabcbava");

bool ValidPalindrome(string word)
{
    int left = 0;
    int right = word.Length - 1;
    bool isPalindrome = true;

    while (left < right && isPalindrome)
    {
        if (word[left] != word[right])
            isPalindrome = IsPalindrome(word, left + 1, right) || IsPalindrome(word, left, right - 1);

        if (!isPalindrome)
            return false;

        left++;
        right--;
    }

    return isPalindrome;
}

bool IsPalindrome(string word, int left, int right)
{
    while (right > left)
    {
        if (word[left] != word[right])
            return false;

        right--;
        left++;
    }

    return true;
}


//**************** Add string
// Level: Easy
// Method: 
// Time: O(n logn)
// Space: O(n)

var sum = AddStrings("9", "99");

string AddStrings(string num1, string num2)
{
    string result = string.Empty;
    int remaining = 0, i = 0;
    int n1 = num1.Length - 1;
    int n2 = num2.Length - 1;
    int limit = n1 > n2 ? n1 + 1 : n2 + 1;

    while (i < limit)
    {
        var x = n1 - i >= 0 ? Char.GetNumericValue(num1[n1 - i]) : 0;
        var y = n2 - i >= 0 ? Char.GetNumericValue(num2[n2 - i]) : 0;

        var sum = (x + y + remaining) % 10;
        remaining = x + y + remaining >= 10 ? 1 : 0;

        result = sum.ToString() + result;

        i++;
    }

    return remaining > 0 ? remaining.ToString() + result : result;
}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Node
{
    public int _key;
    public int _val;

    public Node prev;//pointer to LRU
    public Node next;// pointer to MRU

    public Node(int key, int val)
    {
        _key = key;
        _val = val;
        this.prev = null;
        this.next = null;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class LRUCache
{
    private int _capacity;
    private Dictionary<int, Node> cache;
    private Node left;//LRU
    private Node right;//MRU

    public LRUCache(int capacity)
    {
        this._capacity = capacity;
        this.cache = new Dictionary<int, Node>();

        this.left = new Node(0, 0);
        this.right = new Node(0, 0);

        this.left.next = right;
        this.right.prev = left;
    }

    public int Get(int key)
    {
        if (this.cache.ContainsKey(key))
        {
            remove(this.cache[key]);
            insert(this.cache[key]);
            return this.cache[key]._val;
        }
        return -1;
    }

    public void remove(Node node)
    {
        var prv = node.prev;
        var nxt = node.next;

        prv.next = nxt;
        nxt.prev = prv;
    }

    public void insert(Node node)
    {
        var prv = this.right.prev;
        var nxt = this.right;

        prv.next = node;
        nxt.prev = node;

        node.prev = prv;
        node.next = nxt;
    }

    public void Put(int key, int value)
    {
        if (this.cache.ContainsKey(key))
        {
            remove(this.cache[key]);
        }

        this.cache[key] = new Node(key, value);
        insert(this.cache[key]);

        if (this.cache.Count > _capacity)
        {
            var lru = this.left.next;
            this.left.next = lru.next;
            lru.next.prev = lru.prev;
            cache.Remove(lru._key);
        }

    }
}

public class Solution
{

    private int capacity;
    private Dictionary<int, LinkedListNode<Node>> cache;
    private LinkedList<Node> expirationControl;
    private int size;

    private class Node
    {
        public int Key { get; set; }
        public int Val { get; set; }
    }

    public Solution(int capacity, string nothing)
    {
        this.capacity = capacity;
        this.cache = new Dictionary<int, LinkedListNode<Node>>(capacity);
        this.expirationControl = new LinkedList<Node>();
        size = 0;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key))
            return -1;

        var node = cache[key];
        expirationControl.Remove(node);
        expirationControl.AddFirst(node);

        return node.Value.Val;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            expirationControl.Remove(node);
            expirationControl.AddFirst(node);
            node.Value.Val = value;

            return;
        }

        if (size == capacity)
        {
            var oldestKey = expirationControl.Last.Value.Key;
            cache.Remove(oldestKey);
            expirationControl.RemoveLast();
            size--;
        }

        expirationControl.AddFirst(new Node { Key = key, Val = value });
        cache.Add(key, expirationControl.First);
        size++;
    }

    public void UpdateExpiration(int key)
    {
        var node = cache[key];
        expirationControl.Remove(node);
        expirationControl.AddFirst(node);
    }

    public String LongestPalindrome(String s)
    {
        if (s.Length <= 1)
            return s;

        string finalPalin = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            string palin = LookForPalin(s, i);

            if (palin.Length > finalPalin.Length)
                finalPalin = palin;
        }

        return finalPalin;
    }

    private string LookForPalin(string s, int center)
    {
        string oddPalin, evenPalin;

        oddPalin = ExpandFromCenter(center, center, s);
        evenPalin = ExpandFromCenter(center, center + 1, s);

        return oddPalin.Length > evenPalin.Length ? oddPalin : evenPalin;
    }

    private string ExpandFromCenter(int left, int right, string s)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return s.Substring((left + 1), (right) - (left + 1));
    }

    int guessNumber;

    public Solution() { }
    public Solution(int guessNumber)
    {
        this.guessNumber = guessNumber;
    }

    public int GuessNumber(int n)
    {
        return GuessNumber(0, n);
    }

    private int guess(int num)
    {
        return guessNumber.CompareTo(num);
    }

    private int GuessNumber(int start, int end)
    {
        if (guess(start) == 0)
            return start;
        if (guess(end) == 0)
            return 0;

        var mid = start + (end - start) / 2;

        var pick = guess(mid);

        if (pick == 0)
            return mid;
        else if (pick == 1)
            return GuessNumber(mid + 1, end);
        else
            return GuessNumber(start, mid);
    }

    public int NumJewelsInStones(string jewels, string stones)
    {
        var numJewels = 0;
        var stoneMap = new char[256];

        foreach (var s in stones)
            stoneMap[s]++;

        foreach (var j in jewels)
        {
            if (stoneMap[j] > 0)
            {
                numJewels += stoneMap[j];
                stoneMap[j]--;
            }
        }

        return numJewels;
    }

    public class MyCalendar
    {
        SortedDictionary<int, int> _dict;

        public MyCalendar()
        {
            _dict = new SortedDictionary<int, int>();
        }

        public bool Book(int start, int end)
        {
            if (!_dict.TryGetValue(start, out var temp))
                _dict.Add(start, temp + 1);
            else
                _dict[start]++;

            if (!_dict.TryGetValue(end, out var temp1))
                _dict.Add(end, temp1 - 1);
            else
                _dict[end]--;

            int active = 0;
            foreach (var d in _dict.Values)
            {
                active += d;
                if (active >= 3)
                {
                    _dict[start]--;
                    _dict[end]++;

                    Console.WriteLine("The meeting {0}-{1} has been conflicted ", start, end);
                    return false;
                }
            }

            Console.WriteLine("The meeting {0}-{1} has been accepted ", start, end);
            return true;
        }
    }

    public string GetHint(string secret, string guess)
    {
        var secretMap = new char[10];
        int bulls = 0, cows = 0;

        foreach (var s in secret)
            secretMap[s - '0']++;

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
                secretMap[guess[i] - '0']--;
                secret = secret.Remove(i, 1);
                guess = guess.Remove(i, 1);
                i--;
            }
        }

        for (int i = 0; i < secret.Length; i++)
        {
            if (secretMap[guess[i] - '0'] > 0)
            {
                cows++;
                secretMap[guess[i] - '0']--;
            }
        }

        return string.Concat(bulls, 'A', cows, 'B');
    }

    public bool IsStrobogrammatic(string num)
    {
        var map = new Dictionary<char, char> { { '6', '9' }, { '9', '6' }, { '8', '8' }, { '1', '1' }, { '0', '0' } };
        var newNum = string.Empty;

        foreach (var n in num)
        {
            if (!map.ContainsKey(n))
                return false;

            newNum = map[n] + newNum;
        }

        return newNum == num;
    }

    public bool IsIsomorphic(string s, string t)
    {
        var m1 = new int[256];
        var m2 = new int[256];
        var n = s.Length;

        for (int i = 0; i < n; ++i)
        {
            if (m1[s[i]] != m2[t[i]]) return false;
            m1[s[i]] = i + 1;
            m2[t[i]] = i + 1;
        }

        return true;
    }

    class Pair
    {
        public int OriginalIndex;
        public int Value;

        public Pair(int originalIndex, int val)
        {
            OriginalIndex = originalIndex;
            Value = val;
        }
    }

    public IList<int> CountSmaller(int[] nums)
    {
        int n = nums.Length;
        var pairs = new Pair[n];
        var result = new int[n];

        for (int i = 0; i < n; i++)
            pairs[i] = new Pair(i, nums[i]);

        MergeCounting(pairs, 0, n - 1, result);

        return result;
    }

    private void MergeCounting(Pair[] pairs, int start, int end, int[] result)
    {
        if (start >= end) return;

        int mid = (start + end) / 2;
        MergeCounting(pairs, start, mid, result);
        MergeCounting(pairs, mid + 1, end, result);

        int leftPos = start;
        int rightPos = mid + 1;
        int numElemsRightArrayLessThanLeftArray = 0;
        var merged = new List<Pair>();

        while (leftPos < mid + 1 && rightPos <= end)
        {
            if (pairs[leftPos].Value > pairs[rightPos].Value)
            {
                numElemsRightArrayLessThanLeftArray++;
                merged.Add(pairs[rightPos]);
                rightPos++;
            }
            else
            {
                result[pairs[leftPos].OriginalIndex] += numElemsRightArrayLessThanLeftArray;
                merged.Add(pairs[leftPos]);
                leftPos++;
            }
        }

        while (leftPos < mid + 1)
        {
            result[pairs[leftPos].OriginalIndex] += numElemsRightArrayLessThanLeftArray;

            merged.Add(pairs[leftPos]);
            leftPos++;
        }

        while (rightPos <= end)
        {
            merged.Add(pairs[rightPos]);
            rightPos++;
        }

        int pos = start;
        foreach (var item in merged)
        {
            pairs[pos] = item;
            pos++;
        }
    }

    public int Candy(int[] ratings)
    {
        int size = ratings.Length;

        if (size <= 1)
            return size;

        int[] num = Enumerable.Repeat(1, size).ToArray();

        for (int i = 1; i < size; i++)
        {
            if (ratings[i] > ratings[i - 1])
                num[i] = num[i - 1] + 1;
        }

        for (int i = size - 1; i > 0; i--)
        {
            if (ratings[i - 1] > ratings[i])
                num[i - 1] = Math.Max(num[i] + 1, num[i - 1]);
        }

        int result = 0;

        for (int i = 0; i < size; i++)
        {
            result += num[i];
        }

        return result;
    }

    public bool BackspaceCompare(string s, string t)
    {
        var s2 = "";
        var t2 = "";

        foreach (var sChar in s)
        {
            if (sChar.Equals('#') && s2.Length > 0)
                s2 = s2.Remove(s2.Length - 1, 1);
            else if (!sChar.Equals('#'))
                s2 += sChar;
        }

        foreach (var tChar in t)
        {
            if (tChar.Equals('#') && t2.Length > 0)
                t2 = t2.Remove(t2.Length - 1, 1);
            else if (!tChar.Equals('#'))
                t2 += tChar;
        }

        return t2.Equals(s2);
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;
        int k = 0;

        int[] arr = new int[nums1.Length + nums2.Length];

        while (i < nums1.Length || j < nums2.Length)
        {
            if (j == nums2.Length || i < nums1.Length && nums1[i] <= nums2[j])
            {
                arr[k] = nums1[i];
                i++;
            }
            else
            {
                if (j < nums2.Length || nums1[i] <= nums2[j])
                {
                    arr[k] = nums2[j];
                    j++;
                }
            }

            k++;
        }

        var mid = (int)Math.Floor(arr.Length / (double)2);

        return arr.Length % 2 == 0 ? (double)(arr[mid - 1] + arr[mid]) / 2 : (double)arr[mid];
    }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] chars = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i]]++;
            chars[t[i]]--;
        }

        foreach (int c in chars)
        {
            if (c != 0)
            {
                return false;
            }
        }

        return true;
    }

    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }

        List<int[]> result = new List<int[]>();
        foreach (var interval in intervals)
        {
            if (newInterval[0] > interval[1])
            {
                result.Add(interval);
            }

            else if (newInterval[1] < interval[0])
            {
                result.Add(newInterval);
                newInterval = interval;
            }

            else
            {
                newInterval[0] = Math.Min(interval[0], newInterval[0]);
                newInterval[1] = Math.Max(interval[1], newInterval[1]);
            }
        }

        result.Add(newInterval);
        return result.ToArray();
    }

    public int[] SearchTargetBinarySearch(int[] nums, int target)
    {
        int[] result = new int[2];

        result[0] = FindFunc(nums, target, (i) => nums[i] >= target);
        result[1] = FindFromRight(nums, target);

        return result;
    }

    public int FindFunc(int[] nums, int target, Func<int, bool> evaluate)
    {
        int r = -1;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (right + left) / 2;

            if (evaluate.Invoke(mid)) right = mid - 1;
            else left = mid + 1;
            if (nums[mid] == target) r = mid;
        }

        return r;
    }

    public int FindFromLeft(int[] nums, int target)
    {
        int r = -1;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (right + left) / 2;

            if (nums[mid] >= target) right = mid - 1;
            else left = mid + 1;
            if (nums[mid] == target) r = mid;
        }

        return r;
    }

    public int FindFromRight(int[] nums, int target)
    {
        int r = -1;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (right + left) / 2;

            if (nums[mid] > target) right = mid - 1;
            else left = mid + 1;
            if (nums[mid] == target) r = mid;
        }

        return r;
    }

    public int MinMeetingRoomsV2(int[][] intervals)
    {

        int[] starts = new int[intervals.GetLength(0)];
        int[] ends = new int[intervals.GetLength(0)];
        int rooms = 0, countEnd = 0;

        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            starts[i] = intervals[i][0];
            ends[i] = intervals[i][1];
        }

        Array.Sort(starts);
        Array.Sort(ends);

        for (int i = 0; i < starts.Length; i++)
        {
            if (starts[i] < ends[countEnd])
            {
                rooms++;
            }
            else
            {
                countEnd++;
            }
        }

        return rooms;
    }

    public int MinMeetingRooms(int[][] intervals)
    {
        var rooms = 1;

        Array.Sort(intervals, (x, y) => x[0] != y[0] ? x[0].CompareTo(y[0]) : y[1].CompareTo(x[1]));

        for (int i = 0; i < intervals.Length - 1; i++)
        {
            var end = intervals[i][1];
            bool needsRoom = false;

            for (int j = i + 1; j < intervals.Length; j++)
            {
                var start = intervals[j][0];

                if (end > start)
                {
                    needsRoom = true;
                }
            }

            if (needsRoom)
                rooms++;
        }

        return rooms;
    }

    public int LengthOfLongestSubstringKDistinctV2(string s, int k)
    {
        int[] table = new int[256];
        int num = 0, i = 0, res = 0;

        for (int j = 0; j < s.Length; j++)
        {
            if (table[s[j]] == 0) num++; //if (table[s[j]]++ == 0)

            if (num > k)
            {
                while (table[s[i]] > 0) // while(--table[s[i++]] > 0);
                {
                    table[s[i]]--;
                    i++;
                }

                num--;
            }

            table[s[j]]++;
            res = Math.Max(res, j - i + 1);
        }
        return res;
    }

    public int LengthOfLongestSubstringKDistinct(string letters, int k)
    {
        if (k == 0)
            return k;

        int right = 0, left = 0, nextLeft = 0, lengthLongest = 0;
        var found = new HashSet<char>();

        while (right < letters.Length)
        {
            var letter = letters[right];

            if (found.Count < k)
            {
                nextLeft = right;
                found.Add(letter);
            }
            else if (found.Count == k && !found.Contains(letter))
            {
                found.Clear();
                found.Add(letter);
                found.Add(letters[nextLeft]);
                left = nextLeft;
                nextLeft = right;
            }
            else if (letters[nextLeft] != letters[right])
                nextLeft = right;

            lengthLongest = Math.Max(lengthLongest, found.Count == k ? (right - left) : (right - left) + 1);

            right++;
        }

        return lengthLongest;
    }

    public int Trap(int[] heights)
    {
        if (heights.Length < 3)
            return 0;

        int water = 0;
        int i = 0;
        var max = heights.Max();
        var indexMax = Array.IndexOf(heights, max);

        while (i < heights.Length)
        {
            if (heights[i] > 0 && Math.Abs(indexMax - i) > 1)
            {
                int j = i < indexMax ? i + 1 : indexMax + 1;
                int limit = i < indexMax ? indexMax : i;

                while (j < limit)
                {
                    if (heights[i] > heights[j])
                    {
                        var diff = heights[i] - heights[j];
                        water += diff;
                        heights[j] = heights[i];
                    }
                    j++;
                }
            }
            i++;
        }

        return water;
    }

    public int MaxDistToClosest(int[] seats)
    {
        int max = 0, count = 0;
        var isFirstSeats = seats[0] == 0;

        for (var j = 0; j < seats.Length; j++)
        {
            isFirstSeats = seats[j] == 0 && isFirstSeats;

            if (seats[j] == 0)
            {
                count++;
                max = isFirstSeats || (seats[seats.Length - 1] == 0 && j == seats.Length - 1) ?
                      Math.Max(max, count) :
                      (int)Math.Max(max, Math.Ceiling((double)count / (double)2));
            }
            else
                count = 0;
        }

        return max;
    }

    public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
    {
        var dicIndices = new Dictionary<int, int>();

        for (int i = 0; i < indices.Length; i++)
            if (!dicIndices.ContainsKey(indices[i])) dicIndices.Add(indices[i], i);

        Array.Sort(indices);

        for (var i = indices.Length - 1; i >= 0; i--)
        {
            var originIndice = dicIndices[indices[i]];
            var indice = indices[i];
            var source = sources[originIndice];
            var target = targets[originIndice];
            var endRange = s.Length - indice < source.Length ? s.Length - indice : source.Length;

            if (source == s.Substring(indice, endRange))
            {
                var regex = new Regex(Regex.Escape(source));
                s = regex.Replace(s, target, 1, indice);
            }
        }

        return s;
    }

    public int ExpressiveWords(string s, string[] words)
    {
        int count = 0;
        foreach (string w in words)
        {
            int i, j;
            for (i = 0, j = 0; i < s.Length; ++i)
            {
                if (j < w.Length && s[i] == w[j])
                    ++j;

                else if (i > 0 && s[i - 1] == s[i] && i + 1 < s.Length && s[i] == s[i + 1])
                    ++i;

                else if (!(i > 1 && s[i] == s[i - 1] && s[i] == s[i - 2]))
                    break;
            }
            if (i == s.Length && j == w.Length) ++count;
        }

        return count;
    }

    public string ReplaceAt(string input, char newChar, int index)
    {
        char[] chars = input.ToCharArray();
        chars[index] = newChar;

        return new string(chars);
    }

    public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
    {

        if (nums.Length == 0 && lower == upper)
            return new List<string> { lower.ToString() };
        else if (nums.Length == 0)
            return new List<string> { string.Concat(lower, "->", upper) };

        var missingRanges = new List<string>();
        var i = 0;
        var range = lower;

        if (range < nums[0] && range + 1 < nums[0])
            missingRanges.Add(string.Concat(range, "->", nums[0] - 1));
        else if (range < nums[0])
            missingRanges.Add(range.ToString());

        while (i < nums.Length)
        {
            range = nums[i] + 1;

            if (i + 1 < nums.Length && range > nums[i] && range < nums[i + 1])
            {
                if (range + 1 < nums[i + 1])
                    missingRanges.Add(string.Concat(range, "->", nums[i + 1] - 1));
                else
                    missingRanges.Add(range.ToString());
            }

            i++;
        }

        range = nums[nums.Length - 1];

        if (range < upper && range + 1 < upper)
            missingRanges.Add(string.Concat(range + 1, "->", upper));
        else if (range < upper)
            missingRanges.Add(upper.ToString());

        return missingRanges;
    }

    public int LengthOfLongestSubstringTwoDistinct(string letters)
    {
        int right = 0, left = 0, nextLeft = 0, lengthLongest = 0;
        var found = new HashSet<char>();

        while (right < letters.Length)
        {
            var letter = letters[right];

            if (found.Count < 2)
            {
                nextLeft = right;
                found.Add(letter);
            }
            else if (found.Count == 2 && !found.Contains(letter))
            {
                found.Clear();
                found.Add(letter);
                found.Add(letters[nextLeft]);
                left = nextLeft;
                nextLeft = right;
            }
            else if (letters[nextLeft] != letters[right])
                nextLeft = right;

            lengthLongest = Math.Max(lengthLongest, (right - left) + 1);

            right++;
        }

        return lengthLongest;
    }

    public string MinWindow(string letters, string groupedLetters)
    {
        int[] map = new int[128];
        Array.Fill(map, 0);

        foreach (var l in groupedLetters)
            map[l]++;

        int counter = groupedLetters.Length, begin = 0, end = 0, d = int.MaxValue, head = 0;

        while (end < letters.Length)
        {
            if (map[letters[end++]]-- > 0)
                counter--;

            while (counter == 0)
            {
                if (end - begin < d)
                    d = end - (head = begin);

                if (map[letters[begin++]]++ == 0)
                    counter++;
            }
        }

        return d == int.MaxValue ? "" : letters.Substring(head, d);
    }

    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i > -1; i--)
        {
            if (digits[i] == 9)
                digits[i] = 0;
            else
            {
                digits[i]++;
                return digits;
            }
        }

        Array.Resize(ref digits, digits.Length + 1);
        digits[0] = 1;

        return digits;
    }

    public bool CanJump(int[] nums)
    {
        int lastPos = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= lastPos)
                lastPos = i;
        }

        return lastPos == 0;
    }

    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length - 1;

        for (int i = 0; i <= n / 2; i++)
        {
            for (int j = 0; j <= n - i - 1; j++)
            {
                int aux = matrix[i][j];

                matrix[i][j] = matrix[n - j - 1][i];
                matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                matrix[j][n - i - 1] = aux;
            }
        }
    }

    public string Multiply(string num1, string num2)
    {
        var lastNum = Char.GetNumericValue(num2[num2.Length - 1]);
        var needsSum = false;
        var builderNum = new StringBuilder(num1);

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int lastNumSum = (int)(Char.GetNumericValue(builderNum[i]) + Char.GetNumericValue(builderNum[i]));

            if (needsSum)
            {
                lastNumSum++;
                needsSum = false;
            }

            int substraction = lastNumSum >= 10 ? lastNumSum - 10 : lastNumSum;
            builderNum[i] = Convert.ToChar(substraction.ToString());

            if (lastNumSum >= 10)
            {
                if (i == 0)
                    builderNum.Insert(0, "1");
                else
                    needsSum = true;
            }
        }

        return builderNum.ToString();
    }

    public int LengthOfLongestSubstring(string s)
    {
        var lettersPosition = new List<char>();
        int maxSequence = 1, start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var letter = s[i];

            if (lettersPosition.Contains(letter))
            {
                var tempLetter = '\0';

                while (letter != tempLetter)
                {
                    tempLetter = lettersPosition[start];
                    lettersPosition.RemoveAt(0);
                }
            }

            lettersPosition.Add(letter);
            maxSequence = Math.Max(maxSequence, lettersPosition.Count);
        }

        return maxSequence;
    }

    public int TotalFruit(int[] fruits)
    {
        int start = 0, mid = 1, end = 1, maxFruits = 0;
        bool hasMoved = false;

        for (; end < fruits.Length; end++)
        {
            if (fruits[start] != fruits[mid] &&
               fruits[start] != fruits[end] &&
               fruits[mid] != fruits[end])
            {
                if ((mid - start) + 1 > maxFruits)
                    maxFruits = (mid - start) + 1;

                start = mid;
            }

            if ((end - start) > maxFruits)
                maxFruits = hasMoved ? (end - start) : (end - start) + 1;

            mid = end;
        }

        return maxFruits;
    }

    public int TotalFruit_WRONG(int[] fruits)
    {
        var basket = new Dictionary<int, int>();

        for (int i = 0; i < fruits.Length; i++)
        {
            if (!basket.ContainsKey(fruits[i]))
            {
                basket.Add(fruits[i], 1);
            }
            else
            {
                basket[fruits[i]]++;
            }
        }

        return basket.Values.OrderByDescending(i => i).Take(2).Sum();
    }

    public int NumUniqueEmails(string[] emails)
    {
        var uniqueEmails = new HashSet<string>();

        foreach (var email in emails)
        {
            var splittedEmail = email.Split("@");
            var localName = splittedEmail[0];
            var domain = splittedEmail[1];

            if (localName.Contains("+"))
                localName = localName.Remove(localName.IndexOf('+'));

            localName = localName.Replace(".", string.Empty);

            uniqueEmails.Add(string.Concat(localName, '@', domain));
        }

        return uniqueEmails.Count;
    }

    public int NumIslands(char[][] grid)
    {
        var totalIslands = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    totalIslands++;
                    MapIsland(i, j, grid);
                }
            }
        }

        return totalIslands;
    }

    public void MapIsland(int i, int j, char[][] grid)
    {
        if (i >= grid.Length || i < 0 ||
            j >= grid[i].Length || j < 0 ||
            grid[i][j] == '0')
            return;

        grid[i][j] = '0';
        MapIsland(i + 1, j, grid);
        MapIsland(i, j + 1, grid);
        MapIsland(i - 1, j, grid);
        MapIsland(i, j - 1, grid);
    }
}