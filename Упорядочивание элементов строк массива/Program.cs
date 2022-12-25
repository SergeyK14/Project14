// Упорядочивание элементов строк массива по убыванию
void Zadadcha54 ()
{
    int rows = 7;
    int columns = 7;
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

    
    for (int i = rows - 1; i >= 0; i--)
    {
        for (int j = columns-1; j >= 0; j--)
        {
            for (int k = columns-1; k > 0; k--)
            {
                if (array [i, k] >= array [i, k-1])
                {
                    int count = array [i, k];
                    array [i, k] = array [i, k-1];
                    array [i, k-1] = count;
                }
            }  
        }
    }
    Console.WriteLine();
    PrintArray(array);
}
Zadadcha54 ();

void FillArray (int [,] array, int minValue = 0, int maxValue = 6)
{
    maxValue++;
    Random rand = new Random ();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i, j] = rand.Next (minValue, maxValue);
        }
    }
}
void PrintArray (int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write ($"{array [i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


