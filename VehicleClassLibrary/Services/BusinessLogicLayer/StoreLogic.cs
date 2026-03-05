using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.DataAccessLayer;

/*
 * Elijah Hodge
 * CST - 250
 * 3/1/2026
 * Vehicle Class Library
 * Activity 1
 */

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class StoreLogic
    {
        // Declare class level variables
        private StoreDAO _storeDAO;

        /// <summary>
        /// Default constructor for StoreLogic
        /// </summary>
        public StoreLogic()
        {
            // Initialize the DAO instance
            _storeDAO = new StoreDAO();
        }

        /// <summary>
        /// Get a list of vehicles in the inventory
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            // Call and return the vehicles in the inventory
            return _storeDAO.GetInventory();
        }

        /// <summary>
        /// Get a list of the vehicles in the users shopping cart
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            // Call and return the vehicles in the shopping cart
            return _storeDAO.GetShoppingCart();
        }

        /// <summary>
        /// Add a new vehicle to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Call and return the AddVehicleToInventory method in the DAO
            return _storeDAO.AddVehicleToInventory(vehicle);
        }

        /// <summary>
        /// Add a vehicle to the shopping cart by the vehicles ID
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Call and return the AddVehicleToCart method in the DAO
            return _storeDAO.AddVehicleToCart(vehicleId);
        }

        /// <summary>
        /// Remove a vehicle from the shopping cart by the vehicles ID
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int RemoveVehicleFromCart(int vehicleId)
        {
            // Call and return the RemoveVehicleFromCart method in the DAO
            return _storeDAO.RemoveVehicleFromCart(vehicleId);
        }

        /// <summary>
        /// Remove a vehicle from the inventory by the vehicles ID
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int RemoveVehicleFromInventory(int vehicleId)
        {
            // Call and return the RemoveVehicleFromCart method in the DAO
            return _storeDAO.RemoveVehicleFromInventory(vehicleId);
        }

        /// <summary>
        /// Write the inventory to a text file
        /// </summary>
        public void WriteInventory()
        {
            // Call the WriteInventory method in the DAO
            _storeDAO.WriteInventory();
        }

        /// <summary>
        /// Read the list of vehicles from a text file
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> ReadInventory()
        {
            // Call and return the ReadInventory method in the DAO
            return _storeDAO.ReadInventory();
        }

        /// <summary>
        /// Get the total of the users shopping cart and clear the cart
        /// </summary>
        /// <returns></returns>
        public decimal Checkout()
        {
            // Call and return the Checkout method in the DAO
            return _storeDAO.Checkout();
        }
    }
}
