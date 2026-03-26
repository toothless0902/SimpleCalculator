namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string currentOperator = "";
        bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }




        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (isOperatorClicked)
            {
                txtInputWindow.Text = "";
                isOperatorClicked = false;
            }
            if (txtInputWindow.Text == "0" || txtInputWindow.Text == "")
            {
                if (clickedButton.Text == "0") return;
                txtInputWindow.Text = "";
            }
            txtInputWindow.Text += clickedButton.Text;
            if (currentOperator == "")
            {
                txtOutputWindow.Text = txtInputWindow.Text;
            }
            else
            {
                txtOutputWindow.Text = firstNumber + " " + currentOperator + " " + txtInputWindow.Text;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputWindow.Text)) return;
            Button btn = (Button)sender;
            firstNumber = int.Parse(txtInputWindow.Text);
            currentOperator = btn.Text;
            txtOutputWindow.Text = firstNumber + " " + currentOperator;

            isOperatorClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputWindow.Text) || currentOperator == "") return;
            double secondNumber = double.Parse(txtInputWindow.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                    break;
            }
            txtInputWindow.Text = result.ToString();
            txtOutputWindow.Text = firstNumber + " " + currentOperator + " " + secondNumber + " = " + result.ToString();
            currentOperator = "";
            isOperatorClicked = true;
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtInputWindow.Text.Length > 0)
            {

                txtInputWindow.Text = txtInputWindow.Text.Substring(0, txtInputWindow.Text.Length - 1);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInputWindow.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputWindow.Text = "0";
            txtOutputWindow.Text = "";
            firstNumber = 0;
            currentOperator = "";
            isOperatorClicked = false;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtInputWindow.Text != "" && txtInputWindow.Text != "0")
            {
                double val = double.Parse(txtInputWindow.Text);
                val = val * -1;
                txtInputWindow.Text = val.ToString();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtInputWindow.Text = "0";
                isOperatorClicked = false;
            }
            if (!txtInputWindow.Text.Contains("."))
            {
                txtInputWindow.Text += ".";
            }
        }
    }
}
