public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> res = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i - 1] == nums[i]) continue;
            (int l, int r) = (i + 1, nums.Length - 1);
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                
                if (sum > 0) r--;
                else if (sum < 0) l++;
                else
                {
                    res.Add([nums[i], nums[l], nums[r]]);
                    r--;
                    l++;
                    while (l < r && nums[l] == nums[l - 1]) l++;
                }
            }
        }
        return res;
    }
}
