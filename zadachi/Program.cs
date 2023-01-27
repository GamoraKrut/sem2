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

// Console.Clear();
// Console.Write("Input number: ");
// int A = Convert.ToInt32(Console.ReadLine());

// if (A > 7 || A < 1)
// {
//     Console.WriteLine("Incorrect day");
// }
// else if (A > 5)
// {
//     Console.WriteLine("Yes it's holiday");
// }
// else
// {
//     Console.WriteLine("No it's weekday");
// }

// SEM 3:

// zad 1: Напишите программу которая принимает на вход координаты причем X != 0, Y != 0,  и выдаёт номер четверти плоскости в которой находится:

// Console.Clear();
// Console.Write("Input X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("First quarter");
// }
// else if (X < 0 && Y > 0)
// {
//     Console.WriteLine("Second quarter");
// }
// else if (X < 0 && Y < 0)
// {
//     Console.WriteLine("Third quarter");
// }
// else if (X > 0 && Y < 0)
// {
//     Console.WriteLine("Fourth quarter");
// }
// else
// {
//     Console.WriteLine("incorrect input");
// }

// DZ
// zad 1:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());
// if (a >= 100000 || a < 10000)
// {
//     Console.WriteLine("только пятизнaчное число");
// }
// else
// {
//     string s = a.ToString();
//     char[] ar = s.ToCharArray();
//     Array.Reverse(ar);
//     s = new String(ar);
//     int b = Convert.ToInt32(s);
//     if (a == b)
//     {
//         Console.WriteLine($"{a} = {b} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"{a} не равно {b} не является палиндромом");
//     }
// }
// Console.WriteLine(a);

// zad 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// Console.Clear();
// Console.WriteLine("Введите координаты точки A: ");
// Console.Write("x:");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("y:");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("z:");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B: ");
// Console.Write("x:");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("y:");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.Write("z:");
// int bz = Convert.ToInt32(Console.ReadLine());

// double sum = Math.Sqrt(
//     Math.Abs(Math.Pow((bx - ax), 2)) + (Math.Pow((by - ay), 2)) + (Math.Pow((bz - az), 2))
// );
// Console.WriteLine(sum);

// Zad 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// Console.Clear();
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int a = 0;
// Console.Write($"{N} --->");
// while (i <= N)
// {
//     a = i * i * i;
//     Console.Write($"{a}, ");
//     i = i + 1;
// }

// Console.Clear();
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//                 minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// seminar 4

// zad 1: Написать программу которая, принимает на вход число (А) и выдает сумму чисел от 1 до А.

// Console.Clear();
// int A = Convert.ToInt32(Console.ReadLine());
// int B = 0;
// for (int i = 0; i <= A; i++)
// {
//     B += i;
// }
// Console.WriteLine(B);

//zad 1 через функцию:

// int summa(int a)
// {
//     int B = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         B += i;
//     }
//     return B;
// }
// Console.WriteLine(summa(10));
// Console.WriteLine(summa(15));

//zad2: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// void CountN(int Numb)
// {
//     int res = 0;
//     while (Numb > 0)
//     {
//         Numb = Numb / 10;
//         res++;
//     }
//     Console.WriteLine(res);
// }
// CountN(Convert.ToInt32(Console.ReadLine()));

//zad2: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] mass = new int[8];
// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random().Next(2);
//     Console.Write(mass[i]);
// }

// DZ sem 4.
// zad 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Clear();
// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");

// int Pow(int num, int rank)
// {
//     if (rank == 0)
//         return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }
//     return result;
// }

// zad 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {NumSum(num)}");

// int NumSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// zad 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Console.Clear();
// int[] CreateArray()
// {
//     int[] arr = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         Console.Write($"Введите {i + 1} элемент массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void Show(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateArray();
// Show(myArray);

// Sem 5
// Razbor dz massiv
// int[] RandomArray(int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < 0; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// int[] CreateArray()
// {
//     //Console.Write("Введите количество элементов массива: ");
//     //int size = Convert.ToInt32(Console.ReadLine());
//     int[] arr = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         Console.Write($"Введите {i + 1} элемент массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void Show(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// // int[] CreateRandomArray = RandomArray(num, min, max);
// // Show(CreateRandomArray);
// Console.WriteLine("--------");
// int[] myArray = CreateArray();
// Show(myArray);

