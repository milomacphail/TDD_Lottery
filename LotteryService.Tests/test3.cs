using NUnit.Framework;
using LotteryService;

namespace LotteryService
{
    public class LotteryServicThreeNumSorted
    {

        [Test]
        public void return_threeNumSorted()
        {
            SortedArray obj3 = new SortedArray();
            int[] threeNumArray = new int[3] { 2, 1, 3 };
            obj3.SortNumbers(threeNumArray);
            int[] sortedArray = new int[3] { 1, 2, 3 };
            Assert.AreEqual(threeNumArray[0], sortedArray[0]);
        }

    }
}