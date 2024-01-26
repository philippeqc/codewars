namespace Solution;

/*
Given two arrays a and b write a function comp(a, b) (orcompSame(a, b)) that checks 
whether the two arrays have the "same" elements, with the same multiplicities (the 
multiplicity of a member is the number of times it appears). "Same" means, here, 
that the elements in b are the elements in a squared, regardless of the order.
*/
public class KataAreTheyTheSame
{
    public static bool comp(int[] a, int[] b)
    {
        a = a.Order().ToArray();
        b = b.Order().ToArray();

        return a.Zip(b, (lhs, rhs) => (lhs, rhs)).All(x => x.lhs * x.lhs == x.rhs);
    }
}

[TestFixture]
public class TestsAreTheyTheSame
{
    [Test]
    public void AreTheyTheSame_1()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

        Assert.That(KataAreTheyTheSame.comp(a, b), Is.True);
    }

    [Test]
    public void AreTheyTheSame_2()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };

        Assert.That(KataAreTheyTheSame.comp(a, b), Is.False);
    }

}