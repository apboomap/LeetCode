namespace LeetCode._0001_0050;

public class _0035_Search_Insert_Position
{
    public int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length == 0) return 0;  // Handle null/empty case
        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }
}