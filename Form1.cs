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

        private void UpdateOutputWindow()
        {
            // 1. 만약 결과값까지 나온 상태(=이 포함된 상태)라면?
            if (txtOutputWindow.Text.Contains("="))
            {
                // "=" 기호 앞까지만 수식을 자르고, 그 뒤에 현재 수정 중인 숫자를 붙입니다.
                int equalIndex = txtOutputWindow.Text.IndexOf('=');
                string formula = txtOutputWindow.Text.Substring(0, equalIndex + 1);

                // 메인창이 "0"이면 "= "까지만 보여주고, 아니면 수정된 숫자를 붙여줌
                txtOutputWindow.Text = formula + " " + (txtInputWindow.Text == "0" ? "" : txtInputWindow.Text);
            }
            // 2. 연산자 선택 전이라면?
            else if (currentOperator == "")
            {
                txtOutputWindow.Text = txtInputWindow.Text;
            }
            // 3. 연산자 선택 후 입력 중이라면?
            else
            {
                string currentInput = (txtInputWindow.Text == "0") ? "" : txtInputWindow.Text;
                txtOutputWindow.Text = firstNumber + " " + currentOperator + " " + currentInput;
            }
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
            // 1. 이미 "0"이거나 비어있으면 무시
            if (txtInputWindow.Text == "0" || string.IsNullOrEmpty(txtInputWindow.Text)) return;

            // 2. [핵심] 한 글자만 지우기
            txtInputWindow.Text = txtInputWindow.Text.Substring(0, txtInputWindow.Text.Length - 1);

            // 3. 지웠는데 빈칸이면 "0"으로 세팅
            if (string.IsNullOrEmpty(txtInputWindow.Text))
            {
                txtInputWindow.Text = "0";
            }

            // 4. [요청하신 기능] 결과값이 나온 상태(=이 포함된 상태)에서 지울 때
            if (txtOutputWindow.Text.Contains("="))
            {
                // 보조창에서도 맨 뒤의 한 글자만 똑같이 지워줍니다.
                txtOutputWindow.Text = txtOutputWindow.Text.Substring(0, txtOutputWindow.Text.Length - 1);

                // 만약 메인창이 "0"이 되었다면, 보조창의 "=" 뒤를 깔끔하게 비워줍니다.
                if (txtInputWindow.Text == "0")
                {
                    int equalIndex = txtOutputWindow.Text.IndexOf('=');
                    txtOutputWindow.Text = txtOutputWindow.Text.Substring(0, equalIndex + 1) + " ";
                }
            }
            else
            {
                // 일반 입력 중일 때는 기존 동기화 함수 호출
                UpdateOutputWindow();
            }

            // 5. 지우기를 눌렀다는 건 수정을 하겠다는 뜻이므로 
            // 다음 숫자를 누를 때 화면이 싹 비워지지 않도록 플래그를 꺼줍니다.
            isOperatorClicked = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInputWindow.Text = "0";
            isOperatorClicked = false; // 지웠으니 이어서 칠 수 있게 상태 해제

            // [핵심] 보조창 실시간 동기화 호출
            UpdateOutputWindow();
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