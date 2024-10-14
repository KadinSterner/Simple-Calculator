namespace Calculator
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
            txtDisplay = new TextBox();
            btnN1 = new Button();
            btnN2 = new Button();
            btnN3 = new Button();
            btnN4 = new Button();
            btnN5 = new Button();
            btnN6 = new Button();
            btnN7 = new Button();
            btnN8 = new Button();
            btnN9 = new Button();
            btnN0 = new Button();
            btnEquals = new Button();
            btnDecimal = new Button();
            btnNegative = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnBackSpace = new Button();
            btcCE = new Button();
            btnFullClear = new Button();
            txtHistory = new TextBox();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Info;
            txtDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(542, 105);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnN1
            // 
            btnN1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN1.Location = new Point(12, 369);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(83, 76);
            btnN1.TabIndex = 1;
            btnN1.Text = "1";
            btnN1.UseVisualStyleBackColor = true;
            btnN1.Click += btnN1_Click;
            // 
            // btnN2
            // 
            btnN2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN2.Location = new Point(101, 369);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(83, 76);
            btnN2.TabIndex = 2;
            btnN2.Text = "2";
            btnN2.UseVisualStyleBackColor = true;
            btnN2.Click += btnN2_Click;
            // 
            // btnN3
            // 
            btnN3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN3.Location = new Point(190, 369);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(83, 76);
            btnN3.TabIndex = 3;
            btnN3.Text = "3";
            btnN3.UseVisualStyleBackColor = true;
            btnN3.Click += btnN3_Click;
            // 
            // btnN4
            // 
            btnN4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN4.Location = new Point(12, 287);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(83, 76);
            btnN4.TabIndex = 4;
            btnN4.Text = "4";
            btnN4.UseVisualStyleBackColor = true;
            btnN4.Click += btnN4_Click;
            // 
            // btnN5
            // 
            btnN5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN5.Location = new Point(101, 287);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(83, 76);
            btnN5.TabIndex = 5;
            btnN5.Text = "5";
            btnN5.UseVisualStyleBackColor = true;
            btnN5.Click += btnN5_Click;
            // 
            // btnN6
            // 
            btnN6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN6.Location = new Point(190, 287);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(83, 76);
            btnN6.TabIndex = 6;
            btnN6.Text = "6";
            btnN6.UseVisualStyleBackColor = true;
            btnN6.Click += btnN6_Click;
            // 
            // btnN7
            // 
            btnN7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN7.Location = new Point(12, 205);
            btnN7.Name = "btnN7";
            btnN7.Size = new Size(83, 76);
            btnN7.TabIndex = 7;
            btnN7.Text = "7";
            btnN7.UseVisualStyleBackColor = true;
            btnN7.Click += btnN7_Click;
            // 
            // btnN8
            // 
            btnN8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN8.Location = new Point(101, 205);
            btnN8.Name = "btnN8";
            btnN8.Size = new Size(83, 76);
            btnN8.TabIndex = 8;
            btnN8.Text = "8";
            btnN8.UseVisualStyleBackColor = true;
            btnN8.Click += btnN8_Click;
            // 
            // btnN9
            // 
            btnN9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN9.Location = new Point(190, 205);
            btnN9.Name = "btnN9";
            btnN9.Size = new Size(83, 76);
            btnN9.TabIndex = 9;
            btnN9.Text = "9";
            btnN9.UseVisualStyleBackColor = true;
            btnN9.Click += btnN9_Click;
            // 
            // btnN0
            // 
            btnN0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnN0.Location = new Point(101, 451);
            btnN0.Name = "btnN0";
            btnN0.Size = new Size(83, 76);
            btnN0.TabIndex = 10;
            btnN0.Text = "0";
            btnN0.UseVisualStyleBackColor = true;
            btnN0.Click += btnN0_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(279, 451);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(83, 76);
            btnEquals.TabIndex = 11;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(190, 451);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(83, 76);
            btnDecimal.TabIndex = 12;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnNegative
            // 
            btnNegative.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNegative.Location = new Point(12, 451);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(83, 76);
            btnNegative.TabIndex = 13;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(279, 123);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 76);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(190, 123);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(83, 76);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(101, 123);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(83, 76);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(12, 123);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(83, 76);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackSpace.Location = new Point(279, 205);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(83, 76);
            btnBackSpace.TabIndex = 18;
            btnBackSpace.Text = "Backspace";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btcCE
            // 
            btcCE.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btcCE.Location = new Point(279, 287);
            btcCE.Name = "btcCE";
            btcCE.Size = new Size(83, 76);
            btcCE.TabIndex = 19;
            btcCE.Text = "Clear Entry";
            btcCE.UseVisualStyleBackColor = true;
            btcCE.Click += btcCE_Click;
            // 
            // btnFullClear
            // 
            btnFullClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFullClear.Location = new Point(279, 369);
            btnFullClear.Name = "btnFullClear";
            btnFullClear.Size = new Size(83, 76);
            btnFullClear.TabIndex = 20;
            btnFullClear.Text = "Clear All";
            btnFullClear.UseVisualStyleBackColor = true;
            btnFullClear.Click += btnFullClear_Click;
            // 
            // txtHistory
            // 
            txtHistory.Location = new Point(368, 123);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(186, 401);
            txtHistory.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(566, 536);
            Controls.Add(txtHistory);
            Controls.Add(btnFullClear);
            Controls.Add(btcCE);
            Controls.Add(btnBackSpace);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnNegative);
            Controls.Add(btnDecimal);
            Controls.Add(btnEquals);
            Controls.Add(btnN0);
            Controls.Add(btnN9);
            Controls.Add(btnN8);
            Controls.Add(btnN7);
            Controls.Add(btnN6);
            Controls.Add(btnN5);
            Controls.Add(btnN4);
            Controls.Add(btnN3);
            Controls.Add(btnN2);
            Controls.Add(btnN1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnN1;
        private Button btnN2;
        private Button btnN3;
        private Button btnN4;
        private Button btnN5;
        private Button btnN6;
        private Button btnN7;
        private Button btnN8;
        private Button btnN9;
        private Button btnN0;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btnNegative;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnBackSpace;
        private Button btcCE;
        private Button btnFullClear;
        private TextBox txtHistory;
    }
}
