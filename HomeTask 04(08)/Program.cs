// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число num = ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 3)
{
    Console.Write($"Перед числом {num} нет четных чисел");
}
int count = 2;
while (count <= num)
{
    Console.Write($"{count} ");
    count = count + 2;
}