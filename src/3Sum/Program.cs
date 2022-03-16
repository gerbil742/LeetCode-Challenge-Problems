// See https://aka.ms/new-console-template for more information
using ThreeSum;
Console.WriteLine("Hello, World!");

int[] input1 = { -1, 0, 1, 2, -1, -4 };
//List<List<int>> expected1 = new List<List<int>> { new List<int> { -8, 4, 4 }, new List<int> { -4, 0, 4 } };

IList<IList<int>> value1 = Solution.ThreeSum(input1);
foreach (IList<int> list in value1)
{
  foreach (int num in list)
  {
    System.Console.WriteLine(num);
  }
}
//value1.Should().BeEquivalentTo(expected1);
