// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string InputData(string text)
{
    Console.WriteLine(text);
    string num = Console.ReadLine();
    return num;
}
void CheckNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("Число " + number + " является палиндромом");
    else Console.WriteLine("Число " + number + " не вляется палиндромом");
}

//Тут я решил усложнить задачу - и после проверки спросить пользователя хочет ли он проверить еще одно число.

Console.Clear();
string continueReason = "y"; //Я хотел использовать не string, а char, но пока не разобрался как работать с этим типом.
while (continueReason == "y")
{
    Console.Clear();
    string number = InputData("Введите пятизначное число");
    CheckNumber(number);
    Console.WriteLine("Проверить еще одно число? (y/n) ");
    continueReason = Console.ReadLine(); // А здесь я хотел использовать ReadKey, чтобы после ввода не надо было нажимать Enter, но тоже не разобрался.
}
