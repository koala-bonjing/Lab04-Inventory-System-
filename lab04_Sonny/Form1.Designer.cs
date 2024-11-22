namespace lab04_Sonny
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            button5 = new Button();
            dtgOutput = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Vendor = new DataGridViewTextBoxColumn();
            btnReload = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dtgOutput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "lblsearch";
            label1.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.AccessibleName = "";
            txtSearch.Location = new Point(83, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(173, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(262, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 45);
            btnSearch.TabIndex = 2;
            toolTip1.SetToolTip(btnSearch, "Click to Search");
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(108, 318);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(189, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(438, 332);
            button5.Name = "button5";
            button5.Size = new Size(60, 35);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // dtgOutput
            // 
            dtgOutput.BackgroundColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOutput.Columns.AddRange(new DataGridViewColumn[] { Id, Description, Price, Vendor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgOutput.DefaultCellStyle = dataGridViewCellStyle2;
            dtgOutput.EnableHeadersVisualStyles = false;
            dtgOutput.Location = new Point(27, 82);
            dtgOutput.Name = "dtgOutput";
            dtgOutput.RowHeadersVisible = false;
            dtgOutput.Size = new Size(530, 206);
            dtgOutput.TabIndex = 7;
            // 
            // Id
            // 
            Id.DataPropertyName = "p_code";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Width = 70;
            // 
            // Description
            // 
            Description.DataPropertyName = "p_descript";
            Description.HeaderText = "DESCRIPTION";
            Description.Name = "Description";
            Description.Width = 200;
            // 
            // Price
            // 
            Price.DataPropertyName = "p_price";
            Price.HeaderText = "PRICE";
            Price.Name = "Price";
            Price.Width = 90;
            // 
            // Vendor
            // 
            Vendor.DataPropertyName = "v_name";
            Vendor.HeaderText = "VENDOR";
            Vendor.Name = "Vendor";
            Vendor.Width = 170;
            // 
            // btnReload
            // 
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.Location = new Point(310, 13);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(42, 45);
            btnReload.TabIndex = 8;
            toolTip1.SetToolTip(btnReload, "Click to Refresh the Data");
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 5000;
            toolTip1.AutoPopDelay = 1000;
            toolTip1.BackColor = Color.FromArgb(255, 255, 128);
            toolTip1.ForeColor = Color.FromArgb(255, 128, 128);
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 13, 95);
            ClientSize = new Size(589, 379);
            Controls.Add(btnReload);
            Controls.Add(dtgOutput);
            Controls.Add(button5);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Inventory System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button button5;
        private DataGridView dtgOutput;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Vendor;
        private Button btnReload;
        private ToolTip toolTip1;
    }
}
