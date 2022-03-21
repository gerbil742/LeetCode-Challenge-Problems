namespace CombinationSum.Tests;

using Xunit;
using FluentAssertions;
using System.Collections.Generic;

public class Solution2Test
{
  [Fact]
  public void Test1()
  {
    int target = 7;
    int[] candidates = new int[] { 2, 3, 6, 7 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 2, 2, 3 }, new List<int> { 7 } };

    IList<IList<int>> result = Solution2.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void Test2()
  {
    int target = 8;
    int[] candidates = new int[] { 2, 3, 5 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 2, 2, 2, 2 }, new List<int> { 2, 3, 3 }, new List<int> { 3, 5 } };

    IList<IList<int>> result = Solution2.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void Test3()
  {
    int target = 1;
    int[] candidates = new int[] { 2 };
    List<List<int>> expected = new List<List<int>> { };

    IList<IList<int>> result = Solution2.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }
}