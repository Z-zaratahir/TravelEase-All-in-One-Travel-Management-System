namespace WindowsFormsAppProject
{
    partial class selectInterface
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
            this.travelerb = new System.Windows.Forms.Button();
            this.adminb = new System.Windows.Forms.Button();
            this.operatorb = new System.Windows.Forms.Button();
            this.serviceprovider = new System.Windows.Forms.Button();
            this.reportb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // travelerb
            // 
            this.travelerb.BackColor = System.Drawing.Color.Black;
            this.travelerb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.travelerb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.travelerb.Location = new System.Drawing.Point(104, 356);
            this.travelerb.Name = "travelerb";
            this.travelerb.Size = new System.Drawing.Size(122, 37);
            this.travelerb.TabIndex = 21;
            this.travelerb.Text = "Traveler";
            this.travelerb.UseVisualStyleBackColor = false;
            this.travelerb.Click += new System.EventHandler(this.travelerb_Click);
            // 
            // adminb
            // 
            this.adminb.BackColor = System.Drawing.Color.Black;
            this.adminb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.adminb.Location = new System.Drawing.Point(262, 356);
            this.adminb.Name = "adminb";
            this.adminb.Size = new System.Drawing.Size(122, 37);
            this.adminb.TabIndex = 22;
            this.adminb.Text = "Admin";
            this.adminb.UseVisualStyleBackColor = false;
            this.adminb.Click += new System.EventHandler(this.adminb_Click);
            // 
            // operatorb
            // 
            this.operatorb.BackColor = System.Drawing.Color.Black;
            this.operatorb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.operatorb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.operatorb.Location = new System.Drawing.Point(413, 356);
            this.operatorb.Name = "operatorb";
            this.operatorb.Size = new System.Drawing.Size(122, 37);
            this.operatorb.TabIndex = 23;
            this.operatorb.Text = "Operator";
            this.operatorb.UseVisualStyleBackColor = false;
            this.operatorb.Click += new System.EventHandler(this.operatorb_Click);
            // 
            // serviceprovider
            // 
            this.serviceprovider.BackColor = System.Drawing.Color.Black;
            this.serviceprovider.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.serviceprovider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.serviceprovider.Location = new System.Drawing.Point(564, 356);
            this.serviceprovider.Name = "serviceprovider";
            this.serviceprovider.Size = new System.Drawing.Size(159, 37);
            this.serviceprovider.TabIndex = 24;
            this.serviceprovider.Text = "Service Provider";
            this.serviceprovider.UseVisualStyleBackColor = false;
            this.serviceprovider.Click += new System.EventHandler(this.serviceprovider_Click);
            // 
            // reportb
            // 
            this.reportb.BackColor = System.Drawing.Color.Black;
            this.reportb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.reportb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.reportb.Location = new System.Drawing.Point(746, 356);
            this.reportb.Name = "reportb";
            this.reportb.Size = new System.Drawing.Size(122, 37);
            this.reportb.TabIndex = 25;
            this.reportb.Text = "Reports";
            this.reportb.UseVisualStyleBackColor = false;
            this.reportb.Click += new System.EventHandler(this.reportb_Click);
            // 
            // selectInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.mainpage;
            this.Controls.Add(this.reportb);
            this.Controls.Add(this.serviceprovider);
            this.Controls.Add(this.operatorb);
            this.Controls.Add(this.adminb);
            this.Controls.Add(this.travelerb);
            this.Name = "selectInterface";
            this.Size = new System.Drawing.Size(959, 565);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button travelerb;
        private System.Windows.Forms.Button adminb;
        private System.Windows.Forms.Button operatorb;
        private System.Windows.Forms.Button serviceprovider;
        private System.Windows.Forms.Button reportb;
    }
}
