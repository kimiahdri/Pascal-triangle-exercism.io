using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] pascal = new int[rows][];
        for (int a = 1; a <= rows; a++)
        {
            int[] row = new int[a];
            row[0] = 1;
            row[a - 1] = 1;
            for (int b = 2; b < a; b++)
            {
                row[b - 1] = pascal[a - 2][b - 2] + pascal[a - 2][b - 1];
            }
            pascal[a - 1] = row;
        }
        return pascal;
    }
}