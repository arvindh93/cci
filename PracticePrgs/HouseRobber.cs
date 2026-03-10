namespace PracticePrgs;

public class HouseRobber {
    public int Rob(int[] nums, int start, int[] cache)
    {
        if (cache[start] == -1)
        {
            int max = 0;
            for (int i = start + 2; i < nums.Length; i++)
            {
                max = Math.Max(Rob(nums, i, cache), max);
            }

            cache[start] = nums[start] + max;
        }
        
        return cache[start];
    }
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        nums[1] = Math.Max(nums[0], nums[1]);
        //top down
        for (int i = 2; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i - 1], nums[i-2] + nums[i]);
        }

        return nums[nums.Length - 1];

        //get cache
        int[] cache = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            cache [i] = -1;
        }

        return Math.Max(Rob(nums, 0, cache), Rob(nums, 1, cache));
    }
}