using System;
using System.Collections;
using System.Linq;
using MathNet.Numerics;


namespace Modul1DasarCSharp
{
    public class Car
    {
         public string model = string.Empty;
         public string brand = string.Empty;
         public int enginesize = 0;

// constructor
        public Car(string brand, string model, int ukuranMesin)
        {
            this.brand = brand;
            this.model = model;
            this.enginesize = ukuranMesin;
        }

        public Car()
        {

        }

        // procedure 
        public void StartEngine()
        {
            Console.WriteLine("This car is start");
        }

// function

        public int CurrentSpeed(int speed)
        {
            speed+=speed + 10;
            return speed;
        }

       public double AverageSpeed(params double[] speed)
       {
           double rerataKecepatan = 0;
           rerataKecepatan = Queryable.Average(speed.AsQueryable());
           return rerataKecepatan;
       }

// static 

        public static void DisplayCar()
        {
            Console.WriteLine("This is a car");
        }   
    }
}
