public class Solution {
    public int Search(int[] nums, int target)
    {
        ReadOnlySpan<int> span = nums;
        (int l, int r) = (0, span.Length - 1);
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            switch (span[m].CompareTo(target))
            {
                case > 0: r--; break;
                case < 0: l++; break;
                default: return m;
            }
        }
        return -1;
    }
}
