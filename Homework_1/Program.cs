// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int numReversed = 0;

if(num < 0 || (num % 10 == 0 && num != 0))
{
    Console.WriteLine("No!");
    return;
}
while (num > numReversed)
{
    numReversed = numReversed * 10 + num % 10;
    num /= 10;
}
if (num == numReversed || num == numReversed/10)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
