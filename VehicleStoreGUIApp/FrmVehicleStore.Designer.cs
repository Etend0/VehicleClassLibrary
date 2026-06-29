namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblMileageError = new Label();
            txtMileage = new TextBox();
            label9 = new Label();
            lblColorError = new Label();
            txtColor = new TextBox();
            label7 = new Label();
            lblWheelsError = new Label();
            lblPriceError = new Label();
            lblYearError = new Label();
            lblModelError = new Label();
            lblMakeError = new Label();
            lblVehicleTypeError = new Label();
            btnCreate = new Button();
            txtWheels = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdoVehicle = new RadioButton();
            rdoPickup = new RadioButton();
            rdoMotorcycle = new RadioButton();
            rdoCar = new RadioButton();
            groupBox2 = new GroupBox();
            lblSpecialtyBooleanError = new Label();
            lblSpecialtyDecimalError = new Label();
            txtSpecialtyDecimal = new TextBox();
            lblSpecialtyDecimal = new Label();
            rdoSpecialtyNo = new RadioButton();
            rdoSpecialtyYes = new RadioButton();
            lblSpecialtyBoolean = new Label();
            groupBox3 = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            groupBox4 = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            label8 = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMileageError);
            groupBox1.Controls.Add(txtMileage);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblColorError);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblWheelsError);
            groupBox1.Controls.Add(lblPriceError);
            groupBox1.Controls.Add(lblYearError);
            groupBox1.Controls.Add(lblModelError);
            groupBox1.Controls.Add(lblMakeError);
            groupBox1.Controls.Add(lblVehicleTypeError);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtWheels);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdoVehicle);
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(rdoMotorcycle);
            groupBox1.Controls.Add(rdoCar);
            groupBox1.Location = new Point(10, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 463);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblMileageError
            // 
            lblMileageError.AutoSize = true;
            lblMileageError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMileageError.ForeColor = Color.Red;
            lblMileageError.Location = new Point(53, 384);
            lblMileageError.Name = "lblMileageError";
            lblMileageError.Size = new Size(161, 15);
            lblMileageError.TabIndex = 26;
            lblMileageError.Text = "Please enter a valid mileage";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(88, 358);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(100, 23);
            txtMileage.TabIndex = 25;
            txtMileage.Leave += TxtMileageLeaveEH;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 361);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 24;
            label9.Text = "Mileage:";
            // 
            // lblColorError
            // 
            lblColorError.AutoSize = true;
            lblColorError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColorError.ForeColor = Color.Red;
            lblColorError.Location = new Point(61, 166);
            lblColorError.Name = "lblColorError";
            lblColorError.Size = new Size(116, 15);
            lblColorError.TabIndex = 23;
            lblColorError.Text = "Please enter a color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(88, 140);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 22;
            txtColor.Leave += TxtColorLeaveEH;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 143);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 21;
            label7.Text = "Color:";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(41, 340);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(186, 15);
            lblWheelsError.TabIndex = 20;
            lblWheelsError.Text = "Please enter a valid wheel count";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(61, 296);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(145, 15);
            lblPriceError.TabIndex = 19;
            lblPriceError.Text = "Please enter a valid price";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(61, 254);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(141, 15);
            lblYearError.TabIndex = 18;
            lblYearError.Text = "Please enter a valid year";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(61, 210);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(123, 15);
            lblModelError.TabIndex = 17;
            lblModelError.Text = "Please enter a model";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(61, 122);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(119, 15);
            lblMakeError.TabIndex = 16;
            lblMakeError.Text = "Please enter a make";
            // 
            // lblVehicleTypeError
            // 
            lblVehicleTypeError.AutoSize = true;
            lblVehicleTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleTypeError.ForeColor = Color.Red;
            lblVehicleTypeError.Location = new Point(26, 78);
            lblVehicleTypeError.Name = "lblVehicleTypeError";
            lblVehicleTypeError.Size = new Size(166, 15);
            lblVehicleTypeError.TabIndex = 15;
            lblVehicleTypeError.Text = "Please Choose a Vehicle Type";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(88, 425);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreateClickEH;
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(88, 314);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(100, 23);
            txtWheels.TabIndex = 13;
            txtWheels.Leave += TxtWheelsLeaveEH;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(88, 272);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 12;
            txtPrice.Leave += TxtPriceLeaveEH;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(88, 228);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 11;
            txtYear.Leave += TxtYearLeaveEH;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(88, 184);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 10;
            txtModel.Leave += TxtModelLeaveEH;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(88, 96);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 9;
            txtMake.Leave += TxtMakeLeaveEH;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 317);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Wheels:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 275);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 231);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 187);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 99);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Make:";
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(142, 56);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(62, 19);
            rdoVehicle.TabIndex = 3;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Vehicle";
            rdoVehicle.UseVisualStyleBackColor = true;
            rdoVehicle.Click += RdoVehicleClickEH;
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(26, 56);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(61, 19);
            rdoPickup.TabIndex = 2;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += RdoPickupClickEH;
            // 
            // rdoMotorcycle
            // 
            rdoMotorcycle.AutoSize = true;
            rdoMotorcycle.Location = new Point(142, 31);
            rdoMotorcycle.Name = "rdoMotorcycle";
            rdoMotorcycle.Size = new Size(85, 19);
            rdoMotorcycle.TabIndex = 1;
            rdoMotorcycle.TabStop = true;
            rdoMotorcycle.Text = "Motorcycle";
            rdoMotorcycle.UseVisualStyleBackColor = true;
            rdoMotorcycle.Click += RdoMotorcycleClickEH;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(26, 31);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(43, 19);
            rdoCar.TabIndex = 0;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.Click += RdoCarClickEH;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSpecialtyBooleanError);
            groupBox2.Controls.Add(lblSpecialtyDecimalError);
            groupBox2.Controls.Add(txtSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyDecimal);
            groupBox2.Controls.Add(rdoSpecialtyNo);
            groupBox2.Controls.Add(rdoSpecialtyYes);
            groupBox2.Controls.Add(lblSpecialtyBoolean);
            groupBox2.Location = new Point(12, 502);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Specialty Properties";
            // 
            // lblSpecialtyBooleanError
            // 
            lblSpecialtyBooleanError.AutoSize = true;
            lblSpecialtyBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyBooleanError.ForeColor = Color.Red;
            lblSpecialtyBooleanError.Location = new Point(25, 72);
            lblSpecialtyBooleanError.Name = "lblSpecialtyBooleanError";
            lblSpecialtyBooleanError.Size = new Size(166, 15);
            lblSpecialtyBooleanError.TabIndex = 22;
            lblSpecialtyBooleanError.Text = "Please Choose a Vehicle Type";
            // 
            // lblSpecialtyDecimalError
            // 
            lblSpecialtyDecimalError.AutoSize = true;
            lblSpecialtyDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyDecimalError.ForeColor = Color.Red;
            lblSpecialtyDecimalError.Location = new Point(26, 116);
            lblSpecialtyDecimalError.Name = "lblSpecialtyDecimalError";
            lblSpecialtyDecimalError.Size = new Size(166, 15);
            lblSpecialtyDecimalError.TabIndex = 21;
            lblSpecialtyDecimalError.Text = "Please Choose a Vehicle Type";
            // 
            // txtSpecialtyDecimal
            // 
            txtSpecialtyDecimal.Location = new Point(115, 90);
            txtSpecialtyDecimal.Name = "txtSpecialtyDecimal";
            txtSpecialtyDecimal.Size = new Size(100, 23);
            txtSpecialtyDecimal.TabIndex = 4;
            // 
            // lblSpecialtyDecimal
            // 
            lblSpecialtyDecimal.AutoSize = true;
            lblSpecialtyDecimal.Location = new Point(6, 93);
            lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            lblSpecialtyDecimal.Size = new Size(103, 15);
            lblSpecialtyDecimal.TabIndex = 3;
            lblSpecialtyDecimal.Text = "Specialty Decimal:";
            // 
            // rdoSpecialtyNo
            // 
            rdoSpecialtyNo.AutoSize = true;
            rdoSpecialtyNo.Location = new Point(88, 53);
            rdoSpecialtyNo.Name = "rdoSpecialtyNo";
            rdoSpecialtyNo.Size = new Size(41, 19);
            rdoSpecialtyNo.TabIndex = 2;
            rdoSpecialtyNo.TabStop = true;
            rdoSpecialtyNo.Text = "No";
            rdoSpecialtyNo.UseVisualStyleBackColor = true;
            // 
            // rdoSpecialtyYes
            // 
            rdoSpecialtyYes.AutoSize = true;
            rdoSpecialtyYes.Location = new Point(25, 53);
            rdoSpecialtyYes.Name = "rdoSpecialtyYes";
            rdoSpecialtyYes.Size = new Size(42, 19);
            rdoSpecialtyYes.TabIndex = 1;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            // 
            // lblSpecialtyBoolean
            // 
            lblSpecialtyBoolean.AutoSize = true;
            lblSpecialtyBoolean.Location = new Point(6, 35);
            lblSpecialtyBoolean.Name = "lblSpecialtyBoolean";
            lblSpecialtyBoolean.Size = new Size(103, 15);
            lblSpecialtyBoolean.TabIndex = 0;
            lblSpecialtyBoolean.Text = "Specialty Boolean:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(277, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 393);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(6, 31);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(239, 349);
            lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(534, 172);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(75, 46);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCartClickEH;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(615, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(251, 393);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cart";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.ItemHeight = 15;
            lstShoppingCart.Location = new Point(6, 31);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(239, 349);
            lstShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(707, 411);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckoutClickEH;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(707, 444);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 5;
            label8.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(759, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 663);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox4);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdoVehicle;
        private RadioButton rdoPickup;
        private RadioButton rdoMotorcycle;
        private RadioButton rdoCar;
        private Button btnCreate;
        private TextBox txtWheels;
        private TextBox txtPrice;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private GroupBox groupBox2;
        private RadioButton rdoSpecialtyNo;
        private RadioButton rdoSpecialtyYes;
        private Label lblSpecialtyBoolean;
        private TextBox txtSpecialtyDecimal;
        private Label lblSpecialtyDecimal;
        private GroupBox groupBox3;
        private ListBox lstInventory;
        private Button btnAddToCart;
        private GroupBox groupBox4;
        private ListBox lstShoppingCart;
        private Label lblWheelsError;
        private Label lblPriceError;
        private Label lblYearError;
        private Label lblModelError;
        private Label lblMakeError;
        private Label lblVehicleTypeError;
        private Button btnCheckout;
        private Label label8;
        private Label lblTotal;
        private Label lblSpecialtyBooleanError;
        private Label lblSpecialtyDecimalError;
        private Label lblColorError;
        private TextBox txtColor;
        private Label label7;
        private Label label1;
        private Label lblMileageError;
        private TextBox txtMileage;
        private Label label9;
    }
}
