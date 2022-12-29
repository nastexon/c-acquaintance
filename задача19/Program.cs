/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string numStr = Console.ReadLine() ??"";

int i = 0;
bool result = true;

while (i < numStr.Length/2){
    if (numStr[i] != numStr[numStr.Length - i - 1]){
        result = false;
        break;
    } else {
        i = i + 1;
    }
}
if (result == true)
    Console.WriteLine($"Число {numStr} - палиндром");
else 
    Console.WriteLine($"Число {numStr} - не является палиндромом");


