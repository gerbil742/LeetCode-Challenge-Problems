namespace LongestSubstring;

public class Solution
{
  public static int LengthOfLongestSubstring(string s)
  {
    int length = 0, index1 = 0, index2 = 0;
    HashSet<char> usedChars = new HashSet<char>();
    char ch;
    string substring;

    if (s.Length == 1) return 1;

    while (index2 < s.Length)
    {
      ch = s[index2];

      if (usedChars.Contains(ch))
      {
        //we found a substring. Cut out the string and see its length
        substring = s.Substring(index1, index2 - index1); // don't include the final character in the substring;
        if (substring.Length > length) length = substring.Length;

        // Update index1 to be the char right after the first occurance of the duplicate char. 
        while (s[index1] != s[index2])
        {
          usedChars.Remove(s[index1]);
          index1++;
        }
        index1++;
      }
      else if (index2 == s.Length - 1) // edge case where we are at the end of a string and there is not a duplicate
      {
        // At the end of the string and teh last char is not a duplicate for the current substring
        substring = s.Substring(index1); // include the final character in the substring;
        if (substring.Length > length) length = substring.Length;
      }

      usedChars.Add(ch);
      index2++;
    }

    return length;
  }
}