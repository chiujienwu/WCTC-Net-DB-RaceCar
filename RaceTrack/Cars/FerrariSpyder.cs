using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class FerrariSpyder : RaceCar
    {
        public FerrariSpyder()
        {
            Name = "FerrariSpyder";
            TopSpeed = 220;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} fires up like rocket!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} stops on a dime!");
            base.Brake();
        }
    }
}
