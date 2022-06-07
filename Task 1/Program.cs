/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumFromMToN(int numberM, int numberN, int sum)
{
    if (numberM == numberN) return sum + numberM;
    sum += numberM;
    numberM++;
    return SumFromMToN(numberM, numberN, sum);
}
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int result = SumFromMToN(m, n, sum);
Console.WriteLine("Сумма элементов от M до N равна: ");
Console.Write(result);
