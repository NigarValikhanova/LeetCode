﻿namespace LeetCode
{
    public class Solution59
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];

            int left = 0, right = n - 1, top = 0, bottom = n - 1;
            int num = 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++) matrix[top][i] = num++;
                top++;

                for (int i = top; i <= bottom; i++) matrix[i][right] = num++;
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) matrix[bottom][i] = num++;
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) matrix[i][left] = num++;
                    left++;
                }
            }

            return matrix;
        }
    }
}
