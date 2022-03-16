using Xunit;
using System.Collections.Generic;
using System;
using FluentAssertions;

namespace ThreeSum.Tests;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    int[] input1 = { -1, 0, 1, 2, -1, -4 };
    List<int> row1 = new List<int> { -1, -1, 2 };
    List<int> row2 = new List<int> { -1, 0, 1 };
    List<List<int>> expected1 = new List<List<int>> { row1, row2 };

    IList<IList<int>> value1 = Solution.ThreeSum(input1);

    value1.Should().BeEquivalentTo(expected1);
  }

  [Fact]
  public void Test2()
  {
    int[] input1 = { 0 };

    List<List<int>> expected1 = new List<List<int>> { };

    IList<IList<int>> value1 = Solution.ThreeSum(input1);

    value1.Should().BeEquivalentTo(expected1);
  }

  [Fact]
  public void Test3()
  {
    int[] input1 = { };

    List<List<int>> expected1 = new List<List<int>> { };

    IList<IList<int>> value1 = Solution.ThreeSum(input1);

    value1.Should().BeEquivalentTo(expected1);
  }

  [Fact]
  public void Test4()
  {
    int[] input1 = { -4, 4, 4, 4, 4, -8, 0 };
    List<List<int>> expected1 = new List<List<int>> { new List<int> { -8, 4, 4 }, new List<int> { -4, 0, 4 } };

    IList<IList<int>> value1 = Solution.ThreeSum(input1);

    value1.Should().BeEquivalentTo(expected1);
  }
}