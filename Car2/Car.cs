using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class Car
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;
        public int HorsePower;
        public CarType CarType;

        public Car( 
            string brand, 
            string color, 
            int maxSpeed, 
            int horsePower,
            CarType carType) 
        {
            Brand  = brand;
            Color = color;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            CarType = carType;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Car Brand: {Brand}, Color: {Color}, Max Speed: {MaxSpeed} with horsepower of: {HorsePower} and the type of fuel is {CarType} ");
        }

        public void Drive()
        {
            Console.WriteLine($"The {Brand} is driving at {MaxSpeed}");
        }

        public void Honk() 
        { 
            Console.WriteLine("Honk Honk! ");
        }

        public void Fuel ()
        {
            Console.WriteLine($"Car is of type: {CarType}");
            switch (CarType) 
            {
                case CarType.Electric: 
                    Console.WriteLine("electric fuel");
                    break;
                case CarType.Gas:
                    Console.WriteLine("Gas fuel");
                    break;
                case CarType.Disel:
                    Console.WriteLine("Diesel fuel");
                    break;
                 case CarType.Hybrid:
                    Console.WriteLine("Hybrid fuel");
                    break;
            }

        }

        public void IsFasterThan (Car otherCar)
        {
            if (this.MaxSpeed > otherCar.MaxSpeed)
            {
                Console.WriteLine($"{this.Brand} is faster than {otherCar.Brand}");
            }
            else if (this.MaxSpeed < otherCar.MaxSpeed)
            {
                Console.WriteLine($"{otherCar.Brand} is faster than {this.Brand}");
            }
            else
            {
                Console.WriteLine($"{this.Brand} and {otherCar.Brand} have the same speed");
            }
        }
    }

    
}
