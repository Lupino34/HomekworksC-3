// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятинзначное чило: ");
int print_number = int.Parse(Console.ReadLine());
double full = print_number/10000;
int number_1 = print_number / 10000;
int number_2 = (print_number / 1000) % 10;
int number_4 = (print_number % 100) / 10;
int number_5 = print_number % 10;
if (full < 1 || full >= 10)
{
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число. Попробуйте снова. ");
}
else 
{
    // Console.WriteLine($"Числа: {number_1} {number_2} {number_4} {number_5}");
    if (number_1 == number_5 && number_2 == number_4)
    {
        Console.WriteLine("Данное чисо ЯВЛЯЕТСЯ палиндромом. ");
    }
    else 
    {
    Console.WriteLine("Данное чисо НЕ ЯВЛЯЕТСЯ палиндромом. ");
    }
}    