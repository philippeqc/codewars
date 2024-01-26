using System.Linq;
using System.Collections.Generic;

namespace Solution
{
  class KataFindTheOddInt
  {
    public static int find_it(int[] seq)
    {
        // var h = new HashSet<int>();

        // foreach (var element in seq)
        // {
        //   if (h.Contains(element))
        //   {
        //     h.Remove(element);
        //   }
        //   else
        //   {
        //     h.Add(element);
        //   }
        // }
        // return h.First();

        return seq.GroupBy(x => x).Single(x => x.Count() % 2 == 1).Key;
        }

    }


    [TestFixture]
    public class TestsFindTheOddInt
    {
        [Test]
        public void FindTheOddInt()
        {
            var actual = KataFindTheOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
            Assert.That(actual, Is.EqualTo(5));
        }
    }
}