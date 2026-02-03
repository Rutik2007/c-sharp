using System;
class demo
{
    static void Main()
    {
        int[][][] a = new int[2][][];

        a[0] = new int[3][];
        a[1] = new int[2][];

        a[0][0] = new int[1];
        a[0][1] = new int[3];
        a[0][2] = new int[5];

        a[1][0] = new int[2];
        a[1][1] = new int[3];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.WriteLine("a[i][j] length="+ a[i][j].Length);
            }
        }
    }
}