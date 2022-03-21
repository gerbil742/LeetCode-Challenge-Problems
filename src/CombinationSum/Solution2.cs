namespace CombinationSum;

using System.Collections.Generic;

public class Solution2
{
  public static IList<IList<int>> CombinationSum(int[] candidates, int target)
  {
    IList<IList<int>> result = new List<IList<int>>();

    // valid state. when the sum of teh state is = to target. 
    // state. a list of multiples of candidates. 
    // candidate a number we want to add to our state. 
    List<int> sortedCandidates = new List<int>(candidates);
    sortedCandidates.Sort();

    findAllCombinations(result, new List<int>(), target, sortedCandidates);

    return result;
  }

  public static void findAllCombinations(IList<IList<int>> solutions, List<int> combination, int target, List<int> candidates)
  {
    for (int index = 0; index < candidates.Count; index++)
    {
      int num = candidates[index];

      combination.Add(num);

      if (combination.Sum() > target)
      {
        combination.RemoveAt(combination.Count - 1);
        return;
      }

      if (combination.Sum() == target)
      {
        solutions.Add(new List<int>(combination));

        combination.RemoveAt(combination.Count - 1); // reset candidates for when we return back to origional stack
        return;
      }

      findAllCombinations(solutions, combination, target, candidates.GetRange(index, candidates.Count - index));
      combination.RemoveAt(combination.Count - 1);
    }
  }
}