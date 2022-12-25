// Заполнение спирально массива 4 на 4 числами от 1 до 16

void DisqArray ()
{
    int rows = 4;
    int columns = 4;
    int [,] array = new int [rows, columns];
    FillArray (array);
    PrintArray (array);
    
    int i = 0;
    int j = 0;
    int count = 0;
    for (i=0; j<4; j++) 
    {
        array[i, j] = count+1;
        count+=1;
    }
    i++;
    for (j=3; i<4; i++) 
    {
        array[i, j] = count+1;
        count+=1;
    }
    j--;
    for (i=3; j>=0; j--) 
    {
        array[i, j] = count+1;
        count+=1;
    }
    i--;
    for (j=0; i>=1; i--) 
    {
        array[i, j] = count+1;
        count+=1;
    }
    j++;
    for (i=1; j<3; j++) 
    {
        array[i, j] = count+1;
        count+=1;
    }
    i++;
    for (j=2; i<3; i++)
    {
        array[i, j] = count+1;
        count+=1;
    }
    j--;
    for (i=2; j>0; j--)
    {
        array[i, j] = count+1;
    }
    PrintArray (array);
}
void FillArray (int [,] array, int minValue = 0, int maxValue = 0)
{
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
DisqArray ();