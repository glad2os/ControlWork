using System;
using System.Xml;

namespace ControlWork
{
    public class Straight
    {
        private float First_A { get; set; }
        private float First_B { get; set; }
        public float First_X { get; set; }
        public float First_Y { get; set; }

        private float Second_A { get; set; }
        private float Second_B { get; set; }
        public float Second_X { get; set; }
        public float Second_Y { get; set; }

        //Констуктор
        public Straight(float First_A, float First_B, float Second_A, float Second_B)
        {
            this.First_A = First_A;
            this.First_B = First_B;
            this.Second_A = Second_A;
            this.Second_B = Second_B;
            Console.WriteLine("Ax = {0}" +
                              "\nAy = {1}" +
                              "\nBx = {2}" +
                              "\nBy = {3}",
                First_A, First_B, Second_A, Second_B
            );

            if ((First_A == 0 && First_B == 0) || (Second_A == 0 && Second_B == 0))
            {
                throw new Exception(
                    "A и B - произвольные постоянные, причём постоянные A и B не равны нулю одновременно.");
            }
        }

        public void Get_First_Y(float x)
        {
            Console.WriteLine("First_X = {0}",x);
            First_X = x;
            First_Y = First_A * First_X + First_B;
            Console.WriteLine("First_Y = {0}", First_Y);
        }

        public void Get_Second_Y(float x)
        {
            Console.WriteLine("Second_X = {0}",x);
            Second_X = x;
            Second_Y = Second_A * Second_X + Second_B;
            Console.WriteLine("First_Y = {0}", Second_Y);
        }

        public void check()
        {
            if (First_X == First_Y || Second_X == Second_Y)
            {
                throw new  Exception("Длина одной из прямых не задана.");
            }

            Console.WriteLine(First_X - Second_X > 0
                ? "Данная прямая не пересекает ось Y."
                : "Данная прямая пересекает ось Y.");

            Console.WriteLine(Second_Y - First_Y > 0
                ? "Данная прямая не пересекает ось X."
                : "Данная прямая пересекает ось X.");
        }

        ~Straight()
        {
            //Деструктор
        }
    }
}