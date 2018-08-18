using System;

namespace VehicleExample.Directions
{
    public class DirectionRight : DirectionBase
    {
        public override void Drive()
        {
            Console.WriteLine("Drove right");
        }
    }
    public class DirectionLeft : DirectionBase
    {
        public override void Drive()
        {
            Console.WriteLine("Drove left");
        }
    }
    public class DirectionForwards : DirectionBase
    {
        public override void Drive()
        {
            Console.WriteLine("Drove forward");
        }
    }
    public class DirectionBackwards : DirectionBase
    {
        public override void Drive()
        {
            Console.WriteLine("Drove backwards");
        }
    }
}
