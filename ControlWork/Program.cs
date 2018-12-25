using System;

namespace ControlWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * TODO: Основная задача
             * Вариант 1
             * Написать класс Прямая (y=ax+b) Поля класса -
             * коэффициенты уравнения прямой. Реализовать
             * функции: конструкторы (по умолчанию и инициализации),
             * свойства, методы вывода уравнения прямой,
             * определение точек пересечения с осями.
             * В классе Program продемонстр. работу с объектом
             * созданного класса
             */
            Straight Straight = new Straight(2, 3, 5, 6) {First_X = 2, First_Y = 3};
            Straight.Get_First_Y(-1);
            Straight.Get_Second_Y(3);
            Straight.check();
        }
    }
}