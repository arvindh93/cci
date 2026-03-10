public class MergeIntervals {
    public int[][] Merge(int[][] intervals) {
        //return if intervals has only one or empty array
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        //sort intervals based on start i
        Array.Sort(intervals, (int1, int2) => int1[0].CompareTo(int2[0]));

        List<int[]> result = [];
        int pointer1 = 0;
        int pointer2 = 1;
        int localmaxima = intervals[pointer1][1];
        while (pointer2 < intervals.Length)
        {
            //compare start2 with local maixma
            if (intervals[pointer2][0] - localmaxima <= 0)
            {
                //update local maxima if required
                if (intervals[pointer2][1] > localmaxima)
                {
                    localmaxima = intervals[pointer2][1];
                }
                pointer2++;
            } else {
                //add to results
                result.Add([intervals[pointer1][0], localmaxima]);
                pointer1 = pointer2;
                pointer2++;
                localmaxima = intervals[pointer1][1]; 
            }
        }
        //add r1 and local maxima to result to cover last array
        result.Add([intervals[pointer1][0], localmaxima]);
        
        return result.ToArray();
    }
}