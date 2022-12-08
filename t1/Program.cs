// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да  12345654321 88
// 23432 -> да

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int check = 0;
for (int number = n; number > 0; number /= 10)
{
    check = number % 10 + check * 10;
}
Console.Write(check);

if (check == n)
{
    Console.Write("ДА");
}
else
{
    Console.Write("Нет");
}

