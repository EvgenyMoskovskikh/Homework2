// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int numberOne = (a % 10);
int numberThree = (a / 100);
int numberTwo = (a / 10 % 10);
Console.Write($"Первая цифра в числе {a} будет {numberThree}, а третья цифра в числе {a} будет {numberOne} и наконец вторая цифра в числе {a} будет {numberTwo}");
