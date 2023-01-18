// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("***** Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. *****");
Console.WriteLine(" ");
Console.WriteLine("Введите число от 1 до 7.");

int num = 0;

while(true) {
    if(!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 7)
        Console.WriteLine("Вы ввели неверное число, введите число от 1 до 7.");
    else break;
}

if(num > 0 && num < 6) Console.WriteLine("нет");
else Console.WriteLine("да");

Console.WriteLine(" ");
Console.WriteLine("***** Программа завершается. Спасибо за использование) *****");

