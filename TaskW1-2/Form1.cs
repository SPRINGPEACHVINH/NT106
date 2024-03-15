namespace TaskW1_2
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String funcPerformed = "";
        bool isFuncPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num(object sender, EventArgs e)
        {
            if (isFuncPerformed)
            {

            }
            isFuncPerformed = false;
            Button btn = (Button)sender;
            txtTotal.Text = txtTotal.Text + btn.Text;

        }

        private void btn_func(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(result != 0)
            {
                btnequal.PerformClick();
                funcPerformed = btn.Text;
                result = Double.Parse(txtTotal.Text);
                isFuncPerformed = true;
                txtTotal.Text = "";
            }
            else
            {
                funcPerformed = btn.Text;
                result = Double.Parse(txtTotal.Text);
                isFuncPerformed = true;
                txtTotal.Text = "";
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
        }

        private void btnEraseAll_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            result = 0;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (funcPerformed == "+")
            {
                txtTotal.Text = (result + Double.Parse(txtTotal.Text)).ToString();
            }
            else if (funcPerformed == "-")
            {
                txtTotal.Text = (result - Double.Parse(txtTotal.Text)).ToString();
            }
            else if (funcPerformed == "x")
            {
                txtTotal.Text = (result * Double.Parse(txtTotal.Text)).ToString();
            }
            else if (funcPerformed == "/")
            {
                txtTotal.Text = (result / Double.Parse(txtTotal.Text)).ToString();
            }
            else if (funcPerformed == "%")
            {
                txtTotal.Text = (result % Double.Parse(txtTotal.Text)).ToString();
            }
            else if (funcPerformed == "+/-")
            {
                txtTotal.Text = (result * -1).ToString();
            }
            result = Double.Parse(txtTotal.Text);
        }
    }
}
