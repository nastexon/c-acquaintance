/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetMassiv ()
{
    int[] massiv = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
    massiv[i] = rnd.Next(-10,100); // [..)
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


int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}

Console.WriteLine($" \n{sum}"); 