public class Solution {
    public int Search(int[] nums, int target)
    {
        ReadOnlySpan<int> span = nums;
        (int l, int r) = (0, span.Length - 1);
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (span[m] > target) r = m - 1;
            else if (span[m] < target) l = m + 1;
            else
            {
                return m;
            } 
        }
        return -1;
    }
}
