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
    }

    class Program
    {
        static void Main()
        {
            Pen pen = new Pen();
            Console.WriteLine($"{pen.color} {pen.cost}");

            pen = new Pen("Зеленый", 80);
            Console.WriteLine($"{pen.color} {pen.cost}");

            Console.ReadKey();
        }
    }
}
