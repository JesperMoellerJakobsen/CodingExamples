using System;
using VehicleExample.Directions;

namespace VehicleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which way do you want to go?");
            var input = Console.ReadLine();

            var directionMapper = new DirectionMapper();
            var direction = directionMapper.GetDirection(input);
            direction.Drive();

            Console.ReadLine();
        }
    }
}
