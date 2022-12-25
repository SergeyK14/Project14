// Строка массива с наименьшей суммой элементов
void SmallestRowSum ()
{
    int rows = 3;
    int columns = 3;
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

    
    int minSum = CalculatingTheAmount (array, 0);
    int numberRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
           sum = CalculatingTheAmount (array, i);
        }
        if (minSum > sum)
        {
            minSum = sum;
            numberRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {numberRow + 1}");
}
SmallestRowSum ();

void FillArray (int [,] array, int minValue = 0, int maxValue = 8)
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
int CalculatingTheAmount (int [,] array, int rowIndex)
{
    int sum = 0;
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
        {
           sum += array [rowIndex, j];
        }
return (sum);
}