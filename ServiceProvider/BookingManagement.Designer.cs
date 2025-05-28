namespace Project
{
    partial class BookingManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingManagement));
            this.labelBookingManagement = new System.Windows.Forms.Label();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.radioButtonPaid = new System.Windows.Forms.RadioButton();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookingManagement
            // 
            this.labelBookingManagement.AutoSize = true;
            this.labelBookingManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBookingManagement.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingManagement.Location = new System.Drawing.Point(387, 186);
            this.labelBookingManagement.Name = "labelBookingManagement";
            this.labelBookingManagement.Size = new System.Drawing.Size(726, 91);
            this.labelBookingManagement.TabIndex = 6;
            this.labelBookingManagement.Text = "BOOKING MANAGEMENT";
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(387, 408);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 62;
            this.dataGridViewBooking.RowTemplate.Height = 28;
            this.dataGridViewBooking.Size = new System.Drawing.Size(727, 150);
            this.dataGridViewBooking.TabIndex = 7;
            this.dataGridViewBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellContentClick);
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(968, 567);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(146, 48);
            this.buttonReject.TabIndex = 14;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(814, 567);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(146, 48);
            this.buttonConfirm.TabIndex = 15;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(387, 567);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(221, 48);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update Availability";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // radioButtonPaid
            // 
            this.radioButtonPaid.AutoSize = true;
            this.radioButtonPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.radioButtonPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonPaid.Location = new System.Drawing.Point(387, 361);
            this.radioButtonPaid.Name = "radioButtonPaid";
            this.radioButtonPaid.Size = new System.Drawing.Size(206, 36);
            this.radioButtonPaid.TabIndex = 17;
            this.radioButtonPaid.TabStop = true;
            this.radioButtonPaid.Text = "Mark As Paid";
            this.radioButtonPaid.UseVisualStyleBackColor = false;
            this.radioButtonPaid.CheckedChanged += new System.EventHandler(this.radioButtonPaid_CheckedChanged);
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(935, 336);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(178, 28);
            this.comboBoxChoose.TabIndex = 18;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(809, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Services";
            // 
            // BookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.radioButtonPaid);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.labelBookingManagement);
            this.Name = "BookingManagement";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.BookingManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookingManagement;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RadioButton radioButtonPaid;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label label1;
    }
}
