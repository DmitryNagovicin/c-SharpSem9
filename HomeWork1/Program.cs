// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"



int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintNum(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0 & m != 0)
        {
            System.Console.Write(m + " ");
        }
        PrintNum(m + 1, n);
    }
    return 0;
}

int m = Prompt("Введите число M : ");
int n = Prompt("Введите число N : ");
PrintNum(m, n);