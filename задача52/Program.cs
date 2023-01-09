/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


// ввод числа для количества строк и столбцов в двумерной матрице. проверка на число

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}



// ввод числа для количества строк и столбцов в двумерной матрице. собственно, ввод

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int m = GetNumber("Введите кол-во строк");
int n = GetNumber("Введите кол-во столбцов");

int[,] matrix = InitMatrix(m,n);

PrintArray(matrix);

// метод для подсчета среднего арифметического элементов в каждом столбце

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + matrix[i,j];
    }

    double srar = sum/m;

    Console.WriteLine($"Сумма всех элементов столбца {j} равно {sum}");
    Console.WriteLine($"Среднее арифметическое стобца {j} матрицы равно {srar:0.0}\n");
}