using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    class KataMutiplesOf3Or5
    {
        public static int Solution(int value)
        {
            if (value < 3) return 0;
            value--;
            var threes = Enumerable.Range(1, value / 3).Select(x => x * 3).ToArray();
            var fives = Enumerable.Range(1, value / 5).Select(x => x * 5).ToArray();
            return new HashSet<int>(threes.Concat(fives)).Sum();
        }
    }


    [TestFixture]
    public class TestsMutiplesOf3Or5
    {
        [Test]
        public void MutiplesOf3Or5()
        {
            Assertion(expected: 23, input: 10);
            Assertion(expected: 78, input: 20);
            Assertion(expected: 9168, input: 200);
            Assertion(expected: 0, input: 0);
        }

        private static void Assertion(int expected, int input) =>
          Assert.That(
            KataMutiplesOf3Or5.Solution(input),
            Is.EqualTo(expected),
            $"Value: {input}"
          );
    }
}