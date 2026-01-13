namespace PracticePrgs;

public class RotationArray
{
    public void RotateArray(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;

        //combine two array 
        int[] res = new int[nums.Length];
        for (int i = 0; i < n; i++)
        {
            res[(i + k) % n] = nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = res[i];
        }
    }

    public void RotateArrayInPlace(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    public void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}