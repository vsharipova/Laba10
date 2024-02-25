using CarLibrary;
using System;

namespace Task3
{
    internal class Program
    {
        static void FillArray1(IInit[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                int choice = random.Next(1, 5);
                if (choice == 1)
                    mas[i] = new LightCar();
                else if (choice == 2)
                    mas[i] = new MiddleCar();
                else if (choice == 3)
                    mas[i] = new HeavyCar();
                else
                    mas[i] = new Student();

                mas[i].RandomInit();
            }
        }

        static void FillArray2(IInit[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                int choice = random.Next(1, 4);
                if (choice == 1)
                    mas[i] = new LightCar();
                else if (choice == 2)
                    mas[i] = new MiddleCar();
                else if (choice == 3)
                    mas[i] = new HeavyCar();

                mas[i].RandomInit();
            }
        }

        static void ShowArray(IInit[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            IInit[] mas = new IInit[10];
            

            int countStudents = 0;
            int countLightCars = 0;
            int countMiddleCars = 0;
            int countHeavyCars = 0;

            IInit[] cars = new IInit[10];
            

            int action;
            do
            {
                Console.WriteLine('\n' + "1. Создать список машин с помощью IInit");
                Console.WriteLine("2. Узнать количество легковых, грузовых машин, внедорожников и студентов");
                Console.WriteLine("3. Отсортировать лист машин по бренду");
                Console.WriteLine("4. Отсортировать лист машин по стоимости");
                Console.WriteLine("5. Копирование и клонирование");
                Console.WriteLine("0. Выход ");

                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            FillArray1(mas);
                            Console.WriteLine("Созданный массив");
                            ShowArray(mas);
                            break;
                        }
                    case 2:
                        {
                            FillArray1(mas);
                            Console.WriteLine("Созданный массив:");
                            for (int i = 0; i < mas.Length; i++)
                            {
                                Console.WriteLine(mas[i]);

                                if (mas[i] is Student)
                                    countStudents++;
                                else if (mas[i] is MiddleCar)
                                    countMiddleCars++;
                                else if (mas[i] is LightCar)
                                    countLightCars++;
                                else if (mas[i] is HeavyCar)
                                    countHeavyCars++;
                            }
                            Console.WriteLine('\n' + $"Кол-во студентов = {countStudents}");
                            Console.WriteLine($"Кол-во легковых машин = {countLightCars}");
                            Console.WriteLine($"Кол-во внедорожников = {countMiddleCars}");
                            Console.WriteLine($"Кол-во грузовиков = {countHeavyCars}");
                            break;
                        }
                    case 3:
                        {
                            FillArray2(cars);
                            Console.WriteLine("Исходный массив");
                            ShowArray(cars);
                            Array.Sort(cars);
                            Console.WriteLine('\n' + "Отсортированный массив по модели");
                            ShowArray(cars);

                            int pos = Array.BinarySearch(cars, cars[3]);
                            Console.WriteLine('\n' + $"Позиция найденного объекта = {pos}");
                            break;
                        }
                    case 4:
                        {
                            FillArray2(cars);
                            Console.WriteLine("Исходный массив");
                            ShowArray(cars);
                            Array.Sort(cars, new ComparatorCost());
                            Console.WriteLine('\n' + "Отсортированный массив по стоимости");
                            ShowArray(cars);

                            int pos2 = Array.BinarySearch(cars, cars[3], new ComparatorCost());
                            Console.WriteLine('\n' + $"Позиция найденного объекта = {pos2}");
                            break;
                        }
                    case 5:
                        {
                            Car car = new Car();
                            car.RandomInit();
                            Console.WriteLine(car);
                            Car copy = (Car) car.ShallowCopy();
                            Console.WriteLine(copy);
                            Car clon = (Car) car.Clone();
                            Console.WriteLine(clon);
                            break;
                        }
                }
            }
            while (action != 0);
        }
    }
}