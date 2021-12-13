using System;

namespace Part14Task1
{
    // 1. Ниже находятся варианты тем. Выберите ту тему, которая вам больше всего нравится.
    // 1.1 Разработать один из классов на выбор
    // 1.2 Реализовать не менее пяти закрытых полей (различных типов), представляющих основные
    // характеристики рассматриваемого класса.
    // 1.3 Создать не менее трех методов управления классом и методы доступа к его закрытым полям.
    // 1.4 Создать не менее двух статических полей (различных типов), представляющих
    // общие характеристики объектов данного класса.
    // 1.5 Обязательным требованием является реализация нескольких перегруженных конструкторов,
    // аргументы которых определяются студентом, исходя из специфики реализуемого класса,
    // а так же реализация конструктора по умолчанию.
    // 1.6 Создать статический конструктор.
    // 1.7 Создать массив (не менее 5 элементов) объектов созданного класса.

    public class Task
    {
        private static void Main(string[] args)
        {
            Car ford = new Car("Ford", "Blue", 110, 4.12, 1.76);
            Car car = new Car();
            ford.PrintInformation();
            ford.RepaintCarInRed();
            ford.AddHorsepower();
            ford.PrintInformation();
            Car[] cars =
            {
                new Car("Mazda", "Black", 110, 4.5, 1.6),
                new Car(180, 6.5, 1.9),
                new Car("Dodge", "Yellow"),
                new Car("Audi", "Grey", 160, 4.87, 1.78),
                new Car("BMW", "Black", 150, 4.5, 1.81)
            };
        }
    }

    public class Car
    {
        private static int numberOfWheels;
        private static int numberOfEngines;

        private string brand;
        private string color;
        private int horsepower;
        private double length;
        private double width;

        static Car()
        {
            numberOfWheels = 4;
            numberOfEngines = 1;
            Console.WriteLine($"Every average car has {numberOfEngines} engine and {numberOfWheels} wheels");
        }

        public Car(string brand, string color, int horsepower, double length, double width)
        {
            this.brand = brand;
            this.color = color;
            this.horsepower = horsepower;
            this.length = length;
            this.width = width;
        }

        public Car(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }

        public Car(int horsepower, double length, double width)
        {
            this.horsepower = horsepower;
            this.length = length;
            this.width = width;
        }

        public Car()
        {
        }

        public void PrintInformation() => Console.WriteLine($"{color} {brand} technical data: horsepower - " +
                                                            $"{horsepower}, length - {length}, width - {width}");

        public void RepaintCarInRed() => color = "Red";

        public void AddHorsepower() => horsepower += 20;

        public string Brand
        {
            get => brand;
            set => brand = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Color
        {
            get => color;
            set => color = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Horsepower
        {
            get => horsepower;
            set => horsepower = value;
        }

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Width
        {
            get => width;
            set => width = value;
        }
    }
}