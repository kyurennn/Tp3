namespace _TP_MODUL3_103022400056
{
    public partial class Form1 : Form
    {
        int total = 0;
        string inputSementara = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "1";
            lblOutput.Text = inputSementara;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "2";
            lblOutput.Text = inputSementara;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "3";
            lblOutput.Text = inputSementara;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "4";
            lblOutput.Text = inputSementara;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "5";
            lblOutput.Text = inputSementara;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "6";
            lblOutput.Text = inputSementara;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "7";
            lblOutput.Text = inputSementara;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "8";
            lblOutput.Text = inputSementara;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "9";
            lblOutput.Text = inputSementara;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (inputSementara != "")
            {
                total = total + int.Parse(inputSementara);
                lblOutput.Text = total.ToString();
                inputSementara = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputSementara = inputSementara + "0";
            lblOutput.Text = inputSementara;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total = total + int.Parse(inputSementara);
            lblOutput.Text = total.ToString();

            total = 0;
            inputSementara = "";
        }
    }
}
