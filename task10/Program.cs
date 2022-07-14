/* Задача 10
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomNumber(int minBorder, int maxBorder)

{

    return new Random().Next(minBorder, maxBorder + 1);

}

int digit(int number)

{

    int digitTwo = ((number / 10) % 10);

    return digitTwo;

}



int randomNumber = GetRandomNumber(100, 999);

int Digit = digit(randomNumber);

Console.Write($"Вторая цифра случайного числа {randomNumber} - это {Digit}");