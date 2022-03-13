using Xunit;

namespace ReverseInteger.Tests;
public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    int x = -2147483412;
    int xexpected = -2143847412;

    int y = 1000000009;
    int yexpected = 0;

    int z = 120;
    int zexpected = 21;

    int w = 1463847412;
    int wexpected = 2147483641;

    int j = 0;
    int jexpected = 0;

    int k = -1000000009;
    int kexpected = 0;

    int xresult = ReverseInt.Reverse(x);
    int yresult = ReverseInt.Reverse(y);
    int zresult = ReverseInt.Reverse(z);
    int wresult = ReverseInt.Reverse(w);
    int jresult = ReverseInt.Reverse(j);
    int kresult = ReverseInt.Reverse(k);

    Assert.Equal(xexpected, xresult);
    Assert.Equal(yexpected, yresult);
    Assert.Equal(zexpected, zresult);
    Assert.Equal(wexpected, wresult);
    Assert.Equal(jexpected, jresult);
    Assert.Equal(kexpected, kresult);
  }
}
