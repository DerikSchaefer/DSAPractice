

#region FlowChart
//Flowchart to identify problem patterns

/* 
Start

// Step 2: Identify if the problem involves a collection of elements.
// For example, an array, list, or tree.
if (ProblemInvolvesCollectionOfElements())
{
    // Step 3: Identify if the problem involves finding a specific element in a sorted collection.
    if (ProblemInvolvesFindingInSortedCollection())
    {
        // Binary Search Pattern (Pattern #1)
    }
    else
    {
        // Step 4: Identify if the problem involves finding the maximum or minimum element(s) in a collection.
        if (ProblemInvolvesFindingMaxOrMinElements())
        {
            // Two Pointers Pattern (Pattern #2) or Sliding Window Pattern (Pattern #3)
        }
        else
        {
            // Step 5: Identify if the problem involves finding a pattern or specific sequence in a collection.
            if (ProblemInvolvesFindingPatternOrSequence())
            {
                // Fast and Slow Pointers Pattern (Pattern #4)
            }
            else
            {
                // Step 6: Identify if the problem involves finding all possible combinations or permutations.
                if (ProblemInvolvesFindingCombinationsOrPermutations())
                {
                    // Backtracking Pattern (Pattern #5)
                }
                else
                {
                    // Step 7: Identify if the problem involves processing elements in a tree or graph.
                    if (ProblemInvolvesProcessingTreeOrGraph())
                    {
                        // Tree Depth-First Search (DFS) Pattern (Pattern #8)
                        // Tree Breadth-First Search (BFS) Pattern (Pattern #7)
                        // Topological Sort Pattern (Pattern #12)
                    }
                    else
                    {
                        // Step 8: Identify if the problem involves finding the median or top K elements.
                        if (ProblemInvolvesFindingMedianOrTopKElements())
                        {
                            // Two Heaps Pattern (Pattern #9) or Top K Elements Pattern (Pattern #14)
                        }
                        else
                        {
                            // Step 9: Identify if the problem involves choosing from a set of elements with limited capacity.
                            if (ProblemInvolvesChoosingWithLimitedCapacity())
                            {
                                // Knapsack (0/1) Pattern (Pattern #13)
                            }
                            else
                            {
                                // The problem might not fit the listed patterns
                            }
                        }
                    }
                }
            }
        }
    }
}

// End
*/
#endregion

//Pattern #1: Sliding Window
/*Definition: The "Sliding Window" pattern involves creating a fixed-size window that slides through an array or linked list to solve problems where we need to perform operations on a subset of elements. This pattern is useful for solving problems that require finding subarrays or substrings with specific properties.*/

//Common Problems:
//Subarray Sum: Find the subarray with a given sum in an array of positive and negative numbers.
//Longest Substring without Repeating Characters: Find the longest substring in a string without any repeating characters.
//Maximum Sum Subarray: Find the subarray with the maximum sum in an array of numbers.
//Anagrams in a String: Find all the anagrams of a pattern in a given string.

#region C# implementation

/*
using System;

public int MaxSumSubarray(int[] nums, int k)
{
    int maxSum = 0, windowSum = 0;
    for (int i = 0; i < k; i++)
    {
        windowSum += nums[i];
    }
    maxSum = windowSum;

    for (int i = k; i < nums.Length; i++)
    {
        windowSum += nums[i] - nums[i - k];
        maxSum = Math.Max(maxSum, windowSum);
    }

    return maxSum;
}
*/

#endregion

#region TypeScript implementation

/*
function maxSumSubarray(nums: number[], k: number): number
{
    let maxSum = 0;
    let windowSum = 0;

    for (let i = 0; i < k; i++)
    {
        windowSum += nums[i];
    }
    maxSum = windowSum;

    for (let i = k; i < nums.length; i++)
    {
        windowSum += nums[i] - nums[i - k];
        maxSum = Math.max(maxSum, windowSum);
    }

    return maxSum;
}
*/

#endregion

//Pattern #2: Two Pointers
/*Definition: The "Two Pointers" pattern involves using two pointers that move through the data simultaneously. This pattern is useful for solving problems that require searching, comparing, or manipulating elements in a collection, such as arrays or linked lists.*/

//Common Problems:
//Two Sum: Find two numbers in an array that add up to a given target.
//Triplet Sum: Find triplets in an array that add up to a given target.
//Subarray with a Given Sum: Find a subarray in an array that adds up to a given sum.
//Pair with a Target Sum: Find a pair of numbers in an array that adds up to a given target.

#region C# implementation

/*
using System.Collections.Generic;
using System;

public int[] TwoSum(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;
    while (left < right)
    {
        int sum = nums[left] + nums[right];
        if (sum == target)
        {
            return new int[] { left, right };
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return new int[] { -1, -1 }; // Target not found
}
*/

#endregion

#region TypeScript implementation

