
using System.Globalization;


/**
Given an integer array nums, find a subarray that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

Note that the product of an array with a single element is the value of that element.

Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
**/
namespace PracticePrgs;

public class MaxProduct
{
    public int GetMaxProduct(int[] nums)
    {
        int maxProd = nums[0];
        int minProd = nums[0];

        int result = nums[0];

        //at each step, compare current num and update maxProd and minProd
        //if negative swap both minProd and maxProd

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                //if negative, swap max and min -- to keep track till we hit another -ve 
                int temp = maxProd;
                maxProd = minProd;
                minProd = temp;
            }
            maxProd = Math.Max(nums[i], maxProd * nums[i]);
            minProd = Math.Min(nums[i], minProd * nums[i]);

            result = Math.Max(maxProd, result);
        }
        return result;
    }
}