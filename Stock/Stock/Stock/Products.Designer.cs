namespace Stock
{
    partial class Products
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
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductStatusLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridViewProductCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeLabel.Location = new System.Drawing.Point(27, 38);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(113, 21);
            this.ProductCodeLabel.TabIndex = 0;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(291, 38);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(120, 21);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductStatusLabel
            // 
            this.ProductStatusLabel.AutoSize = true;
            this.ProductStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductStatusLabel.Location = new System.Drawing.Point(577, 38);
            this.ProductStatusLabel.Name = "ProductStatusLabel";
            this.ProductStatusLabel.Size = new System.Drawing.Size(57, 21);
            this.ProductStatusLabel.TabIndex = 2;
            this.ProductStatusLabel.Text = "Status";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.Location = new System.Drawing.Point(914, 58);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(86, 35);
            this.AddItemButton.TabIndex = 7;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteItemButton.Location = new System.Drawing.Point(765, 58);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(92, 35);
            this.DeleteItemButton.TabIndex = 6;
            this.DeleteItemButton.Text = "Delete";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Location = new System.Drawing.Point(31, 72);
            this.ProductCodeTextBox.Multiline = true;
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(211, 21);
            this.ProductCodeTextBox.TabIndex = 1;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(295, 72);
            this.ProductNameTextBox.Multiline = true;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(214, 21);
            this.ProductNameTextBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.StatusComboBox.Location = new System.Drawing.Point(556, 72);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridViewProductCodeColumn,
            this.GridViewProductNameColumn,
            this.GridViewStatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(31, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 262);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // GridViewProductCodeColumn
            // 
            this.GridViewProductCodeColumn.HeaderText = "Product Code";
            this.GridViewProductCodeColumn.Name = "GridViewProductCodeColumn";
            // 
            // GridViewProductNameColumn
            // 
            this.GridViewProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GridViewProductNameColumn.HeaderText = "Product Name";
            this.GridViewProductNameColumn.Name = "GridViewProductNameColumn";
            // 
            // GridViewStatusColumn
            // 
            this.GridViewStatusColumn.HeaderText = "Status";
            this.GridViewStatusColumn.Name = "GridViewStatusColumn";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 418);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.ProductStatusLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductCodeLabel);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductStatusLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridViewProductCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridViewProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridViewStatusColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}