/*
function twoSum(nums: number[], target: number): number[]
{
    let left = 0;
    let right = nums.length - 1;

    while (left < right)
    {
        const sum = nums[left] + nums[right];
        if (sum === target)
        {
            return [left, right];
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return [-1, -1]; // Target not found
}
*/

#endregion

//Pattern #3: Fast and Slow Pointers

/*Definition: The "Fast and Slow Pointers" pattern involves using two pointers that move through the data at different speeds, often referred to as the "fast" and "slow" pointers.
This pattern is useful for solving problems that involve finding cycles in linked lists or arrays, detecting meeting points in linked lists, or finding middle elements in a list.*/

//Common Problems:
//Linked List Cycle: Given a linked list, determine if it has a cycle (i.e., a loop). This problem involves using fast and slow pointers to detect cycles in a linked list.

//Palindrome Linked List: Determine if a linked list is a palindrome (i.e., reads the same backward as forward). Fast and slow pointers can be used to find the middle of the
//linked list and reverse the second half to compare with the first half for palindromic property.

//Middle of the Linked List: Find the middle node of a linked list. By using fast and slow pointers, the middle node can be found efficiently without having to know the
//length of the linked list in advance.

//Happy Number: Given a number, determine if it is a "happy number." A happy number is a number that, when repeatedly replaced by the sum of the squares of its digits,
//eventually reaches 1. If it loops endlessly in a cycle, it is not a happy number. This problem can be solved using fast and slow pointers to detect cycles.

//Cycle in Circular Array: Given an array, determine if there is a cycle in it. The array is treated as a circular array, where the next index is determined using modulo
//operations. Fast and slow pointers can be used to detect cycles in this circular array.

#region C# implementation

/*
public bool HasCycle(ListNode head)
{
    if (head == null || head.next == null) return false;
    ListNode slow = head, fast = head.next;
    while (slow != fast)
    {
        if (fast == null || fast.next == null) return false;
        slow = slow.next;
        fast = fast.next.next;
    }
    return true;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
*/

#endregion

#region TypeScript implementation

/*
function hasCycle(head: ListNode | null): boolean
{
    if (!head || !head.next) return false;
    let slow = head;
    let fast = head.next;

    while (slow !== fast)
    {
        if (!fast || !fast.next) return false;
        slow = slow.next!;
        fast = fast.next.next!;
    }

    return true;
}

class ListNode
{
    val: number;
    next: ListNode | null;
    constructor(val: number)
    {
        this.val = val;
        this.next = null;
    }
}
*/

#endregion

//Pattern #4: Merge Intervals
/*Definition: The "Merge Intervals" pattern involves merging overlapping intervals or determining non-overlapping intervals in a collection of intervals. 
It is commonly used in problems that deal with scheduling, time intervals, and time series data.*/

//Common Problems:
//Merge Intervals: Given a collection of intervals, merge any overlapping intervals.
//Insert Intervals: Given a collection of non-overlapping intervals and a new interval, insert the new interval into the collection and merge any overlapping intervals.
//Non-overlapping Intervals: Given a collection of intervals, find the minimum number of intervals needed to remove to make the rest of the intervals non-overlapping.
//Maximum Overlapping Intervals: Given a collection of intervals, find the maximum number of overlapping intervals at any point in time.

#region C# implementation

/*
public int[][] MergeIntervals(int[][] intervals)
{
    if (intervals.Length <= 1) return intervals;

    Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

    List<int[]> merged = new List<int[]>();
    int[] currentInterval = intervals[0];
    merged.Add(currentInterval);

    foreach (int[] interval in intervals)
    {
        if (interval[0] <= currentInterval[1])
        {
            currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
        }
        else
        {
            currentInterval = interval;
            merged.Add(currentInterval);
        }
    }
    return merged.ToArray();
}
*/

#endregion

#region TypeScript implementation

/*
function mergeIntervals(intervals: number[][]): number[][]
{
    if (intervals.length <= 1) return intervals;

    intervals.sort((a, b) => a[0] - b[0]);

    const merged: number[][] = [intervals[0]];
    for (let i = 1; i < intervals.length; i++)
    {
        const currInterval = intervals[i];
        const lastMergedInterval = merged[merged.length - 1];

        if (currInterval[0] <= lastMergedInterval[1])
        {
            lastMergedInterval[1] = Math.max(lastMergedInterval[1], currInterval[1]);
        }
        else
        {
            merged.push(currInterval);
        }
    }

    return merged;
}
*/

#endregion

//Pattern #5: Cyclic Sort
/*Definition: The "Cyclic Sort" pattern involves placing each number or element at its correct position in the sorted order. This pattern is used when the input contains numbers 
 * or elements within a certain range, and it is helpful for solving problems that require finding missing or duplicate numbers.*/

//Common Problems:
//Find the Smallest Missing Positive Number: Given an unsorted integer array, find the smallest missing positive integer. This problem can be solved using the cyclic sort technique.

