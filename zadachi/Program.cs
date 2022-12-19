//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

// Console.Clear();

// int num1 = new Random().Next(100 - 1000);
// Console.WriteLine(num1);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

// Console.WriteLine('input num1: ');
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine('Input num2: ');
// int B = Convert.ToInt32(Console.ReadLine());

// if (b % a == 0)
// {
//     Console.WriteLine('Kratno');
// }
// else
// {
//     Console.Writeline('Ne kratno')
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.WriteLine('Input num1: ');
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine('Input num2: ');
// int B = Convert.ToInt32(Console.ReadLine());
// if (A % B == 0)
// {
//     Console.WriteLine('Kratno');
// }
// else
// {
//     Console.WriteLine('Ne kranto');
//}

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.WriteLine('Input num1: ');
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine('Input num2: ');
// int B = Convert.ToInt32(Console.ReadLine());

// if (A * A == B && B * B == A)
// {
//     Console.WriteLine('Yes');
// }
// else
// {
//     Console.WriteLine('No');
// }

//ЗАДАЧА 1.
int Number = new Random().Next(100, 1000);
Console.WriteLine(Number);
Console.Write($"Удаляя вторую цифру из числа, получаем: {Number / 100}{Number % 100 % 10}");
