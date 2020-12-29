using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            CarBase car = new Toyota();
            car.CreateCar("Toyota");
        }
    }
}
