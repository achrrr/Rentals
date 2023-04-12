namespace RentalsDatabase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spcrBtn = new RentalsDatabase.ValueRadioBtn();
            this.suvBtn = new RentalsDatabase.ValueRadioBtn();
            this.compactBtn = new RentalsDatabase.ValueRadioBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rentDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.placeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.licensebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRuDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridXtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Rentals";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spcrBtn);
            this.groupBox1.Controls.Add(this.suvBtn);
            this.groupBox1.Controls.Add(this.compactBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // spcrBtn
            // 
            this.spcrBtn.AutoSize = true;
            this.spcrBtn.Location = new System.Drawing.Point(25, 86);
            this.spcrBtn.Name = "spcrBtn";
            this.spcrBtn.Size = new System.Drawing.Size(132, 19);
            this.spcrBtn.TabIndex = 2;
            this.spcrBtn.TabStop = true;
            this.spcrBtn.Text = "Sports Car ($60/day)";
            this.spcrBtn.Value(60);
            this.spcrBtn.CarType("Sports Car");
            this.spcrBtn.UseVisualStyleBackColor = true;
            // 
            // suvBtn
            // 
            this.suvBtn.AutoSize = true;
            this.suvBtn.Location = new System.Drawing.Point(25, 55);
            this.suvBtn.Name = "suvBtn";
            this.suvBtn.Size = new System.Drawing.Size(99, 19);
            this.suvBtn.TabIndex = 1;
            this.suvBtn.TabStop = true;
            this.suvBtn.Text = "SUV ($40/day)";
            this.suvBtn.Value(40);
            this.suvBtn.CarType("SUV");
            this.suvBtn.UseVisualStyleBackColor = true;
            // 
            // compactBtn
            // 
            this.compactBtn.AutoSize = true;
            this.compactBtn.Location = new System.Drawing.Point(25, 22);
            this.compactBtn.Name = "compactBtn";
            this.compactBtn.Size = new System.Drawing.Size(127, 19);
            this.compactBtn.TabIndex = 0;
            this.compactBtn.TabStop = true;
            this.compactBtn.Text = "Compact ($25/day)";
            this.compactBtn.Value(25);
            this.compactBtn.CarType("Compact");
            this.compactBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rent Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Date: ";
            // 
            // rentDate
            // 
            this.rentDate.Location = new System.Drawing.Point(424, 92);
            this.rentDate.Name = "rentDate";
            this.rentDate.Size = new System.Drawing.Size(200, 23);
            this.rentDate.TabIndex = 4;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(424, 131);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 23);
            this.returnDate.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(668, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Xtra Driver ($25)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // placeButton
            // 
            this.placeButton.Location = new System.Drawing.Point(355, 191);
            this.placeButton.Name = "placeButton";
            this.placeButton.Size = new System.Drawing.Size(130, 30);
            this.placeButton.TabIndex = 7;
            this.placeButton.Text = "Place Rental";
            this.placeButton.UseVisualStyleBackColor = true;
            this.placeButton.Click += new System.EventHandler(this.placeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = " ";
            // 
            // licensebox
            // 
            this.licensebox.Location = new System.Drawing.Point(360, 245);
            this.licensebox.Name = "licensebox";
            this.licensebox.Size = new System.Drawing.Size(130, 23);
            this.licensebox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "License Plate: ";
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(12, 295);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 11;
            this.fillBtn.Text = "Display Data";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(12, 349);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 12;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridID,
            this.gridPlateNum,
            this.gridCarType,
            this.gridRDate,
            this.gridRuDate,
            this.gridCost,
            this.gridXtra});
            this.dataGridView1.Location = new System.Drawing.Point(143, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(699, 184);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // plateNumber
            // 
            this.plateNumber.DataPropertyName = "PlateNum";
            this.plateNumber.HeaderText = "Plate Number";
            this.plateNumber.Name = "plateNumber";
            // 
            // gridID
            // 
            this.gridID.DataPropertyName = "Id";
            this.gridID.HeaderText = "Id";
            this.gridID.Name = "gridID";
            // 
            // gridPlateNum
            // 
            this.gridPlateNum.DataPropertyName = "PlateNum";
            this.gridPlateNum.HeaderText = "Plate Number";
            this.gridPlateNum.Name = "gridPlateNum";
            // 
            // gridCarType
            // 
            this.gridCarType.DataPropertyName = "CarType";
            this.gridCarType.HeaderText = "Car Type";
            this.gridCarType.Name = "gridCarType";
            // 
            // gridRDate
            // 
            this.gridRDate.DataPropertyName = "RentDate";
            this.gridRDate.HeaderText = "Rent Date";
            this.gridRDate.Name = "gridRDate";
            // 
            // gridRuDate
            // 
            this.gridRuDate.DataPropertyName = "ReturnDate";
            this.gridRuDate.HeaderText = "Return Date";
            this.gridRuDate.Name = "gridRuDate";
            // 
            // gridCost
            // 
            this.gridCost.DataPropertyName = "Cost";
            this.gridCost.HeaderText = "Cost";
            this.gridCost.Name = "gridCost";
            // 
            // gridXtra
            // 
            this.gridXtra.DataPropertyName = "xDriver";
            this.gridXtra.HeaderText = "Extra Driver";
            this.gridXtra.Name = "gridXtra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.licensebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placeButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.rentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rentals";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker rentDate;
        private DateTimePicker returnDate;
        private CheckBox checkBox1;
        private Button placeButton;
        private Label label4;
        private TextBox licensebox;
        private Label label5;
        private Button fillBtn;
        private Button updatebtn;
        private DataGridView dataGridView1;
        private ValueRadioBtn compactBtn;
        private ValueRadioBtn spcrBtn;
        private ValueRadioBtn suvBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn plateNumber;
        private DataGridViewTextBoxColumn gridID;
        private DataGridViewTextBoxColumn gridPlateNum;
        private DataGridViewTextBoxColumn gridCarType;
        private DataGridViewTextBoxColumn gridRDate;
        private DataGridViewTextBoxColumn gridRuDate;
        private DataGridViewTextBoxColumn gridCost;
        private DataGridViewTextBoxColumn gridXtra;
    }
}