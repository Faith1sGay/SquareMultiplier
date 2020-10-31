using System;

namespace SomeProgram


{
    class Square
    {
        public int x, y;
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class SquareMultiply
    {

        class Program
        {
            static void Main(string[] args)
            {
                Square sq1 = new Square(3, 9);
                Square sq2 = new Square(10, 5);
                Console.WriteLine($"The Value of both squares together is {sq1.x * sq1.y + sq2.x * sq2.y}");
                Console.ReadLine();


            }

        }
    }
}