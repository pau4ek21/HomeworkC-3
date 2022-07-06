// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
    Console.Write("Input number Polindrom ");
    string num = Console.ReadLine();

void Palindrom (string num)
{
    
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"number {num} is Polindrom.");
    }
    else
    {
        Console.WriteLine($"number {num} is NOT Polindrom.");
    } 
}

Palindrom(num);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int number(string n1, string n2)
{
    Console.WriteLine($"Input coordinate {n1} and {n2}");
    return Convert.ToInt32(Console.ReadLine());
}

int a1 = number("a", "A");
int b1 = number("b", "A");
int c1 = number("c", "A");
int a2 = number("a", "B");
int b2 = number("b", "B");
int c2 = number("c", "B");


double Start(double a1, double a2, double b1, double b2, double c1, double c2)
{
 return Math.Sqrt(Math.Pow((a2 - a1), 2) +
                 Math.Pow((b2 - b1), 2) +
                 Math.Pow((c2 - c1), 2));

}
   
double length =  Math.Round(Start(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Number {length}");
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube()
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    int count = 0;
    int y;
    int z = 1;
    while (count < a)
    {
        y=z*z*z;
        Console.WriteLine(y);
        z++;
        count++;
    }

}
cube();

