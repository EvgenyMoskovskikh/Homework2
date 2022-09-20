// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int numberOne = (a % 10);
if (a > 99)
{
    Console.Write($"Третья цифра в числе {a} будет {numberOne}");
}
else
{
    Console.Write($"Третьей цифры в числе {a} нет");
}
