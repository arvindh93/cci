namespace PracticePrgs;

public class CoinCount (float[] denominations)
{
    public float[] Denominations = denominations;

    public int CountDenoms(float sum)
    {   
        if (sum == 0)
        {
            return 0;
        }
        
        return CountDenomsWithCacheComb(sum, new(), 0);
        if (sum == 1)
        {
            return 1;
        }

        int result = 0;
        foreach (var denom in denominations)
        {
            if (sum - denom > 0)
            {
                result += CountDenoms(sum - denom);
            }
        }

        return result;
    }

    public int CountDenomsWithCache (float sum, Dictionary<float, int> cache)
    {
        if (sum == 0)
        {
            return 1;
        }

        int result = 0;
        foreach (var denom in Denominations)
        {
            if (sum - denom >= 0)
            {
                if (cache.TryGetValue(sum - denom, out int val))
                {
                    result += val;
                } else {
                    cache[sum - denom] = CountDenomsWithCache(sum - denom, cache);
                    result += cache[sum - denom];
                }
            }
        }

        return result;
    }

    public int CountDenomsWithCacheComb(float sum, Dictionary<float, int> cache, int denomIndex)
    {
        if (denomIndex >= Denominations.Length - 1)
        {
            return 1;
        }

        int result = 0;
        float denomAmount = Denominations[denomIndex];

        for (int i = 0; i * denomAmount <= sum; i++)
        {
            if (cache.TryGetValue(sum - (i * denomAmount), out int val))
            {
                result += val;
            } else {
                cache[sum - (i * denomAmount)] = CountDenomsWithCacheComb(sum - (i * denomAmount), cache, denomIndex + 1);
                result += cache[sum - (i * denomAmount)];
            }
        }

        return result;
    }
}