using NUnit.Framework;
using LotteryService;

namespace LotteryService
{
    public class LotteryServiceTwoNumSorted
    {

        [Test]
        public void return_twoNumSorted()
        {
            SortedArray obj = new SortedArray();
            int[] TwoNumSorted = new int[2] { 7, 1 };
            obj.SortNumbers(TwoNumSorted);
            int[] sortedArray = obj.SortNumbers(TwoNumSorted);
            int[] checkArray = new int[2] { 1, 7 };
            Assert.AreEqual(TwoNumSorted[0], checkArray[0]);

        }
    }
}