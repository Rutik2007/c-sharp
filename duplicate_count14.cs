using System;
class Program14
{
    public static void Main(string[] args)
    {
        int r,c;

        Console.Write("Enter number of rows: ");
        r =Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        c =Convert.ToInt32(Console.ReadLine());

        int[,] arr =new int[r,c];

        Console.WriteLine("\nEnter elements of the 2D array:");

        for (int i =0; i<r; i++)
        {
            for (int j =0; j<c; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n2D Array in Tabular Format:");

        for (int i =0; i<r; i++)
        {
            for (int j =0; j<c; j++)
            {
                Console.Write(arr[i,j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nDuplicate Elements and Count:");

        bool found =false;
		for (int i =0; i <r; i++)
        {
            for (int j =0; j<c; j++)
            {
                int count =0;
                bool alreadyCounted =false;


                for (int x =0; x <=i; x++)
                {
                    for (int y =0; y<c; y++)
                    {
                        if (x ==i && y==j)
                            break;

                        if (arr[i,j] ==arr[x,y])
                        {
                            alreadyCounted =true;
                            break;
                        }
                    }
                    if (alreadyCounted)
                        break;
                }

                if (alreadyCounted)
                    continue;

                for (int x =0; x <r; x++)
                {
                    for (int y =0; y<c; y++)
                    {
                        if (arr[i,j] == arr[x,y])
                            count++;
                    }
                }

                if (count >1)
                {
                    Console.WriteLine("Element {0} occurs {1} times", arr[i,j], count);
                    found =true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No duplicate elements found.");
        }
    }
}
