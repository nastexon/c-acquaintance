/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
1. Проверка на ввод числа
2. ввод чисел с клавиатуры
3. подсчет положительных
*/

//поверка на число

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

//метод инициализации массива

int[] InitArray(int dimention)
{
    int[] array = new int [dimention];
    Random rnd = new Random();
    for (int i = 0; i < dimention; i++)
    {
        array[i] = GetNumber ("Введите элемент массива");;
    }
    return array;
}

//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод подсчёта количества элементов, удовлетворяющих условию

int CountNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        count ++;
        }
    }
    return count;
}

int dim = GetNumber ("Введите размерность массива");
int [] array = InitArray(dim);
PrintArray(array);
Console.WriteLine($"Количество положительных элементов {CountNumbers(array)}");
