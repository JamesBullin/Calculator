using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    class ShellViewModel : Screen
    {
        private string _input = string.Empty;
        public string Input
        {
            get { return _input; }
            set
            {
                _input  = value;
                NotifyOfPropertyChange(() => Input);
            }
        }
        
        private string _display = "0";
        public string Display
        {
            get { return _display; }
            set
            {
                _display = value;
                NotifyOfPropertyChange(() => Display);
            }
        }

        public string _lastOperation = string.Empty;

        public void DoCalculation()
        {
            decimal x = decimal.Parse(Display);
            decimal y = 0;

            if (Input != string.Empty)
            {
                y = decimal.Parse(Input);
            }

            decimal output = 0;

            switch (_lastOperation)
            {
                case "":
                    output = (y == 0) ? x : y ;
                    break;

                case "Addition":
                    output = x + y;
                    break;

                case "Subtraction":
                    output = x - y;
                    break;

                case "Multiplication":
                    output = x * y;
                    break;

                case "Division":
                    output = x / y;
                    break;

                default:
                    Display = Input;
                    break;
            }

            Display = output.ToString();
            Input = string.Empty;

        }

        #region ActionButtons

        public void BtnEquals()
        {
            DoCalculation();
            _lastOperation = "";
        }

        public void BtnAdd()
        {
            DoCalculation();
            _lastOperation = "Addition";
        }

        public void BtnSubtract()
        {
            DoCalculation();
            _lastOperation = "Subtraction";
        }

        public void BtnMultiply()
        {
            DoCalculation();
            _lastOperation = "Multiplication";
        }

        public void BtnDivide()
        {
            DoCalculation();
            _lastOperation = "Division";
        }

        #endregion

        #region InputButtons

        public void Btn0()
        {
            Input += "0";
        }
        public void Btn1()
        {
            Input += "1";
        }
        public void Btn2()
        {
            Input += "2";
        }
        public void Btn3()
        {
            Input += "3";
        }
        public void Btn4()
        {
            Input += "4";
        }
        public void Btn5()
        {
            Input += "5";
        }
        public void Btn6()
        {
            Input += "6";
        }
        public void Btn7()
        {
            Input += "7";
        }
        public void Btn8()
        {
            Input += "8";
        }
        public void Btn9()
        {
            Input += "9";
        }

        public void BtnNegative()
        {
            Input = (Input != string.Empty && Input.Substring(0, 1) == "-") ? Input.TrimStart('-') : Input = "-" + Input;
        }
        public void BtnPoint()
        {
            Input += (Input == string.Empty || Input == "-") ? "0." : ".";
        }

        #endregion

        #region ClearButtons
        public void BtnClearHistory()
        {
            BtnClear();
        }
        public void BtnClear()
        {
            Input = string.Empty;
            Display = "0";
            _lastOperation = string.Empty;
        }
        public void BtnDelete()
        {
            int length = Input.Length;

            if (length > 0)
            {
                Input = Input.Remove(length - 1);
            }
        }

        #endregion
    }
}
