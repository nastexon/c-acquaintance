/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
String numberStr = Console.ReadLine ();

int number = Convert.ToInt32(numberStr);

int result = number % 2;

if (result == 0)
{
    Console.WriteLine ("True");
}
else 
{
    Console.WriteLine ($"False");
}