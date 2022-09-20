// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
/*
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

string NumMN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    return m + ", " + NumMN(m + 1, n);

}

void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int m = ReadData("Input first number: ");
int n = ReadData("Input second number: ");
string rec = (m < n) ? (NumMN(m, n)) : (NumMN(n, m));
PrintData($" Natarul numbers from {m}-{n}: ", rec);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
/*
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

int SumMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    return m + SumMN(m + 1, n);

}

void PrintData(string prefix, int num)
{
    Console.WriteLine(prefix + num);
}

int m = ReadData("Input first number: ");
int n = ReadData("Input second number: ");
int rec = SumMN(m, n);
PrintData($" Sum of natarul numbers from {m}-{n}: ", rec);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

long Ackerman(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

void PrintData(string prefix, long num)
{
    Console.WriteLine(prefix + num);
}

int m = ReadData("Input first non-negative number: ");
int n = ReadData("Input second non-negative number: ");
long rec = Ackerman(m, n);
PrintData($" Result of function Ackerman ({m}, {n}): ", rec);
*/

