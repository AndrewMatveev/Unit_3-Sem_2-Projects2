Random rand = new Random();
int number = rand.Next(100, 1000);

System.Console.WriteLine($"Случайное число: {number}");

// int num1 = number/10;
int num2 = number%10;
int num3 = number/100;
System.Console.WriteLine(num2);
System.Console.WriteLine(num3);
System.Console.WriteLine(num3,num2); // Косяк неправильно записан вывод 

// Андрей Игоревич 
// int result = (num3*10)+num2;
// System.Console.WriteLine(result);



// Random rand = new Random();
// int number = new Random() .Next(100,» 1000);
// System.Console.WriteLine($"Cny4aiiHoe число: {number}");
// System.Console.WriteLine($"Cny4atiHoe число: {number}");
// System.Console.WriteLine($"{number / 100}{number % 10}");
// number = ((number / 100) * 10) + (number % 10);