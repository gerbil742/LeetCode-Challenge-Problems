namespace ThreeSum;
public class Solution
{
  public static IList<IList<int>> ThreeSum(int[] nums)
  {
    IList<IList<int>> result = new List<IList<int>>();
    List<HashSet<int>> triplets = new List<HashSet<int>>();

    List<int> tripletList;
    HashSet<int> tripletSet;

    // Will the Last index we see each individual num. We will use this to avoid having to loop through the entire input
    // array a 3rd time and imporove efficency. 
    Dictionary<int, int> numberAndIndex = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      numberAndIndex[nums[i]] = i;
    }

    // loop through input array 3 times. if the cur index is the same as any of the others then go to the next val. 
    // calc the sum = 0; if good then make new array and add it to teh list
    // verify no duplicates. put candidate into a set. see if the candidate 
    // to verify, take our candidate, check first element against every list in the results. if there is a match in one, then check the 2nd element againse all
    // of those elements, same for thrid. 
    // use Sets? take candidate and each of the existing trips check if candidate.setequals other trips. if so dont add it. 

    for (int i = 0; i < nums.Length; i++)
    {
      for (int j = i + 1; j < nums.Length; j++)
      {
        // if we already have 2 possible nums, then we actually already know what the 3rd num would have to be
        int num3 = -(nums[i] + nums[j]);

        // if you have the required num3 in the dictionary and the last index it appears is greater than j, they you have a good tripplet. if not, then 
        // move on the the next loop iter
        if (!(numberAndIndex.ContainsKey(num3) && numberAndIndex[num3] > j)) continue;

        tripletList = new List<int> { nums[i], nums[j], num3 };
        tripletSet = new HashSet<int>(tripletList);

        if (notDuplicate(tripletSet, triplets))
        {
          triplets.Add(tripletSet);
          result.Add(tripletList);
        }

      }
    }

    return result;
  }

  private static bool notDuplicate(HashSet<int> triplet, List<HashSet<int>> foundTriplets)
  {
    foreach (HashSet<int> set in foundTriplets)
    {
      if (set.SetEquals(triplet))
      {
        return false;
      }
    }

    return true;
  }
}


