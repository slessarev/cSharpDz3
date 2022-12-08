// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
Console.Clear();
int num = InputData("Введите число N: ");
for (int i = 1; i <= num; i++)
{
    // double cube = Math.Pow(i, 3); - Вот эта штука почему-то требует тип данных - double. 
    //Хотя возведение в степень целого числа  не приводит к образованию дроби. Видимо особенность методов Math.
    int cube = i * i * i;
    Console.Write(cube + ", ");
}