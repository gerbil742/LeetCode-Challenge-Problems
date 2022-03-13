namespace ReverseInteger;
public class ReverseInt
{
  //Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
  public static int Reverse(int x)
  {
    // turn int into a string  and find the length. use the absolute value

    // make x a string, index the string from back to front then do teh max check. 
    // check every character in the string compared to int max or int min, make sure that its less thatn the max values. 
    // find first integer that is different. if the digit in reverse is less than int max digit, then its less than max val. else if its greater than max val digit
    // than its greater than max val

    string xString = x >= 0 ? x.ToString() : x.ToString().Substring(1);
    string reverse = "";

    for (int i = xString.Length - 1; i >= 0; i--)
    {
      reverse += xString[i];
    }

    if (xString.Length == 10 && !maxValCheck(x, reverse))
    {
      return 0;
    }

    return x < 0 ? -int.Parse(reverse) : int.Parse(reverse);
  }

  // Check to see if the Reversed input is a valid INT32. If not, return false
  private static bool maxValCheck(int x, string reverse)
  {
    // if x is negative, use 2147483648 to verify if the reverse string is within range. else, use 2147483647. 
    string maxVal = x >= 0 ? int.MaxValue.ToString() : int.MinValue.ToString().Substring(1);

    for (int i = 0; i < maxVal.Length; i++)
    {
      int reverseDigit = int.Parse(reverse[i].ToString());
      int maxValDigit = int.Parse(maxVal[i].ToString());

      // Compare each digit between maxVal and reverse
      // If the first differeing digit in reverse you encounter is higher than int.MaxValue, then the reverse digit is out of range
      if (reverseDigit > maxValDigit)
      {
        return false;
      }
      // If the first differeing digit in reverse you encounter is lower than int.MaxValue, then the reverse digit is within range
      else if (reverseDigit < maxValDigit)
      {
        return true;
      }
    }

    //  the numbers are the same (both MaxValue or MinValue)
    return true;
  }
}

