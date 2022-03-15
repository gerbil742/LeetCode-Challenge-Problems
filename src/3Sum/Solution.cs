namespace ThreeSum;
public class Solution
{
  public static IList<IList<int>> ThreeSum(int[] nums)
  {
    IList<IList<int>> result = new List<IList<int>>();
    // HashSet<List<int>> triplets = new HashSet<List<int>>();
    List<HashSet<int>> triplets = new List<HashSet<int>>();

    List<int> tripletList;
    HashSet<int> tripletSet;

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
        if (nums[i] == nums[j]) continue;

        for (int k = j + 1; k < nums.Length; k++)
        {
          if (k == j || k == i) continue;

          int sum = nums[i] + nums[j] + nums[k];
          tripletList = new List<int> { nums[i], nums[j], nums[k] };
          tripletSet = new HashSet<int>(tripletList);

          if (sum == 0 && notDuplicate(tripletSet, triplets))
          {
            triplets.Add(tripletSet);
            result.Add(tripletList);
          }
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


