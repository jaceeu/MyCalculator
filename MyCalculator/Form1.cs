using System.Data;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;
            var result = new DataTable().Compute(equation, null);
            textBox1.Text = result.ToString();
        }
    }
}