namespace LeetCode._0001_0050
{
    public class _001_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i=0; i<nums.Length; i++)
            {
                int sub = target - nums[i];
                if (map.ContainsKey(sub))
                {
                    return new int[] { map[sub], i };
                }
                else
                {
                    map[nums[i]] = i;
                }
            }
            return new int[] { };
        }
    }
}
