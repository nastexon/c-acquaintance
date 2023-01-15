/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


// проверка на ввод числа


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

// рекурсия Аккермана

int sum = 0;

int Recursion(int m, int n){
    if (m == 0){
        return (n+1);
    }
    else if (m > 0 && n == 0){
        return Recursion(m-1, 1);
    } else {
        return Recursion(m-1, Recursion(m, n-1));
    }
}
int numberM = GetNumber("Enter number m >= 0");
int numberN = GetNumber("Enter number n >= 0");
Console.Write("\n");
sum = Recursion(numberM, numberN);
Console.WriteLine($"{sum}");

/*
для проверки
m=1 n=2 f=4
m=0 n=0 f=1
m=4 n=5 f=Stack Overflow
*/