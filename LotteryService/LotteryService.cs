using System;

namespace LotteryService
{
    public class SortedArray
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            Array.Sort(lotteryNums);
            return lotteryNums;
        }
    }
}
