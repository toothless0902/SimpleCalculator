namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
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
            int secondNumber = int.Parse(txtInputWindow.Text);
            int result = 0;
            if (currentOperator == "+")
            {
                result = firstNumber + secondNumber;
            }
            txtInputWindow.Text = result.ToString();
            txtOutputWindow.Text = firstNumber + " " + currentOperator + " " + secondNumber + " = " + result.ToString();
            currentOperator = "";
        }
    }
}
