/*
 * Elijah Hodge
 * CST - 250
 * 3/1/2026
 * Vehicle Class Library
 * Activity 1
 */

using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;

namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        // Class level variables
        string currentVehicleType;
        bool isVehicleTypeValid = false, isMakeValid = false, isModelValid = false,
        isColorValid = false, isYearValid = false, isPriceValid = false,
        isMileageValid = false, isWheelsValid = false,
        isSpecialtyBooleanValid = false, isSpecialtyDecimalValid = false;
        // Create a new vehicle store logic variable
        private StoreLogic _storeLogic;
        // Binding sources for the inventory and shopping cart
        private BindingSource _inventoryBindingSource;
        private BindingSource _shoppingCartBindingSource;

        public FrmVehicleStore()
        {
            InitializeComponent();
            // Initialize the current vehicle to create
            currentVehicleType = "";
            //Hide the error labels
            lblVehicleTypeError.Visible = false;
            lblMakeError.Visible = false;
            lblModelError.Visible = false;
            lblColorError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblMileageError.Visible = false;
            lblWheelsError.Visible = false;
            lblSpecialtyBooleanError.Visible = false;
            lblSpecialtyDecimalError.Visible = false;
            // Initialize the store logic variable
            _storeLogic = new StoreLogic();

            // Initialize the binding source variables
            _inventoryBindingSource = new BindingSource();
            _shoppingCartBindingSource = new BindingSource();
            // Set the data sources of the binding source objects
            _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
            _shoppingCartBindingSource.DataSource = _storeLogic.GetShoppingCart();
            // Set the data source for each list control
            lstInventory.DataSource = _inventoryBindingSource;
            lstShoppingCart.DataSource = _shoppingCartBindingSource;
        }

        /// <summary>
        /// Click event handler to create a car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoCarClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Car";

            // Change the label for the specialty boolean
            lblSpecialtyBoolean.Text = "Is the car a convertible?";
            // Change the label for the specialty decimal
            lblSpecialtyDecimal.Text = "Trunk Size (cubic feet):";

            // Show the specialty boolean label and radio buttons
            lblSpecialtyBoolean.Visible = true;
            rdoSpecialtyYes.Visible = true;
            rdoSpecialtyNo.Visible = true;
            // Show the specialty decimal label and text box
            lblSpecialtyDecimal.Visible = true;
            txtSpecialtyDecimal.Visible = true;
            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Click event handler to create a motorcycle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoMotorcycleClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Motorcycle";

            // Change the label for the specialty boolean
            lblSpecialtyBoolean.Text = "Does the Motorcycle has a side car?";
            // Change the label for the specialty decimal
            lblSpecialtyDecimal.Text = "Seat Height (inches):";

            // Show the specialty boolean label and radio buttons
            lblSpecialtyBoolean.Visible = true;
            rdoSpecialtyYes.Visible = true;
            rdoSpecialtyNo.Visible = true;
            // Show the specialty decimal label and text box
            lblSpecialtyDecimal.Visible = true;
            txtSpecialtyDecimal.Visible = true;
            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Click event handler to create a pickup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoPickupClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Pickup";

            // Change the label for the specialty boolean
            lblSpecialtyBoolean.Text = "Does the pickup have a bed cover?";
            // Change the label for the specialty decimal
            lblSpecialtyDecimal.Text = "Bed Size (cubic feet):";

            // Show the specialty boolean label and radio buttons
            lblSpecialtyBoolean.Visible = true;
            rdoSpecialtyYes.Visible = true;
            rdoSpecialtyNo.Visible = true;
            // Show the specialty decimal label and text box
            lblSpecialtyDecimal.Visible = true;
            txtSpecialtyDecimal.Visible = true;
            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Click event handler to create a vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoVehicleClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Vehicle";

            // Show the specialty boolean label and radio buttons
            lblSpecialtyBoolean.Visible = false;
            rdoSpecialtyYes.Visible = false;
            rdoSpecialtyNo.Visible = false;
            // Show the specialty decimal label and text box
            lblSpecialtyDecimal.Visible = false;
            txtSpecialtyDecimal.Visible = false;
            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Click event handler to create a new vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateClickEH(object sender, EventArgs e)
        {
            // Declare and initialize variables
            int id = 0;
            string make = "", model = "", color = "";
            int year = -1, wheels = -1;
            decimal price = -1, mileage = -1, specialtyDecimal = -1;
            bool specialtyBoolean = false;
            VehicleModel vehicle;

            // Test for null/empty textboxes
            ValidateVehicleType();
            make = ValidateTxtMake();
            model = ValidateTxtModel();
            color = ValidateTxtColor();
            year = ValidateTxtYear();
            wheels = ValidateTxtWheels();
            price = ValidateTxtPrice();
            mileage = ValidateTxtMileage();
            specialtyBoolean = ValidateSpecialtyBoolean();
            specialtyDecimal = ValidateSpecialtyDecimal();

            // Check the state of the flags
            if (isVehicleTypeValid && isMakeValid && isModelValid && isColorValid && isYearValid &&
                isPriceValid && isMileageValid && isWheelsValid && isSpecialtyBooleanValid &&
                isSpecialtyDecimalValid)
            {
                // Create the vehicle object based on the selected type
                switch (currentVehicleType)
                {
                    // Create a new car
                    case "Car":
                        vehicle = new CarModel(id, make, model, color, year, mileage, price, wheels,
                            specialtyBoolean, specialtyDecimal);
                        break;
                    // Create a new motorcycle
                    case "Motorcycle":
                        vehicle = new MotorcycleModel(id, make, model, color, year, mileage, price, wheels,
                            specialtyBoolean, specialtyDecimal);
                        break;
                    // Create a new pickup
                    case "Pickup":
                        vehicle = new PickupModel(id, make, model, color, year, mileage, price, wheels,
                            specialtyBoolean, specialtyDecimal);
                        break;
                    // Create a new vehicle
                    default:
                        vehicle = new VehicleModel(id, make, model, color, year, mileage, price, wheels);
                        break;
                }

                // Add the vehicle to the inventory
                _storeLogic.AddVehicleToInventory(vehicle);
                // Show the user a success message
                MessageBox.Show($"The following car has been added to the inventory:\n{vehicle}");

                // Clear the input fields
                rdoCar.Checked = false;
                rdoMotorcycle.Checked = false;
                rdoPickup.Checked = false;
                rdoVehicle.Checked = false;
                txtMake.Clear();
                txtModel.Clear();
                txtColor.Clear();
                txtYear.Clear();
                txtMileage.Clear();
                txtPrice.Clear();
                txtWheels.Clear();
                rdoSpecialtyYes.Checked = false;
                rdoSpecialtyNo.Checked = false;
                txtSpecialtyDecimal.Clear();

                // Refresh the list control
                _inventoryBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Validate that the user has selected a vehicle type
        /// </summary>
        private void ValidateVehicleType()
        {
            if (rdoCar.Checked || rdoMotorcycle.Checked || rdoPickup.Checked || rdoVehicle.Checked)
            {
                // Hide the error label
                lblVehicleTypeError.Visible = false;
                // Set the flag
                isVehicleTypeValid = true;
            }
            else
            {
                // Show the error label
                lblVehicleTypeError.Visible = true;
                // Set the flag
                isVehicleTypeValid = false;
            }
        }

        /// <summary>
        /// Validate the make textbox
        /// </summary>
        /// <returns></returns>
        private string ValidateTxtMake()
        {
            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtMake.Text))
            {
                // Show the error label
                lblMakeError.Visible = true;
                // Set the flag
                isMakeValid = false;
            }
            else
            {
                // Hide the error label
                lblMakeError.Visible = false;
                // Set the flag
                isMakeValid = true;
            }
            // Return the text from the textbox
            return txtMake.Text;
        }

        /// <summary>
        /// Validate the model textbox
        /// </summary>
        /// <returns></returns>
        private string ValidateTxtModel()
        {
            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                // Show the error label
                lblModelError.Visible = true;
                // Set the flag
                isModelValid = false;
            }
            else
            {
                // Hide the error label
                lblModelError.Visible = false;
                // Set the flag
                isModelValid = true;
            }
            // Return the text from the textbox
            return txtModel.Text;
        }

        /// <summary>
        /// Validate the model textbox
        /// </summary>
        /// <returns></returns>
        private string ValidateTxtColor()
        {
            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                // Show the error label
                lblColorError.Visible = true;
                // Set the flag
                isColorValid = false;
            }
            else
            {
                // Hide the error label
                lblColorError.Visible = false;
                // Set the flag
                isColorValid = true;
            }
            // Return the text from the textbox
            return txtColor.Text;
        }


        /// <summary>
        /// Validate the year textbox
        /// </summary>
        /// <returns></returns>
        private int ValidateTxtYear()
        {
            // Declare and initialize
            int yearValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                // Show the error label
                lblYearError.Visible = true;
                // Set the flag
                isYearValid = false;
            }
            else
            {
                // Hide the error label
                lblYearError.Visible = false;
                // Attempt to parse the textbox value
                isYearValid = int.TryParse(txtYear.Text, out yearValue);
                // If the parse failed, show the error message
                if (!isYearValid)
                {
                    lblYearError.Visible = true;
                }
            }
            // Return the year
            return yearValue;
        }

        /// <summary>
        /// Validate the mileage textbox
        /// </summary>
        /// <returns></returns>
        private decimal ValidateTxtMileage()
        {
            // Declare and initialize
            decimal mileageValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtMileage.Text))
            {
                // Show the error label
                lblMileageError.Visible = true;
                // Set the flag
                isMileageValid = false;
            }
            else
            {
                // Hide the error label
                lblMileageError.Visible = false;
                // Attempt to parse the textbox value
                isMileageValid = decimal.TryParse(txtMileage.Text, out mileageValue);
                // If the parse failed, show the error message
                if (!isMileageValid)
                {
                    lblMileageError.Visible = true;
                }
            }
            // Return the price
            return mileageValue;
        }

        /// <summary>
        /// Validate the price textbox
        /// </summary>
        /// <returns></returns>
        private decimal ValidateTxtPrice()
        {
            // Declare and initialize
            decimal priceValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                // Show the error label
                lblPriceError.Visible = true;
                // Set the flag
                isPriceValid = false;
            }
            else
            {
                // Hide the error label
                lblPriceError.Visible = false;
                // Attempt to parse the textbox value
                isPriceValid = decimal.TryParse(txtPrice.Text, out priceValue);
                // If the parse failed, show the error message
                if (!isPriceValid)
                {
                    lblPriceError.Visible = true;
                }
            }
            // Return the price
            return priceValue;
        }

        /// <summary>
        /// Validate the wheels textbox
        /// </summary>
        /// <returns></returns>
        private int ValidateTxtWheels()
        {
            // Declare and initialize
            int wheelsValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtWheels.Text))
            {
                // Show the error label
                lblWheelsError.Visible = true;
                // Set the flag
                isWheelsValid = false;
            }
            else
            {
                // Hide the error label
                lblWheelsError.Visible = false;
                // Attempt to parse the textbox value
                isWheelsValid = int.TryParse(txtWheels.Text, out wheelsValue);
                // If the parse failed, show the error message
                if (!isWheelsValid)
                {
                    lblWheelsError.Visible = true;
                }
            }
            // Return the price
            return wheelsValue;
        }

        /// <summary>
        /// Validate that the user has selected a specialty boolean
        /// </summary>
        /// <returns></returns>
        private bool ValidateSpecialtyBoolean()
        {
            if (currentVehicleType != "Vehicle")
            {
                if (rdoSpecialtyYes.Checked || rdoSpecialtyNo.Checked)
                {
                    // Hide the error label
                    lblSpecialtyBooleanError.Visible = false;
                    // Set the flag
                    isSpecialtyBooleanValid = true;
                }
                else
                {
                    // Show the error label
                    lblSpecialtyBooleanError.Visible = true;
                    // Set the flag
                    isSpecialtyBooleanValid = false;
                }
            }
            else
            {
                // Hide the error label
                lblSpecialtyBooleanError.Visible = false;
                // Set the flag
                isSpecialtyBooleanValid = false;
            }
            return rdoSpecialtyYes.Checked;
        }

        /// <summary>
        /// Validate the specialty decimal textbox
        /// </summary>
        /// <returns></returns>
        private decimal ValidateSpecialtyDecimal()
        {
            // Declare and initialize
            decimal specialtyDecimalValue = -1;
            if (currentVehicleType != "Vehicle")
            {
                // Test for a null/empty textbox
                if (string.IsNullOrEmpty(txtSpecialtyDecimal.Text))
                {
                    // Show the error label
                    lblSpecialtyDecimalError.Visible = true;
                    // Set the flag
                    isSpecialtyDecimalValid = false;
                }
                else
                {
                    // Hide the error label
                    lblSpecialtyDecimalError.Visible = false;
                    // Attempt to parse the textbox value
                    isSpecialtyDecimalValid = decimal.TryParse(txtSpecialtyDecimal.Text, out specialtyDecimalValue);
                    // If the parse failed, show the error message
                    if (!isSpecialtyDecimalValid)
                    {
                        lblSpecialtyDecimalError.Visible = true;
                    }
                }
            }
            else
            {
                // Hide the error label
                lblSpecialtyDecimalError.Visible = false;
                // Set the flag
                isSpecialtyDecimalValid = false;
            }
            return specialtyDecimalValue;
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMakeLeaveEH(object sender, EventArgs e)
        {
            // Validate the make textbox
            ValidateTxtMake();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtModelLeaveEH(object sender, EventArgs e)
        {
            // Validate the model textbox
            ValidateTxtModel();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtColorLeaveEH(object sender, EventArgs e)
        {
            // Validate the color textbox
            ValidateTxtColor();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtYearLeaveEH(object sender, EventArgs e)
        {
            // Validate the year textbox
            ValidateTxtYear();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMileageLeaveEH(object sender, EventArgs e)
        {
            // Validate the mileage textbox
            ValidateTxtMileage();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPriceLeaveEH(object sender, EventArgs e)
        {
            // Validate the price textbox
            ValidateTxtPrice();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWheelsLeaveEH(object sender, EventArgs e)
        {
            // Validate the wheels textbox
            ValidateTxtWheels();
        }

        /// <summary>
        /// Click event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoSpecialtyBooleanClickEH(object sender, EventArgs e)
        {
            // Validate the specialty boolean
            ValidateSpecialtyBoolean();
        }

        /// <summary>
        /// Leave event handler to validate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtDecimalLeaveEH(object sender, EventArgs e)
        {
            // Validate the specialty decimal
            ValidateSpecialtyDecimal();
        }

        /// <summary>
        /// Click event handler for the add to cart button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddToCartClickEH(object sender, EventArgs e)
        {
            // Get the selected vehicle from the inventory list
            VehicleModel vehicle = (VehicleModel)lstInventory.SelectedItem;
            // Add the vehicle to the shopping cart
            _storeLogic.AddVehicleToCart(vehicle.Id);
            // Reset the bindings for the shopping cart binding source
            _shoppingCartBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Click event handler for the checkout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckoutClickEH(object sender, EventArgs e)
        {
            // Checkout the user and save the total
            decimal total = _storeLogic.Checkout();
            // Display the total to lblTotal with currency format
            lblTotal.Text = total.ToString("C");
            // Reset the bindings for the inventory and shopping cart binding source
            _shoppingCartBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Click event handler for the remove from cart button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveFromCartEH(object sender, EventArgs e)
        {
            // Get the selected vehicle from the inventory list
            VehicleModel vehicle = (VehicleModel)lstInventory.SelectedItem;
            // Add the vehicle to the shopping cart
            _storeLogic.RemoveVehicleFromCart(vehicle.Id);
            // Reset the bindings for the shopping cart binding source
            _shoppingCartBindingSource.ResetBindings(false);
        }
    }
}