//Find the First K Missing Positive Numbers: Given an unsorted integer array and an integer 'k', find the first 'k' missing positive numbers. This problem can also be solved
//using the cyclic sort technique.

#region C# implementation

/*
public int FirstMissingPositive(int[] nums)
{
    int n = nums.Length;
    for (int i = 0; i < n; i++)
    {
        while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
        {
            Swap(nums, i, nums[i] - 1);
        }
    }

    for (int i = 0; i < n; i++)
    {
        if (nums[i] != i + 1)
        {
            return i + 1;
        }
    }

    return n + 1;
}

private void Swap(int[] nums, int i, int j)
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}
*/

#endregion

#region TypeScript implementation

/*
function firstMissingPositive(nums: number[]): number
{
    const n = nums.length;
    for (let i = 0; i < n; i++)
    {
        while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] !== nums[i])
        {
            [nums[nums[i] - 1], nums[i]] = [nums[i], nums[nums[i] - 1]];
        }
    }

    for (let i = 0; i < n; i++)
    {
        if (nums[i] !== i + 1)
        {
            return i + 1;
        }
    }

    return n + 1;
}
*/

#endregion

//Pattern #6: In-place Reversal of a Linked List
/*Definition: The "In-place Reversal of a Linked List" pattern involves reversing a linked list directly within the linked list itself, without using additional data structures. 
This pattern is used to solve problems that require reversing a linked list, reversing a sub-list within a linked list, or checking if a linked list is a palindrome.*/

//Common Problems:
//Reverse a Linked List: Reverse a given linked list in place. This problem can be solved using the iterative approach of reversing the linked list.
//Reverse a Sub-list: Reverse a sub-list within a linked list between 'start' and 'end' (inclusive). This problem involves reversing a portion of the linked list using in-place reversal.

//Check if a Linked List is a Palindrome: Determine if a linked list is a palindrome (i.e., reads the same backward as forward). This problem can be solved using slow and fast
//pointers to find the middle and then reversing the second half of the linked list.

#region C# implementation

/*
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public ListNode ReverseLinkedList(ListNode head)
{
    ListNode prev = null;
    ListNode current = head;

    while (current != null)
    {
        ListNode next = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }

    return prev;
}

public ListNode ReverseSubList(ListNode head, int start, int end)
{
    if (start == end) return head;

    ListNode dummy = new ListNode(0);
    dummy.next = head;
    ListNode prev = dummy;

    for (int i = 0; i < start - 1; i++)
    {
        prev = prev.next;
    }

    ListNode current = prev.next;
    ListNode next = null;

    for (int i = 0; i < end - start + 1; i++)
    {
        next = current.next;
        current.next = prev.next;
        prev.next = current;
        current = next;
    }

    head.next = next;
    return dummy.next;
}

public bool IsPalindrome(ListNode head)
{
    if (head == null || head.next == null) return true;

    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    ListNode secondHalf = ReverseLinkedList(slow);
    ListNode firstHalf = head;

    while (secondHalf != null)
    {
        if (firstHalf.val != secondHalf.val)
        {
            return false;
        }

        firstHalf = firstHalf.next;
        secondHalf = secondHalf.next;
    }

    return true;
}
*/

#endregion

#region TypeScript implementation

/*
class ListNode
{
    val: number;
    next: ListNode | null;
    constructor(val?: number, next?: ListNode | null)
    {
        this.val = val === undefined ? 0 : val;
        this.next = next === undefined ? null : next;
    }
}

function reverseLinkedList(head: ListNode | null): ListNode | null
{
    let prev: ListNode | null = null;
    let current: ListNode | null = head;

    while (current !== null)
    {
        const next: ListNode | null = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }

    return prev;
}

function reverseSubList(head: ListNode | null, start: number, end: number): ListNode | null
{
    if (start === end) return head;

    const dummy: ListNode = new ListNode(0);
    dummy.next = head;
    let prev: ListNode = dummy;

    for (let i = 0; i < start - 1; i++)
    {
        prev = prev.next!;
    }

    let current: ListNode | null = prev.next;
    let next: ListNode | null = null;

    for (let i = 0; i < end - start + 1; i++)
    {
        next = current!.next;
        current!.next = prev.next;
        prev.next = current;
        current = next;
    }

    head!.next = next;
    return dummy.next;
}

function isPalindrome(head: ListNode | null): boolean
{
    if (head === null || head.next === null) return true;

    let slow: ListNode | null = head;
    let fast: ListNode | null = head;

    while (fast !== null && fast.next !== null)
    {
        slow = slow!.next;
        fast = fast.next.next;
    }

    let secondHalf: ListNode | null = reverseLinkedList(slow);
    let firstHalf: ListNode | null = head;

    while (secondHalf !== null)
    {
        if (firstHalf!.val !== secondHalf.val)
        {
            return false;
        }

        firstHalf = firstHalf!.next;
        secondHalf = secondHalf.next;
    }

    return true;
}
*/

