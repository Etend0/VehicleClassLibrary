using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elijah Hodge
 * CST - 250
 * 06/26/2026
 * Vehicle Class Library
 * Activity 1
 */

namespace VehicleClassLibrary.Models
{
    internal class MotorcycleModel : VehicleModel
    {
        // Class level properties
        public bool HasSidecar { get; set; }
        public decimal SeatHeight { get; set; } // In inches

        /// <summary>
        /// Default constructor for the motorcycle model
        /// </summary>
        public MotorcycleModel() : base()
        {
            HasSidecar = false;
            SeatHeight = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the motorcycle model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasSidecar"></param>
        /// <param name="seatHeight"></param>
        public MotorcycleModel(int id, string make, string model, int year, decimal price, int numWheels, bool hasSidecar,
          decimal seatHeight) : base(id, make, model, year, price, numWheels)
        {
            HasSidecar = hasSidecar;
            SeatHeight = seatHeight;
        }

        /// <summary>
        /// ToString method for printing a motorcycle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the sidecar string
            //                      condition    if true   if false
            string sidecar = HasSidecar ? "with" : "without";
            // Print the motorcycle in the following format
            // 1: 2015 Yamaha Bolt with 2 wheels and a 44.1 inch seat with(out) a side car - $8000.00
            return $"{Id}: {Year} {Model} with {NumWheels} wheels and a {SeatHeight} inch seat {sidecar} a side car - {Price:C2}";
        }
    }
}
