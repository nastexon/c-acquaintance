/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


// прямоугольный двумерный массив 4x4

int m = 4;
int n = m;

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

// метод для подсчета суммы элементов в каждой строке

int[] array = new int[m];

for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + matrix[i,j];
        array[i] = sum;
    }
    Console.WriteLine($"\n Сумма всех элементов строки {i+1} равно {sum}"); // i+1 для пользователей. человек привык считать с 1
    // Console.WriteLine($"{array[i]}, ");
}

// метод сравнения сумм элементов каждой строки. поиск минимальной

int[] minarray = new int[m];
int min = array[0];
int mini = 0;
// string result = " ";

    for (int i = 0; i < m; i++)
        {
            if (array[i] <= min)
                {
                    min = array[i];
                    mini = i+1;            //пользователь ведь считает не с 0, как компьютер
                    // result = result + " " + Convert.ToString(i);  - попытки сделать поиск минимумов, если одинаковые суммы на нескольких строках. Неудачная
                    minarray[i] = min;
                }
        }
    
        Console.WriteLine($"\n Наименьшая сумма элементов {min}"); 
        Console.WriteLine($"\n Номер строки c наименьшей суммой элементов {mini} \n");