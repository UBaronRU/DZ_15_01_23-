// Задание 2.2 
//По двум заданным числам проверять является ли одно квадратом другого

int Num1 = 0; // Первое число
int Num2 = 0; // Первое число
// Ввод значений
Console.Write("Введите число 1: ");
Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
Num2 = int.Parse(Console.ReadLine());

// Проверка, является ли одно квадратом другого
if (Num1 == Num2*Num2)
{
Console.Write("Число "+Num1+" является квадратом числа "+Num2);
}
else
{
    if (Num2 == Num1*Num1)
    {
        Console.Write("Число "+Num2+" является квадратом числа "+Num1);
    }
    else
    {
       Console.Write("Число "+Num1+" не является квадратом числа "+Num2); 
       Console.Write(".  "); 
       Console.Write("Число "+Num2+" не является квадратом числа "+Num1); 
    }
}

