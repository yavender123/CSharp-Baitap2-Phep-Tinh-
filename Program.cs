using System;
class Bai2
{
    static void Main(string[] args)
    {
        //Opening
        Console.WriteLine($"Hello!");

        //Enter number
        Console.WriteLine($"Enter your first number: ");
        double number1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Enter your number two: ");
        double number2 = double.Parse(Console.ReadLine()!);

        //Phep tinh va in ra destop
        Console.WriteLine($"Tong: {number1 + number2}");
        Console.WriteLine($"Hieu: {number1 - number2}");
        Console.WriteLine($"Tich: {number1 * number2}");
        Console.WriteLine($"Thuong: {number1 / number2}");
    }
}