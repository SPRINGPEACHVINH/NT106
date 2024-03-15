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
            btndivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btndel = new Button();
            btnEraseAll = new Button();
            btnMod = new Button();
            btnplus = new Button();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnequal
            // 
            btnequal.Location = new Point(182, 397);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(164, 58);
            btnequal.TabIndex = 2;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // btn0
            // 
            btn0.FlatAppearance.MouseDownBackColor = Color.Lime;
            btn0.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn0.Location = new Point(97, 397);
            btn0.Name = "btn0";
            btn0.Size = new Size(79, 58);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_num;
            // 
            // btnNegate
            // 
            btnNegate.Location = new Point(11, 397);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(79, 58);
            btnNegate.TabIndex = 7;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = true;
            btnNegate.Click += btn_func;
            // 
            // btn3
            // 
            btn3.Location = new Point(181, 332);
            btn3.Name = "btn3";
            btn3.Size = new Size(79, 58);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_num;
            // 
            // btn2
            // 
            btn2.Location = new Point(97, 332);
            btn2.Name = "btn2";
            btn2.Size = new Size(79, 58);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_num;
            // 
            // btn1
            // 
            btn1.Location = new Point(11, 332);
            btn1.Name = "btn1";
            btn1.Size = new Size(79, 58);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_num;
            // 
            // btn6
            // 
            btn6.Location = new Point(181, 262);
            btn6.Name = "btn6";
            btn6.Size = new Size(79, 58);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_num;
            // 
            // btn5
            // 
            btn5.Location = new Point(97, 262);
            btn5.Name = "btn5";
            btn5.Size = new Size(79, 58);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_num;
            // 
            // btn4
            // 
            btn4.Location = new Point(11, 262);
            btn4.Name = "btn4";
            btn4.Size = new Size(79, 58);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_num;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(267, 262);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(79, 58);
            btnminus.TabIndex = 14;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btn_func;
            // 
            // btnmultiply
            // 
            btnmultiply.Location = new Point(267, 197);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(79, 58);
            btnmultiply.TabIndex = 15;
            btnmultiply.Text = "x";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btn_func;
            // 
            // btndivide
            // 
            btndivide.Location = new Point(267, 132);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(79, 58);
            btndivide.TabIndex = 16;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btn_func;
            // 
            // btn9
            // 
            btn9.Location = new Point(181, 197);
            btn9.Name = "btn9";
            btn9.Size = new Size(79, 58);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_num;
            // 
            // btn8
            // 
            btn8.Location = new Point(97, 197);
            btn8.Name = "btn8";
            btn8.Size = new Size(79, 58);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_num;
            // 
            // btn7
            // 
            btn7.Location = new Point(11, 197);
            btn7.Name = "btn7";
            btn7.Size = new Size(79, 58);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_num;
            // 
            // btndel
            // 
            btndel.Location = new Point(181, 132);
            btndel.Name = "btndel";
            btndel.Size = new Size(79, 58);
            btndel.TabIndex = 20;
            btndel.Text = "Del";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnEraseAll
            // 
            btnEraseAll.Location = new Point(97, 132);
            btnEraseAll.Name = "btnEraseAll";
            btnEraseAll.Size = new Size(79, 58);
            btnEraseAll.TabIndex = 21;
            btnEraseAll.Text = "C";
            btnEraseAll.UseVisualStyleBackColor = true;
            btnEraseAll.Click += btnEraseAll_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(11, 132);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(79, 58);
            btnMod.TabIndex = 22;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btn_func;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(267, 332);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(79, 58);
            btnplus.TabIndex = 23;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btn_func;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(11, 62);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(331, 46);
            txtTotal.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 467);
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
        private Button btndivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btndel;
        private Button btnEraseAll;
        private Button btnMod;
        private Button btnplus;
        private TextBox txtTotal;
    }
}
