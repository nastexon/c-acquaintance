/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// создание матрицы 4х4

int m = 4;
int n = 4;

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

int[,] matrix = InitMatrix(m,n);

PrintArray(matrix);

// упорядочивание


int tmp = 0;

//int i = 0;


for (int i = 0; i < m; i++){

    int k = n - 1;
    
    while (k > 0){
        for (int j = 0; j < k; j++){
            if (matrix[i,j] > matrix[i,j+1]){ 
                tmp = matrix[i,j]; 
                matrix[i,j] = matrix[i,j+1]; 
                matrix[i,j+1] = tmp; 
            }
        }
        k = k - 1;
    }
}
Console.WriteLine();
PrintArray(matrix);
            