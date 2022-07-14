/*
Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit3 = -1; //несуществующее значение
while (number > 99)
{
    digit3 = number % 10;
    number = number / 10;
}
if (digit3 != -1)
{
    Console.WriteLine(digit3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
