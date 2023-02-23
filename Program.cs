//Тип double (не целый числа).
    //Math.Pow(a,b) = "a" в "b" квадрате.
    //Math.Sqrt(a) = Корень из "a".

//Метод для округления числа, где "а" число которое нужно округлить, "b" знак по счету после запятой.
    //Math.Round(a,b)

/*
void ShowDiap(int quad)
{
    if(quad == 1) Console.WriteLine("x > 0 and y > 0");
        else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
        else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
        else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
        else Console.WriteLine("Некорректный ввод!");
}

Console.Write("Введи номер четверти: ");
int quarant = Convert.ToInt32(Console.ReadLine());

ShowDiap(quarant);
*/

//Задача 1.
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*

int getQuadrant(int x, int y) {
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;
    if(x > 0 && y < 0)
        return 4;

    return -1;
}

Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = getQuadrant(x, y);
if(quarter > 0)
    Console.WriteLine($"Point is in {quarter} quarter.");
    else
        Console.WriteLine($"Point is not in quarters.");
*/


// Задача 2.
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double getDistance(double xa, double ya, double xb, double yb) {
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
}
Console.Write("Введите координату Х первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Math.Round(getDistance( xa, ya, xb, yb),2));
*/

//Задача 3.
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void squareTable(int n) {
    int currentNumber = 1;
    while (currentNumber <= n)
    {
         Console.WriteLine(currentNumber + "-" + (currentNumber * currentNumber));
         currentNumber++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
    squareTable(n);
else
Console.Write("Введите число больше 0");
*/