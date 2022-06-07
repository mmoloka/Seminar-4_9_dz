/*
 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    if(number < 0) 
    {
        Console.WriteLine(message);
        number = int.Parse(Console.ReadLine());
    }
    return number;
}
int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return Akkerman(m - 1,1);
    else return(Akkerman(m - 1, Akkerman(m, n - 1)));
}
int m = GetNumber("Введите первое неотрицательное число: ");
int n = GetNumber("Введите второе неотрицательное число: ");
int f = Akkerman(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана для чисел {m} и {n}: {f}");
