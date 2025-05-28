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
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
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
            // rolecombo
            // 
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Items.AddRange(new object[] {"Traveler", "Operator"});
            this.rolecombo.Location = new System.Drawing.Point(430, 415);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(120, 28);
            this.rolecombo.TabIndex = 21;
            this.rolecombo.SelectedIndex = -1;
            this.rolecombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.labelRole.Location = new System.Drawing.Point(320, 415);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(110, 19);
            this.labelRole.TabIndex = 22;
            this.labelRole.Text = "Logged in as:";
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.mainpage;
            this.Controls.Add(this.rolecombo);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.Signupb);
            this.Controls.Add(this.loginb);
            this.Name = "mainpage";
            this.Size = new System.Drawing.Size(959, 565);
            this.ResumeLayout(false);


            // Update the BackgroundImage assignment to reference an existing resource in the Resources class.  
            // Since 'mainpage' is not defined in the Resources class, replace it with a valid resource name.  
            // Based on the provided type signatures, valid options include 'back', 'back2', 'back3', or 'Screenshot_2025_05_05_113850'.  
            // Here, I will use 'back' as an example.  

            //this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.mainpage;
        }

        #endregion

        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Button Signupb;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Label labelRole;
    }
}
