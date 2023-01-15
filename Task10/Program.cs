//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int Num1 = 0;
int Num1_1 = 0;
int Num1_2 = 0;
int Num1_3 = 0;
Console.Write("Введите число в пределах от 100 до 999: ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 > 99 && Num1 < 1000 )
{
Num1_3 = (Num1/1)%10;
Num1_2 = (Num1/10)%10;
Num1_1 = (Num1/100);
Console.WriteLine(Num1+" -> "+Num1_2);
}
else
{
 Console.WriteLine("Ошибка ввода числа.");
}