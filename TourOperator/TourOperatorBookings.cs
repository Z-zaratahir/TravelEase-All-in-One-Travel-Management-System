using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class TourOperatorBookings : UserControl
    {
        private Label labelBookings;
        private DataGridView bookingsDataGridView;
        private Panel bookingDetailsPanel;
        private Label labelDetails;
        private Label labelBookingId;
        private TextBox textBoxBookingId;
        private Label labelTripName;
        private TextBox textBoxTripName;
        private Label labelCustomerName;
        private TextBox textBoxCustomerName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelBookingDate;
        private DateTimePicker dateTimePickerBookingDate;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private Label labelPaymentStatus;
        private ComboBox comboBoxPaymentStatus;
        private Label labelNotes;
        private TextBox textBoxNotes;
        private Button updateBookingButton;
        private Button cancelBookingButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

        public TourOperatorBookings()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.AutoScroll = false;
            this.Size = new Size(897, 400);

            // Set up columns before loading data
            bookingsDataGridView.Columns.Clear();
            bookingsDataGridView.Columns.Add("BookingID", "Booking ID");
            bookingsDataGridView.Columns.Add("TripName", "Trip Name");
            bookingsDataGridView.Columns.Add("CustomerName", "Customer Name");
            bookingsDataGridView.Columns.Add("Email", "Email");
            bookingsDataGridView.Columns.Add("Phone", "Phone");
            bookingsDataGridView.Columns.Add("BookingDate", "Booking Date");
            bookingsDataGridView.Columns.Add("TravelDate", "Travel Date");
            bookingsDataGridView.Columns.Add("Status", "Status");
            bookingsDataGridView.Columns.Add("PaymentStatus", "Payment Status");

            SetControlStyles();
            AdjustControlPositions();
            LoadBookingsData();
        }

        private void InitializeComponent()
        {
            this.labelBookings = new System.Windows.Forms.Label();
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.bookingDetailsPanel = new System.Windows.Forms.Panel();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelBookingId = new System.Windows.Forms.Label();
            this.textBoxBookingId = new System.Windows.Forms.TextBox();
            this.labelTripName = new System.Windows.Forms.Label();
            this.textBoxTripName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.comboBoxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.updateBookingButton = new System.Windows.Forms.Button();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            this.bookingDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBookings
            // 
            this.labelBookings.AutoSize = true;
            this.labelBookings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelBookings.Location = new System.Drawing.Point(10, 10);
            this.labelBookings.Name = "labelBookings";
            this.labelBookings.Size = new System.Drawing.Size(322, 38);
            this.labelBookings.TabIndex = 3;
            this.labelBookings.Text = "Bookings Management";
            // 
            // bookingsDataGridView
            // 
            this.bookingsDataGridView.AllowUserToAddRows = false;
            this.bookingsDataGridView.AllowUserToDeleteRows = false;
            this.bookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bookingsDataGridView.Location = new System.Drawing.Point(10, 40);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.ReadOnly = true;
            this.bookingsDataGridView.RowHeadersWidth = 62;
            this.bookingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingsDataGridView.Size = new System.Drawing.Size(880, 160);
            this.bookingsDataGridView.TabIndex = 1;
            // 
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookingDetailsPanel.Controls.Add(this.labelDetails);
            this.bookingDetailsPanel.Controls.Add(this.labelBookingId);
            this.bookingDetailsPanel.Controls.Add(this.textBoxBookingId);
            this.bookingDetailsPanel.Controls.Add(this.labelTripName);
            this.bookingDetailsPanel.Controls.Add(this.textBoxTripName);
            this.bookingDetailsPanel.Controls.Add(this.labelCustomerName);
            this.bookingDetailsPanel.Controls.Add(this.textBoxCustomerName);
            this.bookingDetailsPanel.Controls.Add(this.labelEmail);
            this.bookingDetailsPanel.Controls.Add(this.textBoxEmail);
            this.bookingDetailsPanel.Controls.Add(this.labelPhone);
            this.bookingDetailsPanel.Controls.Add(this.textBoxPhone);
            this.bookingDetailsPanel.Controls.Add(this.labelBookingDate);
            this.bookingDetailsPanel.Controls.Add(this.dateTimePickerBookingDate);
            this.bookingDetailsPanel.Controls.Add(this.labelStatus);
            this.bookingDetailsPanel.Controls.Add(this.comboBoxStatus);
            this.bookingDetailsPanel.Controls.Add(this.labelPaymentStatus);
            this.bookingDetailsPanel.Controls.Add(this.comboBoxPaymentStatus);
            this.bookingDetailsPanel.Controls.Add(this.labelNotes);
            this.bookingDetailsPanel.Controls.Add(this.textBoxNotes);
            this.bookingDetailsPanel.Controls.Add(this.updateBookingButton);
            this.bookingDetailsPanel.Controls.Add(this.cancelBookingButton);
            this.bookingDetailsPanel.Location = new System.Drawing.Point(10, 210);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Size = new System.Drawing.Size(880, 180);
            this.bookingDetailsPanel.TabIndex = 2;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDetails.Location = new System.Drawing.Point(10, 10);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(194, 32);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "Booking Details";
            // 
            // labelBookingId
            // 
            this.labelBookingId.AutoSize = true;
            this.labelBookingId.Location = new System.Drawing.Point(15, 40);
            this.labelBookingId.Name = "labelBookingId";
            this.labelBookingId.Size = new System.Drawing.Size(92, 20);
            this.labelBookingId.TabIndex = 1;
            this.labelBookingId.Text = "Booking ID:";
            // 
            // textBoxBookingId
            // 
            this.textBoxBookingId.Location = new System.Drawing.Point(100, 40);
            this.textBoxBookingId.Name = "textBoxBookingId";
            this.textBoxBookingId.ReadOnly = true;
            this.textBoxBookingId.Size = new System.Drawing.Size(150, 26);
            this.textBoxBookingId.TabIndex = 2;
            // 
            // labelTripName
            // 
            this.labelTripName.AutoSize = true;
            this.labelTripName.Location = new System.Drawing.Point(15, 65);
            this.labelTripName.Name = "labelTripName";
            this.labelTripName.Size = new System.Drawing.Size(85, 20);
            this.labelTripName.TabIndex = 3;
            this.labelTripName.Text = "Trip Name:";
            // 
            // textBoxTripName
            // 
            this.textBoxTripName.Location = new System.Drawing.Point(100, 65);
            this.textBoxTripName.Name = "textBoxTripName";
            this.textBoxTripName.ReadOnly = true;
            this.textBoxTripName.Size = new System.Drawing.Size(150, 26);
            this.textBoxTripName.TabIndex = 4;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(15, 90);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(128, 20);
            this.labelCustomerName.TabIndex = 5;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(100, 90);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(150, 26);
            this.textBoxCustomerName.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(100, 115);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(15, 140);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(59, 20);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(100, 140);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(150, 26);
            this.textBoxPhone.TabIndex = 10;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(280, 40);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(110, 20);
            this.labelBookingDate.TabIndex = 11;
            this.labelBookingDate.Text = "Booking Date:";
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(380, 40);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickerBookingDate.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(280, 65);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 20);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Pending",
            "Cancelled",
            "Completed"});
            this.comboBoxStatus.Location = new System.Drawing.Point(380, 65);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(150, 28);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // labelPaymentStatus
            // 
            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.Location = new System.Drawing.Point(280, 90);
            this.labelPaymentStatus.Name = "labelPaymentStatus";
            this.labelPaymentStatus.Size = new System.Drawing.Size(126, 20);
            this.labelPaymentStatus.TabIndex = 15;
            this.labelPaymentStatus.Text = "Payment Status:";
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentStatus.FormattingEnabled = true;
            this.comboBoxPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Partial",
            "Refunded"});
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(380, 90);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(150, 28);
            this.comboBoxPaymentStatus.TabIndex = 16;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(280, 115);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(55, 20);
            this.labelNotes.TabIndex = 17;
            this.labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(380, 115);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(200, 50);
            this.textBoxNotes.TabIndex = 18;
            // 
            // updateBookingButton
            // 
            this.updateBookingButton.Location = new System.Drawing.Point(590, 80);
            this.updateBookingButton.Name = "updateBookingButton";
            this.updateBookingButton.Size = new System.Drawing.Size(100, 30);
            this.updateBookingButton.TabIndex = 20;
            this.updateBookingButton.Text = "Update";
            this.updateBookingButton.UseVisualStyleBackColor = true;
            this.updateBookingButton.Click += new System.EventHandler(this.UpdateBookingButton_Click);
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Location = new System.Drawing.Point(590, 120);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(100, 30);
            this.cancelBookingButton.TabIndex = 21;
            this.cancelBookingButton.Text = "Cancel Booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // TourOperatorBookings
            // 
            this.Controls.Add(this.bookingDetailsPanel);
            this.Controls.Add(this.bookingsDataGridView);
            this.Controls.Add(this.labelBookings);
            this.Name = "TourOperatorBookings";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.TourOperatorBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadBookingsData()
        {
            string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
            string query = @"
                SELECT 
                    b.BookingID,
                    ISNULL((SELECT TOP 1 i.Title FROM Itinerary i WHERE i.TripID = t.TripID AND i.DayNumber = 1), 'N/A') AS TripName,
                    ISNULL(p.FName + ' ' + p.LName, 'N/A') AS CustomerName,
                    ISNULL(p.Email, 'random@email.com') AS Email,
                    ISNULL(p.PhoneNumber, '000-0000') AS Phone,
                    b.Date AS BookingDate,
                    t.DepartureDate AS TravelDate,
                    ISNULL(b.Status, 'Confirmed') AS Status,
                    ISNULL(pay.Status, 'Paid') AS PaymentStatus
                FROM Booking b
                JOIN BookingAttempt ba ON b.AttemptID = ba.AttemptID
                JOIN Traveler tr ON ba.TravelerID = tr.TravelerID
                JOIN Person p ON tr.TravelerID = p.Registration
                JOIN Trip t ON ba.TripID = t.TripID
                JOIN Payment pay ON b.PaymentID = pay.PaymentID
            ";

            bookingsDataGridView.Rows.Clear();
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookingsDataGridView.Rows.Add(
                            reader["BookingID"].ToString(),
                            reader["TripName"].ToString(),
                            reader["CustomerName"].ToString(),
                            reader["Email"]?.ToString() ?? "random@email.com",
                            reader["Phone"]?.ToString() ?? "000-0000",
                            reader["BookingDate"] != DBNull.Value ? Convert.ToDateTime(reader["BookingDate"]).ToString("MM/dd/yyyy") : "",
                            reader["TravelDate"] != DBNull.Value ? Convert.ToDateTime(reader["TravelDate"]).ToString("MM/dd/yyyy") : "",
                            reader["Status"].ToString(),
                            reader["PaymentStatus"].ToString()
                        );
                    }
                }
            }
        }

        private void SetControlStyles()
        {
            // Set column widths
            bookingsDataGridView.Columns["BookingID"].Width = 80;
            bookingsDataGridView.Columns["TripName"].Width = 120;
            bookingsDataGridView.Columns["CustomerName"].Width = 120;
            bookingsDataGridView.Columns["Email"].Width = 140;
            bookingsDataGridView.Columns["Phone"].Width = 90;
            bookingsDataGridView.Columns["BookingDate"].Width = 90;
            bookingsDataGridView.Columns["TravelDate"].Width = 90;
            bookingsDataGridView.Columns["Status"].Width = 80;
            bookingsDataGridView.Columns["PaymentStatus"].Width = 90;

            // Register selection changed event
            bookingsDataGridView.SelectionChanged += (s, args) =>
            {
                if (bookingsDataGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = bookingsDataGridView.SelectedRows[0].Index;
                    DisplayBookingDetails(selectedIndex);
                }
            };
        }

        private void AdjustControlPositions()
        {
            // Center the bookings label
            labelBookings.Left = (this.Width - labelBookings.Width) / 2;
            labelBookings.Top = 5;
            labelBookings.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Set positions for main controls
            bookingsDataGridView.Width = this.Width - 20;
            bookingsDataGridView.Left = 10;
            bookingsDataGridView.Height = 160;
            bookingsDataGridView.Top = 35;

            bookingDetailsPanel.Width = bookingsDataGridView.Width;
            bookingDetailsPanel.Left = bookingsDataGridView.Left;
            bookingDetailsPanel.Height = 180;
            bookingDetailsPanel.Top = bookingsDataGridView.Bottom + 10;
        }

        private void DisplayBookingDetails(int rowIndex)
        {
            // Display selected booking details in the form fields
            if (rowIndex >= 0 && rowIndex < bookingsDataGridView.Rows.Count)
            {
                DataGridViewRow row = bookingsDataGridView.Rows[rowIndex];
                textBoxBookingId.Text = row.Cells["BookingID"].Value.ToString();
                textBoxTripName.Text = row.Cells["TripName"].Value.ToString();
                textBoxCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();

                // Parse booking date
                if (DateTime.TryParse(row.Cells["BookingDate"].Value.ToString(), out DateTime bookingDate))
                    dateTimePickerBookingDate.Value = bookingDate;

                comboBoxStatus.Text = row.Cells["Status"].Value.ToString();
                comboBoxPaymentStatus.Text = row.Cells["PaymentStatus"].Value.ToString();

                // Sample notes based on status
                string status = row.Cells["Status"].Value.ToString();
                if (status == "Confirmed")
                    textBoxNotes.Text = "Customer has special dietary requirements. All documents sent.";
                else if (status == "Pending")
                    textBoxNotes.Text = "Waiting for payment confirmation. Follow up required.";
                else if (status == "Cancelled")
                    textBoxNotes.Text = "Cancelled due to unavailability. Refund processed.";
                else
                    textBoxNotes.Text = "Trip completed successfully. Customer satisfaction survey sent.";
            }
        }

        private void UpdateBookingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (bookingsDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    int selectedIndex = bookingsDataGridView.SelectedRows[0].Index;
                    DataGridViewRow row = bookingsDataGridView.Rows[selectedIndex];

                    // Update the selected booking with values from the input fields
                    row.Cells["CustomerName"].Value = textBoxCustomerName.Text;
                    row.Cells["Email"].Value = textBoxEmail.Text;
                    row.Cells["Phone"].Value = textBoxPhone.Text;
                    row.Cells["BookingDate"].Value = dateTimePickerBookingDate.Value.ToString("MM/dd/yyyy");
                    row.Cells["Status"].Value = comboBoxStatus.Text;
                    row.Cells["PaymentStatus"].Value = comboBoxPaymentStatus.Text;

                    MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a booking to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookingsDataGridView.SelectedRows.Count > 0)
                {
                    string bookingId = textBoxBookingId.Text;
                    string customerName = textBoxCustomerName.Text;

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to cancel booking {bookingId} for {customerName}?",
                        "Confirm Cancellation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Remove from database
                        string connectionString = "Data Source=DESKTOP-7RF0QH4\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False;";
                        using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Booking WHERE BookingID = @BookingID";
                            using (var cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@BookingID", bookingId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Remove from DataGridView
                        int selectedIndex = bookingsDataGridView.SelectedRows[0].Index;
                        bookingsDataGridView.Rows.RemoveAt(selectedIndex);

                        // Clear details panel
                        textBoxBookingId.Clear();
                        textBoxTripName.Clear();
                        textBoxCustomerName.Clear();
                        textBoxEmail.Clear();
                        textBoxPhone.Clear();
                        dateTimePickerBookingDate.Value = DateTime.Now;
                        comboBoxStatus.SelectedIndex = -1;
                        comboBoxPaymentStatus.SelectedIndex = -1;
                        textBoxNotes.Clear();

                        MessageBox.Show("Booking cancelled and removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TourOperatorBookings_Load(object sender, EventArgs e)
        {

        }
    }
}