namespace lab04_Sonny
{
    partial class Update
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            txtdescript = new TextBox();
            txtstock = new TextBox();
            txtMinStock = new TextBox();
            txtvenCode = new TextBox();
            txtvenName = new TextBox();
            btnExit = new Button();
            label7 = new Label();
            label8 = new Label();
            txtprice = new TextBox();
            label9 = new Label();
            txtDiscount = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 163);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 106);
            label1.Name = "label1";
            label1.Size = new Size(30, 21);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 217);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 3;
            label3.Text = "Stocks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 274);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 4;
            label4.Text = "Mininmum Stocks:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 371);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 5;
            label5.Text = "Vendor Code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 429);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 6;
            label6.Text = "Vendor Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(37, 518);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 41);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(191, 106);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 21);
            txtId.TabIndex = 8;
            // 
            // txtdescript
            // 
            txtdescript.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescript.Location = new Point(191, 163);
            txtdescript.Multiline = true;
            txtdescript.Name = "txtdescript";
            txtdescript.Size = new Size(184, 21);
            txtdescript.TabIndex = 9;
            // 
            // txtstock
            // 
            txtstock.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstock.Location = new Point(191, 217);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(100, 21);
            txtstock.TabIndex = 10;
            // 
            // txtMinStock
            // 
            txtMinStock.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinStock.Location = new Point(191, 274);
            txtMinStock.Multiline = true;
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(100, 21);
            txtMinStock.TabIndex = 11;
            // 
            // txtvenCode
            // 
            txtvenCode.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvenCode.Location = new Point(191, 371);
            txtvenCode.Multiline = true;
            txtvenCode.Name = "txtvenCode";
            txtvenCode.Size = new Size(100, 21);
            txtvenCode.TabIndex = 12;
            // 
            // txtvenName
            // 
            txtvenName.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvenName.Location = new Point(191, 429);
            txtvenName.Multiline = true;
            txtvenName.Name = "txtvenName";
            txtvenName.Size = new Size(184, 21);
            txtvenName.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(314, 518);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 41);
            btnExit.TabIndex = 14;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 128, 0);
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(118, 48);
            label7.Name = "label7";
            label7.Size = new Size(138, 21);
            label7.TabIndex = 15;
            label7.Text = "UPDATE WINDOW";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 128);
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 321);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 16;
            label8.Text = "Price:";
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(93, 321);
            txtprice.Multiline = true;
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(86, 21);
            txtprice.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 255, 128);
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(191, 321);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 18;
            label9.Text = "Discount:";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(275, 321);
            txtDiscount.Multiline = true;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(86, 21);
            txtDiscount.TabIndex = 19;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(406, 633);
            Controls.Add(txtDiscount);
            Controls.Add(label9);
            Controls.Add(txtprice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(txtvenName);
            Controls.Add(txtvenCode);
            Controls.Add(txtMinStock);
            Controls.Add(txtstock);
            Controls.Add(txtdescript);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
        private TextBox txtId;
        private TextBox txtdescript;
        private TextBox txtstock;
        private TextBox txtMinStock;
        private TextBox txtvenCode;
        private TextBox txtvenName;
        private Button btnExit;
        private Label label7;
        private Label label8;
        private TextBox txtprice;
        private Label label9;
        private TextBox txtDiscount;
    }
}