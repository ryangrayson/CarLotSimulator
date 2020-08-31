using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
            


            //DONE - Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Instantiation 1 "Using Dot Notation"
            var ryansCar = new Car();
            ryansCar.Make = "Ford";
            ryansCar.Model = "Focus";
            ryansCar.Year = 2013;
            ryansCar.EngineNoise = "VROOM";
            ryansCar.HonkNoise = "LOUD";
            ryansCar.IsDriveable = true;

            lot.Cars.Add(ryansCar);

           
            //Instantiation 2 "Object initializer syntax"
            var missysCar = new Car()
            {
                Year = 1981,
                Make = "Ford",
                Model = "Bronco",
                EngineNoise = "VERY LOUD",
                HonkNoise = "NONE",
                IsDriveable = true
            };

            lot.Cars.Add(missysCar);

            //Instantiation 3 "using the constructer to allow parameter values to be placed inside properties"
            //All parameters are required to use this way
            var ryansBike = new Car(1994, "Harley-Davidson", "FXRP", "VERY LOUD", "NONE", true);

            lot.Cars.Add(ryansBike);

            //Call Methods
            ryansCar.MakeEngineNoise();

            missysCar.MakeHonkNoise();

            ryansBike.MakeEngineNoise();




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model {car.Model}");
            }


        }
    }
}
