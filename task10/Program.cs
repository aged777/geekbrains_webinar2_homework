// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("***** Программа принимает на вход трёхзначное число, на выходе показывает вторую цифру этого числа. *****");
Console.WriteLine(" ");
Console.WriteLine("Введите число от 100 до 999.");

int num = 0;

while(true) {
    if(!int.TryParse(Console.ReadLine(), out num) || num < 100 || num > 999) 
        Console.WriteLine("Вы ввели неверное число, введите число от 100 до 999.");
    else break;
}

int secondDigit = num / 10 % 10;

Console.WriteLine(" ");
Console.WriteLine("Вторая цифра числа " + num + " : цифра " + secondDigit);
Console.WriteLine(" ");
Console.WriteLine("***** Программа завершается. Спасибо за использование) *****");