// // zad 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка от [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// Console.Clear();
// int[] RandomArray(int n, int start, int end) /*задаем рандомный массив с необходимыми параметрами*/
// {
//     int[] Array = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Count(int[] Arr)
// {
//     int Pos = 0;
//     int Neg = 0;
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         if (Arr[i] < 0)
//         {
//             Neg += Arr[i];
//         }
//         else
//         {
//             Pos += Arr[i];
//         }
//     }
//     Console.WriteLine($"Сумма положительных = {Pos}\nСумма отрицательных = {Neg}");
// }
// int[] myArray = RandomArray(12, -9, 9);
// Show(myArray);
// Count(myArray);

// // zad 2 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// Console.Clear();
// int[] RandomArray(int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for(int i = 0; i < N; i ++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
// return Array;
// }

// void Show(int[] Arr)
// {
//     for(int i = 0; i< Arr.Length; i ++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] TurnNegPos(int[] Arr)
// {
//     for(int i = 0; i < Arr.Length; i++)
//     {
//         Arr[i] *= -1;
//     }
//     return Arr;
// }



// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начало диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = RandomArray(num, min, max);
// Show(myArray);
// int[] NegPos = TurnNegPos(myArray);
// Show(NegPos);
// // zad 3 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Console.Clear();
// int[] RandomArray(int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for(int i = 0; i < N; i ++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
// return Array;
// }

// void Show(int[] Arr)
// {
//     for(int i = 0; i< Arr.Length; i ++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начало диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число которое надо найти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [] myArray = RandomArray(num, min, max);
// Show(myArray);
// int Chislo = 0;
// for(int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] == number)
//         {
//             Chislo++;
//         }
// }
// if(Chislo > 0)
// {
//     Console.WriteLine($"Число {number} присутствует в массиве");
// }
// else
// {
//     Console.WriteLine($"Число {number} отсутствует в массиве");
// }

// // DZ sem 5.

// // zad 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] RandomArray(int N, int start, int end) /*функция задает массив со случайными числами*/
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Arr) /*функция задает вывод массива*/
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Count(int[] Arr2)
// {
//     int N = 0;
//     for (int i = 0; i < Arr2.Length; i++)
//     {
//         if (Arr2[i] % 2 == 0)
//         {
//             N++;
//         }
//     }
//     Console.WriteLine($"Четных чисел в массиве: {N}");
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число диапазона от 100 до 999");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число диапазона от 100 до 999");
// int max = Convert.ToInt32(Console.ReadLine());
// if (min < 100 || min > 999 || max < 100 || max > 999 || num < 1)
// {
//     Console.WriteLine("ERROR!");
// }
// else
// {
//     int[] CreateRandomArray = RandomArray(num, min, max);
//     Show(CreateRandomArray);
//     Count(CreateRandomArray);
// }

// // zad 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] RandomArray(int N, int start, int end) /*функция задает массив со случайными числами*/
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Arr) /*функция задает вывод массива*/
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
// }
// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 1)
// {
//     Console.WriteLine("ERROR!");
// }
// else
// {
//     Console.WriteLine("Введите первое число диапазона");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите последнее число диапазона");
//     int max = Convert.ToInt32(Console.ReadLine());

//     int[] CreateRandomArray = RandomArray(num, min, max);
//     Show(CreateRandomArray);
//     Console.WriteLine();
//     Count(CreateRandomArray);
// }

// void Count(int[] Arr2)
// {
//     int N = 0;
//     for (int i = 0; i < Arr2.Length; i += 2)
//     {
//         N += Arr2[i];
//     }
//     Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {N}");
// }


// // zad 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.Clear();
// int[] RandomArray(int size, int start, int end)
// {
//     int[] Array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int MinMax(int[] Array)
// {
//     int Min = Array[0];
//     int Max = Array[0];
//     int Diff = 0;
//     for (int i = 0; i < Array.Length - 1; i++)
//     {
//         if (Min > Array[i + 1])
//         {
//             Min = Array[i + 1];
//         }
//         if (Max < Array[i + 1])
//         {
//             Max = Array[i + 1];
//         }
//     }
//     Diff = Max - Min;
//     return Diff;
// }

