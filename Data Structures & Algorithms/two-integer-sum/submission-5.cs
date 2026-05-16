public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];
            if (map.TryGetValue(compliment, out int value))
            {
                return [value, i];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}
