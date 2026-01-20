namespace PracticePrgs;

public class JumpStep
{
    public int GetStepCount(int steps)
    {
        int[] cache = new int[steps+1];
        Array.Fill(cache, -1);
        return GetStepCountOpt(steps, cache);
        //brute
        if (steps <= 0)
        {
            return 0;
        }
        if (steps == 1)
        {
            return 1;
        }
        
       int result = GetStepCount(steps - 1) + GetStepCount(steps - 2) + GetStepCount(steps - 3);
       return result;
    }

    public int GetStepCountOpt(int steps, int[] cache)
    {
        if (steps <= 0)
        {
            return 0;
        }
        if (steps == 1)
        {
            return 1;
        }
        if (cache[steps] == -1)
        {
            cache[steps] = GetStepCountOpt(steps - 1, cache) + GetStepCountOpt(steps - 2, cache) + GetStepCountOpt(steps - 3, cache);
        }

        return cache[steps];
    }
}