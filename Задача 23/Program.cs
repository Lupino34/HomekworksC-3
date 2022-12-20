// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("ВВедите число N");
int number_N = int.Parse(Console.ReadLine());
int number_A = 1;
if (number_N == 0)
{
    Console.WriteLine($"Вы ввели число {number_N}, в любой степени данное число принимает значение: {number_N}.");
}
else
{
    Console.WriteLine("Результирующая последовательность чисел: ");
    while (number_A < number_N)
    {
        int kub = number_A * number_A * number_A;
        Console.Write($"{kub}, ");
        number_A++;   
    }
    if (number_A == number_N)
    {
        int kub = number_A * number_A * number_A;
        Console.Write($"{kub}. ");
    }
}  
