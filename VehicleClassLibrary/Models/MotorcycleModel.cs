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
    public class MotorcycleModel : VehicleModel
    {
        // Class level properties
        public bool HasSideCar { get; set; }
        public decimal SeatHeight { get; set; } // In inches

        /// <summary>
        /// Default constructor for the motorcycle model
        /// </summary>
        public MotorcycleModel() : base()
        {
            HasSideCar = false;
            SeatHeight = 0m;
        }

        /// <summary>
        /// Parameterized constructor for a motorcycle model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasSidecar"></param>
        /// <param name="seatHeight"></param>
        public MotorcycleModel(int id, string make, string model, string color, int year, decimal price, decimal mileage, int numWheels, bool hasSidecar, decimal seatHeight)
            : base(id, make, model, color, year, price, mileage, numWheels)
        {
            HasSideCar = hasSidecar;
            SeatHeight = seatHeight;
        }

        /// <summary>
        /// String method for printing a motorcycle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the sidecar string
            //                      condition       if true    if false
            string sidecar = HasSideCar ? "with" : "without";

            // Print the motorcycle in the following format
            // 1: 2015 Yamah Bolt with 2 wheels and a 44.1 inch seat with(out) a side car - $8000.00
            return $"{Id} {Year} {Make} {Model} {Color} with {Mileage} miles, {NumWheels} wheels and a {SeatHeight} inch seat {sidecar} a side car - {Price:C2}";
        }
    }
}
