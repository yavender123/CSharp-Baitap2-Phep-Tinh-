using System;
class Bai2
{
    static void Main(string[] args)
    {
        //Loi mo dau
        Console.WriteLine($"Hello!");

        //Dien so
        Console.WriteLine($"Enter your number: ");
        int number = int.Parse(Console.ReadLine()!);
        
        //Tinh phep tinh tong
        Console.WriteLine($"Tong: {number} + {number} = {number+number}");

        //Tinh phep tinh tru
        Console.WriteLine($"Hieu: {number} - {number} = {number-number}");

        //Tinh phep tinh nhan
        Console.WriteLine($"Tich: {number} * {number} = {number*number}");

        //Tinh phep tinh chia
        Console.WriteLine($"Thuong: {number} / {number} = {number/number}");
    }
}