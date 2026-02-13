using System;
class ArrayProgram
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int r = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int c = int.Parse(Console.ReadLine());

        int[,] arr = new int[r, c];

        Console.WriteLine("\nEnter elements:");

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("Element [" + i + "," + j + "] : ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nDuplicate Elements:");

        bool found = false;

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                int count = 0;
                bool alreadyPrinted = false;

                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (arr[x, y] == arr[i, j])
                        {
                            alreadyPrinted = true;
                            break;
                        }
                    }
                }

                if (alreadyPrinted)
                    continue;

                for (int x = 0; x < r; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (arr[x, y] == arr[i, j])
                        {
                            count++;
                        }
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(arr[i, j] + " is repeated " + count + " times");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No duplicate elements found.");
        }
    }
}
