// ## Задание 2.4 
//  Найти расстояние между точками в пространстве 2D/3D
// 
// Для отрезка AB в трехмерном пространстве она имеет вид: 
// Решение будет только для 3 мерной модели т.к. двухмерная модель - это часный случай с Z = 0
// Размерность
int Num1 = 2; 
// Координата первой точки
int point1_x = 0; 
int point1_y = 0; 
int point1_z = 0; 
// Координата первой точки
int point2_x = 0; 
int point2_y = 0; 
int point2_z = 0; 
double LenVector ;

// Ввод значений
Console.Write("Введите размернось (по умолчанию используется 2Д модель): ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 == 3)
{
    Console.Write("Введите значение координаты Х для первой точки: ");
    point1_x = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Y для первой точки: ");
    point1_y = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Z для первой точки: ");
    point1_z = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Х, для второй точки: ");
    point2_x = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Y, для второй точки: ");
    point2_y = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Z, для второй точки: ");
    point2_z = int.Parse(Console.ReadLine());
}
else
{
    Console.Write("Введите значение координаты Х для первой точки: ");
    point1_x = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Y для первой точки: ");
    point1_y = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Х для второй точки: ");
    point2_x = int.Parse(Console.ReadLine());
    Console.Write("Введите значение координаты Y для первой точки: ");
    point2_y = int.Parse(Console.ReadLine());
}
LenVector = (point1_x - point2_x)*(point1_x - point2_x);
LenVector = LenVector + (point1_y - point2_y)*(point1_y - point2_y);
LenVector = LenVector + (point1_z - point2_z)*(point1_z - point2_z);
if (LenVector < 0) {LenVector = -LenVector; }
LenVector = Math.Sqrt(LenVector);
Console.Write("Длинна отрезка по указанным координатам : "+LenVector);
