// See https://aka.ms/new-console-template for more information
using CombinationSum;

Console.WriteLine("Hello, World!");

int target = 7;
int[] candidates = new int[] { 2, 3, 6, 7 };

IList<IList<int>> result = Solution.CombinationSum(candidates, target);
