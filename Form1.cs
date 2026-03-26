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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
