/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine ("Введите первое число");
String numberOneStr = Console.ReadLine ();

Console.WriteLine ("Введите второе число");
String numberTwoStr = Console.ReadLine ();

Console.WriteLine ("Введите третье число");
String numberThreeStr = Console.ReadLine ();

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo = Convert.ToInt32(numberTwoStr);
int numberThree = Convert.ToInt32(numberThreeStr);

if (numberOne > numberTwo && numberOne > numberThree) 
{
    Console.WriteLine ($"max= {numberOne}");
}

else if (numberOne < numberTwo && numberTwo > numberThree) 
{
    Console.WriteLine ($"max= {numberTwo}");
}

else if (numberThree > numberTwo && numberOne < numberThree) 
{
    Console.WriteLine ($"max= {numberThree}");
}