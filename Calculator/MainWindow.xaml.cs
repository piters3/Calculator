using System;
using System.ComponentModel;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string _result { get; set; }
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }

        public Real Calc { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public bool FirstOperation { get; set; }
        public string Sign { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Calc = new Real();
            FirstOperation = true;
            Sign = null;
            DataContext = this;
        }


        private void SetResult(string mark)
        {
            Result += mark;
            if (FirstOperation)
                First += mark;
            else
                Second += mark;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            SetResult("0");
        }

        private void BtnComma_Click(object sender, RoutedEventArgs e)
        {
            SetResult(",");
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            SetResult("1");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            SetResult("2");
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            SetResult("3");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            SetResult("4");
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            SetResult("5");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            SetResult("6");
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            SetResult("7");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            SetResult("8");
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            SetResult("9");
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            SetResult("-");
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            Result = "";
            switch (Sign)
            {
                case "+":
                    Result = Calc.Add(Convert.ToDouble(First), Convert.ToDouble(Second)).ToString();
                    break;
                case "-":
                    Result = Calc.Subtract(Convert.ToDouble(First), Convert.ToDouble(Second)).ToString();
                    break;
                case "x":
                    Result = Calc.Multiply(Convert.ToDouble(First), Convert.ToDouble(Second)).ToString();
                    break;
                case "/":
                    Result = Calc.Divide(Convert.ToDouble(First), Convert.ToDouble(Second)).ToString();
                    break;
            }
            First = Result;
            FirstOperation = true;
            Second = "";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Result!=null)
            {
                Result += "+";
                Sign = "+";
                FirstOperation = !FirstOperation;
            }
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (Result != null)
            {
                Result += "-";
                Sign = "-";
                FirstOperation = !FirstOperation;
            }
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (Result != null)
            {
                Result += "x";
                Sign = "x";
                FirstOperation = !FirstOperation;
            }
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (Result != null)
            {
                Result += "/";
                Sign = "/";
                FirstOperation = !FirstOperation;
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            Result = null;
            First = null;
            Second = null;
            Sign = null;
            FirstOperation = true;
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            Result = null;
            First = null;
            Second = null;
            Sign = null;
            FirstOperation = true;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (Result != null)
            {
                Result = Result.Substring(0, Result.Length - 1);
                if (FirstOperation)
                    First = Result;
                else
                    Second = Result;
            }
        }
    }
}
