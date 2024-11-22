namespace lab04_Sonny
{
    partial class Info
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dtgIn = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            descript = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            vcode = new DataGridViewTextBoxColumn();
            vendor = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgIn).BeginInit();
            SuspendLayout();
            // 
            // dtgIn
            // 
            dtgIn.BackgroundColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgIn.Columns.AddRange(new DataGridViewColumn[] { id, descript, price, vcode, vendor });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgIn.DefaultCellStyle = dataGridViewCellStyle5;
            dtgIn.Location = new Point(12, 12);
            dtgIn.Name = "dtgIn";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle6.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgIn.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgIn.RowHeadersVisible = false;
            dtgIn.Size = new Size(633, 226);
            dtgIn.TabIndex = 0;
            dtgIn.CellContentClick += dtgIn_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "p_code";
            id.HeaderText = "ID";
            id.Name = "id";
            id.Width = 90;
            // 
            // descript
            // 
            descript.DataPropertyName = "p_descript";
            descript.HeaderText = "DESCRIPTION";
            descript.Name = "descript";
            descript.Width = 200;
            // 
            // price
            // 
            price.DataPropertyName = "p_price";
            price.HeaderText = "PRICE";
            price.Name = "price";
            price.Width = 90;
            // 
            // vcode
            // 
            vcode.DataPropertyName = "v_code";
            vcode.HeaderText = "VENDOR CODE";
            vcode.Name = "vcode";
            vcode.Width = 90;
            // 
            // vendor
            // 
            vendor.DataPropertyName = "v_name";
            vendor.HeaderText = "VENDOR";
            vendor.Name = "vendor";
            vendor.Width = 160;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumPurple;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(195, 262);
            label1.Name = "label1";
            label1.Size = new Size(452, 21);
            label1.TabIndex = 1;
            label1.Text = "\"WARA MAN YAA HA EXTRA KO LANG INI KAY NAG ENJOY AKO\"";
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(684, 333);
            Controls.Add(label1);
            Controls.Add(dtgIn);
            Name = "Info";
            Text = "Info";
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)dtgIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgIn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn descript;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn vcode;
        private DataGridViewTextBoxColumn vendor;
        private Label label1;
    }
}