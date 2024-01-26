namespace Solution;
// https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp

using Fib = (ulong Min, ulong Max, ulong Prod);

public class KataProductOfConsecutiveFibNumbers
{
    public static ulong[] productFib(ulong prod)
    {
        Fib fib = ((ulong)0, (ulong)1, (ulong)0);

        do
        {
            if (fib.Prod >= prod)
            {
                return new ulong[] { fib.Min, fib.Max, (ulong)(fib.Prod == prod ? 1 : 0) };
            }

            fib = (fib.Max, fib.Min + fib.Max, fib.Max * (fib.Min + fib.Max));
        } while (true);
    }
}

[TestFixture]
public class TestsProductOfConsecutiveFibNumbers
{
    [TestCase((ulong)4895, new ulong[] { 55, 89, 1 })]
    [TestCase((ulong)714, new ulong[] { 21, 34, 1 })]
    [TestCase((ulong)800, new ulong[] { 34, 55, 0 })]
    public void ProductOfConsecutiveFibNumbers(ulong value, ulong[] expected)
    {
        Assert.That(KataProductOfConsecutiveFibNumbers.productFib(value), Is.EqualTo(expected));
    }


}