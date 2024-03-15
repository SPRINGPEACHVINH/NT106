namespace File_explorer
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Label();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.btn_backward = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(178, 9);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(684, 37);
            this.txtPath.TabIndex = 1;
            // 
            // btn_path
            // 
            this.btn_path.AutoSize = true;
            this.btn_path.Location = new System.Drawing.Point(126, 13);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(46, 20);
            this.btn_path.TabIndex = 4;
            this.btn_path.Text = "Path:";
            // 
            // web_browser
            // 
            this.web_browser.Location = new System.Drawing.Point(12, 56);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(935, 474);
            this.web_browser.TabIndex = 5;
            // 
            // btn_backward
            // 
            this.btn_backward.Location = new System.Drawing.Point(12, 9);
            this.btn_backward.Name = "btn_backward";
            this.btn_backward.Size = new System.Drawing.Size(47, 41);
            this.btn_backward.TabIndex = 6;
            this.btn_backward.Text = "<<";
            this.btn_backward.UseVisualStyleBackColor = true;
            this.btn_backward.Click += new System.EventHandler(this.btn_backward_Click_1);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(65, 9);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(47, 41);
            this.btn_forward.TabIndex = 7;
            this.btn_forward.Text = ">>";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(868, 9);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(65, 41);
            this.btn_open.TabIndex = 8;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 542);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_backward);
            this.Controls.Add(this.web_browser);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label btn_path;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.Button btn_backward;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_open;
    }
}

