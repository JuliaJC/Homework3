// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number = ReadInt("Введите пятизначное число: ");

if (number / 10000 == number % 10 && number/1000%10 == number/10%10) 
{
    Console.WriteLine("Число является палиндромом");
}

else
{
    Console.WriteLine("Число не является палиндромом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}