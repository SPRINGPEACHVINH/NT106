namespace TaskW1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        String option;
        int result;
        bool PerformedOp = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option == "+")
            {
                result = num1 + num2;
            }
            else if (option == "-")
            {
                result = num1 - num2;
            }
            else if (option == "x")
            {
                result = num1 * num2;
            }
            else if (option == "/")
            {
                result = num1 / num2;
            }
            else if (option == "%")
            {
                result = num1 % num2;
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0" || PerformedOp)
                txtTotal.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtTotal.Text.Contains("."))
                    txtTotal.Text += button.Text;
            }

            else
                txtTotal.Text += button.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
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
    }
}
