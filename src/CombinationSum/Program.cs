// See https://aka.ms/new-console-template for more information
using CombinationSum;

Console.WriteLine("Hello, World!");

int target = 69;
int[] candidates = new int[] { 48, 22, 49, 24, 26, 47, 33, 40, 37, 39, 31, 46, 36, 43, 45, 34, 28, 20, 29, 25, 41, 32, 23 };

IList<IList<int>> result = Solution.CombinationSum(candidates, target);
