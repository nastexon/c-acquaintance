/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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
            Console.WriteLine("Not a number. Enter number");
        }
    }

    return result;
}


int numberA = GetNumber ("Enter number A");
int numberB = GetNumber ("Enter number B");

double GetPow (int numberA, int numberB) 
{
    return Math.Pow (numberA, numberB);
}

double pow = GetPow (numberA, numberB);

Console.WriteLine ($"Number A in exponent B is {pow}");

