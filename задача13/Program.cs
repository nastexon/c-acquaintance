/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

string numberStr = Convert.ToString(number);

if(number > 99)
    Console.WriteLine($"Третья цифра {number} = {numberStr[2]}");
else
    Console.WriteLine($"Третьей цифры нет");