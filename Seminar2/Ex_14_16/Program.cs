// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int div = n1%7;
int div1 = n1%23;

if (div==0 && div1==0)
{
    System.Console.WriteLine("Число кратно 7 и 23");
}
else System.Console.WriteLine("Число не кратно");




// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// System.Console.Write("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// // double.Parse(System.Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int res1 = n1*n1;
// int res2 = n2*n2;

// if (res1==n2) 
// {
//   System.Console.WriteLine("Второе число является квадратом первого");  
// }
// else {
//     if (res2==n1) 
// {
//   System.Console.WriteLine("Первое число является квадратом второго");  
// }
// else 
// {
//     System.Console.WriteLine("Это не квадраты");
// }}