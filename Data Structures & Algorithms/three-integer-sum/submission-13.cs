public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> res = [];
        Array.Sort(nums);
        ReadOnlySpan<int> span = nums;
        for (int i = 0; i < nums.Length; i++)
        {
            if (span[i] > 0) break;
            if (i > 0 && span[i - 1] == span[i]) continue;
            (int l, int r) = (i + 1, span.Length - 1);
            while (l < r)
            {
                int sum = span[i] + span[l] + span[r];
                
                if (sum > 0) r--;
                else if (sum < 0) l++;
                else
                {
                    res.Add([span[i], span[l], span[r]]);
                    r--;
                    l++;
                    while (l < r && span[l] == span[l - 1]) l++;
                }
            }
        }
        return res;
    }
}
