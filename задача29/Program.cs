/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

        while(!isCorrect)
        {
            Console.WriteLine(message);

            if(int.TryParse(Console.ReadLine(), out result))
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Ввели не число. Введите число.");
            }
        }

    return result;
}

int[] array = new int[8];


for (int i = 0; i < array.Length; i++){
    array[i] = GetNumber($"Введите {i} переменную: ");
}

Console.Write($"[");

for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]}");
    if (i != array.Length - 1) {
            Console.Write($", ");
    }
}

Console.Write($"]");

