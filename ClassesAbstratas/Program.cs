using System;
using System.Collections.Generic;
using ClassesAbstratas.Entities;
using ClassesAbstratas.Entities.Enums;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char check = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (check == 'r' || check == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine());
                    Shape shape = new Rectangle(width, heigth, color);
                    list.Add(shape);
                }
                else if (check == 'c' || check == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape shape = new Circle(radius, color);
                    list.Add(shape);
                }
                Console.WriteLine();
            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("F2"));
            }
        }
    }
}
