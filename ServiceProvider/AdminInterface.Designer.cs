namespace Project
{
    partial class AdminInterface
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonRegiteration = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(-2, -2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(93, 98);
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogo.Location = new System.Drawing.Point(91, 32);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(188, 45);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "TravelEase";
            this.labelLogo.Click += new System.EventHandler(this.labelLogo_Click);
            // 
            // buttonRegiteration
            // 
            this.buttonRegiteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonRegiteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRegiteration.Location = new System.Drawing.Point(292, 21);
            this.buttonRegiteration.Name = "buttonRegiteration";
            this.buttonRegiteration.Size = new System.Drawing.Size(193, 45);
            this.buttonRegiteration.TabIndex = 0;
            this.buttonRegiteration.Text = "User/Operator";
            this.buttonRegiteration.UseVisualStyleBackColor = false;
            this.buttonRegiteration.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategories.Location = new System.Drawing.Point(492, 21);
            this.buttonCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(164, 45);
            this.buttonCategories.TabIndex = 4;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalytics.Location = new System.Drawing.Point(664, 21);
            this.buttonAnalytics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(164, 45);
            this.buttonAnalytics.TabIndex = 5;
            this.buttonAnalytics.Text = "Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = false;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // buttonReview
            // 
            this.buttonReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReview.Location = new System.Drawing.Point(830, 21);
            this.buttonReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(164, 45);
            this.buttonReview.TabIndex = 6;
            this.buttonReview.Text = "Reviews";
            this.buttonReview.UseVisualStyleBackColor = false;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonReview);
            this.panel1.Controls.Add(this.buttonAnalytics);
            this.panel1.Controls.Add(this.buttonCategories);
            this.panel1.Controls.Add(this.buttonRegiteration);
            this.panel1.Controls.Add(this.labelLogo);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 98);
            this.panel1.TabIndex = 0;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.panel1);
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonRegiteration;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Panel panel1;
    }
}

