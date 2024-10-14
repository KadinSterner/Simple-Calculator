using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.result = 0; // Initialize result to 0 at first, then it can be modified
        }

        // All of the button functions to display onto the screen
        private void btnN1_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("1");
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("2");
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("3");
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("4");
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("5");
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("6");
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("7");
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("8");
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("9");
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(".");
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Replace("-", "");
            }
            else
            {
                string negative = txtDisplay.Text;
                negative = $"-{negative}";
                txtDisplay.Text = negative;
            }
        }

        // The operator buttons will put the number input into the queue and then also enque the operator as a string to be modified so that it doesn't try to
        // accidentally work on a operator as a number
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data.input.Enqueue(double.Parse(txtDisplay.Text));
            Data.input.Enqueue("+");
            txtDisplay.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Data.input.Enqueue(double.Parse(txtDisplay.Text));
            Data.input.Enqueue("-");
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Data.input.Enqueue(double.Parse(txtDisplay.Text));
            Data.input.Enqueue("*");
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Data.input.Enqueue(double.Parse(txtDisplay.Text));
            Data.input.Enqueue("/");
            txtDisplay.Clear();
        }

        // Backspace works on the input screen, not history
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }

        // Only clears the input screen
        private void btcCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Clears both the input screen and history
        private void btnFullClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtHistory.Clear();
        }

        // Performs the calculations
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Data.input.Enqueue(double.Parse(txtDisplay.Text)); // pulls the last number input into the queue
            // Checking if there was no input or if the input will try to operate a string as a number, which would throw exception
            if (Data.input.Count == 0 || Data.input.Peek().ToString() == "+" || Data.input.Peek().ToString() == "-" || Data.input.Peek().ToString() == "*" || Data.input.Peek().ToString() == "/")
            {
                MessageBox.Show("You must enter numbers to perform a calculation", "Error");
                txtDisplay.Clear();
                txtHistory.Clear();
                Data.result = 0;
            }
            StringBuilder sb = new StringBuilder(); // String builder to eventually add to the history box
            Data.result = Convert.ToDouble(Data.input.Dequeue()); // set result to the first number
            sb.Append(Data.result);
            
            // The operator will be stored as a seperate integer to be able to access the switch later
            if (Data.input.Peek().ToString() == "+")
            {
                Data.opSwitch = 1;
                Data.input.Dequeue();
                sb.Append(" + ");
            }
            else if (Data.input.Peek().ToString() == "-")
            {
                Data.opSwitch = 2;
                Data.input.Dequeue();
                sb.Append(" - ");
            }
            else if (Data.input.Peek().ToString() == "*")
            {
                Data.opSwitch = 3;
                Data.input.Dequeue();
                sb.Append(" * ");
            }
            else if (Data.input.Peek().ToString() == "/")
            {
                Data.opSwitch = 4;
                Data.input.Dequeue();
                sb.Append(" / ");
            }
            else
            {
                MessageBox.Show("There was a critical error, please try again");
                Data.result = 0;
                Data.input.Clear();
                txtDisplay.Clear();
            }

            Math doMath = new Math(); // math class initialization

            // Switch model performs the actual calculations
            switch (Data.opSwitch)
            {
                case 1:
                    sb.Append(Data.input.Peek());
                    doMath.Add();
                    sb.Append($" = {Data.result}\n");
                    break;
                case 2:
                    sb.Append(Data.input.Peek());
                    doMath.Subtract();
                    sb.Append($" = {Data.result}\n");
                    break;
                case 3:
                    sb.Append(Data.input.Peek());
                    doMath.Multiply();
                    sb.Append($" = {Data.result}\n");
                    break;
                case 4:
                    sb.Append(Data.input.Peek());
                    doMath.Divide();
                    sb.Append($" = {Data.result}\n");
                    break;
                default:
                    MessageBox.Show("Something went wrong, please try again");
                    return;
            }
            txtDisplay.Text = Data.result.ToString(); // Display result to screen
            txtHistory.AppendText($"\r\n {sb.ToString()}"); // Add the whole operation to the history box

        }
    }
}
