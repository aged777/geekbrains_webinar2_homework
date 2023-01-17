/*
int number = 0;

while(true) { 
    Console.WriteLine("Введите целое число больше 1"); 
    number = int.Parse(Console.ReadLine());
    if(number > 1) break;
    else Console.WriteLine("Вы ввели неверное число.");
}

Console.WriteLine("Вы ввели верное число, программа выведет на экран интервал целых чисел от 1 до введённого числа:");

int count = 2;
Console.Write(count);
count += 2;
while(count <= number) {
    Console.Write(", " + count);
    count += 2;
}
*/
/*
// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);

Console.WriteLine("Сгенерировано число: " + number);

int firstDigit = number / 10;
int secondDigit = number % 10;

int maxDigit = 0;

if (firstDigit > secondDigit)
    maxDigit = firstDigit;
else
    maxDigit = secondDigit;

Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);


Console.WriteLine("Наибольшая цифра в числе " + number + ": "
+ (firstDigit > secondDigit ? firstDigit : secondDigit));

*/

/*
int num = new Random().Next(100, 1000);

int thirdDigit = num / 100;

int firstDigit = num % 10;

int result = thirdDigit * 10 + firstDigit;

Console.WriteLine("Сгенерировано число: " + num);

Console.WriteLine("После удаления второго разряда получилось число: " + result);
*/

//  12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//  34, 5 -> не кратно, остаток 4 
//  16, 4 -> кратно
/*
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0 || number2 == 0) {
    System.Console.WriteLine("Одно из чисел является нулём");
    return;
}


int result = number1 % number2;

if (result == 0)     
    Console.WriteLine("кратно"); 
else     
    Console.WriteLine("не кратно, остаток " + result);
*/
/*
Console.WriteLine("Введите число, программа проверит его на кратность одновременно числам 7 и 23: ");

int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
*/

/*
16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
Console.WriteLine("Введите 2 числа, программа проверит, является ли одно из них квадратом второго");

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int pow2(int arg1) {
    int result = (int) Math.Pow(arg1, 2);
    return result;
}

if (pow2(number1) == number2 || pow2(number2) == number1) Console.WriteLine("да");
else Console.WriteLine("нет");