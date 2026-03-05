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
            lblWheelsError = new Label();
            lblMileageError = new Label();
            lblPriceError = new Label();
            lblYearError = new Label();
            lblColorError = new Label();
            lblModelError = new Label();
            lblMakeError = new Label();
            lblVehicleTypeError = new Label();
            txtWheels = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtMileage = new TextBox();
            label6 = new Label();
            txtColor = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdoVehicle = new RadioButton();
            rdoPickup = new RadioButton();
            rdoMotercycle = new RadioButton();
            rdoCar = new RadioButton();
            groupBox2 = new GroupBox();
            lblSpecialtyDecimalError = new Label();
            lblSpecialtyBooleanError = new Label();
            txtSpecialtyDecimal = new TextBox();
            lblSpecialtyDecimal = new Label();
            rdoSpecialtyNo = new RadioButton();
            rdoSpecialtyYes = new RadioButton();
            lblSpecialtyBoolean = new Label();
            btnCreate = new Button();
            groupBox3 = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            groupBox4 = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            label10 = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblWheelsError);
            groupBox1.Controls.Add(lblMileageError);
            groupBox1.Controls.Add(lblPriceError);
            groupBox1.Controls.Add(lblYearError);
            groupBox1.Controls.Add(lblColorError);
            groupBox1.Controls.Add(lblModelError);
            groupBox1.Controls.Add(lblMakeError);
            groupBox1.Controls.Add(lblVehicleTypeError);
            groupBox1.Controls.Add(txtWheels);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtMileage);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdoVehicle);
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(rdoMotercycle);
            groupBox1.Controls.Add(rdoCar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Vehicle";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(67, 429);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(188, 15);
            lblWheelsError.TabIndex = 25;
            lblWheelsError.Text = "Please Enter a Valid Wheel Count";
            // 
            // lblMileageError
            // 
            lblMileageError.AutoSize = true;
            lblMileageError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMileageError.ForeColor = Color.Red;
            lblMileageError.Location = new Point(69, 342);
            lblMileageError.Name = "lblMileageError";
            lblMileageError.Size = new Size(160, 15);
            lblMileageError.TabIndex = 24;
            lblMileageError.Text = "Please Enter a Valid Mileage";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(81, 385);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(144, 15);
            lblPriceError.TabIndex = 23;
            lblPriceError.Text = "Please Enter a Valid Price";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(85, 293);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(140, 15);
            lblYearError.TabIndex = 22;
            lblYearError.Text = "Please Enter a valid Year";
            // 
            // lblColorError
            // 
            lblColorError.AutoSize = true;
            lblColorError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColorError.ForeColor = Color.Red;
            lblColorError.Location = new Point(99, 237);
            lblColorError.Name = "lblColorError";
            lblColorError.Size = new Size(116, 15);
            lblColorError.TabIndex = 21;
            lblColorError.Text = "Please Enter a Color";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(97, 185);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(122, 15);
            lblModelError.TabIndex = 20;
            lblModelError.Text = "Please Enter a Model";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(97, 138);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(118, 15);
            lblMakeError.TabIndex = 19;
            lblMakeError.Text = "Please Enter a Make";
            // 
            // lblVehicleTypeError
            // 
            lblVehicleTypeError.AutoSize = true;
            lblVehicleTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleTypeError.ForeColor = Color.Red;
            lblVehicleTypeError.Location = new Point(17, 89);
            lblVehicleTypeError.Name = "lblVehicleTypeError";
            lblVehicleTypeError.Size = new Size(166, 15);
            lblVehicleTypeError.TabIndex = 18;
            lblVehicleTypeError.Text = "Please Choose a Vehicle Type";
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(104, 403);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(100, 23);
            txtWheels.TabIndex = 17;
            txtWheels.Leave += TxtWheelsLeaveEH;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(104, 360);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 15;
            txtPrice.Leave += TxtPriceLeaveEH;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(103, 267);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 14;
            txtYear.Leave += TxtYearLeaveEH;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(104, 316);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(100, 23);
            txtMileage.TabIndex = 16;
            txtMileage.Leave += TxtMileageLeaveEH;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 324);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Mileage:";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(103, 211);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 13;
            txtColor.Leave += TxtColorLeaveEH;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(103, 159);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 12;
            txtModel.Leave += TxtModelLeaveEH;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(102, 112);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 11;
            txtMake.Leave += TxtMakeLeaveEH;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 406);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 10;
            label7.Text = "Wheels:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 368);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 270);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 214);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 162);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 115);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Make:";
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(102, 67);
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
            rdoPickup.Location = new Point(18, 67);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(61, 19);
            rdoPickup.TabIndex = 2;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += RdoPickupClickEH;
            // 
            // rdoMotercycle
            // 
            rdoMotercycle.AutoSize = true;
            rdoMotercycle.Location = new Point(102, 30);
            rdoMotercycle.Name = "rdoMotercycle";
            rdoMotercycle.Size = new Size(84, 19);
            rdoMotercycle.TabIndex = 1;
            rdoMotercycle.TabStop = true;
            rdoMotercycle.Text = "Motercycle";
            rdoMotercycle.UseVisualStyleBackColor = true;
            rdoMotercycle.Click += RdoMotercycleClickEH;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(18, 30);
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
            groupBox2.Controls.Add(lblSpecialtyDecimalError);
            groupBox2.Controls.Add(lblSpecialtyBooleanError);
            groupBox2.Controls.Add(txtSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyDecimal);
            groupBox2.Controls.Add(rdoSpecialtyNo);
            groupBox2.Controls.Add(rdoSpecialtyYes);
            groupBox2.Controls.Add(lblSpecialtyBoolean);
            groupBox2.Location = new Point(12, 499);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Specialty Properties";
            // 
            // lblSpecialtyDecimalError
            // 
            lblSpecialtyDecimalError.AutoSize = true;
            lblSpecialtyDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyDecimalError.ForeColor = Color.Red;
            lblSpecialtyDecimalError.Location = new Point(24, 132);
            lblSpecialtyDecimalError.Name = "lblSpecialtyDecimalError";
            lblSpecialtyDecimalError.Size = new Size(162, 15);
            lblSpecialtyDecimalError.TabIndex = 27;
            lblSpecialtyDecimalError.Text = "Please Enter a Valid Number";
            // 
            // lblSpecialtyBooleanError
            // 
            lblSpecialtyBooleanError.AutoSize = true;
            lblSpecialtyBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyBooleanError.ForeColor = Color.Red;
            lblSpecialtyBooleanError.Location = new Point(17, 84);
            lblSpecialtyBooleanError.Name = "lblSpecialtyBooleanError";
            lblSpecialtyBooleanError.Size = new Size(130, 15);
            lblSpecialtyBooleanError.TabIndex = 26;
            lblSpecialtyBooleanError.Text = "Please Enter Yes or No";
            // 
            // txtSpecialtyDecimal
            // 
            txtSpecialtyDecimal.Location = new Point(129, 106);
            txtSpecialtyDecimal.Name = "txtSpecialtyDecimal";
            txtSpecialtyDecimal.Size = new Size(100, 23);
            txtSpecialtyDecimal.TabIndex = 4;
            txtSpecialtyDecimal.Leave += TxtDecimalLeaveEH;
            // 
            // lblSpecialtyDecimal
            // 
            lblSpecialtyDecimal.AutoSize = true;
            lblSpecialtyDecimal.Location = new Point(6, 109);
            lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            lblSpecialtyDecimal.Size = new Size(103, 15);
            lblSpecialtyDecimal.TabIndex = 3;
            lblSpecialtyDecimal.Text = "Specialty Decimal:";
            // 
            // rdoSpecialtyNo
            // 
            rdoSpecialtyNo.AutoSize = true;
            rdoSpecialtyNo.Location = new Point(81, 62);
            rdoSpecialtyNo.Name = "rdoSpecialtyNo";
            rdoSpecialtyNo.Size = new Size(41, 19);
            rdoSpecialtyNo.TabIndex = 2;
            rdoSpecialtyNo.TabStop = true;
            rdoSpecialtyNo.Text = "No";
            rdoSpecialtyNo.UseVisualStyleBackColor = true;
            rdoSpecialtyNo.Click += RdoSpecialtyBooleanClickEH;
            // 
            // rdoSpecialtyYes
            // 
            rdoSpecialtyYes.AutoSize = true;
            rdoSpecialtyYes.Location = new Point(24, 62);
            rdoSpecialtyYes.Name = "rdoSpecialtyYes";
            rdoSpecialtyYes.Size = new Size(42, 19);
            rdoSpecialtyYes.TabIndex = 1;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            rdoSpecialtyYes.Click += RdoSpecialtyBooleanClickEH;
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
            // btnCreate
            // 
            btnCreate.Location = new Point(114, 470);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreateClickEH;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(311, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 507);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(277, 469);
            lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(606, 223);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(76, 47);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCartClickEH;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(698, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(289, 507);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Store Inventory";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.ItemHeight = 15;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(277, 469);
            lstShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(807, 527);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckoutClickEH;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(807, 570);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(849, 570);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 680);
            Controls.Add(lblTotal);
            Controls.Add(label10);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox4);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(btnCreate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVehicleStore";
            Text = "VehicleStore";
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
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdoVehicle;
        private RadioButton rdoPickup;
        private RadioButton rdoMotercycle;
        private RadioButton rdoCar;
        private TextBox txtModel;
        private TextBox txtMake;
        private TextBox txtWheels;
        private TextBox txtMileage;
        private TextBox txtPrice;
        private TextBox txtYear;
        private GroupBox groupBox2;
        private RadioButton rdoSpecialtyNo;
        private RadioButton rdoSpecialtyYes;
        private Label lblSpecialtyBoolean;
        private Button btnCreate;
        private TextBox txtSpecialtyDecimal;
        private Label lblSpecialtyDecimal;
        private GroupBox groupBox3;
        private ListBox lstInventory;
        private Button btnAddToCart;
        private GroupBox groupBox4;
        private ListBox lstShoppingCart;
        private Button btnCheckout;
        private Label label10;
        private Label lblTotal;
        private Label lblVehicleTypeError;
        private Label lblMakeError;
        private Label lblMileageError;
        private Label lblPriceError;
        private Label lblYearError;
        private Label lblColorError;
        private Label lblModelError;
        private TextBox txtColor;
        private Label lblWheelsError;
        private Label lblSpecialtyDecimalError;
        private Label lblSpecialtyBooleanError;
    }
}