#endregion

//Pattern #7: Tree Breadth-First Search (BFS)
/*Definition: The "Tree Breadth-First Search (BFS)" pattern involves traversing a tree level by level. This pattern is useful for solving problems that require visiting all the 
nodes in a tree level by level, such as level order traversal, finding the minimum depth of a binary tree, or connecting level-order siblings.*/

//Common Problems:
//Level Order Traversal: Traverse a binary tree level by level and store each level's nodes in a separate list.
//Minimum Depth of Binary Tree: Find the minimum depth of a binary tree, which is the shortest distance from the root node to a leaf node.
//Connect Level-Order Siblings: Connect nodes at the same level of a binary tree using the "next" pointer.

#region C# implementation

/*
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class ConnectNode {
    public int val;
    public ConnectNode left;
    public ConnectNode right;
    public ConnectNode next;
    public ConnectNode(int val = 0, ConnectNode left = null, ConnectNode right = null, ConnectNode next = null) {
        this.val = val;
        this.left = left;
        this.right = right;
        this.next = next;
    }
}

public IList<IList<int>> LevelOrder(TreeNode root) {
    IList<IList<int>> result = new List<IList<int>>();
    if (root == null) return result;

    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while (queue.Count > 0) {
        int levelSize = queue.Count;
        List<int> currentLevel = new List<int>();

        for (int i = 0; i < levelSize; i++) {
            TreeNode current = queue.Dequeue();
            currentLevel.Add(current.val);

            if (current.left != null) queue.Enqueue(current.left);
            if (current.right != null) queue.Enqueue(current.right);
        }

        result.Add(currentLevel);
    }

    return result;
}

public int MinDepth(TreeNode root) {
    if (root == null) return 0;

    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    int minDepth = 0;

    while (queue.Count > 0) {
        int levelSize = queue.Count;
        minDepth++;

        for (int i = 0; i < levelSize; i++) {
            TreeNode current = queue.Dequeue();

            if (current.left == null && current.right == null) {
                return minDepth;
            }

            if (current.left != null) queue.Enqueue(current.left);
            if (current.right != null) queue.Enqueue(current.right);
        }
    }

    return minDepth;
}

public ConnectNode Connect(ConnectNode root) {
    if (root == null) return null;

    Queue<ConnectNode> queue = new Queue<ConnectNode>();
    queue.Enqueue(root);

    while (queue.Count > 0) {
        int levelSize = queue.Count;
        ConnectNode prevNode = null;

        for (int i = 0; i < levelSize; i++) {
            ConnectNode current = queue.Dequeue();

            if (prevNode != null) {
                prevNode.next = current;
            }

            prevNode = current;

            if (current.left != null) queue.Enqueue(current.left);
            if (current.right != null) queue.Enqueue(current.right);
        }
    }

    return root;
}
*/

#endregion

#region TypeScript implementation

/*
class TreeNode
{
    val: number;
    left: TreeNode | null;
    right: TreeNode | null;
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null)
    {
        this.val = val === undefined ? 0 : val;
        this.left = left === undefined ? null : left;
        this.right = right === undefined ? null : right;
    }
}

class ConnectNode
{
    val: number;
    left: ConnectNode | null;
    right: ConnectNode | null;
    next: ConnectNode | null;
    constructor(val?: number, left?: ConnectNode | null, right?: ConnectNode | null, next?: ConnectNode | null)
    {
        this.val = val === undefined ? 0 : val;
        this.left = left === undefined ? null : left;
        this.right = right === undefined ? null : right;
        this.next = next === undefined ? null : next;
    }
}

function levelOrder(root: TreeNode | null): number[][]
{
    const result: number[][] = [];
    if (!root) return result;

    const queue: TreeNode[] = [root];

    while (queue.length > 0)
    {
        const levelSize = queue.length;
        const currentLevel: number[] = [];

        for (let i = 0; i < levelSize; i++)
        {
            const current = queue.shift()!;
            currentLevel.push(current.val);

            if (current.left) queue.push(current.left);
            if (current.right) queue.push(current.right);
        }

        result.push(currentLevel);
    }

    return result;
}

function minDepth(root: TreeNode | null): number
{
    if (!root) return 0;

    const queue: TreeNode[] = [root];
    let minDepth = 0;

    while (queue.length > 0)
    {
        const levelSize = queue.length;
        minDepth++;

        for (let i = 0; i < levelSize; i++)
        {
            const current = queue.shift()!;

            if (!current.left && !current.right)
            {
                return minDepth;
            }

            if (current.left) queue.push(current.left);
            if (current.right) queue.push(current.right);
        }
    }

    return minDepth;
}

function connect(root: ConnectNode | null): ConnectNode | null {
    if (!root) return null;

    const queue: ConnectNode[] = [root];

    while (queue.length > 0)
    {
        const levelSize = queue.length;
        let prevNode: ConnectNode | null = null;

        for (let i = 0; i < levelSize; i++)
        {
            const current = queue.shift()!;

            if (prevNode)
            {
                prevNode.next = current;
            }

            prevNode = current;

            if (current.left) queue.push(current.left);
            if (current.right) queue.push(current.right);
        }
    }

    return root;
}*/

