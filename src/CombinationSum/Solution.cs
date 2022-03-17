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

    //int multiplicand = 0;
    //int multiplier = 0;
    IList<IList<int>> result = new List<IList<int>>();

    List<List<int>> possibleMultiplicands = findMultiplicands(candidates, target);
    //System.Console.WriteLine(string.Join("\n", possibleMultiplicands.ToArray()));

    // Find the total amount of possible combinations of indexes on which to check for a correct combination
    int numOfPossibleIndexes = 1;
    foreach (List<int> multiplicandList in possibleMultiplicands)
    {
      numOfPossibleIndexes *= multiplicandList.Count;
    }


    // find potential multiplicands for each of the candidates


    return result;
  }

  private static List<List<int>> findMultiplicands(int[] candidates, int target)
  {
    List<int> multiplicands;
    List<List<int>> possibleMultiplicands = new List<List<int>>();

    foreach (int candidate in candidates)
    {
      multiplicands = new List<int> { 0 };
      for (int i = 1; candidate * i <= target; i++)
      {
        if (candidate * i <= target) multiplicands.Add(i);
      }

      possibleMultiplicands.Add(multiplicands);
    }

    return possibleMultiplicands;
  }

  // When calculating the table of all potential indicies indexes, we need to know what number to modulus to know when to flip the bit of the number
  private static int[] calculateBitFlippers(List<List<int>> multiplicandList)
  {
    int[] flippers = new int[multiplicandList.Count - 1];

    for (int i = 1; i < multiplicandList.Count; i++)
    {
      flippers[i - 1] = multiplicandList[i].Count;
    }

    return flippers;
  }

  private static List<List<int>> createIndiciesTable(List<List<int>> multiplicandList)
  {
    List<List<int>> indiciesList = new List<List<int>>();
    List<int> bitFlippers = new List<int>(); // {12, 4, 2, 1}
    List<int> indicies = new List<int> { 0, 0, 0, 0 };

    // pass in array size for the table

    int arraySize = 48;

    for (int i = 0; i < arraySize; i++)
    {


    }

    return indiciesList;
  }

  private static List<Node> CreateTree(List<List<int>> valuesLists)
  {
    List<Nodes> newNodes = new List<Node>();
    List<int> currentValuesList = valuesLists[0];

    for (int i = 0; i < currentValues.Count; i++)
    {
      newNodes.Add(new Node(currentValuesList[i]));
    }

    List<List<int>> nextValuesLists = valuesLists.Remove(0);

    if (nextValuesLists.Count != 0)
    {
      foreach (Node node in newNodes)
      {
        node.setNeighbors(CreateTree(nextValuesLists));
      }
    }

    return newNodes;
  }

  private static List<Node> CreateNodeNeighbors(List<int> multiplicands)
  {

  }
}

public class Node
{
  public int value { get; private set; }
  public List<Node> neighbors { get; }

  public Node(int val)
  {
    value = val;
    neighbors = new List<Node>();
  }

  public void setNeighbors(List<Node> nodes)
  {
    foreach (Node node in nodes)
    {
      neighbors.Add(node);
    }
  }
}