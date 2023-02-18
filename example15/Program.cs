// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if(num < 6){
    Console.WriteLine($"{num} -> нет");
    return;
}
if(num > 5 && num < 8){
    Console.WriteLine($"{num} -> да");
    return;
}
else{
    Console.WriteLine($"введен неверный номер");
}

