namespace Project
{
    partial class tourCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tourCategories));
            this.dataGridCategories = new System.Windows.Forms.DataGridView();
            this.buttonLoadCategories = new System.Windows.Forms.Button();
            this.buttonAddCAtegory = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Label();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategories
            // 
            this.dataGridCategories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategories.Location = new System.Drawing.Point(291, 252);
            this.dataGridCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridCategories.Name = "dataGridCategories";
            this.dataGridCategories.RowHeadersWidth = 62;
            this.dataGridCategories.RowTemplate.Height = 28;
            this.dataGridCategories.Size = new System.Drawing.Size(418, 98);
            this.dataGridCategories.TabIndex = 0;
            this.dataGridCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategories_CellContentClick);
            // 
            // buttonLoadCategories
            // 
            this.buttonLoadCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonLoadCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLoadCategories.Location = new System.Drawing.Point(573, 353);
            this.buttonLoadCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadCategories.Name = "buttonLoadCategories";
            this.buttonLoadCategories.Size = new System.Drawing.Size(136, 29);
            this.buttonLoadCategories.TabIndex = 1;
            this.buttonLoadCategories.Text = "Load Categories";
            this.buttonLoadCategories.UseVisualStyleBackColor = false;
            this.buttonLoadCategories.Click += new System.EventHandler(this.buttonRegiteration_Click);
            // 
            // buttonAddCAtegory
            // 
            this.buttonAddCAtegory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonAddCAtegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddCAtegory.Location = new System.Drawing.Point(451, 353);
            this.buttonAddCAtegory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCAtegory.Name = "buttonAddCAtegory";
            this.buttonAddCAtegory.Size = new System.Drawing.Size(118, 29);
            this.buttonAddCAtegory.TabIndex = 2;
            this.buttonAddCAtegory.Text = "Add Category";
            this.buttonAddCAtegory.UseVisualStyleBackColor = false;
            this.buttonAddCAtegory.Click += new System.EventHandler(this.buttonAddCAtegory_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(312, 138);
            this.admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(379, 62);
            this.admin.TabIndex = 3;
            this.admin.Text = "TOUR CATEGORIES";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteCategory.Location = new System.Drawing.Point(315, 353);
            this.buttonDeleteCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(133, 29);
            this.buttonDeleteCategory.TabIndex = 4;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // tourCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.buttonAddCAtegory);
            this.Controls.Add(this.buttonLoadCategories);
            this.Controls.Add(this.dataGridCategories);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tourCategories";
            this.Size = new System.Drawing.Size(1000, 520);
            this.Load += new System.EventHandler(this.tourCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategories;
        private System.Windows.Forms.Button buttonLoadCategories;
        private System.Windows.Forms.Button buttonAddCAtegory;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button buttonDeleteCategory;
    }
}
