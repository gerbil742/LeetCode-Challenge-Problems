namespace CombinationSum;

using System.Collections.Generic;

public class Solution2
{
  public static IList<IList<int>> CombinationSum(int[] candidates, int target)
  {
    IList<IList<int>> result = new List<IList<int>>();

    List<int> sortedCandidates = new List<int>(candidates);
    sortedCandidates.Sort(); // sorting the array is important for our algorithim to work. Will allow for faster solution

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
        // combination is passed by reference, so remove the bad candidate from the combination to try the one at the next index. 
        combination.RemoveAt(combination.Count - 1);

        // if Sum(combination + current candidate) >= target, we dont need to check teh remaining combinations for that candidate since we sorted the array. 
        return;
      }

      if (combination.Sum() == target)
      {
        solutions.Add(new List<int>(combination));

        combination.RemoveAt(combination.Count - 1);
        return;
      }

      // if the sum is not yet >= target, Recursive call to findAllCombos(). this will take the current combination of candidates and adds
      // whatever the current index of canditates is to the list. This will keep happening until the total busts or hits the target.  
      findAllCombinations(solutions, combination, target, candidates.GetRange(index, candidates.Count - index));

      // the current candidate (num) didn't find any good combinations (didn't get to a return statement) 
      // so remove it from teh list of combinationions and iterate to teh next candidate
      combination.RemoveAt(combination.Count - 1);
    }
  }
}