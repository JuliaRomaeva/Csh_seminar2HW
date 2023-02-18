// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
int l = s.Length;
if(l > 2) {
string s1 = Convert.ToString(s[2]);
Console.Write($" {s} -> {s1}     ");
}
else{
    Console.Write(" третьей цифры нет ");
}