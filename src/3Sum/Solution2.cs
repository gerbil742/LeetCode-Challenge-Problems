namespace ThreeSum;

using System.Linq;

public class Solution2
{
  public static IList<IList<int>> ThreeSum(int[] nums)
  {
    IList<IList<int>> result = new List<IList<int>>();
    List<int> triplet;

    List<int> sortedNums = new List<int>(nums);
    sortedNums.Sort();

    int index1 = 0, index2 = sortedNums.Count - 1, neededNum, sum, lastIndex;

    /*
      - If the sum of nums[index1 and index2] is >= the needednum, then we can only expect to find more matches with smaller numbers. therefore we should only decrease
        the right pointer, not increase the left pointer.
      - if the sum is = then which pointer to increment in undetermined. look for triplets after changing each pointer individulally and then finally change both pointers and continue 
      - If the sum of nums[index1 and index2] is < the needednum, then we can only expect to find more matches with bigger numbers. therefore we should increase
        the left pointer.
      - when you increnent a pointer, and you get eh same value, keep incrementing till you get teh next value. we already determined we need either smaller or bigger 
        numbers when we are about to increment, so there is no way another match can be found.
    */

    while (index1 < index2 - 1)
    {
      sum = sortedNums[index1] + sortedNums[index2];
      neededNum = -(sum);

      // Performs a reverse search for the num between index1 and index2 not including teh ends. Returns -1 if not found
      lastIndex = sortedNums.LastIndexOf(neededNum, index2 - 1, index2 - index1 - 1);

      if (lastIndex > 0)
      {
        triplet = new List<int> { sortedNums[index1], neededNum, sortedNums[index2] };
        result.Add(triplet);
      }

      // increment pointers
      if (sum == neededNum) // sum == neededNum == 0
      {
        // checking if nums[index1 + 1, index2] has any triplets
        int tempIndex1 = index1;
        do
        {
          tempIndex1++;
        } while (sortedNums[tempIndex1] == sortedNums[tempIndex1 - 1] && tempIndex1 < index2 - 1);

        sum = sortedNums[tempIndex1] + sortedNums[index2];
        neededNum = -(sum);
        lastIndex = sortedNums.LastIndexOf(neededNum, index2 - 1, index2 - tempIndex1 - 1);

        if (lastIndex > 0)
        {
          triplet = new List<int> { sortedNums[tempIndex1], neededNum, sortedNums[index2] };

          result.Add(triplet);
        }

        // checking if nums[index1, index2 - 1] has any triplets
        int tempIndex2 = index2;
        do
        {
          tempIndex2--;
        } while (sortedNums[tempIndex2] == sortedNums[tempIndex2 + 1] && tempIndex2 > index1 + 1);

        sum = sortedNums[index1] + sortedNums[tempIndex2];
        neededNum = -(sum);
        lastIndex = sortedNums.LastIndexOf(neededNum, tempIndex2 - 1, tempIndex2 - index1 - 1);

        if (lastIndex > 0)
        {
          triplet = new List<int> { sortedNums[index1], neededNum, sortedNums[tempIndex2] };

          result.Add(triplet);
        }

        index1 = tempIndex1;
        index2 = tempIndex2;
      }
      else if (sum > neededNum)
      {
        do
        {
          index2--;
        } while (sortedNums[index2] == sortedNums[index2 + 1] && index2 > index1 + 1);
      }
      else if (sum < neededNum)
      {
        do
        {
          index1++;
        } while (sortedNums[index1] == sortedNums[index1 - 1] && index1 < index2 - 1);
      }
    }

    return result;
  }

  public static bool doesNotContain(IList<IList<int>> listOFLists, List<int> otherList)
  {
    foreach (List<int> list in listOFLists)
    {
      if (list.SequenceEqual(otherList))
      {
        return false;
      }
    }

    return true;
  }
}


