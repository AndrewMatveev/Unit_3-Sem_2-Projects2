// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Пример:
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Insert the number: ");
int date = Convert.ToInt32(Console.ReadLine());

if (date > 0 && date < 8)
{
switch (date)
{
    case 1:
        System.Console.WriteLine("Inserted number matched with monday. That is not a holiday");
        break;
    case 2:
        System.Console.WriteLine("Inserted number matched with tuesday. That is not a holiday");
        break;
    case 3:
        System.Console.WriteLine("Inserted number matched with wednesday. That is not a holiday");
        break;
    case 4:
        System.Console.WriteLine("Inserted number matched with thursday. That is not a holiday");
        break;
    case 5:
        System.Console.WriteLine("Inserted number matched with friday. That is not a holiday, except that a little bit :)");
        break;
    case 6:
        System.Console.WriteLine("Yeahhh, that's it braaa! Saturday, holliday, finaly!");
        break;
    case 7:
        System.Console.WriteLine("Sunday, I feel bad. But it's still a holiday.");
        break;
}
}
else System.Console.WriteLine("There is no such day of the week");