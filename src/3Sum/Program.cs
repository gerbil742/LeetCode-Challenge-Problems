// See https://aka.ms/new-console-template for more information
using ThreeSum;
Console.WriteLine("Hello, World!");

int[] input1 = { 0, 4, 0, -2, 3, 1, -5, 0 };
//List<List<int>> expected1 = new List<List<int>> { new List<int> { -8, 4, 4 }, new List<int> { -4, 0, 4 } };

IList<IList<int>> value1 = Solution2.ThreeSum(input1);
foreach (IList<int> list in value1)
{
  foreach (int num in list)
  {
    System.Console.WriteLine(num);
  }
}
//value1.Should().BeEquivalentTo(expected1);
