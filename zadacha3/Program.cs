/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.Clear();

Console.Write("Введите целое число от 1 до 7:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8)
{
    if (num > 0)
    {
        if (num == 1) Console.Write("Понедельник");
        if (num == 2) Console.Write("Вторник");
        if (num == 3) Console.Write("Среда");
        if (num == 4) Console.Write("Четверг");
        if (num == 5) Console.Write("Пятница");
        if (num == 6) Console.Write("Суббота");
        if (num == 7) Console.Write("Воскресенье");
    }
    else Console.Write("Ошибка ввода.Введите число от 1 до 7");
}
else Console.Write("Ошибка ввода.Введите число от 1 до 7");

