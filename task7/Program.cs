/* Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. Если второе число не кратно числу первому, 
 то программа выводит остаток от деления.*/

using static System.Console;
Clear();
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

WriteLine(a%b==0?"Кратно":$"нектратно, остаток {a%b}");
