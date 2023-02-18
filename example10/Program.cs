// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 100 || num > 999){
    Console.WriteLine("Введено неправильное число");
    return;
}
int otvet = (num - (num/100 * 100))/10;

Console.WriteLine($"{num} -> {otvet}");