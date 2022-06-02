using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class KokoEatingBananas
    {
        //binary search solution
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = 0;
            foreach (var item in piles)
                right = Math.Max(right, item);

            while(left < right)
            {
                int middle = left + (right - left) / 2;
                int hourSpent = 0;

                foreach (var item in piles)
                    hourSpent += item / middle + (item % middle == 0 ? 0 : 1);

                if (hourSpent <= h)
                    right = middle;
                else
                    left = middle + 1;
            }
            return right;
        }

        /// <summary>
        /// Brutal force, do not passing every test case scenario
        /// </summary>
        /// <param name="piles"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        //public static int MinEatingSpeed(int[] piles, int h)
        //{
        //    int result = 1;

        //    while (true)
        //    {
        //        int hour = 0;
        //        foreach (var item in piles)
        //        {
        //            hour += item / result + (item % result == 0 ? 0 : 1);
        //            if (hour > h)
        //                break;
        //        }

        //        if (hour <= h)
        //            return result;
        //        else
        //            result++;

        //    }
        //    //return 0;
        //}
    }
}
