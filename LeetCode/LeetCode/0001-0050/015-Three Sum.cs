namespace LeetCode._0001_0050;

public class _003_Three_Sum 
{
    public IList<IList<int>> ThreeSum(int[] nums, int target=0)
    {
        if (!nums.Any()) return [];
        IList<IList<int>> result =[];
        nums = nums.OrderBy(x => x).ToArray();
        int length = nums.Length;
        int i=0;
        while (i<=length-3)
        {
            int left = i+1, right = length-1;
            
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum > target) right--;
                else if (sum < target) left++;
                else 
                {
                    result.Add([nums[i] ,nums[left], nums[right]]);
                    do 
                    {
                        left++;
                    }
                    while(left < length-1 && nums[left] == nums[left-1]);

                    do 
                    {
                        right--;
                    }
                    while(right > left && nums[right] == nums[right+1]);

                    

                    
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