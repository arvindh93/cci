/**
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.
**/

namespace PracticePrgs;

public class ProductExceptSelf
{
    public int[] ProductExSelf(int[] nums) {
        /**
        built prefix array in a loop,
        eg. 24 = 1(prefix)*1(array value)*24(suffix value) | 24 = 1 * 2 * 12 |...
        build suffix array which will be result
        **/
        int[] result = new int[nums.Length];

        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i-1] * nums[i - 1];
        }

        int suffix = 1;
        for (int i = (nums.Length)-1; i >= 0; i--)
        {
            result[i] = suffix * result[i];
            suffix *= nums[i];
        }

        return result;
    }
}