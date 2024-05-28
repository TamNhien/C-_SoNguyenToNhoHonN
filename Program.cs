using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        var primes = Enumerable.Range(2, n - 2).Where(IsPrime);
        Console.WriteLine($"Cac so nguyen to nho hon {n} la: {string.Join(", ", primes)}");
    }
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}