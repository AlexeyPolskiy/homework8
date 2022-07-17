// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

void PrintArrayMas(int[] printMas) // этот метод вспогательный чтобы посмотреть корректноссть нахождения сум элементов строк
{
    int count = printMas.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{printMas[i]} ");
    }
}

int[] SumElementRow(int[,] sortArr)
{
    int k = 0;
    int sum = 0;
    int[] sumArr = new int[sortArr.GetLength(0)]; // этот массив для сумм элементов строк
    for (int i = 0; i < sortArr.GetLength(0); i++)
    {
        sum = 0; // здесь обнуляется сумма элементов строки
        for (int j = 0; j < sortArr.GetLength(1); j++)
        {
            sum += sortArr[i, j];
        }
        sumArr[k] = sum;
        k++;
    }
    return sumArr;
}

int SearchMinRow (int[] searchArr)
{
    int min = searchArr[0];
    int index =0;
    for (int i=0; i<searchArr.Length;i++)
    {
        if (min > searchArr[i])
        {
            min = searchArr[i];
            index = i;
        }
    }
    return index; 
}


int row = Promt("Введите число строк массива => ");
int collums = 2 * row;

int elementMIN = 0;
int elementMAX = 10;

int[,] array = new int[row, collums];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);
System.Console.WriteLine("Суммы элементов строк:");
int[] sumArr = SumElementRow(array);
PrintArrayMas(sumArr);
int min = SearchMinRow(sumArr);
int index = SearchMinRow(sumArr);
System.Console.WriteLine();
System.Console.WriteLine($"Элементы с минимальной суммой находятся на {index+1} строке ");

