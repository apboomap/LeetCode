namespace LeetCode._0001_0050;

public class _0016_Three_Sum_Closeset
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int result = int.MaxValue;
        Array.Sort(nums);
        int length = nums.Length;
        int i = 0;
        while (i <= length-3)
        {
            int left = i+1, right = length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == target) return target;
                if (Math.Abs(sum - target) < Math.Abs(result - target))  
                {
                    result = sum;
                }

                if (sum < target) 
                {
                    left++;
                }
                else
                {
                    right --;
                }
            }
           
            do
            {
                i++;
            }
            while(i<=length-3 && nums[i] == nums[i - 1]);
        }

        return result;
    }
}