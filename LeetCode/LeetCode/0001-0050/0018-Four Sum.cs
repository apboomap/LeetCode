namespace LeetCode._0001_0050;

public class _0018_Four_Sum 
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (!nums.Any()) return [];
        IList<IList<int>> result =[];
        nums = nums.OrderBy(x => x).ToArray();
        int length = nums.Length;
        if (length < 4) return [];
        int i=0;
        int j = i + 1;
        do
        {
            int left = j+1, right = length-1;
            
            while (left < right)
            {
                long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                if (sum > target) right--;
                else if (sum < target) left++;
                else 
                {
                    if (!(int.MinValue > sum || int.MaxValue < sum))
                    {
                        result.Add([nums[i], nums[j] ,nums[left], nums[right]]);
                    }

                    do 
                    {
                        left++;
                    }
                    while(left < right && nums[left] == nums[left-1]);

                    do 
                    {
                        right--;
                    }
                    while(right > left && nums[right] == nums[right+1]);
                    
                }
            }

            if (j < length-3)
            {
                do
                {
                    j++;
                }
                while(j<=length-3 && nums[j] == nums[j - 1]);
            }
            else 
            {
                do
                {
                    i++;
                    j = i + 1;
                }
                while(i<=length-4 && nums[i] == nums[i - 1]);
            }
          
        }while (i<=length-4);

        return result;
    }


    // public IList<IList<int>> FourSum(int[] nums, int target)
    // {
    //     Array.Sort(nums);
    //     List<IList<int>> res = new List<IList<int>>();
    //     int n = nums.Length;
    //     for (int i = 0; i < n - 3; i++)
    //     {
    //         if (i > 0 && nums[i] == nums[i - 1]) continue;
    //         if (nums[i] > target / 4) break;
    //         if (nums[n - 1] < target / 4) break;
    //         for (int j = i + 1; j < n - 2; j++)
    //         {
    //             if (nums[j] > (target - nums[i]) / 3) break;
    //             if (nums[n - 1] < (target - nums[i]) / 3) break;
    //             if (j > i + 1 && nums[j] == nums[j - 1]) continue;
    //             int left = j + 1;
    //             int right = n - 1;
    //             while (left < right)
    //             {
    //                 int sum = nums[i] + nums[j] + nums[left] + nums[right];
    //                 if (sum == target)
    //                 {
    //                     res.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
    //                     while (left < right && nums[left] == nums[left + 1]) left++;
    //                     while (left < right && nums[right] == nums[right - 1]) right--;
    //                     left++;
    //                     right--;
    //                 }
    //                 else if (sum < target) left++;
    //                 else right--;
    //             }
    //         }
    //     }
    //     return res;
    // }
}