/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetMassiv ()
{
    int[] massiv = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
    massiv[i] = rnd.Next(100,1000); // [..)
    }

    return massiv;
}

int[] array = GetMassiv();


Console.Write($"[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}");
    if (i != array.Length - 1) 
            Console.Write($", ");
}

Console.Write($"]");

int a = 0; // count even number

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        a = a + 1;
}

Console.WriteLine($" \n{a}"); // \n == enter
