namespace ThreeSum;
public class Solution3
{
  public static IList<IList<int>> ThreeSum(int[] nums)
  {
    IList<IList<int>> result = new List<IList<int>>();
    List<int> triplet;

    List<int> sortedNums = new List<int>(nums);
    sortedNums.Sort();

    int neededNum, sum, neededNumIndex;



    for (int index1 = 0; index1 < sortedNums.Count - 2; index1++)
    {
      for (int index2 = sortedNums.Count - 1; index2 > index1 + 1; index2--)
      {
        sum = sortedNums[index1] + sortedNums[index2];
        neededNum = -(sum);

        // Performs a reverse search for the num between index1 and index2 not including teh ends. Returns -1 if not found
        neededNumIndex = sortedNums.LastIndexOf(neededNum, index2 - 1, index2 - index1 - 1);

        if (neededNumIndex > 0)
        {
          triplet = new List<int> { sortedNums[index1], neededNum, sortedNums[index2] };
          result.Add(triplet);
        }

        // Skip duplicate numbers
        while (sortedNums[index2] == sortedNums[index2 - 1] && index2 > index1 + 1)
        {
          index2--;
        }
      }

      // Skip duplicate numbers. 
      while (sortedNums[index1] == sortedNums[index1 + 1] && index1 < sortedNums.Count - 2)
      {
        index1++;
      }
    }

    return result;
  }
}