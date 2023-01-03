/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
1. Проверка на ввод числа
2. ввод чисел с клавиатуры
3. решение уравнения
*/

//поверка на число

double GetNumber(string message)
{
    double result;

    while(true)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
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

//введение коэффициентов

double k1 = GetNumber ("Enter first k");
double k2 = GetNumber ("Enter second k");
double b1 = GetNumber ("Enter first b");
double b2 = GetNumber ("Enter second b");

// решение уравнения. y = k1 * x + b1, y = k2 * x + b2

double x = ((b2-b1)/(k1-k2));
Console.WriteLine($"Координата х пересечения прямых равна {x}");

double y = ((k1*x)+b1);
Console.WriteLine($"Координата у пересечения прямых равна {y}");

