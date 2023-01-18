// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/* невнимательно прочитал условие задачи, алгоритм ниже показывает третью цифру справа
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("***** Программа принимает на вход число, на выходе показывает третью цифру этого числа, или сообщает, что третьей цифры нет. *****");
Console.WriteLine(" ");
Console.WriteLine("Введите число: ");

int num = 0;

while(true) {
    if(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Вы ввели неверное число, введите целое число.");
    else break;
}

int absNum = Math.Abs(num); // для работы с отрицательными числами

int thirdDigit = absNum / 100 % 10;

if(absNum < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine("Третья цифра числа " + num + " : цифра " + thirdDigit);

Console.WriteLine(" ");
Console.WriteLine("***** Программа завершается. Спасибо за использование) *****");
*/

// верный алгоритм

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("***** Программа принимает на вход число, на выходе показывает третью цифру этого числа, или сообщает, что третьей цифры нет. *****");
Console.WriteLine(" ");
Console.WriteLine("Введите число: ");

int num = 0;

while(true) {
if(!int.TryParse(Console.ReadLine(), out num))
Console.WriteLine("Вы ввели неверное число, введите целое число.");
else break;
}

int absNum = Math.Abs(num); // для работы с отрицательными числами

int count = 0; // счётчик разрядов
int tmp = absNum; // временная переменная для подсчёта количества разрядов

while(tmp != 0) {
tmp /= 10;
count++;
}

int thirdDigit = absNum / (int) Math.Pow(10, count - 3) % 10;

if(absNum < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine("Третья цифра числа " + num + " : цифра " + thirdDigit);

// Console.WriteLine("количество цифр в числе: " + count); // при желании можно отобразить

Console.WriteLine(" ");
Console.WriteLine("***** Программа завершается. Спасибо за использование) *****");