#endregion

//Pattern #8: Tree Depth-First Search (DFS)
/*Definition: The "Tree Depth-First Search (DFS)" pattern involves traversing a tree in a depth-first manner. This pattern is useful for solving problems that require exploring all the nodes in a tree recursively, such as pre-order, in-order, and post-order traversals, finding path sums, and listing all root-to-leaf paths.*/

//Common Problems:
//Pre-order Traversal: Traverse a binary tree in a "root-left-right" order and store the node values in a list.
//In-order Traversal: Traverse a binary tree in a "left-root-right" order and store the node values in a list.
//Post-order Traversal: Traverse a binary tree in a "left-right-root" order and store the node values in a list.
//Path Sum: Check if there exists a root-to-leaf path with a specific sum.
//All Root-to-Leaf Paths: Find all root-to-leaf paths in a binary tree and store them in a list.

#region C# implementation

/*
public int[] FindOrder(int numCourses, int[][] prerequisites)
{
    List<int>[] graph = new List<int>[numCourses];
    for (int i = 0; i < numCourses; i++)
    {
        graph[i] = new List<int>();
    }

    foreach (int[] prerequisite in prerequisites)
    {
        graph[prerequisite[1]].Add(prerequisite[0]);
    }

    List<int> topologicalOrder = new List<int>();
    bool[] visited = new bool[numCourses];
    bool[] recursiveStack = new bool[numCourses];

    for (int i = 0; i < numCourses; i++)
    {
        if (!visited[i] && IsCyclic(i, graph, visited, recursiveStack, topologicalOrder))
        {
            return new int[0];
        }
    }

    topologicalOrder.Reverse();
    return topologicalOrder.ToArray();
}

private bool IsCyclic(int current, List<int>[] graph, bool[] visited, bool[] recursiveStack, List<int> topologicalOrder)
{
    if (recursiveStack[current])
    {
        return true;
    }

    if (visited[current])
    {
        return false;
    }

    visited[current] = true;
    recursiveStack[current] = true;

    foreach (int neighbor in graph[current])
    {
        if (IsCyclic(neighbor, graph, visited, recursiveStack, topologicalOrder))
        {
            return true;
        }
    }

    recursiveStack[current] = false;
    topologicalOrder.Add(current);

    return false;
}
*/

#endregion

#region TypeScript implementation

/*
function findOrder(numCourses: number, prerequisites: number[][]): number[]
{
    const graph: Map<number, number[]> = new Map();
    for (const [course, dependency] of prerequisites) {
        if (!graph.has(dependency))
        {
            graph.set(dependency, []);
        }
        graph.get(dependency)!.push(course);
    }

    const topologicalOrder: number[] = [];
    const visited: boolean[] = new Array(numCourses).fill(false);
    const recursiveStack: boolean[] = new Array(numCourses).fill(false);

    for (let i = 0; i < numCourses; i++)
    {
        if (!visited[i] && isCyclic(i, graph, visited, recursiveStack, topologicalOrder))
        {
            return [];
        }
    }

    return topologicalOrder.reverse();
}

function isCyclic(
    current: number,
    graph: Map<number, number[]>,
    visited: boolean[],
    recursiveStack: boolean[],
    topologicalOrder: number[]
): boolean
{
    if (recursiveStack[current])
    {
        return true;
    }

    if (visited[current])
    {
        return false;
    }

    visited[current] = true;
    recursiveStack[current] = true;

    for (const neighbor of graph.get(current) || []) {
        if (isCyclic(neighbor, graph, visited, recursiveStack, topologicalOrder))
        {
            return true;
        }
    }

    recursiveStack[current] = false;
    topologicalOrder.push(current);

    return false;
}
*/

#endregion

//Pattern #9: Two Heaps
/*Definition: The "Two Heaps" pattern involves using two heaps to solve problems efficiently. Typically, the two heaps are a max heap and a min heap, and they are 
used together to keep track of certain elements while efficiently extracting maximum or minimum elements from the data. This pattern is useful for solving problems that involve finding the median of a stream of numbers, sliding window median, or finding the Kth largest element in an array.*/

//Common Problems:

//Find the Median of a Stream of Numbers: Find the median of a stream of numbers received one by one. The two heaps can be used to keep track of the elements on both
//sides of the median, allowing for efficient median retrieval.

//Sliding Window Median: Find the median of each sliding window in an array. The two heaps can be used to maintain the elements within the window and efficiently find the median.

//Kth Largest Element in an Array: Find the Kth largest element in an array. The two heaps can be used to efficiently keep track of the K largest elements seen so far and find the
//Kth largest.

