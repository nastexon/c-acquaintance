/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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


int sum = 0;

int Recursion(int m, int n, int sum){
    if (m > n){
        return sum;
    } else {
        return Recursion(m + 1, n, sum + m);
    }
}


int numberM = GetNumber("Enter number M");
int numberN = GetNumber("Enter number N");
Console.Write("\n");

sum = Recursion(numberM, numberN, 0);

Console.WriteLine($"{sum}");
