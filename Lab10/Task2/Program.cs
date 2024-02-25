using CarLibrary;
using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static Car FindMaxCostMiddleCar(Car[] cars)
        {
            Car result = null;
            int maxCost = 0;
            foreach (Car car in cars)
            {
                if (car is MiddleCar && car.Cost > maxCost)
                {
                    result = car;
                    maxCost = car.Cost;
                }
            }
            return result;
        }

        static double AverageSpeedLightCars(Car[] cars)
        {
            int count = 0;
            int sumSpeed = 0;
            foreach (Car car in cars)
            {
                if (car is LightCar)
                {
                    LightCar lightCar = car as LightCar;
                    sumSpeed += lightCar.MaxSpeed;
                    count++;
                }
            }
            if (count > 0)
            {
                double avg = (double)sumSpeed / count;
                return avg;
            }
            return 0;
        }

        static List<string> ColorMiddleCars(Car[] cars)
        {
            List<string> result = new List<string>();
            foreach (Car car in cars)
            {
                if (car is MiddleCar middle && middle.FourWheelDrive)
                {
                    result.Add(middle.Color);
                }
            }
            return result;
        }

        static List<HeavyCar> CapacityHeavyCar(Car[] cars, int m)
        {
            List<HeavyCar> result = new List<HeavyCar>();
            foreach (Car car in cars)
            {
                if (car is HeavyCar)
                {
                    HeavyCar heavyCar = car as HeavyCar;
                    if (m < heavyCar.Capacity)
                        result.Add(heavyCar); 
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Car[] cars = new Car[20];
            Random random = new Random();
            for (int i = 0; i < cars.Length; i++)
            {
                int choice = random.Next(1, 4);
                if (choice == 1)
                    cars[i] = new LightCar();
                else if (choice == 2)
                    cars[i] = new MiddleCar();
                else
                    cars[i] = new HeavyCar();

                cars[i].RandomInit();
            }

            int action;
            do
            {
                Console.WriteLine('\n' + "1. Создать список машин");
                Console.WriteLine("2. Самый дорогой внедорожник");
                Console.WriteLine("3. Цвета автомобилей с полным приводом");
                Console.WriteLine("4. Средняя скорость легковых автомобилей");
                Console.WriteLine("5. Бренды грузовиков с грузоподьемностью выше заданной");
                Console.WriteLine("0. Выход ");

                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Созданный список");
                            for (int i = 0; i < cars.Length; i++)
                            {
                                cars[i].Show();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            Car res1 = FindMaxCostMiddleCar(cars);
                            Console.WriteLine($"Самый дорогой внедорожник: {res1.Brand}. Стоимость данного внедорожника: {res1.Cost}");
                            break;
                        }
                    case 3:
                        {
                            List<string> colors = ColorMiddleCars(cars);
                            Console.WriteLine("Цвета автомобилей с полным приводом:");
                            foreach (string color in colors)
                            {
                                Console.WriteLine(color);
                            }
                            break;
                        }
                    case 4:
                        {
                            double avgSpeed = AverageSpeedLightCars(cars);
                            Console.WriteLine($"Средняя скорость легковых автомобилей: {avgSpeed}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите грузопдъемность:");
                            int m = int.Parse(Console.ReadLine());
                            List<HeavyCar> heavyCars = CapacityHeavyCar(cars, m);

                            Console.WriteLine('\n' + "Бренды грузовиков с грузоподьемностью выше заданной:");
                            foreach (HeavyCar heavyCar in heavyCars)
                            {
                                Console.WriteLine(heavyCar.Brand);
                            }
                            break;
                        }
                }
            }
            while (action != 0);
        }
    }
}