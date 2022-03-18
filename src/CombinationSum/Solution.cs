namespace CombinationSum;

using System.Collections.Generic;

public class Solution
{
  public static IList<IList<int>> CombinationSum(int[] candidates, int target)
  {
    // iterate through multiplying each digit from 1 to x times where x times will bust 
    // 2 + 2 + 2 + 2 -> bust -> 2 + 2 + 2 + 3 -> bust -> 2 + 2 + 3 -> return 2, 2, 3;
    // this is a binary tree. travle down the tree trace the patch and return the path
    // on 2. checkSum( 2, 3, 6, 7) -> 6 and 7 will bust

    IList<IList<int>> result = new List<IList<int>>();
    List<List<int>> possibleMultiplicands = FindMultiplicands(candidates, target);

    // Find the total amount of possible combinations of indexes on which to check for a correct combination
    List<Node> tree = CreateTree(possibleMultiplicands);
    List<List<int>> allPossibleMultiplesOfCandidates = FindAllPossiblePaths(tree, target);

    result = CreateFinalResult(candidates, allPossibleMultiplesOfCandidates);

    return result;
  }

  // Find all the possible ways we can multiple each input in candidates to potentiall reach the target. 
  public static List<List<int>> FindMultiplicands(int[] candidates, int target)
  {
    List<int> multiplicands;
    List<List<int>> possibleMultiplicands = new List<List<int>>();

    foreach (int candidate in candidates)
    {
      multiplicands = new List<int> { 0 };
      for (int i = 1; candidate * i <= target; i++)
      {
        if (candidate * i <= target) multiplicands.Add(i * candidate);
      }

      possibleMultiplicands.Add(multiplicands);
    }

    return possibleMultiplicands;
  }

  public static List<Node> CreateTree(List<List<int>> valuesLists)
  {
    List<Node> newNodes = new List<Node>();
    List<int> currentValuesList = valuesLists[0];

    for (int i = 0; i < currentValuesList.Count; i++)
    {
      newNodes.Add(new Node(currentValuesList[i]));
    }

    List<List<int>> nextValuesLists = new List<List<int>>(valuesLists);
    nextValuesLists.RemoveAt(0);

    if (nextValuesLists.Count != 0)
    {
      foreach (Node node in newNodes)
      {
        node.SetNeighbors(CreateTree(nextValuesLists));
      }
    }

    return newNodes;
  }

  public static List<List<int>> FindPathsForCurrentNode(Node currentNode, int target, List<int> path, int sum)
  {
    //List<List<int>> successfulPaths = new List<List<int>>();
    // coppy the current path and add the current node; 
    List<int> newPath = new List<int>(path);
    List<List<int>> successfulPaths = new List<List<int>>();
    newPath.Add(currentNode.Value);
    sum += currentNode.Value;

    if (sum > target)
    {
      return successfulPaths;
    }
    else if (currentNode.Neighbors.Count == 0 && sum == target)
    {
      successfulPaths.Add(newPath);
    }

    foreach (Node node in currentNode.Neighbors)
    {
      successfulPaths.AddRange(FindPathsForCurrentNode(node, target, newPath, sum));
    }

    return successfulPaths;
  }

  public static List<List<int>> FindAllPossiblePaths(List<Node> tree, int target)
  {
    List<List<int>> successfulPaths = new List<List<int>>();

    foreach (Node node in tree)
    {
      List<List<int>> paths = FindPathsForCurrentNode(node, target, new List<int>(), 0);
      foreach (List<int> path in paths)
      {
        successfulPaths.Add(path);
      }
    }

    return successfulPaths;
  }

  public static IList<IList<int>> CreateFinalResult(int[] candidates, List<List<int>> candidateMultiples)
  {
    IList<IList<int>> result = new List<IList<int>>();
    List<int> resultRow;

    foreach (List<int> multiples in candidateMultiples)
    {
      resultRow = new List<int>();
      for (int candidateIndex = 0; candidateIndex < multiples.Count; candidateIndex++)
      {
        // add candidate to the output x amount of times where x is the number for multiple;
        int timesAddingCandidate = multiples[candidateIndex] / candidates[candidateIndex];
        for (int index = 0; index < timesAddingCandidate; index++)
        {
          resultRow.Add(candidates[candidateIndex]);
        }
      }

      result.Add(resultRow);
    }

    return result;
  }
}

public class Node
{
  public int Value { get; private set; }
  public List<Node> Neighbors { get; }

  public Node(int val)
  {
    Value = val;
    Neighbors = new List<Node>();
  }

  public void SetNeighbors(List<Node> nodes)
  {
    foreach (Node node in nodes)
    {
      Neighbors.Add(node);
    }
  }
}