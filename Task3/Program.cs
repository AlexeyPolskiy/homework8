// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

int[,] FillArray(int[,] fillArr, int elementMIN, int elementMAX)
{
    for (int i = 0; i < fillArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillArr.GetLength(1); j++)
        {
            fillArr[i, j] = new Random().Next(elementMIN, elementMAX);
        }
    }
    return fillArr;
}

void PrintArray(int[,] printArr)
{
    for (int i = 0; i < printArr.GetLength(0); i++)
    {
        for (int j = 0; j < printArr.GetLength(1); j++)
        {
            System.Console.Write(printArr[i, j] + "\t"); //($"{printArr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplicationArray(int[,] mulArr1, int[,] mulArr2)
{
    int[,] result = new int[mulArr1.GetLength(0), mulArr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = CalculateElementResult(mulArr1, mulArr2, i, j);
        }
    }
    return result;    
}

int CalculateElementResult(int[,] array1, int[,] array2, int rowArr1, int collumsArr2)
{
    int temp = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        temp += array1[rowArr1, i] * array2[i, collumsArr2];
    }
    return temp;
}


int row1 = Promt("Введите число строк первого массива => ");
int collums1 = Promt("Введите число колон первого массива => ");

int row2 = Promt("Введите число строк второго массива => ");
int collums2 = Promt("Введите число колон второго массива => ");

int elementMIN = 0;
int elementMAX = 10;

int[,] array1 = new int[row1, collums1];
int[,] array2 = new int[row2, collums2];

System.Console.WriteLine();
System.Console.WriteLine("Матрица 1:");
FillArray(array1, elementMIN, elementMAX);
PrintArray(array1);
System.Console.WriteLine();

System.Console.WriteLine("Матрица 2:");
FillArray(array2, elementMIN, elementMAX);
PrintArray(array2);
System.Console.WriteLine();

if (array2.GetLength(0) != array1.GetLength(1)) 
{
    Console.WriteLine("Матрица не согласованна, учи мат.часть!");
    Environment.Exit(0);
}

int[,] array3 = MultiplicationArray(array1, array2);
System.Console.WriteLine("Произведение матриц:");
PrintArray(array3);