using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace ThreeSum.Tests;

public class UnitTest2
{
  // [Fact]
  // public void Test1()
  // {
  //   int[] input1 = { -1, 0, 1, 2, -1, -4 };
  //   List<int> row1 = new List<int> { -1, -1, 2 };
  //   List<int> row2 = new List<int> { -1, 0, 1 };
  //   List<List<int>> expected1 = new List<List<int>> { row1, row2 };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test2()
  // {
  //   int[] input1 = { 0 };

  //   List<List<int>> expected1 = new List<List<int>> { };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test3()
  // {
  //   int[] input1 = { };

  //   List<List<int>> expected1 = new List<List<int>> { };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test4()
  // {
  //   int[] input1 = { -4, 4, 4, 4, 4, -8, 0 };
  //   List<List<int>> expected1 = new List<List<int>> { new List<int> { -8, 4, 4 }, new List<int> { -4, 0, 4 } };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test5()
  // {
  //   int[] input1 = { 0, 0, 0 };
  //   List<List<int>> expected1 = new List<List<int>> { new List<int> { 0, 0, 0 } };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }
  // [Fact]
  // public void Test6()
  // {
  //   int[] input1 = { 999, 999, 999, 999, 999, 999, 999, 999, 999, 999, 9999, 999, 999, 999 };
  //   List<List<int>> expected1 = new List<List<int>> { };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test7()
  // {
  //   int[] input1 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
  //   List<List<int>> expected1 = new List<List<int>> { new List<int> { -4, 0, 4 }, new List<int> { -4, 1, 3 }, new List<int> { -3, -1, 4 },
  //                                                     new List<int> { -3, 0, 3 }, new List<int> { -3, 1, 2 }, new List<int> { -2, -1, 3 }, new List<int> { -2, 0, 2 },
  //                                                     new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test8()
  // {
  //   int[] input1 = { -2, 0, 1, 1, 2 };
  //   List<List<int>> expected1 = new List<List<int>> { new List<int> { -2, 0, 2 }, new List<int> { -2, 1, 1 } };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }

  // [Fact]
  // public void Test9()
  // {
  //   int[] input1 = { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
  //   List<List<int>> expected1 = new List<List<int>> { new List<int> { -4, -2, 6 }, new List<int> { -4, 0, -4 },
  //                                                     new List<int> { -4, 1, 3 }, new List<int> { -4, 2, 2 },
  //                                                     new List<int> { -2, -2, 4 }, new List<int> { -2, 0, 2 } };

  //   IList<IList<int>> value1 = Solution2.ThreeSum(input1);

  //   value1.Should().BeEquivalentTo(expected1);
  // }
}