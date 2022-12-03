/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int M = getUserInt("Введите минимальный элемент ряда: ");
int N = getUserInt("Введите максимальный элемент ряда: ");
int sumOfNaturalElements = printRange(M, N);
Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sumOfNaturalElements}");

int printRange(int M, int N)
{
    if (M < N)
    {
        return M + printRange(M + 1, N);
    }
    return N;
}

