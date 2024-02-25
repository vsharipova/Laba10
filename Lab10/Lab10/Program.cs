using CarLibrary;

namespace Lab10
{
    internal class Program
    {
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

            Console.WriteLine("С помощью виртуальных методов");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Show();
                Console.WriteLine();
            }

            Console.WriteLine("С помощью не виртуальных методов");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Show2();
                Console.WriteLine();
            }
        }
    }
}