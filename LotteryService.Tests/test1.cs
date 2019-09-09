using NUnit.Framework;
using LotteryService;

namespace LotteryService
{
    public class LotteryServiceOneNumSorted
    {

        [Test]
        public void Return_OneNumSorted()
        {
            SortedArray obj = new SortedArray();
            int[] oneNumSorted = new int[] { 7 };
            obj.SortNumbers(oneNumSorted);
            var sortedArray = obj.SortNumbers(oneNumSorted);
            Assert.AreEqual(oneNumSorted[0], sortedArray[0]);

        }
    }
}
