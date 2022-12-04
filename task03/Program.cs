/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int m = getUserInt("Введите число m: ");
int n = getUserInt("Введите число n: ");
int value = functionAckerman(m, n);
Console.WriteLine($"Значение функции Аккермана: {value}");

int functionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return functionAckerman(m - 1, 1);
    }
    return functionAckerman(m - 1, functionAckerman(m, n - 1));
}
