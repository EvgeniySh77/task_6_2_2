using System;

namespace task_6_2_2
{
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }

        public void Display()
        {
            Console.WriteLine($"{color} {cost}");
        }
    }

    class Program
    {
        static void Main()
        {
            Pen pen = new Pen();
            pen.Display();

            pen = new Pen("Зеленый", 80);
            pen.Display(); ;

            Console.ReadKey();
        }
    }
}
