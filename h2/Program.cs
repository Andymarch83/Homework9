/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string msg)
{
    Console.Write(msg);
    {
        int result = 0;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out result)) break;
            else Console.WriteLine("НЕ КОРРЕКТНОЕ ЗНАЧЕНИЕ");
        }
        return result;
    }
}



int GetSum(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    else
    {
        m++;
        res = m + GetSum(m, n);
        return res;
    }
}


int m = GetNumber("Введите число M:");
int n = GetNumber("Введите число N:");
Console.WriteLine(GetSum(m-1, n));