// Console.WriteLine("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] CreateRandomArray = RandomArray(num, min, max);
// Show(CreateRandomArray);
// Console.WriteLine(
//     $"Разница между наибольшим и наименьшим значениями = {MinMax(CreateRandomArray)}"
// );

// // Sem 5:
// foreach (var i in array) - работает как for в python(for i in array) - перебирает каждый элемент в массиве
// dz zad 3 через double
// double[] CreateRandomArray(int N, int start, int end)
// {
//     double[] RandomArray = new double[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1) + new Random().NextDouble();
//         if (RandomArray[i] > end)
//             RandomArray[i] = end;
//         return RandomArray;
//     }
// }

// void Show(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Zad 1: Переверните одномерный массив:

// Console.Clear();

// int[] RandomArray(int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

/*1 способ*/
//////////////////////////////////////////////////

// int[] ReverseArray(int[] Array)
// {
//     int Length = Array.Length;
//     int[] Reverse = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         Reverse[Length - 1 - i] = Array[i];
//     }
//     return Reverse;
// }

/*2 способ*/
///////////////////////////////////////////////////
// int[] ReverseArray(int[] Array)
// {
//     for (int i = 0; i < Array.Length / 2; i++)
//     {
//         int Temp = Array[i];
//         Array[i] = Array[Array.Length - 1 - i];
//         Array[Array.Length - 1 - i] = Temp;
//     }
//     return Array;
// }

// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начало диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(num, min, max);
// Console.Write("Изначальный массив: ");
// Show(myArray);
// Console.Write("Изначальный массив: ");
// Show(ReverseArray(myArray));

// Zad 2: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. АВ < BC + AC && BC < AB + AC && AC < AB + BC -  norm

// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());
// if (A < B + C && B < A + C && C < A + B)
// {
//     Console.WriteLine("norm");
// }
// else
// {
//     Console.WriteLine("error");
// }

// Zad 3: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// int[] DoubleSys(int N)
// {
//     int J = 0;
//     int B = N;
//     while (B > 0)
//     {
//         B = B / 2;
//         J += 1;
//     }
//     int[] array = new int[J];
//     int C = 0;
//     while (N > 0)
//     {
//         if (N / 2 == 0)
//         {
//             array[array.Length - 1 - C] = 0;
//         }
//         else
//         {
//             array[array.Length - 1 - C] = 1;
//         }
//         C += 1;
//     }
//     return array;
// }
// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Show(DoubleSys(Convert.ToInt32(Console.ReadLine())));

// Zad 4: Не используя рекурсию вывести первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. dz

// int[] Fibonacci(int N)
// {
//     int[] array = new int[N];
//     array[1] = 1;
//     array[2] = 1;
//     for (int i = 2; i < N; i++)
//     {
//         array[i] = (array[i - 1]) + (array[i - 2]);
//     }
//     return array;
// }
// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Show(Fibonacci(Convert.ToInt32(Console.ReadLine())));

// Zad 5: Напишите программу которая будет создавть копию массива с помощью поэлементного копирования.
// Console.Clear();

// int[] RandomArray(int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }

// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int[] Array)
// {
//     int Length = Array.Length;
//     int[] Reverse = new int[Length];
//     int j = 0;
//     foreach (int i in Array)
//     {
//         Reverse[Length - 1 - j] = i;
//         j++;
//     }
//     return Reverse;
// }

// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начало диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(num, min, max);
// Console.Write("Изначальный массив: ");
// Show(myArray);
// Console.Write("Изначальный массив: ");
// Show(ReverseArray(myArray));

//Dz sem 6:

// // Zad 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();

// Console.Write("Введите сколько чисел хотите ввести: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] UserArray = new int[M];
// for (int i = 0; i < M; i++)
// {
//     Console.Write($"Введите {i + 1} число: ");
//     UserArray[i] = Convert.ToInt32(Console.ReadLine());
// }

// int CountPos(int[] Array)
// {
//     int j = 1;
//     foreach (int i in Array)
//     {
//         if (i > 0)
//         {
//             j += 1;
//         }
//     }
//     return j;
// }

// void Show(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Show(UserArray);
// Console.WriteLine($"Введено чисел > 0: {CountPos(UserArray)}");

// // Zad 2:  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// //         y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
