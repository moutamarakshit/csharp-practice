public class Solution {
    public int FindMin(int[] nums) {
        int low = 0, high = nums.Length - 1;
        int ans = int.MaxValue;

        while (low <= high) {
            int mid = low + (high - low) / 2;

            if (nums[mid] == nums[low] && nums[mid] == nums[high]) {
                ans = Math.Min(ans, nums[low]);
                low++;
                high--;
                continue;
            }

            if (nums[mid] >= nums[low]) {
                ans = Math.Min(ans, nums[low]);
                low = mid + 1;
            } else {
                ans = Math.Min(ans, nums[mid]);
                high = mid - 1;
            }
        }

        return ans;
    }
}
