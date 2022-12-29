/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
string numStr = Console.ReadLine() ??"";

int i = 0;
int sum = 0;

while (i < numStr.Length){
    
    char temp_char = numStr[i]; 
    int temp = temp_char - '0'; //метод честно найденный в гугле)
    sum = sum + temp;
    i = i + 1;
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");