#region C# implementation

/*
public class MedianFinder
{
    private readonly PriorityQueue<int> maxHeap;
    private readonly PriorityQueue<int> minHeap;

    public MedianFinder()
    {
        maxHeap = new PriorityQueue<int>((a, b) => b - a);
        minHeap = new PriorityQueue<int>((a, b) => a - b);
    }

    public void AddNum(int num)
    {
        if (maxHeap.Count == 0 || num <= maxHeap.Peek())
        {
            maxHeap.Enqueue(num);
        }
        else
        {
            minHeap.Enqueue(num);
        }

        if (maxHeap.Count > minHeap.Count + 1)
        {
            minHeap.Enqueue(maxHeap.Dequeue());
        }
        else if (minHeap.Count > maxHeap.Count)
        {
            maxHeap.Enqueue(minHeap.Dequeue());
        }
    }

    public double FindMedian()
    {
        if (maxHeap.Count == minHeap.Count)
        {
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }
        else
        {
            return maxHeap.Peek();
        }
    }
}

public class PriorityQueue<T>
{
    private readonly List<T> data;
    private readonly Comparison<T> comparison;

    public PriorityQueue(Comparison<T> comparison)
    {
        data = new List<T>();
        this.comparison = comparison;
    }

    public int Count => data.Count;

    public void Enqueue(T item)
    {
        data.Add(item);
        int childIndex = data.Count - 1;
        while (childIndex > 0)
        {
            int parentIndex = (childIndex - 1) / 2;
            if (comparison(data[childIndex], data[parentIndex]) > 0)
            {
                Swap(childIndex, parentIndex);
                childIndex = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    public T Dequeue()
    {
        int lastIndex = data.Count - 1;
        T frontItem = data[0];
        data[0] = data[lastIndex];
        data.RemoveAt(lastIndex);

        lastIndex--;
        int parentIndex = 0;

        while (true)
        {
            int leftChildIndex = parentIndex * 2 + 1;
            int rightChildIndex = parentIndex * 2 + 2;

            if (leftChildIndex > lastIndex)
            {
                break;
            }

            int childIndex = (rightChildIndex <= lastIndex && comparison(data[rightChildIndex], data[leftChildIndex]) > 0)
                ? rightChildIndex
                : leftChildIndex;

            if (comparison(data[childIndex], data[parentIndex]) > 0)
            {
                Swap(childIndex, parentIndex);
                parentIndex = childIndex;
            }
            else
            {
                break;
            }
        }

        return frontItem;
    }

    public T Peek()
    {
        return data[0];
    }

    private void Swap(int i, int j)
    {
        T temp = data[i];
        data[i] = data[j];
        data[j] = temp;
    }
}
*/

#endregion

#region TypeScript implementation

/*
class MedianFinder
{
    private maxHeap: PriorityQueue<number>;
    private minHeap: PriorityQueue<number>;

    constructor()
    {
        this.maxHeap = new PriorityQueue<number>((a, b) => b - a);
        this.minHeap = new PriorityQueue<number>((a, b) => a - b);
    }

    addNum(num: number) : void {
        if (this.maxHeap.size() === 0 || num <= this.maxHeap.peek()) {
            this.maxHeap.enqueue(num);
        } else {
            this.minHeap.enqueue(num);
        }

        if (this.maxHeap.size() > this.minHeap.size() + 1) {
            this.minHeap.enqueue(this.maxHeap.dequeue()!);
        } else if (this.minHeap.size() > this.maxHeap.size()) {
            this.maxHeap.enqueue(this.minHeap.dequeue()!);
        }
    }

    findMedian() : number {
        if (this.maxHeap.size() === this.minHeap.size()) {
            return (this.maxHeap.peek() + this.minHeap.peek()) / 2;
        } else {
            return this.maxHeap.peek();
        }
    }
}

class PriorityQueue<T>
{
    private data: T[];
    private readonly comparison: (a: T, b: T) => number;

    constructor(comparison: (a: T, b: T) => number) {
        this.data = [];
        this.comparison = comparison;
    }

    size(): number
    {
        return this.data.length;
    }

    enqueue(item: T): void
    {
        this.data.push(item);
        let childIndex = this.data.length - 1;
        while (childIndex > 0)
        {
            const parentIndex = Math.floor((childIndex - 1) / 2);
            if (this.comparison(this.data[childIndex], this.data[parentIndex]) > 0)
            {
                this.swap(childIndex, parentIndex);
                childIndex = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    dequeue(): T | undefined {
        const lastIndex = this.data.length - 1;
        const frontItem = this.data[0];
        this.data[0] = this.data[lastIndex];
        this.data.pop();

        let parentIndex = 0;
        while (true)
        {
            const leftChildIndex = parentIndex * 2 + 1;
            const rightChildIndex = parentIndex * 2 + 2;

            if (leftChildIndex > lastIndex)
            {
                break;
            }

            const childIndex =
                rightChildIndex <= lastIndex && this.comparison(this.data[rightChildIndex], this.data[leftChildIndex]) > 0
                    ? rightChildIndex
                    : leftChildIndex;

            if (this.comparison(this.data[childIndex], this.data[parentIndex]) > 0)
            {
                this.swap(childIndex, parentIndex);
                parentIndex = childIndex;
            }
            else
            {
                break;
            }
        }

        return frontItem;
    }

    peek(): T | undefined {
        return this.data[0];
    }

    private swap(i: number, j: number): void
    {
        [this.data[i], this.data[j]] = [this.data[j], this.data[i]];
    }
}
*/

