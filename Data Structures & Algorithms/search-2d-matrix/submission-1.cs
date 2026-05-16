public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        (int rows, int cols) = (matrix.Length, matrix[0].Length);
        (int t, int b) = (0, rows - 1);
        while (t <= b)
        {
            int m = (t + b) / 2;
            if (target > matrix[m][cols - 1]) t = m + 1;
            else if (target < matrix[m][0]) b = m - 1;
            else break;
        }

        int row = (t + b) / 2;
        (int l, int r) = (0, cols - 1);
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (target > matrix[row][m]) l = m + 1;
            else if (target < matrix[row][m]) r = m - 1;
            else return true;
        }
        return false;
    }
}
