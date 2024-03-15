using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_backward_Click_1(object sender, EventArgs e)
        {
            if (web_browser.CanGoBack)
            {
                web_browser.GoBack();
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {


            if (web_browser.CanGoForward)
            {
                web_browser.GoForward();
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    web_browser.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
