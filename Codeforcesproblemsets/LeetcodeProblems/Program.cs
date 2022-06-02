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
            // int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
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
            #region 141
            //ListNode a = new ListNode(-4, null);
            //ListNode b = new ListNode(0, a);
            //ListNode c = new ListNode(2, b);
            //ListNode d = new ListNode(3, c);
            //c.next = c;
            //Console.WriteLine( LinkedListCycle.HasCycle(d));
            #endregion
            #region 2
            //ListNode l11 = new ListNode(3, null);
            //ListNode l12 = new ListNode(4, l11);
            //ListNode l13 = new ListNode(2, l12);

            //ListNode l21 = new ListNode(4, null);
            //ListNode l22 = new ListNode(6, l21);
            //ListNode l23 = new ListNode(5, l22);

            //ListNode l11 = new ListNode(9, null);
            //ListNode l12 = new ListNode(9, l11);
            //ListNode l13 = new ListNode(9, l12);
            //ListNode l14 = new ListNode(9, l13);

            //ListNode l21 = new ListNode(9, null);
            //ListNode l22 = new ListNode(9, l21);
            //AddTwoNumbers.AddTwoNumbersFunc(l14, l22);
            #endregion
            #region 61
            //ListNode e = new ListNode(5, null);
            //ListNode d = new ListNode(4, e);
            //ListNode c = new ListNode(3, d);
            //ListNode b = new ListNode(2, c);
            //ListNode a = new ListNode(1, b);
            //RotateList.RotateRight(a, 2);
            #endregion
            #region 138
            //RotateList.RotateRight();
            #endregion
            #region 71
            //SimplifyPath.SimplifyPathFunc("/home//foo/");
            #endregion
            #region 1249
            //MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("lee(t(c)o)de)");
            #endregion
            #region 946
            //ValidateStackSequences.ValidateStackSequencesFunc(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 });
            #endregion
            #region 856
            //ScoreOfParentheses.ScoreOfParenthesesFunc("()((()))");
            #endregion
            #region 316
            //Console.WriteLine(RemoveDuplicateLetters.RemoveDuplicateLettersFunc("ecbacba"));

            #endregion
            #region 763
            //PartitionLabels.PartitionLabelsFunc("ababcbacadefegdehijhklij");
            #endregion
            #region 1663
            // Console.WriteLine(SmallestStringWithAGivenNumericValue.GetSmallestString(5, 73));
            #endregion
            #region 881
            //BoatsToSavePeople.NumRescueBoats(new int[] { 3,8,7,1,4 }, 9);
            #endregion
            #region 1029
            //TwoCityScheduling.TwoCitySchedCost(new int[][]
            //{
            //    new int[] { 10, 20 },
            //    new int[] { 30, 200 },
            //    new int[] { 400, 50 },
            //    new int[] { 30, 20 }
            //});
            #endregion
            #region 704
            //Console.WriteLine(BinarySearch.Search(new int[] { 5 }, 5));
            #endregion
            #region 81
            //SearchInRotatedSortedArrayII.Search(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 1);
            #endregion
            #region 287 
            //FindTheDuplicateNumber.FindDuplicate(new int[] { 1, 3, 4, 2, 2 });
            #endregion
            #region 74
            //SearchA2DMatrix.SearchMatrix(new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 3);
            //SearchA2DMatrix.SearchMatrix(new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 13);
            //SearchA2DMatrix.SearchMatrix(new int[][] { new int[] { 1}, new int[] { 3 } }, 3);
            //SearchA2DMatrix.SearchMatrix(new int[][] { new int[] { 1, 1 } }, 2);

            #endregion
            #region 875
            //KokoEatingBananas.MinEatingSpeed(new int[] { 3, 6, 7, 11 }, 8);
            #endregion
            #region 410
            //SplitArrayLargestSum.SplitArray(new int[] { 7, 2, 5, 10, 8 }, 2);
            #endregion
            #region 344
            //ReverseString.ReverseStringFunc(new char[] {'h', 'e', 'l', 'l', 'o' });
            #endregion
            #region 680
            //Console.WriteLine(ValidPalindromeII.ValidPalindrome("abca"));
            #endregion
            #region 31
            //NextPermutation.NextPermutationFunc(new int[] { 1, 2, 3 });
            #endregion
            #region 1721
            //ListNode e = new ListNode(5, null);
            //ListNode d = new ListNode(4, e);
            //ListNode c = new ListNode(3, d);
            //ListNode b = new ListNode(2, c);
            //ListNode a = new ListNode(1, b);
            //SwappingNodesInALinkedList.SwapNodes(a,2);
            #endregion
            #region 11
            //Console.WriteLine(ContainerWithMostWater.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            #endregion
            #region 923
            //_3SumWithMultiplicity.ThreeSumMulti(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, 8);
            #endregion
            #region 1046
            //LastStoneWeight.LastStoneWeightFunc(new int[] { 2, 2 });
            #endregion
            #region 703
            //KthLargestElementInAStream obj = new KthLargestElementInAStream(3, new int[] { 4, 5, 8, 2 });
            //Console.WriteLine(obj.Add(3));
            //Console.WriteLine(obj.Add(5));
            //Console.WriteLine(obj.Add(10));
            //Console.WriteLine(obj.Add(9));
            //Console.WriteLine(obj.Add(4));

            #endregion
            #region 347
            //TopKFrequentElements.TopKFrequent(new int[] { 1, 2 }, 2);
            #endregion
            #region 682
            //BaseballGame.CalPoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" });
            #endregion
            #region 289
            //GameOfLife.GameOfLifeFunc(new int[][] { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } });
            #endregion
            #region 59
            //SpiralMatrixII.GenerateMatrix(2);
            #endregion
            #region 700
            //TreeNode e = new TreeNode(3);
            //TreeNode d = new TreeNode(1);
            //TreeNode c = new TreeNode(2, e, d);
            //TreeNode b = new TreeNode(7);
            //TreeNode a = new TreeNode(4, c, b);

            //SearchInABinarySearchTree.SearchBST(a, 2);
            #endregion
            //Console.WriteLine(Convert.ToInt32("100100111000000", 2));

            #region 669
            //TreeNode e = new TreeNode(1);
            //TreeNode d = new TreeNode(2, e);
            //TreeNode c = new TreeNode(0, null, d);
            //TreeNode b = new TreeNode(4);
            //TreeNode a = new TreeNode(3, c, b);

            //TrimABinarySearchTree.TrimBST(a, 1, 3);
            #endregion
            #region 538
            //TreeNode i = new TreeNode(8);
            //TreeNode h = new TreeNode(3);

            //TreeNode g = new TreeNode(7, null, i);
            //TreeNode f = new TreeNode(5);

            //TreeNode e = new TreeNode(2, null, h);
            //TreeNode d = new TreeNode(0);

            //TreeNode c = new TreeNode(6, f, g);
            //TreeNode b = new TreeNode(1, d, e);

            //TreeNode a = new TreeNode(4, b, c);

            //ConvertBSTToGreaterTree.ConvertBST(a);
            #endregion
            #region 897

            #endregion
            #region 99
            //TreeNode c = new TreeNode(2);
            //TreeNode b = new TreeNode(3,null,c);
            //TreeNode a = new TreeNode(1,b);
            //RecoverBinarySearchTree.RecoverTree(a);
            #endregion
            #region 173
            //TreeNode e = new TreeNode(9);
            //TreeNode d = new TreeNode(20);
            //TreeNode c = new TreeNode(15, e, d);
            //TreeNode b = new TreeNode(3);
            //TreeNode a = new TreeNode(7, b, c);
            //BinarySearchTreeIterator bsti = new BinarySearchTreeIterator(a);
            //int aa = bsti.Next();
            //int bb = bsti.Next();
            //bool cc = bsti.HasNext();
            //int dd = bsti.Next();
            #endregion
            #region 705

            #endregion
            #region 1396
            //DesignUndergroundSystem dus = new DesignUndergroundSystem();
            //dus.CheckIn(45, "Leyton", 3);
            //dus.CheckIn(32, "Paradise", 8);
            //dus.CheckIn(27, "Leyton", 10);
            //dus.CheckOut(45, "Waterloo", 15);
            //dus.CheckOut(27, "Waterloo", 20);
            //dus.CheckOut(32, "Cambridge", 22);
            //dus.GetAverageTime("Paradise", "Cambridge");
            #endregion
            #region 284
            //PeekingIterator pi = new PeekingIterator(new List<int> {1, 2, 3 }.GetEnumerator());
            //var a = pi.Next();
            //var b = pi.Peek();
            //var c = pi.Next();
            //var d = pi.Next();
            //var e = pi.HasNext();
            #endregion
            #region 1584
            //int[][] points = new int[][]
            //{
            //    new int[] { 0, 0 },
            //    new int[] { 2, 2 },
            //    new int[] { 3, 10 },
            //    new int[] { 5, 2 },
            //    new int[] { 7, 0 },

            //};

            //int[][] points2 = new int[][]
            //{    
            //    new int[] { 3, 12 },
            //    new int[] { -2, 5 },
            //    new int[] { -4, 1 },

            //};

            //MinCostToConnectAllPoints pctcap = new MinCostToConnectAllPoints();
            //var result = pctcap.MinCostConnectPoints(points2);
            #endregion
            #region 17
            // LetterCombinationsOfAPhoneNumber.LetterCombinations("23");
            #endregion
            #region 1641
            //CountSortedVowelStrings.CountVowelStrings(2);
            #endregion
            #region 47
            //PermutationsII.PermuteUnique(new int[] { 2, 2, 1, 1 });
            #endregion
            #region 116
            //NodeTree g = new NodeTree(7);
            //NodeTree f = new NodeTree(6);
            //NodeTree e = new NodeTree(5);
            //NodeTree d = new NodeTree(4);
            //NodeTree c = new NodeTree(3, f, g);
            //NodeTree b = new NodeTree(2, d, e);
            //NodeTree a = new NodeTree(1, b, c);

            //NodeTree test = PopulatingNextRightPointersInEachNode.Connect(a);
            #endregion
            #region 117 
            //NodeTree g = new NodeTree(7);
            //NodeTree e = new NodeTree(5);
            //NodeTree d = new NodeTree(4);
            //NodeTree c = new NodeTree(3, null, g);
            //NodeTree b = new NodeTree(2, d, e);
            //NodeTree a = new NodeTree(1, b, c);

            //PopulatingNextRightPointersInEachNodeII.Connect(a);
            #endregion
            #region 1091
            //ShortestPathInBinaryMatrix.ShortestPathBinaryMatrix(new int[][] { new int[] {0, 1}, new int[] {1, 0} });
            #endregion
            #region 1192
            //List<IList<int>> connections = new List<IList<int>>();
            //connections.Add(new List<int>() {1, 0 });
            //connections.Add(new List<int>() {2, 0 });
            //connections.Add(new List<int>() {3, 2 });
            //connections.Add(new List<int>() {4, 2 });
            //connections.Add(new List<int>() {4, 3 });
            //connections.Add(new List<int>() {3, 0 });
            //connections.Add(new List<int>() {4, 0 });
            //CriticalConnectionsInANetwork.CriticalConnections(5, connections);
            #endregion
            #region 647
            //PalindromicSubstrings.CountSubstrings("aba");
            #endregion
            #region 322
            //CoinChange.CoinChangeFunc(new int[] { 2 }, 3);
            #endregion
            #region 1461
            //CheckIfAStringContainsAllBinaryCodesOfSizeK.HasAllCodes("00110110", 2);
            #endregion


            int x = 1000000;
            int y = 1000000;

            // int xy = checked (x * y);
          
            // checked nie ma znaczenia dla float - nigdy nie jest sprawdzana arytmetyka
            checked
            {
                decimal i = decimal.MaxValue;
                while (true)
                    i *= 500;
            }

            int a = int.MinValue;
            a++;

            Console.ReadKey();
        }
    }
}
