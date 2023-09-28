// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число num1 = ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число num2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"Первое число больше второго числа {num1} > {num2}");
}
else if (num2 > num1)
{
    Console.Write($"Второе число больше первого числа {num2} > {num1}");
}
else Console.Write($"Числа равны между собой {num2} = {num1}");