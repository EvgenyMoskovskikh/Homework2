// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int a = int.Parse(Console.ReadLine());
if (a <= 5)
{

    Console.Write($"День {a} не является выходным");

}
else
{
    if ((a == 6) || (a == 7))
    {
        Console.Write($"День {a} является выходным");
    }
    else
    {
        Console.Write("Таких дней в неделе нет");
    }
}
