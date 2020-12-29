using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{

    public class Toyota : CarBase
    {
        public override void AddBox()
        {
            Console.WriteLine("Best box");
        }

        public override void AddCarcase()
        {
            Console.WriteLine("Best Carcase");
        }

        public override void AddMotor()
        {
            Console.WriteLine("Best motor");
        }

        public override void AddWheel()
        {
            Console.WriteLine("Best wheel");
        }
    }

    public abstract class CarBase
    {
        public string carName { get; set; }
        public void CreateCar(string CarName)
        {
            carName = CarName;
            AddBox();
            AddWheel();
            AddMotor();
            AddCarcase();
        }

        public abstract void AddBox();
        public abstract void AddWheel();
        public abstract void AddMotor();
        public abstract void AddCarcase();
    }
}
