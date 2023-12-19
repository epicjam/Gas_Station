// See https://aka.ms/new-console-template for more information
using Gas_Station;
using static Gas_Station.Car;
using static Gas_Station.CarDriving;

Console.WriteLine("Hello, Teacher");
Console.WriteLine();

InitLoad = 150;
OilCount = 100;

CarDriving move = new CarDriving();
move.Move();
