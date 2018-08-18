using System.Collections.Generic;

namespace VehicleExample.Directions
{
    public class DirectionMapper
    {
        public Dictionary<string, DirectionBase> mapping;

        public DirectionMapper()
        {
            mapping = new Dictionary<string, DirectionBase>()
            {
                {"right",       new DirectionRight() },
                {"left",        new DirectionLeft()   },
                {"forward",     new DirectionForwards()   },
                {"backward",    new DirectionBackwards()   },
            };
        }

        public DirectionBase GetDirection(string direction)
        {
            if (mapping.ContainsKey(direction))
                return mapping[direction];
            throw new KeyNotFoundException("direction not mapped");
        }
    }
}