#endregion

//Pattern #10: Subsets
/*Definition: The "Subsets" pattern involves generating all possible subsets (or combinations) of a given set of elements. 
This pattern is commonly used in problems that require trying out all possible combinations of elements.*/

//Common Problems:
//Subset Generation: Generate all possible subsets of a given set of elements.
//Permutations: Generate all possible permutations of a given set of elements.
//Combination Sum: Find all unique combinations of elements in a set that add up to a target sum.
//Power Set: Generate the power set of a given set, which includes all possible subsets.

#region C# implementation

/*
public IList<IList<int>> Subsets(int[] nums)
{
    IList<IList<int>> subsets = new List<IList<int>>();
    GenerateSubsets(nums, 0, new List<int>(), subsets);
    return subsets;
}

private void GenerateSubsets(int[] nums, int start, List<int> currentSubset, IList<IList<int>> subsets)
{
    subsets.Add(new List<int>(currentSubset));

    for (int i = start; i < nums.Length; i++)
    {
        currentSubset.Add(nums[i]);
        GenerateSubsets(nums, i + 1, currentSubset, subsets);
        currentSubset.RemoveAt(currentSubset.Count - 1);
    }
}
*/

#endregion

#region TypeScript implementation

/*
function subsets(nums: number[]): number[][]
{
    const subsets: number[][] = [];
    generateSubsets(nums, 0, [], subsets);
    return subsets;
}

function generateSubsets(nums: number[], start: number, currentSubset: number[], subsets: number[][]): void
{
    subsets.push([...currentSubset]);

    for (let i = start; i < nums.length; i++)
    {
        currentSubset.push(nums[i]);
        generateSubsets(nums, i + 1, currentSubset, subsets);
        currentSubset.pop();
    }
}
*/

#endregion

//Pattern #11: Modified Binary Search
/*Definition: The "Modified Binary Search" pattern involves using binary search to efficiently solve problems that deal with sorted or rotated arrays. 
It is especially useful when the array has some modifications like rotation or being sorted in a specific order.*/

//Common Problems:
//Binary Search in a Sorted Array: Find the index of a target element in a sorted array.
//Find the Rotation Count in a Rotated Array: Determine the number of times a sorted array has been rotated.

#region C# implementation

/*
public int FindMin(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] > nums[right])
        {
            left = mid + 1;
        }
        else if (nums[mid] < nums[right])
        {
            right = mid;
        }
        else
        {
            right--;
        }
    }

    return nums[left];
}
*/

#endregion

#region TypeScript implementation

/*
function findMin(nums: number[]): number
{
    let left = 0;
    let right = nums.length - 1;

    while (left < right)
    {
        const mid = left + Math.floor((right - left) / 2);

        if (nums[mid] > nums[right])
        {
            left = mid + 1;
        }
        else if (nums[mid] < nums[right])
        {
            right = mid;
        }
        else
        {
            right--;
        }
    }

    return nums[left];
}
*/

#endregion

//Pattern #12: Topological Sort
/*Definition: The "Topological Sort" pattern involves ordering elements in such a way that, for any directed edge (A, B), node A appears before node B in the 
ordering. It is used to solve problems that involve tasks scheduling, course scheduling, or dependency resolution, where certain tasks or courses must be completed before others.*/

//Common Problems:
//Course Schedule: Determine if it is possible to complete all courses.
//Task Scheduling: Determine if it is possible to schedule tasks based on prerequisites.
//Dependency Resolution: Resolve dependencies among various tasks or modules.
//Build Order: Determine the correct order in which to build or compile modules.

#region C# implementation

/*
public int[] FindOrder(int numCourses, int[][] prerequisites)
{
    Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
    int[] inDegree = new int[numCourses];

    foreach (int[] prerequisite in prerequisites)
    {
        int course = prerequisite[0];
        int dependency = prerequisite[1];

        if (!graph.ContainsKey(dependency))
        {
            graph[dependency] = new List<int>();
        }
        graph[dependency].Add(course);

        inDegree[course]++;
    }

    Queue<int> queue = new Queue<int>();
    for (int i = 0; i < numCourses; i++)
    {
        if (inDegree[i] == 0)
        {
            queue.Enqueue(i);
        }
    }

    int[] order = new int[numCourses];
    int index = 0;

    while (queue.Count > 0)
    {
        int course = queue.Dequeue();
        order[index++] = course;

        if (graph.ContainsKey(course))
        {
            foreach (int dependentCourse in graph[course])
            {
                inDegree[dependentCourse]--;
                if (inDegree[dependentCourse] == 0)
                {
                    queue.Enqueue(dependentCourse);
                }
            }
        }
    }

    return index == numCourses ? order : new int[0];
}
*/

