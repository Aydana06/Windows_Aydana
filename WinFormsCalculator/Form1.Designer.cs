namespace WinFormsCalculator
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
            txtResult = new TextBox();
            btnMS = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMinus = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMSub = new Button();
            btnMAdd = new Button();
            btnMC = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(12, 12);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(363, 86);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // btnMS
            // 
            btnMS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMS.Location = new Point(12, 164);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(117, 54);
            btnMS.TabIndex = 1;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(135, 164);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 54);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(258, 164);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(117, 54);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 224);
            btn1.Name = "btn1";
            btn1.Size = new Size(117, 54);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(135, 224);
            btn2.Name = "btn2";
            btn2.Size = new Size(117, 54);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(258, 224);
            btn3.Name = "btn3";
            btn3.Size = new Size(117, 54);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 284);
            btn4.Name = "btn4";
            btn4.Size = new Size(117, 54);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(135, 284);
            btn5.Name = "btn5";
            btn5.Size = new Size(117, 54);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(258, 284);
            btn6.Name = "btn6";
            btn6.Size = new Size(117, 54);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 344);
            btn7.Name = "btn7";
            btn7.Size = new Size(117, 54);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(135, 344);
            btn8.Name = "btn8";
            btn8.Size = new Size(117, 54);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(258, 344);
            btn9.Name = "btn9";
            btn9.Size = new Size(117, 54);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(12, 404);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(117, 54);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(135, 404);
            btn0.Name = "btn0";
            btn0.Size = new Size(117, 54);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(258, 404);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(117, 54);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMSub
            // 
            btnMSub.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMSub.Location = new Point(258, 104);
            btnMSub.Name = "btnMSub";
            btnMSub.Size = new Size(117, 54);
            btnMSub.TabIndex = 17;
            btnMSub.Text = "M-";
            btnMSub.UseVisualStyleBackColor = true;
            btnMSub.Click += btnMSub_Click;
            // 
            // btnMAdd
            // 
            btnMAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMAdd.Location = new Point(135, 104);
            btnMAdd.Name = "btnMAdd";
            btnMAdd.Size = new Size(117, 54);
            btnMAdd.TabIndex = 18;
            btnMAdd.Text = "M+";
            btnMAdd.UseVisualStyleBackColor = true;
            btnMAdd.Click += btnMAdd_Click;
            // 
            // btnMC
            // 
            btnMC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMC.Location = new Point(12, 104);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(117, 54);
            btnMC.TabIndex = 19;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(381, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 446);
            panel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 470);
            Controls.Add(panel1);
            Controls.Add(btnMC);
            Controls.Add(btnMAdd);
            Controls.Add(btnMSub);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btnMinus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnMS);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnMS;
        private Button btnClear;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMinus;
        private Button btn0;
        private Button btnPlus;
        private Button btnMSub;
        private Button btnMAdd;
        private Button btnMC;
        private Panel panel1;
    }
}
