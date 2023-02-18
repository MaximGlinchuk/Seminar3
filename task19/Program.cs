// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число: ");
int number = Convert.ToInt32(Console.ReadLine());
string strnum = Convert.ToString(number);
if (number >= 10000 && number <= 99999)
{
    if (strnum[0] == strnum[^1] && strnum[1] == strnum[^2])
    {
    Console.WriteLine("Число является полиндромом");
    }
    else
    Console.WriteLine("Число не является полиндромом");
}
else
Console.WriteLine("Число не пятизначное!");
