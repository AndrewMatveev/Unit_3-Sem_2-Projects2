// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// Пример:
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num > 99 && num < 1000) // [)
{
    System.Console.WriteLine("Second number is: " + (num % 100) / 10);
}
else
{
    System.Console.WriteLine("Entered number is not a three-digit");
}