using Xunit;

namespace LongestSubstring.tests;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    string input = "abcabcbb";
    int expected = 3;

    int result = Solution.LengthOfLongestSubstring(input);

    Assert.Equal(expected, result);
  }

  [Fact]
  public void Test2()
  {
    string input = "bbbbb";
    int expected = 1;

    int result = Solution.LengthOfLongestSubstring(input);

    Assert.Equal(expected, result);
  }

  [Fact]
  public void Test3()
  {
    string input = "pwwkew";
    int expected = 3;

    int result = Solution.LengthOfLongestSubstring(input);

    Assert.Equal(expected, result);
  }

  [Fact]
  public void Test4()
  {
    string input = " ";
    int expected = 1;

    int result = Solution.LengthOfLongestSubstring(input);

    Assert.Equal(expected, result);
  }
  [Fact]
  public void Test5()
  {
    string input = "au";
    int expected = 2;

    int result = Solution.LengthOfLongestSubstring(input);

    Assert.Equal(expected, result);
  }
}