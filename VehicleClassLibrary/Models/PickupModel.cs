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
    public class PickupModel : VehicleModel
    {
        // Class level properties
        public bool HasBedCover { get; set; }
        public decimal BedSize { get; set; } // In cubic feet

        /// <summary>
        /// Default constructor for a pickup model
        /// </summary>
        public PickupModel() : base()
        {
            HasBedCover = false;
            BedSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for a pickup model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasBedCover"></param>
        /// <param name="bedSize"></param>
        public PickupModel(int id, string make, string model, string color, int year, decimal price, decimal mileage, int numWheels, bool hasBedCover, decimal bedSize)
            : base(id, make, model, color, year, price, mileage, numWheels)
        {
            HasBedCover = hasBedCover;
            BedSize = bedSize;
        }

        /// <summary>
        /// ToString method for printing a pickup
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the bed cover string
            //                      condition       if true    if false
            string bedCover = HasBedCover ? "with" : "without";
            // Print the pickup in the following format
            // 1: 2001 Toyota Tundra with 4 wheels and a 8.3 cubic foot bed with(out) a bed cover - $5000.00
            return $"{Year} {Make} {Model} {Color} with {Mileage} miles, {NumWheels} wheels and a {BedSize} cubic foot bed {bedCover} a bed cover - {Price:C2}";
        }
    }
}
