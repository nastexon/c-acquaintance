/*  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// проверка на ввод числа

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

// создание первой матрицы

int[,] InitMatrixA(int m, int n)
{
    int[,] matrixA = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i,j] = rnd.Next(1,10);
        }
    }

    return matrixA;
}

void PrintArrayA(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write($"{matrixA[i,j]} ");
        }

        Console.WriteLine();
    }
}

int m = GetNumber("Введите кол-во строк для первой матрицы");
int n = GetNumber("Введите кол-во столбцов для первой матрицы");

int[,] matrixA = InitMatrixA(m,n);

Console.Write($"\n");
Console.WriteLine($"Первая матрица");
PrintArrayA(matrixA);

// создание второй матрицы

int[,] InitMatrixB(int o, int p)
{
    int[,] matrixB = new int[o,p];
    Random rnd = new Random();

    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i,j] = rnd.Next(1,10);
        }
    }

    return matrixB;
}

void PrintArrayB(int[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write($"{matrixB[i,j]} ");
        }

        Console.WriteLine();
    }
}

int o = GetNumber("Введите кол-во строк для второй матрицы");
int p = GetNumber("Введите кол-во столбцов для второй матрицы");

int[,] matrixB = InitMatrixB(o,p);

Console.Write($"\n");
Console.WriteLine($"Вторая матрица");
PrintArrayB(matrixB);

// умножение матриц A и В

if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
    Console.WriteLine ("Матрицы нельзя перемножить"); //проверка на соблюдение условий

int[,] InitMatrix(int w, int v)
{
    int[,] matrix = new int[w,v];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(0); k++)
            {
                matrix[i,j] += matrixA[i,k]*matrixB[k,j];
            }
        }
    }
    return matrix;
}

//вывод результирующей (основной) матрицы

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int w = m;
int v = p;

int[,] matrix = InitMatrix(w,v);
Console.Write($"\n");
Console.WriteLine($"Результирующая матрица");
PrintArray(matrix);