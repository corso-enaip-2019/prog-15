using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> draw = new List<IDrawable>();
            draw.Add(new Line(10));
            draw.Add(new Square(4));
            draw.Add(new Rectangle(5, 4));
            draw.Add(new Rhombus(5));

            foreach (IDrawable d in draw)
            {
                d.Draw();
            }


            Console.Read();
        }


    }


    class Square : IDrawable
    {
        public int LengthSide { get; set; }
        public void Draw()
        {
            for (int i = 0; i < LengthSide; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            for (int i = 0; i < LengthSide; i++)
            {
                Console.WriteLine("|" + "|".PadLeft(LengthSide));
            }
            for (int i = 0; i < LengthSide; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

        }

        public Square(int lenghtSide)
        {
            LengthSide = lenghtSide;
        }
    }

    class Rectangle : IDrawable
    {
        public int LengthSide { get; set; }
        public int HeightSide { get; set; }
        public void Draw()
        {

            for (int i = 0; i < LengthSide; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            for (int i = 0; i < HeightSide; i++)
            {
                Console.WriteLine("|" + "|".PadLeft(LengthSide));
            }
            for (int i = 0; i < LengthSide; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            
        }
        public Rectangle(int lenghtSide, int heightSide)
        {
            LengthSide = lenghtSide;
            HeightSide = heightSide;
        }
    }

    class Rhombus : IDrawable
    {
        public int LengthSide { get; set; }
        public void Draw()
        {
            for (int i = 0; i < LengthSide; i++)
            {
                Console.WriteLine("/".PadLeft(LengthSide - i) + "\\".PadLeft(2 * i + 1));
            }

            for (int i = 0; i < LengthSide; i++)
            {
                Console.WriteLine("\\".PadLeft(i + 1) + "/".PadLeft((2 * LengthSide) - (2 * i) - 1));
            }
            Console.WriteLine();
        }
        public Rhombus(int lenghtSide)
        {
            LengthSide = lenghtSide;
        }
    }

    class Line : IDrawable
    {
        public int Length { get; set; }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }

        public Line(int lenght)
        {
            Length = lenght;
        }
    }

    interface IDrawable
    {
        void Draw();
    }
}

