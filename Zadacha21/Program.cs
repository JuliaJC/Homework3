//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt ("Введите координату х точки А: ");
int y1 = ReadInt ("Введите координату y точки А: ");
int z1 = ReadInt ("Введите координату z точки А: ");

int x2 = ReadInt ("Введите координату х точки B: ");
int y2 = ReadInt ("Введите координату y точки B: ");
int z2 = ReadInt ("Введите координату z точки В: ");


int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double result = Math.Sqrt(a*a+b*b+c*c);
Console.WriteLine("Расстояние между точками: " + result);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}