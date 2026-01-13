namespace PracticePrgs;

public class MajorityElement
{
    public int FindMajorityElement(int[] nums)
    {
        //sort the array
        Array.Sort(nums);

        int pointer1 = 0;
        int pointer2 = (nums.Length-1)  / 2;

        if (pointer1 == pointer2)
        {
            return nums[pointer1];
        }

        while (pointer2 < nums.Length)
        {
            if (nums[pointer1] != nums[pointer2])
            {
                pointer1++;
                pointer2++;
            }
            else
            {
                return nums[pointer1];
            }
        }

        return 0;
    }
}