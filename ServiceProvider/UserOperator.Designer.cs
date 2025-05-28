namespace Project
{
    partial class UserOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperator));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.buttonReject = new System.Windows.Forms.Button();
            this.Registeration = new System.Windows.Forms.Label();
            this.buttonApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(681, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(740, 574);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(339, 48);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load Pending Registerations";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.radioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonUser.Location = new System.Drawing.Point(793, 356);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(89, 33);
            this.radioButtonUser.TabIndex = 6;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = false;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.radioButtonOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonOperator.Location = new System.Drawing.Point(888, 356);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(191, 33);
            this.radioButtonOperator.TabIndex = 7;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Tour Operator";
            this.radioButtonOperator.UseVisualStyleBackColor = false;
            this.radioButtonOperator.CheckedChanged += new System.EventHandler(this.radioButtonOperator_CheckedChanged);
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(536, 341);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(128, 48);
            this.buttonReject.TabIndex = 9;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // Registeration
            // 
            this.Registeration.AutoSize = true;
            this.Registeration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registeration.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registeration.Location = new System.Drawing.Point(275, 178);
            this.Registeration.Name = "Registeration";
            this.Registeration.Size = new System.Drawing.Size(950, 91);
            this.Registeration.TabIndex = 10;
            this.Registeration.Text = "USER/OPERATOR MANAGEMENT";
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.Location = new System.Drawing.Point(398, 341);
            this.buttonApprove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(130, 48);
            this.buttonApprove.TabIndex = 8;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // UserOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Registeration);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserOperator";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.UserOperator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Label Registeration;
        private System.Windows.Forms.Button buttonApprove;
    }
}
