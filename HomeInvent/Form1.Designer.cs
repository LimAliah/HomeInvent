namespace HomeInvent
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
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxLivingR = new ComboBox();
            cbxDecor = new ComboBox();
            cbxKitch = new ComboBox();
            cbxBathL = new ComboBox();
            lstItems = new ListBox();
            btnAdd = new Button();
            btnRem = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(4, -30);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 619);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Vineta BT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(58, 75);
            label5.Name = "label5";
            label5.Size = new Size(155, 26);
            label5.TabIndex = 0;
            label5.Text = "Archives";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(396, 41);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 1;
            label1.Text = "Living Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(396, 81);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 2;
            label2.Text = "Decorations:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(396, 123);
            label3.Name = "label3";
            label3.Size = new Size(177, 22);
            label3.TabIndex = 3;
            label3.Text = "Bathroom List:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(396, 170);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 4;
            label4.Text = "Kitchen:";
            // 
            // cbxLivingR
            // 
            cbxLivingR.AccessibleDescription = "txtcomboBox1";
            cbxLivingR.FormattingEnabled = true;
            cbxLivingR.Items.AddRange(new object[] { "Chouch", "Coffee Table", "Tables", "Chairs", "Flower Pot" });
            cbxLivingR.Location = new Point(555, 45);
            cbxLivingR.Name = "cbxLivingR";
            cbxLivingR.Size = new Size(121, 23);
            cbxLivingR.TabIndex = 5;
            // 
            // cbxDecor
            // 
            cbxDecor.FormattingEnabled = true;
            cbxDecor.Items.AddRange(new object[] { "Skeleton Decor", "Christmas Tree", "Christmas Lights", "Parol" });
            cbxDecor.Location = new Point(556, 80);
            cbxDecor.Name = "cbxDecor";
            cbxDecor.Size = new Size(121, 23);
            cbxDecor.TabIndex = 6;
            cbxDecor.SelectedIndexChanged += cbxDecor_SelectedIndexChanged;
            // 
            // cbxKitch
            // 
            cbxKitch.FormattingEnabled = true;
            cbxKitch.Items.AddRange(new object[] { "Cabinets", "Sink", "Refrigerator", "Table", "Chairs" });
            cbxKitch.Location = new Point(531, 169);
            cbxKitch.Name = "cbxKitch";
            cbxKitch.Size = new Size(121, 23);
            cbxKitch.TabIndex = 8;
            // 
            // cbxBathL
            // 
            cbxBathL.FormattingEnabled = true;
            cbxBathL.Items.AddRange(new object[] { "Toilet", "Toiletrees", "Sink", "Bathtub", "Mirror", "Cabinet" });
            cbxBathL.Location = new Point(579, 125);
            cbxBathL.Name = "cbxBathL";
            cbxBathL.Size = new Size(121, 23);
            cbxBathL.TabIndex = 7;
            // 
            // lstItems
            // 
            lstItems.AccessibleDescription = "Items List";
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(771, 45);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(264, 184);
            lstItems.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(531, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 47);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add List";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnRem
            // 
            btnRem.BackColor = Color.Black;
            btnRem.ForeColor = Color.IndianRed;
            btnRem.Location = new Point(531, 262);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(100, 47);
            btnRem.TabIndex = 11;
            btnRem.Text = "Remove List";
            btnRem.UseVisualStyleBackColor = false;
            btnRem.Click += btnRem_Click;
            // 
            // Form1
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1088, 590);
            Controls.Add(btnRem);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Controls.Add(cbxKitch);
            Controls.Add(cbxBathL);
            Controls.Add(cbxDecor);
            Controls.Add(cbxLivingR);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxLivingR;
        private ComboBox cbxDecor;
        private ComboBox cbxKitch;
        private ComboBox cbxBathL;
        private ListBox lstItems;
        private Button btnAdd;
        private Button btnRem;
        private Label label5;
    }
}
