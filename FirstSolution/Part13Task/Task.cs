using System;

namespace Part13Task
{
    
    // Создать класс Квадрат 
    // Поля: 
    // - длина cтороны
    // - цвет
    // - площадь 
    // Метод:
    // - вывести на экран информацию о фигуре 
    // Конструктор принимает параметры: 
    // - длина стороны, цвет 
    // - Высчитывает площадь фигуры 
    // Создать объекты:
    // - Зеленый квадрат, длина стороны 5 
    // - Синий квадрат, длина стороны 2 
    // - Голубой квадрат, длина стороны 15 
    // 1.Вывести информацию о фигурах на экран 
    // 2.Поменять длину стороны зеленого квадрата = длина стороны красного квадрата * 3 
    // 3.Вывести информацию о фигурах на экран

    public class Task
    {
        private static void Main(string[] args)
        {
            Square greenSquare = new Square(5, "Green");
            Square blueSquare = new Square(2, "Blue");
            Square lightBlueSquare = new Square(15, "Light blue");
            greenSquare.PrintInformation();
            blueSquare.PrintInformation();
            lightBlueSquare.PrintInformation();
            Square redSquare = new Square(3, "Red");
            greenSquare.Length = redSquare.Length * 3;
            greenSquare.RecalcuteArea();
            greenSquare.PrintInformation();
            blueSquare.PrintInformation();
            lightBlueSquare.PrintInformation();
        }
    }

    public class Square
    {
        private int length;
        private string color;
        private double area;

        public Square(int length, string color)
        {
            this.length = length;
            this.color = color;
            area = length * length;
        }
        
        public void PrintInformation()
        {
            Console.WriteLine("{0} square side length is {1} and area equals {2}", color, length, area);
        }

        public void RecalcuteArea()
        {
            area = length * length;
        }
        
        public int Length
        {
            get => length;
            set => length = value;
        }

        public string Color
        {
            get => color;
            set => color = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Area
        {
            get => area;
            set => area = value;
        }
    }
}