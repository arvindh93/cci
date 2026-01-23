namespace PracticePrgs;

public class Permutation
{
    public List<List<char>> PermuteWithoutDups(List<char> chrs)
    {
        List<List<char>> result = new();
        if (chrs.Count == 1)
        {
            result.Add(chrs);   
            return result;
        }

        for (int i = 0; i < chrs.Count; i++)
        {
            char pivot = chrs[i];
            chrs.RemoveAt(i);
            //get all permuts minus pivot
            List<List<char>> r = PermuteWithoutDups(chrs);
            foreach (var carr in r)
            {
                for (int j = 0; j <= carr.Count ; j++)
                {
                    carr.Insert(j, pivot);
                    result.Add(new List<char>(carr));
                    carr.RemoveAt(j);
                }
            }   
        }

        return result;
    }
}