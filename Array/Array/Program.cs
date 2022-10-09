using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.	Find out minimal value in array.
            // int[] arr = { 45, 54, 7, 15, 21 };
            //static int FindMinValue(int[] num)
            // {
            //     int minValue =num[0];
            //     for (int i = 0; i < num.Length; i++)
            //     {
            //         if (num[i]<minValue)
            //         {
            //             minValue = num[i];
            //         }
            //     }
            //     return minValue;
            // }
            // int minValue = FindMinValue(arr);
            // Console.WriteLine(minValue);
            #endregion
            #region Task2
            //int[] arr = { 45, 54, 7, 15, 21 };
            //static int FindMaxValue(int[] num)
            //{
            //    int maxValue = num[0];
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        if (num[i] > maxValue)
            //        {
            //            maxValue = num[i];
            //        }
            //    }
            //    return maxValue;
            //}
            //int maxValue = FindMaxValue(arr);
            //Console.WriteLine(maxValue);
            #endregion
            #region Task3
            //3.Find out index of minimal value in array.
            //int[] arr = { 45, 54, 7, 15, 21 };
            //static int FindMinValueIndex(int[] num)
            //{
            //    int minValue = num[0];
            //    int minValueIndex = 0;
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        if (num[i] < minValue)
            //        {
            //            minValue = num[i];
            //            minValueIndex = i;
            //        }
            //    }
            //    return minValueIndex;
            //}
            //int minValue = FindMinValueIndex(arr);
            //Console.WriteLine(minValue);
            #endregion
            #region Task4
            //4.Find out index of maximal  value in array.
            //int[] arr = { 45, 54, 7, 15, 21 };
            //static int FindMaxValue(int[] num)
            //{
            //    int maxValue = num[0];
            //    int maxValueIndex = 0;
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        if (num[i] > maxValue)
            //        {
            //            maxValue = num[i];
            //            maxValueIndex = i;
            //        }
            //    }
            //    return maxValueIndex;
            //}
            //int maxValue = FindMaxValue(arr);
            //Console.WriteLine(maxValue);
            #endregion
            #region Task5
            //5.Calculate sum of all elements with odd indexes.
            //int[] nums = new int[] {7,9,12,37,15,28,41,26 };
            //static int SumOddsIndex(int[] nums)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            sum += nums[i];
            //        }
            //    }
            //    return sum;
            //}
            //int sum = SumOddsIndex(nums);
            //Console.WriteLine(sum);
            #endregion
            #region Task6
            //6.	Reverse an array (f.e. 1 2 3 4 5-> 5 4 3 2 1)
            //int[] nums = new int[] {23,15,78,7,9,51 };
            //static void reverseNum(int[] nums)
            //{
            //    for (int i = 0; i < nums.Length/2; i++)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[nums.Length - i - 1];
            //        nums[nums.Length - i - 1] = temp;

            //    }
            //    for (int j = 0; j < nums.Length; j++)
            //            {
            //                  Console.WriteLine(nums[j]);
            //            }            }
            //        reverseNum(nums);
            #endregion
            #region Task7
            //7.Calculate amount of all elements with odd values.
            //int[] sumodd = new int[] { 12, 15, 48, 68,25, 59, 31 };
            //static int sumOdds(int[] nums)
            //{
            //    int counter = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] % 2==1)
            //        {
            //            counter++;
            //        }
            //    }
            //    return counter;
            //}
            //int amount = sumOdds(sumodd);
            //Console.WriteLine(amount);
            #endregion
            #region Task8
            //8.	Change first and second half of array(f.e. 1 2 3 4 -> 3 4 1 2, or 1 2 3 4 5-> 4 5 3 1 2.
            int[] arr = new int[] { 12, 5, 7, 9, 20, 16 };

            #endregion
        }
    }
}
