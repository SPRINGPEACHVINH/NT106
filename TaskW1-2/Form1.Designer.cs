using Microsoft.VisualBasic.Devices;

namespace TaskW1_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnequal = new Button();
            btn0 = new Button();
            btnNegate = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnminus = new Button();
            btnmultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btndel = new Button();
            btnEraseAll = new Button();
            btnMod = new Button();
            btnplus = new Button();
            txtTotal = new TextBox();
            btndivide = new Button();
            SuspendLayout();
            // 
            // btnequal
            // 
            btnequal.BackColor = Color.Goldenrod;
            btnequal.Font = new Font("Segoe UI", 12F);
            btnequal.Location = new Point(150, 318);
            btnequal.Margin = new Padding(2);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(131, 46);
            btnequal.TabIndex = 2;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = false;
            btnequal.Click += btnequal_Click;
            // 
            // btn0
            // 
            btn0.FlatAppearance.MouseDownBackColor = Color.Lime;
            btn0.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn0.Location = new Point(78, 318);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 46);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_num;
            // 
            // btnNegate
            // 
            btnNegate.BackColor = Color.Goldenrod;
            btnNegate.Location = new Point(9, 318);
            btnNegate.Margin = new Padding(2);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(63, 46);
            btnNegate.TabIndex = 7;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = false;
            btnNegate.Click += btn_func;
            // 
            // btn3
            // 
            btn3.Location = new Point(148, 266);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.RightToLeft = RightToLeft.No;
            btn3.Size = new Size(63, 46);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_num;
            // 
            // btn2
            // 
            btn2.Location = new Point(78, 266);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 46);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_num;
            // 
            // btn1
            // 
            btn1.Location = new Point(9, 266);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 46);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_num;
            // 
            // btn6
            // 
            btn6.Location = new Point(148, 210);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 46);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_num;
            // 
            // btn5
            // 
            btn5.Location = new Point(78, 210);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(63, 46);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_num;
            // 
            // btn4
            // 
            btn4.Location = new Point(9, 210);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 46);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_num;
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.Goldenrod;
            btnminus.Font = new Font("Segoe UI", 14F);
            btnminus.Location = new Point(220, 210);
            btnminus.Margin = new Padding(2);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(63, 46);
            btnminus.TabIndex = 14;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btn_func;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = Color.Goldenrod;
            btnmultiply.Font = new Font("Segoe UI", 7F);
            btnmultiply.Location = new Point(219, 158);
            btnmultiply.Margin = new Padding(2);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(63, 46);
            btnmultiply.TabIndex = 15;
            btnmultiply.Text = "X";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += btn_func;
            // 
            // btn9
            // 
            btn9.Location = new Point(148, 158);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 46);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_num;
            // 
            // btn8
            // 
            btn8.Location = new Point(78, 158);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 46);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_num;
            // 
            // btn7
            // 
            btn7.Location = new Point(9, 158);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 46);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_num;
            // 
            // btndel
            // 
            btndel.BackColor = Color.Goldenrod;
            btndel.Location = new Point(148, 106);
            btndel.Margin = new Padding(2);
            btndel.Name = "btndel";
            btndel.Size = new Size(63, 46);
            btndel.TabIndex = 20;
            btndel.Text = "DEL";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btnEraseAll
            // 
            btnEraseAll.BackColor = Color.Goldenrod;
            btnEraseAll.Location = new Point(78, 106);
            btnEraseAll.Margin = new Padding(2);
            btnEraseAll.Name = "btnEraseAll";
            btnEraseAll.Size = new Size(63, 46);
            btnEraseAll.TabIndex = 21;
            btnEraseAll.Text = "C";
            btnEraseAll.UseVisualStyleBackColor = false;
            btnEraseAll.Click += btnEraseAll_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.Goldenrod;
            btnMod.Location = new Point(9, 106);
            btnMod.Margin = new Padding(2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(63, 46);
            btnMod.TabIndex = 22;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btn_func;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.Goldenrod;
            btnplus.Font = new Font("Segoe UI", 12F);
            btnplus.Location = new Point(219, 266);
            btnplus.Margin = new Padding(2);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(63, 46);
            btnplus.TabIndex = 23;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btn_func;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.Location = new Point(9, 30);
            txtTotal.Margin = new Padding(2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(274, 60);
            txtTotal.TabIndex = 24;
            // 
            // btndivide
            // 
            btndivide.BackColor = Color.Goldenrod;
            btndivide.Location = new Point(220, 106);
            btndivide.Margin = new Padding(2);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(63, 46);
            btndivide.TabIndex = 16;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += btn_func;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(292, 369);
            Controls.Add(txtTotal);
            Controls.Add(btnplus);
            Controls.Add(btnMod);
            Controls.Add(btnEraseAll);
            Controls.Add(btndel);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btndivide);
            Controls.Add(btnmultiply);
            Controls.Add(btnminus);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnNegate);
            Controls.Add(btn0);
            Controls.Add(btnequal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnequal;
        private Button btn0;
        private Button btnNegate;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnminus;
        private Button btnmultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btndel;
        private Button btnEraseAll;
        private Button btnMod;
        private Button btnplus;
        private TextBox txtTotal;
        private Button btndivide;
    }
}
