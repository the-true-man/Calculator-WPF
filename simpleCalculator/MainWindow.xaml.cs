using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace simpleCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttonNum;
        List<Button> buttonActions;
        List<Button> buttonAllActions;
        string num1; 
        string num2;
        string sign;
        bool isEqually = false;
        bool lastSymbolIsSign = true;
        bool valueNotEmpty = false;
        public MainWindow()
        {
            InitializeComponent();
            buttonNum = new List<Button>() { btn_0, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };
            buttonActions = new List<Button>() { btn_plus, btn_minus, btn_multiply, btn_div};
            buttonAllActions = new List<Button>() { btn_plus, btn_minus, btn_multiply, btn_div, btn_dot, btn_equally};
            foreach (Button button in buttonNum)
            {
                button.Click += inputNumber;
            }
            foreach (Button button in buttonActions)
            {
                button.Click += inputSign;
            }
            tb_expression.Text = "0";
        }
        public void inputNumber(object sender, RoutedEventArgs e)
        {
            if(tb_expression.Text == "Ошибка")
            {
                unlockActions();

            }
            Button button = (Button)sender;
            if (lastSymbolIsSign)
            {
                tb_expression.Text = "";
            }
            tb_expression.Text += button.Content;
            lastSymbolIsSign = false;
            isEqually = false;
        }
        
        public void inputSign(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            calcutale();
            sign = button.Content.ToString();
            num1 = tb_expression.Text;
            lb_history.Content = tb_expression.Text + sign;
            lastSymbolIsSign = true;
            isEqually = false;

        }
        public void calcutale()
        {
            
            if (lastSymbolIsSign)
            {
                return;
            }
            valueNotEmpty = true;
            if(sign == "+" && !isEqually)
            {
               plus(lb_history.Content.ToString().Substring(0, lb_history.Content.ToString().Length-1), tb_expression.Text);
            }
            else if(sign == "-" && !isEqually)
            {
                minus(lb_history.Content.ToString().Substring(0, lb_history.Content.ToString().Length - 1), tb_expression.Text);
            }
            else if (sign == "*" && !isEqually)
            {
                multiply(lb_history.Content.ToString().Substring(0, lb_history.Content.ToString().Length - 1), tb_expression.Text);
            }
            else if (sign == "/" && !isEqually)
            {
                div(lb_history.Content.ToString().Substring(0, lb_history.Content.ToString().Length - 1), tb_expression.Text);
            }
        }
        public void plus(string num1, string num2)
        {
            tb_expression.Text = Calculator.Sum(double.Parse(num1), double.Parse(num2)).ToString();
        }
        public void minus(string num1, string num2)
        {
            tb_expression.Text = Calculator.Sum(double.Parse(num1), double.Parse(num2)).ToString();
        }
        public void multiply(string num1, string num2)
        {
            tb_expression.Text = Calculator.Multiply(double.Parse(num1), double.Parse(num2)).ToString();
        }
        public void div(string num1, string num2)
        {
            if(num2 == "0")
            {
                lockActions();
                MessageBox.Show("Второе число равно 0");
                return;
            }
            tb_expression.Text =Calculator.Div(double.Parse(num1), double.Parse(num2)).ToString();
        }
        private void btn_ac_Click(object sender, RoutedEventArgs e)
        {
            lastSymbolIsSign =true;
            sign = null;
            tb_expression.Text = Calculator.Clear().ToString();
            lb_history.Content = "";
            isEqually = false;
            valueNotEmpty = false;
            unlockActions();
        }

        private void btn_equally_Click(object sender, RoutedEventArgs e)
        {
            if(!valueNotEmpty)
            {
                return;
            }
            valueNotEmpty = true;
            if (!isEqually)
            {
                if (lb_history.Content.ToString()[0] == '-')
                {
                    num1 = "-"+lb_history.Content.ToString().Substring(1).Split(Convert.ToChar(sign))[0];
                    num2 = tb_expression.Text;
                }
                else
                {
                    num1 = lb_history.Content.ToString().Split(Convert.ToChar(sign))[0];
                    num2 = tb_expression.Text;
                }
                
            }
            lb_history.Content = num1 + sign + num2 + "=";
            
            if (sign == "+")
            {
                plus(num1, num2);
            }
            else if (sign == "-")
            {
                minus(num1, num2);
            }
            else if (sign == "*")
            {
                multiply(num1, num2);
            }
            else if (sign == "/")
            {
                div(num1, num2);
            }
            num1 = tb_expression.Text;
            
            isEqually = true;
            if (tb_expression.Text.Contains("∞"))
            {
                lastSymbolIsSign = true;
                sign = null;
                tb_expression.Text = "0";
                lb_history.Content = "";
                isEqually = false;
                valueNotEmpty = false;
                unlockActions();
            }
        }

        
        public void lockActions()
        {
            tb_expression.Text = "Ошибка";
            foreach (Button btn in buttonAllActions)
            {
                btn.IsEnabled = false;
            }
            
        }
        public void unlockActions()
        {
            lastSymbolIsSign = true;
            sign = null;
            tb_expression.Text = "0";
            lb_history.Content = "";
            isEqually = false;
            valueNotEmpty = false;
            foreach (Button btn in buttonAllActions)
            {
                btn.IsEnabled = true;
                
            }

        }
        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (tb_expression.Text.Contains(','))
            {
                return;
            }
            lastSymbolIsSign = false;
            tb_expression.Text+= ",";
        }
    }
}
