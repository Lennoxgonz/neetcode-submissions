public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> seen = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.TryGetValue(nums[i], out int num))
            {
                return true;
            }
            seen.Add(nums[i]);
        }
        return false;
    }
}