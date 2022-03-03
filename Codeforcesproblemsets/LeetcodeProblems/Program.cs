using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProblems;

namespace LeetcodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(JudgePoint24.Game24(new int[] { 4, 1, 8, 7 }));
            //Console.WriteLine(XORSum.SubsetXORSum(new int[] { 3, 4, 5, 6, 7, 8 }));
            //Console.WriteLine(Duplicates.RemoveDuplicates("azxxzy"));
            #region 437
            //[10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
            //TreeNode a = new TreeNode(1);
            //TreeNode b = new TreeNode(-2);
            //TreeNode c = new TreeNode(3);
            //TreeNode d = new TreeNode(11);
            //TreeNode e = new TreeNode(2, null, a);
            //TreeNode f = new TreeNode(3, c, b);
            //TreeNode g = new TreeNode(-3, null, d);
            //TreeNode h = new TreeNode(5, f, e);
            //TreeNode i = new TreeNode(10, h, g);
            //[5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22


            //[1,2,3,4,5,6,7]
            //TreeNode g = new TreeNode(7);
            //TreeNode f = new TreeNode(6);
            //TreeNode e = new TreeNode(5);
            //TreeNode d = new TreeNode(4);
            //TreeNode c = new TreeNode(3, f, g);
            //TreeNode b = new TreeNode(2, d, e);
            //TreeNode a = new TreeNode(1, b, c);
            //Console.WriteLine(PathSumIII.PathSum(i, 8));
            #endregion 437
            #region 112
            //Console.WriteLine(PathSumI.HasPathSum(i, 17));
            #endregion 112
            #region 113
            //IList<IList<int>> temp = PathSumII.PathSum(i, 18);
            //foreach (var aaa in temp)
            //    foreach (var bbb in aaa)
            //        Console.Write(bbb + ",");

            #endregion 113
            #region 1710
            //int[][] boxTypes = new int[][]
            //{
            //    new int[] { 1, 3 },
            //    new int[] { 2, 2 },
            //    new int[] { 3, 1 }
            //};
            //Console.WriteLine(MaximumUnits.MaximumUnitsFunc(boxTypes, 4));
            #endregion 1710
            #region 1207
            //UniqueOccurrences.UniqueOccurrencesFunc(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
            #endregion 1207
            #region 1009
            //Console.WriteLine(BitwiseComplement.BitwiseComplementFunc(8));
            #endregion 1009
            #region 1290
            //ListNode a = new ListNode(1, null);
            //ListNode b = new ListNode(1, a);
            //ListNode c = new ListNode(0, b);
            //ListNode d = new ListNode(1, c);
            //Console.WriteLine(GetDecimalValue.GetDecimalValueFunc(d));
            #endregion 1290
            #region 1026
            //TreeNode a = new TreeNode(13);
            //TreeNode b = new TreeNode(14, a);
            //TreeNode c = new TreeNode(10, null, b);
            //TreeNode d = new TreeNode(7);
            //TreeNode e = new TreeNode(4);
            //TreeNode f = new TreeNode(6, e, d);
            //TreeNode g = new TreeNode(1);
            //TreeNode h = new TreeNode(3, g, f);
            //TreeNode i = new TreeNode(8, h, c);

            //TreeNode a = new TreeNode(3);
            //TreeNode b = new TreeNode(0, null, a);
            //TreeNode c = new TreeNode(2, null, b);
            //TreeNode d = new TreeNode(1, null, c);
            //Console.WriteLine(MaxAncestorDiff.MaxAncestorDiffFunc(d));
            #endregion 1026
            #region 3080
            //FindClosestElements.FindClosestElementsFunc(new int[] { 1, 2, 3, 4, 5 }, 4, -1);
            #endregion 3080
            #region 712

            //IList<IList<string>> temp1 = new List<IList<string>>();
            //temp1.Add(new List<string> { "John", "johnsmith@mail.com", "john_newyork@mail.com" });
            //temp1.Add(new List<string> { "John", "johnsmith@mail.com", "john00@mail.com" });
            //temp1.Add(new List<string> { "Mary", "mary@mail.com" });
            //temp1.Add(new List<string> { "John", "johnnybravo@mail.com" });

            //List<IList<string>> temp2 = new List<IList<string>>();
            //temp2.Add(new List<string> { "Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe1@m.co" });
            //temp2.Add(new List<string> { "Kevin", "Kevin3@m.co", "Kevin5@m.co", "Kevin0@m.co" });
            //temp2.Add(new List<string> { "Ethan", "Ethan5@m.co", "Ethan4@m.co", "Ethan0@m.co" });
            //temp2.Add(new List<string> { "Hanzo", "Hanzo3@m.co", "Hanzo1@m.co", "Hanzo0@m.co" });
            //temp2.Add(new List<string> { "Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co" });

            //List<IList<string>> temp3 = new List<IList<string>>();
            //temp3.Add(new List<string> { "David", "David0@m.co", "David4@m.co", "David3@m.co" });
            //temp3.Add(new List<string> { "David", "David5@m.co", "David5@m.co", "David0@m.co" });
            //temp3.Add(new List<string> { "David", "David1@m.co", "David4@m.co", "David0@m.co" });
            //temp3.Add(new List<string> { "David", "David0@m.co", "David1@m.co", "David3@m.co" });
            //temp3.Add(new List<string> { "David", "David4@m.co", "David1@m.co", "David3@m.co" });


            //Accounts_Merge.AccountsMerge(temp3);
            #endregion
            #region week-1-august-1st-august-7th/3837
            //int[] nums = { 1, 2, 3 };


            //List<IList<int>> result = new List<IList<int>>();
            //result.Add(new List<int>() { });

            //foreach (var num in nums)
            //{
            //    List<IList<int>> currentRes = new List<IList<int>>(result);
            //    foreach (var l in currentRes)
            //    {
            //        List<int> newList = new List<int>(l);
            //        newList.Add(num);
            //        bool isIn = false;
            //        foreach(var a in currentRes)
            //            if (a.SequenceEqual(newList))
            //                isIn = true;

            //        if(!isIn)
            //            result.Add(newList);
            //    }
            //}
            #endregion
            #region 1228
            //int[][] arr = { new int[] { 1, 4 }, new int[] { 2, 6 }, new int[] { 2, 8 } };
            RemoveCoveredIntervals.RemoveCoveredIntervalsFunc(new int[][] { new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 3, 4 } });
            //RemoveCoveredIntervals.RemoveCoveredIntervalsFunc(new int[][] { new int[] { 66671, 75156 },
            //    new int[] { 59890, 65654 }, new int[] { 92950, 95965 }, new int[] { 9103, 31953 }, new int[] { 54869, 69855 }, new int[] { 33272, 92693 }, 
            //    new int[] { 52631, 65356 },new int[] { 43332, 89722 },new int[] { 4218, 57729 },new int[] { 20993, 92876 } });

            #endregion 1228
            #region 740
            //int[] nums = { 2,2,3,3,3,4 };
            //DeleteAndEarn.DeleteAndEarnFunc(nums);
            #endregion
            #region 70
            //Console.WriteLine(ClimbingStairs.ClimbStairsDP(5));
            //Console.WriteLine(ClimbingStairs.ClimbStairsFibb(5));
            #endregion
            #region 118
            //IList<IList<int>> a = PascalTriangle.Generate(5);
            //foreach (var val in a)
            //{
            //    foreach (var value in val)
            //        Console.Write(value);
            //    Console.WriteLine();
            //}



            #endregion
            #region 121
            //Console.WriteLine(BestTimetoBuyandSellStock.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            #endregion
            #region 991
            //Console.WriteLine(BrokenCalculator.BrokenCalc(2, 3));
            #endregion
            #region 1260
            //int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            //Shift2DGrid.ShiftGrid(arr, 1);

            #endregion
            #region BinaryGap
            //BinaryGap.BinaryGapFunction(32);
            #endregion
            #region CyclicRotation
            //CyclicRotation.CyclicRotationFunction(new int[] { 3, 8, 9, 7, 6 }, 3);
            #endregion
            #region CodilityTask3
            //Task3Codility.Task3CodilityFunc(-5000);
            #endregion
            #region 53
            //MaximumSubarray.MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            #endregion
            #region 35
            //SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            #endregion
            #region 26
            //RemoveDuplicatesfromSortedArray.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            #endregion
            #region 62
            //Console.WriteLine(UniquePaths.UniquePathsFunc(3, 7));
            #endregion
            #region 9
            //Console.WriteLine(PalindromeNumber.IsPalindrome(121));
            #endregion
            #region 13
            //RomantoInteger.RomanToInt("MCMXCIV");
            #endregion
            #region 219
            //ContainsDuplicate.ContainsDuplicateFunc(new int[] { 1, 2, 3, 4, 5, 6 });
            //ContainsDuplicateII.ContainsNearbyDuplicate(new int[]{ 1,2,3,1,2,3 }, 2);
            #endregion
            #region 268
            // Console.WriteLine(MissingNumber.MissingNumberFunc(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
            #endregion
            #region 46
            //Permutations.Permute(new int[] { 1, 2, 3 });
            #endregion
            #region 1491
            //Console.WriteLine(AverageSalaryExcludingtheMinimumandMaximumSalary.Average(new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 }));
            #endregion
            #region 349
            //IntersectionofTwoArrays.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            #endregion
            #region 414
            //ThirdMaximumNumber.ThirdMax(new int[] { 1,2});
            #endregion
            #region 1387
            //SortIntegersbyThePowerValue.GetKth(12,15,2);
            #endregion
            #region 39
            //CombinationSum.CombinationSumFunc(new int[] { 2, 3, 5 }, 8);
            #endregion
            #region 169
            //BoyerMooreVotingAlgorithm.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            #endregion
            #region 171
            //ExcelSheetColumnNumber.TitleToNumber("FXSHRXW");
            #endregion
            //Console.WriteLine(Convert.ToInt32("100100111000000", 2));
            Console.ReadKey();
        }
    }
}
