using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string result = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            result+= button12.Text;
            ResultBox.Text= result;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result+= button11.Text;
            ResultBox.Text = result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result+= button10.Text;
            ResultBox.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result+= button5.Text;
            ResultBox.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result+= button6.Text;
            ResultBox.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result+= button7.Text;
            ResultBox.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result+= button1.Text;
            ResultBox.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result+= button2.Text;
            ResultBox.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result += button3.Text;
            ResultBox.Text = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result+= button13.Text;
            ResultBox.Text = result;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result+= button14.Text;
            ResultBox.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result+= button4.Text;
            ResultBox.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result+=button8.Text;
            ResultBox.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result+= button9.Text;
            ResultBox.Text = result;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result+= button16.Text;
            ResultBox.Text = result;
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            result = ResultBox.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var res = new DataTable().Compute(result, null);
            result = res.ToString();
            ResultBox.Text = result;
        }
    }
}