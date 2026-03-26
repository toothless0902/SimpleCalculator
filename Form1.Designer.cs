namespace SimpleCalculator
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
            txtOutputWindow = new TextBox();
            txtInputWindow = new TextBox();
            lblTitle = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnAdd = new Button();
            btnPlusMinus = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtOutputWindow
            // 
            txtOutputWindow.Font = new Font("맑은 고딕", 10.125F);
            txtOutputWindow.Location = new Point(100, 58);
            txtOutputWindow.Name = "txtOutputWindow";
            txtOutputWindow.Size = new Size(521, 43);
            txtOutputWindow.TabIndex = 0;
            txtOutputWindow.TextChanged += textBox1_TextChanged;
            // 
            // txtInputWindow
            // 
            txtInputWindow.Font = new Font("맑은 고딕", 10.125F);
            txtInputWindow.Location = new Point(100, 107);
            txtInputWindow.Name = "txtInputWindow";
            txtInputWindow.Size = new Size(521, 43);
            txtInputWindow.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(183, -9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(514, 64);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Simple Calculator";
            // 
            // btnCE
            // 
            btnCE.Location = new Point(100, 166);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(120, 50);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(226, 166);
            btnC.Name = "btnC";
            btnC.Size = new Size(120, 50);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(365, 166);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(120, 50);
            btnDel.TabIndex = 5;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(501, 166);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(120, 50);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(100, 222);
            btn7.Name = "btn7";
            btn7.Size = new Size(120, 50);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(226, 222);
            btn8.Name = "btn8";
            btn8.Size = new Size(120, 50);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(365, 222);
            btn9.Name = "btn9";
            btn9.Size = new Size(120, 50);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.ForeColor = Color.Red;
            btnMul.Location = new Point(501, 222);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(120, 50);
            btnMul.TabIndex = 10;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(100, 278);
            btn4.Name = "btn4";
            btn4.Size = new Size(120, 50);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(226, 278);
            btn5.Name = "btn5";
            btn5.Size = new Size(120, 50);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(365, 278);
            btn6.Name = "btn6";
            btn6.Size = new Size(120, 50);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.ForeColor = Color.Red;
            btnSub.Location = new Point(501, 278);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(120, 50);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(100, 334);
            btn3.Name = "btn3";
            btn3.Size = new Size(120, 50);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(226, 332);
            btn2.Name = "btn2";
            btn2.Size = new Size(120, 50);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(365, 332);
            btn1.Name = "btn1";
            btn1.Size = new Size(120, 50);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(501, 334);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Location = new Point(100, 388);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(120, 50);
            btnPlusMinus.TabIndex = 19;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(226, 388);
            btn0.Name = "btn0";
            btn0.Size = new Size(120, 50);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(365, 388);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(120, 50);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(501, 388);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(120, 50);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnAdd);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblTitle);
            Controls.Add(txtInputWindow);
            Controls.Add(txtOutputWindow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutputWindow;
        private TextBox txtInputWindow;
        private Label lblTitle;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnAdd;
        private Button btnPlusMinus;
        private Button btn0;
        private Button btnDot;
        private Button btnEqual;
    }
}
