// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
            System.Console.Write($"{printArr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortArray(int[,] sortArr)
{
    for (int i = 0; i < sortArr.GetLength(0); i++) //сортировка пузырьком  
        for (int j = 0; j < sortArr.GetLength(1); j++)
            for (int k = 0; k < sortArr.GetLength(1); k++)
            {
                if (sortArr[i, j] <= sortArr[i, k]) continue;
                int temp = sortArr[i, j];
                sortArr[i, j] = sortArr[i, k];
                sortArr[i, k] = temp;
            }       
    return sortArr;
}

int row = Promt("Введите число строк массива => ");
int collums = Promt("Введите число колон массива => ");

int elementMIN = 0;
int elementMAX = 10;

int[,] array = new int[row, collums];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);
System.Console.WriteLine("Отсортированный массив:");
SortArray(array);
PrintArray(array);

