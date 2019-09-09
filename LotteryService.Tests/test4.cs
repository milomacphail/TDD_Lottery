using NUnit.Framework;
using LotteryService;

namespace LotteryService
{
    public class LotteryServiceTenNumSorted
    {

        [Test]
        public void return_tenNumSorted()
        {
            SortedArray obj10 = new SortedArray();
            int[] tenArray = new int[10] { 101, 7, 89, 1000, 23, 33, 10201, 1, 99, -10 };
            int[] sortedArray = obj10.SortNumbers(tenArray);
            int[] checkArray = new int[10] { -10, 1 , 7, 23, 33, 89, 99, 101, 1000, 10201 };
            Assert.AreEqual(tenArray[0], checkArray[0]);
        }
    }
}