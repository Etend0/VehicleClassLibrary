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

using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    internal class StoreDAO
    {
        // CarModel list for the stores inventory
        private List<VehicleModel> _inventory;
        // CarModel list for the users shopping cart
        private List<VehicleModel> _shoppingCart;
        // The directory path to the inventory file
        private string _fileDirectory = "Data";
        // The name of the inventory text file
        private string _textFile = "inventory.txt";
        // The full path to the text file
        private string _filePath;

        /// <summary>
        /// Default constructor for the StoreDAO
        /// </summary>
        public StoreDAO()
        {
            // Initialize the vehicle model lists
            _inventory = new List<VehicleModel>();
            _shoppingCart = new List<VehicleModel>();
            // Set up the file to the inventory text file
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileDirectory, _textFile);
        }

        /// <summary>
        /// Get a list of vehicles in the inventory
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            // Return the inventory list
            return _inventory;
        }

        /// <summary>
        /// Get a list of the vehicles in the users shopping cart
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            // Return the shoppingCart list
            return _shoppingCart;
        }

        /// <summary>
        /// Add a new vehicle to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Set the id for the new vehicle
            vehicle.Id = _inventory.Count + 1;
            // Add the vehicle to the inventory list
            _inventory.Add(vehicle);
            // Return the id of the new vehicle
            return vehicle.Id;
        }

        /// <summary>
        /// Add a vehicle to the shopping cart based on the vehicles id
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Loop through the inventory to find the correct vehicle
            for (int i = 0; i < _inventory.Count; i++)
            {
                // Check if the inventory vehicle matches the parameter
                if (_inventory[i].Id == vehicleId)
                {
                    // If so, add the vehicle to the shopping cart
                    _shoppingCart.Add(_inventory[i]);
                }
            }
            // Return the number of items in the shopping cart
            return _shoppingCart.Count;
        }
    }
}
