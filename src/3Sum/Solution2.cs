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

    int index1 = 0, index2 = 1, num3;

    while (index1 < sortedNums.Count - 2)
    {
      while (index2 < sortedNums.Count - 1)
      {
        num3 = -(sortedNums[index1] + sortedNums[index2]);

        int lastIndex = sortedNums.LastIndexOf(num3, sortedNums.Count - 1, sortedNums.Count - index2);

        if (lastIndex > index2)
        {
          triplet = new List<int> { sortedNums[index1], sortedNums[index2], num3 };
          if (doesNotContain(result, triplet))
          {
            result.Add(triplet);
          }
        }

        index2++;
      }

      index1++;
      index2 = index1 + 1;
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


