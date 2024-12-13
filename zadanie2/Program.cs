public class Vehicle
{
    private double x;
    private double y;
    private double price;
    private double speed;
    private int year;

    //Конструктор базового класса
    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    //Метод для вывода информации о транспортном средстве
    public virtual void Inf()
    {
        Console.WriteLine($"Координаты: x = {x}  y = {y}");
        Console.WriteLine($"Цена: {price}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год выпуска: {year}");
    }
}

public class Plane : Vehicle //Класс самолета
{
    private double height; //Высота
    private int passengers; //Количество пассажиров

    //Конструктор класса Plane
    public Plane(double x, double y, double price, double speed, int year, double height, int passengers) : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    //Переопределение метода Inf для класса Plane
    public override void Inf()
    {
        base.Inf(); //Вызов метода Inf базового класса
        Console.WriteLine($"Высота: {height}");
        Console.WriteLine($"Количество пассажиров: {passengers}");
    }
}

public class Car : Vehicle //Класс автомобиля
{
    //Конструктор класса Car
    public Car(double x, double y, double price, double speed, int year) : base(x, y, price, speed, year)
    {
    }

    public override void Inf()
    {
        base.Inf(); //Вызов метода Inf базового класса
    }
}

public class Ship : Vehicle //Класс корабля
{
    private int passengers;
    private string Port;

    //Конструктор класса Ship
    public Ship(double x, double y, double price, double speed, int year, int passengers, string Port) : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.Port = Port;
    }

    public override void Inf()
    {
        base.Inf();
        Console.WriteLine($"Количество пассажиров: {passengers}");
        Console.WriteLine($"Порт приписки: {Port}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Plane plane = new Plane(10, 18, 1000000, 800, 2018, 10000, 170);
        Car car = new Car(7.5, 15, 2000000, 150, 2021);
        Ship ship = new Ship(5, 1, 5000000, 30, 2015, 500, "Санкт-Петербург");

        Console.WriteLine("Самолет:");
        plane.Inf();

        Console.WriteLine("\nАвтомобиль:");
        car.Inf();

        Console.WriteLine("\nКорабль:");
        ship.Inf();
    }
}