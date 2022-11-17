// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m != 0 && n == 0)
    {
        return A(m - 1, 1);
    }

    if (m > 0 && m > 0)
    {
        return A(m - 1, A(m, n - 1));
    }

    return A(m, n);
}

int m = Prompt("Введите число M : ");
int n = Prompt("Введите число N : ");
int func = A(m, n);
System.Console.WriteLine(func);