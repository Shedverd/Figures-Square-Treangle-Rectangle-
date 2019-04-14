using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры
{
    class Side
    {
        protected string whatsay;
        public float sideA { get;  }
        public float sideB { get;  }
        public float sideC { get;  }
        public void Say()
        {
            Console.WriteLine(whatsay);
        }
    }

    class Triangle : Side
    {
        public double pperimetr { get; set; }
        public float perimetr { get; set; }
        public double square { get; set; }
        public Triangle(float sideA, float sideB, float sideC)
        {
            whatsay = ("Операции с треугольником:");
            pperimetr = 0.5*( sideA + sideB + sideC);
            perimetr = sideA + sideB + sideC;
            square =Math.Sqrt(pperimetr*(pperimetr-sideA) * (pperimetr - sideB) * (pperimetr - sideC));
        }
    }
    class Rectangle : Side
    {
        public float perimetr { get; set; }
        public float square { get; set; }
        public Rectangle (float sideB, float sideA)
        {
            whatsay = ("Операции с прямоугольником:");
            perimetr = sideA+sideB+sideA+sideB;
            square = sideA*sideB;
        }
    }
    class Square : Side
    {
        public float perimetr { get; set; }
        public float square { get; set; }
        public Square(float a, float sideA)
        {
            whatsay = ("Операции с квадратом:");
            perimetr = sideA+sideA+sideA+sideA;
            square = sideA*sideA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square Square1=new Square(5, 3);
            Square1.Say();
            Console.WriteLine("Периметр - "+Square1.perimetr);
            Console.WriteLine("Площадь - " + Square1.square);
            Rectangle Rectangle1 = new Rectangle(3, 5);
            Rectangle1.Say();
            Console.WriteLine("Периметр - " + Rectangle1.perimetr);
            Console.WriteLine("Площадь - " + Rectangle1.square);
            Triangle Triangle1 = new Triangle(4, 5, 6);
            Triangle1.Say();
            Console.WriteLine("Периметр - " + Triangle1.perimetr);
            Console.WriteLine("Площадь - " + Triangle1.square);
            Console.ReadKey();
        }
    }
}
