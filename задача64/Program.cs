/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message){
    int result;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)){
            break;
        }
        else{
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}


void Recursion(int n){
    Console.Write($"{n}, ");
    if (n != 1)
    Recursion(n-1);
}


int number = GetNumber("Enter number");
Console.Write("\n");
Recursion(number);
