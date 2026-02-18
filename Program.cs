using System;
class Bai2
{
    static void Main(string[] args)
    {
        //Loi mo dau
        Console.WriteLine($"Hello!");

        //Nhap so
        Console.WriteLine($"Number one: ");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Number two: ");
        int number2 = int.Parse(Console.ReadLine()!);

        //Tinh
        Console.WriteLine($"Tong: {number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"Hieu: {number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"Tich: {number1} * {number2} = {number1 * number2}");
        Console.WriteLine($"Thuong: {number1} / {number2} = {number1 / number2}");
    }
}