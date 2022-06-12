using System;
using static System.Int32;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요");
            String width = Console.ReadLine();

            Console.WriteLine("사각형의 너비를 입력하세요");
            String height = Console.ReadLine();

            int result = Parse(width) * Parse(height);

            Console.WriteLine($"사각형의 너비는 {result} 입니다");
        }
    }
}