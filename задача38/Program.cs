/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// задаем массив

double[] GetMassiv ()
{
    double[] massiv = new double[4];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
    massiv[i] = rnd.Next(-100, 100) + rnd.NextDouble(); // int + [0;1]
    }

    return massiv;
}

double[] array = GetMassiv();


//выводим массив для проверки дальнейших действий
Console.Write($"[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}");
    if (i != array.Length - 1) 
            Console.Write($", ");
}

Console.Write($"]");

// находим максимум и минимум
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
}
Console.WriteLine($" \n\n{max}"); 

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
}
Console.WriteLine($" \n{min}"); 

// находим разницу. разница, это ж по сути, расстояние на шкале между цифрами. поэтому модуль не нужен, даже если мин отрицательный 
double diff = max - min; 
Console.WriteLine($" \n{diff}"); 