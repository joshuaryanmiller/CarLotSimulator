using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            Car car1 = new Car();
            car1.Year = 2018;
            car1.Make = "Tesla";
            car1.Model = "X";
            car1.EngineNoise = "None";
            car1.HonkNoise = "Honk";
            car1.IsDrivable = true;
            lot.Cars.Add(car1);

            Car car2 = new Car()
            {
                Year = 2018,
                Make = "Tesla",
                Model = "3",
                EngineNoise = "Nada",
                HonkNoise = "Beep",
                IsDrivable = true
            };
            lot.Cars.Add(car2);

            Car car3 = new Car(2023, "Tesla", "Cybertruck", "Zero", "BOOM!", true);
            lot.Cars.Add(car3);

            //Call each of the methods for each car
            Console.WriteLine($"{car1.Year} {car1.Make} {car1.Model}");
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            Console.WriteLine($"--------------------");
            Console.WriteLine($"{car2.Year} {car2.Make} {car2.Model}");
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            Console.WriteLine($"--------------------");
            Console.WriteLine($"{car3.Year} {car3.Make} {car3.Model}");
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            Console.WriteLine($"--------------------");

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}\nMake: {car.Make}\nModel: {car.Model}");
                Console.WriteLine($"--------------------");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
        }
    }
}
