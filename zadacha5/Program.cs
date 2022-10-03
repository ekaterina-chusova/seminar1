/*Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

Console.Clear();

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int N1 = N * (-1);
int x = 0;
if (N > N1)
{
    x = N1;
    while (x <= N)
    {
        Console.Write($"{x}, ");
        x = x + 1;
    }
}
else x = N;
{
    while (x <= N1)
    {
        Console.Write($"{x}, ");
        x = x + 1;
    }
}