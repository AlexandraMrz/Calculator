namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((textDisplay.Text == "0") || (enter_value))
                textDisplay.Text = "";
            enter_value = false;

            if (b.Text == ",")
            {
                if (!textDisplay.Text.Contains(","))
                    textDisplay.Text = textDisplay.Text + b.Text;
            }
            else
            {
                textDisplay.Text = textDisplay.Text + b.Text;
            }
        }

        private void basic_op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                results.Text = result + " " + operation;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                results.Text = System.Convert.ToString(result) + "  " + operation;

            }
            firstnum = results.Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            result = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secnum = textDisplay.Text;
            results.Text = "";
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = (result / Double.Parse(textDisplay.Text)).ToString();
                    break;

                default:
                    break;
            }
            result = Double.Parse(textDisplay.Text);
            operation = "";
            // **********************************
            btnClearHistory.Visible = true;
            DisplayHistory.AppendText(firstnum + " " + secnum + "=");
            DisplayHistory.AppendText(textDisplay.Text + "\n");
            lbHistoryDisplay.Text = "";

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            DisplayHistory.Clear();
            if (lbHistoryDisplay.Text == "")
            {
                lbHistoryDisplay.Text = "There's no history yet";
            }
            btnClearHistory.Visible = false;
            DisplayHistory.ScrollBars = 0;
        }

        private void button20_Click(object sender, EventArgs e) // sign 
        {
            if (textDisplay.Text.StartsWith("-"))
            {
                textDisplay.Text = textDisplay.Text.Substring(1);
            }
            else
                textDisplay.Text = "-" + textDisplay.Text;
        }
    }
}