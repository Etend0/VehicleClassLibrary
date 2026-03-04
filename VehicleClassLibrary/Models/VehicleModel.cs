using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elijah Hodge
 * CST - 250
 * 3/1/2026
 * Vehicle Class Library
 * Activity 1
 */

namespace VehicleClassLibrary.Models
{
    public class VehicleModel
    {
        // Class level properties
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Mileage { get; set; }
        public int NumWheels { get; set; }

        /// <summary>
        /// Default constructor for the vehicle model
        /// </summary>
        public VehicleModel()
        {
            Id = 0;
            Make = "Unkown";
            Model = "Unkown";
            Color = "Unkown";
            Year = 0;
            Price = 0m;
            Mileage = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the vehicle model class
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        public VehicleModel(int id, string make, string model, string color, int year, decimal price, decimal mileage, int numWheels)
        {
            Id = id;
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
            Mileage = mileage;
            NumWheels = numWheels;
        }

        /// <summary>
        /// ToString method for printing a vehicle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Print the vehicled in the following format
            // 1 : 2013 Ford Fiesta with 4 wheels - $800.00
            return $"{Id} : {Year} {Make} {Model} {Color} with {Mileage} miles, {NumWheels} wheels - ${Price:C2}";
        }
    }
}