#endregion

#region TypeScript implementation

/*
function findOrder(numCourses: number, prerequisites: number[][]): number[]
{
    const graph: Map<number, number[]> = new Map();
    const inDegree: number[] = new Array(numCourses).fill(0);

    for (const [course, dependency] of prerequisites) {
        if (!graph.has(dependency))
        {
            graph.set(dependency, []);
        }
        graph.get(dependency)!.push(course);

        inDegree[course]++;
    }

    const queue: number[] = [];
    for (let i = 0; i < numCourses; i++)
    {
        if (inDegree[i] === 0)
        {
            queue.push(i);
        }
    }

    const order: number[] = [];
    let index = 0;

    while (queue.length > 0)
    {
        const course = queue.shift()!;
        order[index++] = course;

        if (graph.has(course))
        {
            for (const dependentCourse of graph.get(course)!) {
                inDegree[dependentCourse]--;
                if (inDegree[dependentCourse] === 0)
                {
                    queue.push(dependentCourse);
                }
            }
        }
    }

    return index === numCourses ? order : [];
}
*/

#endregion

//Pattern #13: Knapsack (0/1)
/*Definition: The "Knapsack (0/1)" pattern is used to solve problems that involve making a choice from a set of items with a limited capacity. The goal is to maximize or 
minimize a certain value while considering weight constraints.*/

//Common Problems:
//Subset Sum: Determine if there is a subset that sums up to a target value.
//Equal Sum Partition: Divide a set of numbers into two subsets with equal sum.
//0/1 Knapsack Problem: Maximize the value of items picked in a knapsack with a weight constraint.
//Minimum Subset Sum Difference: Find the minimum difference between two subsets of a set.

#region C# implementation

/*
public int Knapsack(int[] weights, int[] profits, int capacity)
{
    int[,] dp = new int[weights.Length + 1, capacity + 1];

    for (int i = 1; i <= weights.Length; i++)
    {
        for (int w = 1; w <= capacity; w++)
        {
            if (weights[i - 1] <= w)
            {
                dp[i, w] = Math.Max(profits[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
            }
            else
            {
                dp[i, w] = dp[i - 1, w];
            }
        }
    }

    return dp[weights.Length, capacity];
}
*/

#endregion

#region TypeScript implementation

/*
function knapsack(weights: number[], profits: number[], capacity: number): number
{
    const dp: number[][] = new Array(weights.length + 1).fill(0).map(() => new Array(capacity + 1).fill(0));

    for (let i = 1; i <= weights.length; i++)
    {
        for (let w = 1; w <= capacity; w++)
        {
            if (weights[i - 1] <= w)
            {
                dp[i][w] = Math.max(profits[i - 1] + dp[i - 1][w - weights[i - 1]], dp[i - 1][w]);
            }
            else
            {
                dp[i][w] = dp[i - 1][w];
            }
        }
    }

    return dp[weights.length][capacity];
}
*/

#endregion

//Pattern #14: Top K Elements
/*Definition: The "Top K Elements" pattern is used to find the top K elements in a given dataset. It can be used to solve problems like finding the Kth largest/smallest 
element in an array, finding the top K frequent elements, or finding the top K numbers in a stream of elements.*/

//Common Problems:
//Kth Largest/Smallest Element in an Array: Find the Kth largest/smallest element in an array.
//Top K Frequent Elements: Find the K most frequent elements in an array.
//Top K Numbers in a Stream: Find the top K numbers in a stream of elements.

#region C# implementation

/*
public int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (frequencyMap.ContainsKey(num))
        {
            frequencyMap[num]++;
        }
        else
        {
            frequencyMap[num] = 1;
        }
    }

    List<int> topKFrequent = new List<int>();
    foreach (var item in frequencyMap.OrderByDescending(key => key.Value).Take(k))
    {
        topKFrequent.Add(item.Key);
    }

    return topKFrequent.ToArray();
}
*/

#endregion

#region TypeScript implementation

/*
function topKFrequent(nums: number[], k: number): number[]
{
    const frequencyMap = new Map<number, number>();
    for (const num of nums) {
        frequencyMap.set(num, (frequencyMap.get(num) || 0) + 1);
    }

    const topKFrequent: number[] = [];
    for (const [key, value] of [...frequencyMap.entries()].sort((a, b) => b[1] - a[1]).slice(0, k)) {
        topKFrequent.push(key);
    }

    return topKFrequent;
}
*/

#endregion
