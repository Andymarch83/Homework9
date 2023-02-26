/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");