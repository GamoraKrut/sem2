// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

// Console.Clear();

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
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.WriteLine('Input num1: ');
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine('Input num2: ');
// int B = Convert.ToInt32(Console.ReadLine());

// if (A * A == B || B * B == A)
// {
//     Console.WriteLine('Yes');
// }
// else
// {
//     Console.WriteLine('No');
// }

// //ЗАДАЧА 1.
// int Number = new Random().Next(100, 1000);
// Console.WriteLine(Number);
// Console.Write($"Удаляя вторую цифру из числа, получаем: {Number / 100}{Number % 100 % 10}");

//DZ sem 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее:

// Console.Clear();
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());

// if (A > B)
// {
//     Console.WriteLine(A);
// }
// else if (A < B)
// {
//     Console.WriteLine(B);
// }
// else
// {
//     Console.WriteLine("Equal");
// }


// DZ sem 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел:

// Console.Clear();

// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());

// if (A > B && A > C)
// {
//     Console.WriteLine(A);
// }
// else if (B > A && B > C)
// {
//     Console.WriteLine(B);
// }
// else if (C > A && C > B)
// {
//     Console.WriteLine(C);
// }
// else if (A == B)
// {
//     Console.WriteLine($"{A}");
// }
// else if (A == C)
// {
//     Console.WriteLine($"{A}");
// }
// else if (C == B)
// {
//     Console.WriteLine($"{C}");
// }

// DZ sem 1: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка):

// Console.Clear();

// int A = Convert.ToInt32(Console.ReadLine());

// if (A == 0)
// {
//     Console.WriteLine("It's zero");
// }
// else if (A % 2 == 0)
// {
//     Console.WriteLine("Its's even");
// }
// else
// {
//     Console.WriteLine("It's not even");
// }

// DZ sem 1: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N:

// Console.Clear();

// int N = Convert.ToInt32(Console.ReadLine());
// int I = 0;

// if (N == 0)
// {
//     Console.WriteLine("It's zero, dumbass");
// }
// else if (N == 1 || N == -1)
// {
//     Console.WriteLine("There are no any even numbers before 1, morron");
// }
// else if (N < I)
// {
//     while (I > (N + 1))
//     {
//         I -= 2;
//         Console.WriteLine(I);
//     }
// }
// else
// {
//     while (I < (N - 1))
//     {
//         I += 2;
//         Console.WriteLine(I);
//     }
// }

//DZ sem 2:  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа:

// Console.Clear();
// Console.Write("Ввести трехзначное число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// if (A > 999 || A < 100)
// {
//     Console.WriteLine("Трехзначное не больше, не меньше");
// }
// else
// {
//     int B = A % 100;
//     B = B / 10;
//     Console.WriteLine(B);
// }

// DZ sem 2:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет:
// Console.Clear();
// Console.Write("Input number: ");
// int A = Convert.ToInt32(Console.ReadLine());

// if (A < 100)
// {
//     Console.WriteLine("Input number bigger than 99");
// }
// else
// {
//     while (A >= 1000)
//     {
//         A = A / 10;
//     }
//     int B = A % 10;
//     Console.WriteLine($"Third number is: {B}");
// }

// DZ sem 2:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным:

Console.Clear();
Console.Write("Input number: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A > 7 || A < 1)
{
    Console.WriteLine("Incorrect day");
}
else if (A > 5)
{
    Console.WriteLine("Yes it's holiday");
}
else
{
    Console.WriteLine("No it's weekday");
}
