namespace Project.AdminInterface
{
    partial class User_Operator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Operator));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridPending = new System.Windows.Forms.DataGridView();
            this.buttonload = new System.Windows.Forms.Button();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPending)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-22, -22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridPending
            // 
            this.dataGridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPending.Location = new System.Drawing.Point(167, 327);
            this.dataGridPending.Name = "dataGridPending";
            this.dataGridPending.RowHeadersWidth = 62;
            this.dataGridPending.RowTemplate.Height = 28;
            this.dataGridPending.Size = new System.Drawing.Size(622, 159);
            this.dataGridPending.TabIndex = 2;
            // 
            // buttonload
            // 
            this.buttonload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonload.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonload.Location = new System.Drawing.Point(629, 494);
            this.buttonload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(160, 45);
            this.buttonload.TabIndex = 10;
            this.buttonload.Text = "Load Pending";
            this.buttonload.UseVisualStyleBackColor = false;
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonApprove.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonApprove.Location = new System.Drawing.Point(498, 494);
            this.buttonApprove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(123, 45);
            this.buttonApprove.TabIndex = 11;
            this.buttonApprove.Text = "Approve\r\n";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.radioButtonUser.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonUser.Location = new System.Drawing.Point(167, 276);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(80, 31);
            this.radioButtonUser.TabIndex = 12;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = false;
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.radioButtonOperator.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonOperator.Location = new System.Drawing.Point(253, 276);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(175, 31);
            this.radioButtonOperator.TabIndex = 13;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Tour Operator";
            this.radioButtonOperator.UseVisualStyleBackColor = false;
            this.radioButtonOperator.CheckedChanged += new System.EventHandler(this.radioButtonOperator_CheckedChanged);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(180, 153);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(641, 91);
            this.admin.TabIndex = 14;
            this.admin.Text = "Approve Registerations";
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // User_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.admin);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.dataGridPending);
            this.Controls.Add(this.radioButton1);
            this.Name = "User_Operator";
            this.Size = new System.Drawing.Size(1001, 555);
            this.Load += new System.EventHandler(this.User_Operator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridPending;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.Label admin;
    }
}
