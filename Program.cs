using System;
class Bai2
{
    static void Main(string[] args)
    {
        //Loi khoi dau
        Console.WriteLine($"Hello!");

        //Nhap so
        Console.WriteLine($"Enter your number one: ");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Enter your number two: ");
        int number2 = int.Parse(Console.ReadLine()!);

        //Phep tinh va in ra destop
        Console.WriteLine($"Tong: {number1 + number2}");
        Console.WriteLine($"Hieu: {number1 - number2}");
        Console.WriteLine($"Tich: {number1 * number2}");
        Console.WriteLine($"Thuong: {number1 / number2}");
    }
}