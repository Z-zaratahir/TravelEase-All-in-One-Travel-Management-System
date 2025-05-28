namespace WindowsFormsAppProject
{
    partial class TourOperatorTrips
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTrips = new System.Windows.Forms.Label();
            this.tripsDataGridView = new System.Windows.Forms.DataGridView();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripDetailsPanel = new System.Windows.Forms.Panel();
            this.deleteTripButton = new System.Windows.Forms.Button();
            this.updateTripButton = new System.Windows.Forms.Button();
            this.createTripButton = new System.Windows.Forms.Button();
            this.textBoxInclusions = new System.Windows.Forms.TextBox();
            this.labelInclusions = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxTripName = new System.Windows.Forms.TextBox();
            this.labelTripName = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tripsDataGridView)).BeginInit();
            this.tripDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrips
            // 
            this.labelTrips.AutoSize = true;
            this.labelTrips.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTrips.Location = new System.Drawing.Point(720, 15);
            this.labelTrips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrips.Name = "labelTrips";
            this.labelTrips.Size = new System.Drawing.Size(201, 38);
            this.labelTrips.TabIndex = 0;
            this.labelTrips.Text = "Tour Operator";
            // 
            // tripsDataGridView
            // 
            this.tripsDataGridView.AllowUserToAddRows = false;
            this.tripsDataGridView.AllowUserToDeleteRows = false;
            this.tripsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tripsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.TripName,
            this.Destination,
            this.Category,
            this.StartDate,
            this.EndDate,
            this.Capacity,
            this.Price,
            this.Status});
            this.tripsDataGridView.Location = new System.Drawing.Point(30, 77);
            this.tripsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tripsDataGridView.MultiSelect = false;
            this.tripsDataGridView.Name = "tripsDataGridView";
            this.tripsDataGridView.ReadOnly = true;
            this.tripsDataGridView.RowHeadersWidth = 30;
            this.tripsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tripsDataGridView.Size = new System.Drawing.Size(1680, 277);
            this.tripsDataGridView.TabIndex = 1;
            this.tripsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripsDataGridView_CellContentClick);
            // 
            // TripID
            // 
            this.TripID.HeaderText = "Trip ID";
            this.TripID.MinimumWidth = 8;
            this.TripID.Name = "TripID";
            this.TripID.ReadOnly = true;
            this.TripID.Width = 60;
            // 
            // TripName
            // 
            this.TripName.HeaderText = "Trip Name";
            this.TripName.MinimumWidth = 8;
            this.TripName.Name = "TripName";
            this.TripName.ReadOnly = true;
            this.TripName.Width = 180;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 8;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 180;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 110;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 110;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 110;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 8;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 110;
            // 
            // tripDetailsPanel
            // 
            this.tripDetailsPanel.BackColor = System.Drawing.Color.White;
            this.tripDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tripDetailsPanel.Controls.Add(this.deleteTripButton);
            this.tripDetailsPanel.Controls.Add(this.updateTripButton);
            this.tripDetailsPanel.Controls.Add(this.createTripButton);
            this.tripDetailsPanel.Controls.Add(this.textBoxInclusions);
            this.tripDetailsPanel.Controls.Add(this.labelInclusions);
            this.tripDetailsPanel.Controls.Add(this.textBoxDescription);
            this.tripDetailsPanel.Controls.Add(this.labelDescription);
            this.tripDetailsPanel.Controls.Add(this.numericUpDownCapacity);
            this.tripDetailsPanel.Controls.Add(this.labelCapacity);
            this.tripDetailsPanel.Controls.Add(this.textBoxPrice);
            this.tripDetailsPanel.Controls.Add(this.labelPrice);
            this.tripDetailsPanel.Controls.Add(this.dateTimePickerEnd);
            this.tripDetailsPanel.Controls.Add(this.labelEndDate);
            this.tripDetailsPanel.Controls.Add(this.dateTimePickerStart);
            this.tripDetailsPanel.Controls.Add(this.labelStartDate);
            this.tripDetailsPanel.Controls.Add(this.comboBoxCategory);
            this.tripDetailsPanel.Controls.Add(this.labelCategory);
            this.tripDetailsPanel.Controls.Add(this.textBoxDestination);
            this.tripDetailsPanel.Controls.Add(this.labelDestination);
            this.tripDetailsPanel.Controls.Add(this.textBoxTripName);
            this.tripDetailsPanel.Controls.Add(this.labelTripName);
            this.tripDetailsPanel.Controls.Add(this.labelDetails);
            this.tripDetailsPanel.Location = new System.Drawing.Point(30, 385);
            this.tripDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tripDetailsPanel.Name = "tripDetailsPanel";
            this.tripDetailsPanel.Size = new System.Drawing.Size(1679, 445);
            this.tripDetailsPanel.TabIndex = 2;
            // 
            // deleteTripButton
            // 
            this.deleteTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(175)))), ((int)(((byte)(211)))));
            this.deleteTripButton.FlatAppearance.BorderSize = 0;
            this.deleteTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteTripButton.ForeColor = System.Drawing.Color.Black;
            this.deleteTripButton.Location = new System.Drawing.Point(1455, 277);
            this.deleteTripButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteTripButton.Name = "deleteTripButton";
            this.deleteTripButton.Size = new System.Drawing.Size(195, 54);
            this.deleteTripButton.TabIndex = 21;
            this.deleteTripButton.Text = "Delete Trip";
            this.deleteTripButton.UseVisualStyleBackColor = false;
            this.deleteTripButton.Click += new System.EventHandler(this.DeleteTripButton_Click);
            // 
            // updateTripButton
            // 
            this.updateTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(175)))), ((int)(((byte)(211)))));
            this.updateTripButton.FlatAppearance.BorderSize = 0;
            this.updateTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updateTripButton.ForeColor = System.Drawing.Color.Black;
            this.updateTripButton.Location = new System.Drawing.Point(1455, 185);
            this.updateTripButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTripButton.Name = "updateTripButton";
            this.updateTripButton.Size = new System.Drawing.Size(195, 54);
            this.updateTripButton.TabIndex = 20;
            this.updateTripButton.Text = "Update Trip";
            this.updateTripButton.UseVisualStyleBackColor = false;
            this.updateTripButton.Click += new System.EventHandler(this.UpdateTripButton_Click);
            // 
            // createTripButton
            // 
            this.createTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(175)))), ((int)(((byte)(211)))));
            this.createTripButton.FlatAppearance.BorderSize = 0;
            this.createTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.createTripButton.ForeColor = System.Drawing.Color.Black;
            this.createTripButton.Location = new System.Drawing.Point(1455, 92);
            this.createTripButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createTripButton.Name = "createTripButton";
            this.createTripButton.Size = new System.Drawing.Size(195, 54);
            this.createTripButton.TabIndex = 19;
            this.createTripButton.Text = "Create Trip";
            this.createTripButton.UseVisualStyleBackColor = false;
            this.createTripButton.Click += new System.EventHandler(this.CreateTripButton_Click);
            // 
            // textBoxInclusions
            // 
            this.textBoxInclusions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxInclusions.Location = new System.Drawing.Point(525, 285);
            this.textBoxInclusions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInclusions.Multiline = true;
            this.textBoxInclusions.Name = "textBoxInclusions";
            this.textBoxInclusions.Size = new System.Drawing.Size(523, 121);
            this.textBoxInclusions.TabIndex = 18;
            // 
            // labelInclusions
            // 
            this.labelInclusions.AutoSize = true;
            this.labelInclusions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelInclusions.Location = new System.Drawing.Point(525, 254);
            this.labelInclusions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInclusions.Name = "labelInclusions";
            this.labelInclusions.Size = new System.Drawing.Size(94, 25);
            this.labelInclusions.TabIndex = 17;
            this.labelInclusions.Text = "Inclusions:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDescription.Location = new System.Drawing.Point(525, 108);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(523, 121);
            this.textBoxDescription.TabIndex = 16;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.Location = new System.Drawing.Point(525, 77);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(106, 25);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description:";
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownCapacity.Location = new System.Drawing.Point(150, 354);
            this.numericUpDownCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(330, 31);
            this.numericUpDownCapacity.TabIndex = 14;
            this.numericUpDownCapacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCapacity.Location = new System.Drawing.Point(15, 354);
            this.labelCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(83, 25);
            this.labelCapacity.TabIndex = 13;
            this.labelCapacity.Text = "Capacity:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPrice.Location = new System.Drawing.Point(150, 308);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(328, 31);
            this.textBoxPrice.TabIndex = 12;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPrice.Location = new System.Drawing.Point(15, 308);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(53, 25);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(150, 262);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(328, 31);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEndDate.Location = new System.Drawing.Point(15, 262);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(88, 25);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End Date:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(150, 215);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(328, 31);
            this.dateTimePickerStart.TabIndex = 8;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelStartDate.Location = new System.Drawing.Point(15, 215);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(94, 25);
            this.labelStartDate.TabIndex = 7;
            this.labelStartDate.Text = "Start Date:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Beach",
            "Adventure",
            "Cultural",
            "City Break",
            "Wildlife",
            "Historical",
            "Cruise",
            "Luxury"});
            this.comboBoxCategory.Location = new System.Drawing.Point(150, 169);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(328, 33);
            this.comboBoxCategory.TabIndex = 6;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCategory.Location = new System.Drawing.Point(15, 169);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(88, 25);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category:";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDestination.Location = new System.Drawing.Point(150, 123);
            this.textBoxDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(328, 31);
            this.textBoxDestination.TabIndex = 4;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDestination.Location = new System.Drawing.Point(15, 123);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(106, 25);
            this.labelDestination.TabIndex = 3;
            this.labelDestination.Text = "Destination:";
            // 
            // textBoxTripName
            // 
            this.textBoxTripName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTripName.Location = new System.Drawing.Point(150, 77);
            this.textBoxTripName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTripName.Name = "textBoxTripName";
            this.textBoxTripName.Size = new System.Drawing.Size(328, 31);
            this.textBoxTripName.TabIndex = 2;
            // 
            // labelTripName
            // 
            this.labelTripName.AutoSize = true;
            this.labelTripName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTripName.Location = new System.Drawing.Point(15, 77);
            this.labelTripName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTripName.Name = "labelTripName";
            this.labelTripName.Size = new System.Drawing.Size(96, 25);
            this.labelTripName.TabIndex = 1;
            this.labelTripName.Text = "Trip Name:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDetails.Location = new System.Drawing.Point(15, 15);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(120, 28);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "Trip Details";
            // 
            // TourOperatorTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tripDetailsPanel);
            this.Controls.Add(this.tripsDataGridView);
            this.Controls.Add(this.labelTrips);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TourOperatorTrips";
            this.Size = new System.Drawing.Size(1740, 862);
            this.Load += new System.EventHandler(this.OnControlLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.tripsDataGridView)).EndInit();
            this.tripDetailsPanel.ResumeLayout(false);
            this.tripDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrips;
        private System.Windows.Forms.DataGridView tripsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel tripDetailsPanel;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelTripName;
        private System.Windows.Forms.TextBox textBoxTripName;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelInclusions;
        private System.Windows.Forms.TextBox textBoxInclusions;
        private System.Windows.Forms.Button createTripButton;
        private System.Windows.Forms.Button updateTripButton;
        private System.Windows.Forms.Button deleteTripButton;
    }
}