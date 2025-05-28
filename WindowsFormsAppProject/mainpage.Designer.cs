namespace WindowsFormsAppProject
{
    partial class mainpage
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
            this.loginb = new System.Windows.Forms.Button();
            this.Signupb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.loginb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginb.Location = new System.Drawing.Point(337, 350);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(122, 37);
            this.loginb.TabIndex = 19;
            this.loginb.Text = "Log In!";
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // Signupb
            // 
            this.Signupb.BackColor = System.Drawing.Color.Black;
            this.Signupb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.Signupb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.Signupb.Location = new System.Drawing.Point(497, 350);
            this.Signupb.Name = "Signupb";
            this.Signupb.Size = new System.Drawing.Size(119, 37);
            this.Signupb.TabIndex = 20;
            this.Signupb.Text = "Sign Up!";
            this.Signupb.UseVisualStyleBackColor = false;
            this.Signupb.Click += new System.EventHandler(this.Signupb_Click);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.mainpage;
            this.Controls.Add(this.Signupb);
            this.Controls.Add(this.loginb);
            this.Name = "mainpage";
            this.Size = new System.Drawing.Size(959, 565);
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Button Signupb;
    }
}
