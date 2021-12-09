


using ClassesExercise;

Car car = new Car();
car.Make = "Hyundai";
car.Model = "Sonata";
car.Year = 2021;

var carList = new List<Car>();
carList.Add(car);

foreach(var vehicle in carList)
{
    Console.WriteLine($"{vehicle.Model} {vehicle.Year} {vehicle.Make}");
}


/*
Car car = new Car()
{
Make = "Ford",
Model = "Taurus",
Year = 2019
};
*/