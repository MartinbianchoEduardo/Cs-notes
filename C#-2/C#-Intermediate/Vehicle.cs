using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate
{
    public class Vehicle
    {

        private int _id;
        public int Axis { get; set; }
        public string Name { get; set; }

        public Vehicle(string Name, int Axis)
        {
            this.Name = Name;
            this.Axis = Axis;
        }

        public void Move(int speed, string to)
        {
            Console.WriteLine( "{0} has moved to {1} at a speed of {2}km/h", this.Name, to, speed);
        }

    }

    public class Car : Vehicle
    {
        public Car(string Name)
            : base(Name, 2)
        {

        }
        public void Move(int speed, string to)
        {
            Console.WriteLine("{0} has moved towards {1} at a speed of {2}km/h", this.Name, to, speed);
        }
    }
    }
