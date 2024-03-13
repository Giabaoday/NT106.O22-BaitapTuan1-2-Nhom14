using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button_click(object sender, EventArgs e)
        {
            currentCalculation += ((Button)sender).Text;
            textBox1.Text = currentCalculation;
        }

        private void equal_click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = new DataTable().Compute(currentCalculation, null).ToString();
                currentCalculation = textBox1.Text;
            }
            catch (Exception)
            {
                textBox1.Text = "0";
                currentCalculation = "";
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentCalculation = "";
        }

        private void entryclear_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1,1);

                textBox1.Text = currentCalculation;
            }
        }
        
    }
}
