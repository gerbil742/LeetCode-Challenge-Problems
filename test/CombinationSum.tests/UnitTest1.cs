namespace CombinationSum.Tests;

using Xunit;
using FluentAssertions;
using System.Collections.Generic;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    int target = 7;
    int[] candidates = new int[] { 2, 3, 6, 7 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 2, 2, 3 }, new List<int> { 7 } };

    IList<IList<int>> result = Solution.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void Test2()
  {
    int target = 8;
    int[] candidates = new int[] { 2, 3, 5 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 2, 2, 2, 2 }, new List<int> { 7 }, new List<int> { 2, 3, 3 }, new List<int> { 3, 5 } };

    IList<IList<int>> result = Solution.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void Test3()
  {
    int target = 1;
    int[] candidates = new int[] { 2 };
    List<List<int>> expected = new List<List<int>> { };

    IList<IList<int>> result = Solution.CombinationSum(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void CreateTreeReturnsCorrectTree()
  {
    List<List<int>> input = new List<List<int>> { new List<int> { 3, 2, 1 }, new List<int> { 2, 1 }, new List<int> { 0, 1 } };
    List<Node> testNodes1 = new List<Node>();
    List<Node> testNodes2 = new List<Node>();
    List<Node> testNodes3 = new List<Node>();

    Node node1 = new Node(2);
    Node node2 = new Node(1);
    Node node3 = new Node(0);
    Node node4 = new Node(1);
    Node node13 = new Node(3);
    Node node12 = new Node(2);
    Node node11 = new Node(1);

    testNodes2.AddRange(new List<Node> { node3, node4 });

    node1.SetNeighbors(testNodes2);
    node2.SetNeighbors(testNodes2);
    testNodes1.AddRange(new List<Node> { node1, node2 });

    node11.SetNeighbors(testNodes1);
    node12.SetNeighbors(testNodes1);
    node13.SetNeighbors(testNodes1);
    List<Node> expected = new List<Node> { node13, node12, node11 };

    List<Node> result = Solution.CreateTree(input);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void FindMultiplicandsReturnsCorrectValues()
  {
    int target = 7;
    int[] candidates = new int[] { 2, 3, 6, 7 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 0, 2, 4, 6 }, new List<int> { 0, 3, 6 }, new List<int> { 0, 6 }, new List<int> { 0, 7 } };

    List<List<int>> result = Solution.FindMultiplicands(candidates, target);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void FindPathsForCurrentNodeReturnsCorrectValues()
  {
    List<Node> tree = Solution.CreateTree(new List<List<int>> { new List<int> { 0, 2, 4, 6 }, new List<int> { 0, 3, 6 }, new List<int> { 0, 6 }, new List<int> { 0, 7 } });
    int target = 7;
    int[] candidates = new int[] { 2, 3, 6, 7 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 4, 3, 0, 0 } };

    List<List<int>> result = Solution.FindPathsForCurrentNode(tree[2], target, new List<int>(), 0);

    result.Should().BeEquivalentTo(expected);
  }

  [Fact]
  public void FindAllPossiblePathsReturnsCorrectResult()
  {
    List<Node> tree = Solution.CreateTree(new List<List<int>> { new List<int> { 0, 2, 4, 6 }, new List<int> { 0, 3, 6 }, new List<int> { 0, 6 }, new List<int> { 0, 7 } });
    int target = 7;
    int[] candidates = new int[] { 2, 3, 6, 7 };
    List<List<int>> expected = new List<List<int>> { new List<int> { 4, 3, 0, 0 }, new List<int> { 0, 0, 0, 7 } };

    List<List<int>> result = Solution.FindAllPossiblePaths(tree, target);

    result.Should().BeEquivalentTo(expected);
  }
}