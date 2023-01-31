System.Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int div = n2 % n1;
if (div == 0)
{
    System.Console.WriteLine("Второе число кратно первому");
}
else
{
    System.Console.WriteLine("Остаток: " + div);
}