/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите цифру от 1 до 7");
string day = Console.ReadLine();

if (day == "1"| day == "2"| day == "3"| day == "4"| day == "5")
Console.WriteLine("нет");
if (day == "6"| day == "7")
Console.WriteLine("да");
else 
Console.WriteLine("Вы ввели не коректное число");