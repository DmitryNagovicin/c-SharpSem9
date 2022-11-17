// Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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
        return m + PrintNum(m + 1, n);
    }
    return 0;
}

int m = Prompt("Введите число M : ");
int n = Prompt("Введите число N : ");
int sum = PrintNum(m, n);
System.Console.WriteLine(sum);