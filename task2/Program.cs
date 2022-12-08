// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputPoint(string dot, string position)
{
    Console.Write("введите координату " + dot + " " + position + " точки: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int ax = InputPoint("X", "первой");
int ay = InputPoint("Y", "первой");
int az = InputPoint("Z", "первой");
int bx = InputPoint("X", "второй");
int by = InputPoint("Y", "второй");
int bz = InputPoint("Z", "второй");
double result = Math.Sqrt((Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)));
Console.WriteLine("Расстояние между двумя точками: " + result);