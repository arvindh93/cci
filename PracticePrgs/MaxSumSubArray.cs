namespace PracticePrgs;

public class MaxSumSubArray
{
    public int SubarraySum(int[] nums, int k) {
        //prefix sum + hash map
        int result = 0;
        int currentSum = 0;
        Dictionary<int, int> prefixSumMap = [];
        prefixSumMap[0] = 1;
        for (int j = 0; j < nums.Length; j++)
        {
            currentSum += nums[j];
            int prefixSumMinusK = currentSum - k;
            if (prefixSumMap.TryGetValue(prefixSumMinusK, out int existingCount))
            {
                result += existingCount;
            }
            if (prefixSumMap.ContainsKey(currentSum))
            {
                prefixSumMap[currentSum] += 1;
            } else
            {
                prefixSumMap[currentSum] = 1;
            }
        }

        return result;
    }
}