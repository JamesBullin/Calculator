using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationsLibrary;

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

        public string _operation = string.Empty;

        public void DoCalculation()
        {
            decimal x = 0;
            try
            {
                x = decimal.Parse(Display);
            }
            catch (FormatException) { }

            decimal y = 0;

            if (Input == string.Empty)
            {
                return;
            }

            y = decimal.Parse(Input);

            decimal output = 0;

            switch (_operation)
            {
                case "":
                    output = (y == 0) ? x : y ;
                    break;

                case "Addition":
                    output = OperationsLibrary.Operations.Addition(x, y);
                    break;

                case "Subtraction":
                    output = OperationsLibrary.Operations.Subtraction(x, y);
                    break;

                case "Multiplication":
                    output = OperationsLibrary.Operations.Multiplication(x, y);
                    break;

                case "Division":
                    if (y == 0)
                    {
                        Display = "Math Error";
                        Input = string.Empty;
                        return;
                    }
                    output = OperationsLibrary.Operations.Division(x, y);
                    break;

                case "Power":
                    output = OperationsLibrary.Operations.Power(x, y);
                    break;

                case "Reciprocal":
                    output = OperationsLibrary.Operations.Division(1, y);
                    break;

                case "SquareRoot":
                    output = OperationsLibrary.Operations.Power(y, (decimal)0.5);
                    break;

                case "Modulus":
                    output = OperationsLibrary.Operations.Modulus(x, y);
                    break;

                default:
                    break;
            }

            Display = output.ToString();
            Input = string.Empty;

        }

        #region ActionButtons

        public void OperationInput(string operation)
        {
            DoCalculation();
            _operation = operation;
        }

        public void InstantOperation(string operation)
        {
            _operation = operation;

            // If the input is empty, treat the current display as the input
            if (Input == string.Empty)
            {
                Input = Display;
            }

            DoCalculation();
            _operation = "";
        }

        /*
        public void BtnEquals()
        {
            DoCalculation();
            _operation = "";
        }

        public void BtnAdd()
        {
            DoCalculation();
            _operation = "Addition";
        }

        public void BtnSubtract()
        {
            DoCalculation();
            _operation = "Subtraction";
        }

        public void BtnMultiply()
        {
            DoCalculation();
            _operation = "Multiplication";
        }

        public void BtnDivide()
        {
            DoCalculation();
            _operation = "Division";
        }

        public void BtnModulus()
        {
            DoCalculation();
            _operation = "Modulus";
        }
        */
        #endregion

        #region InputButtons

        public void NumberInput(string x)
        {
            Input += x;
        }

        public void BtnNegative()
        {
            Input = (Input != string.Empty && Input.Substring(0, 1) == "-") 
                ? Input.TrimStart('-') 
                : Input = "-" + Input;
        }
        public void BtnPoint()
        {
            Input += (Input == string.Empty || Input == "-") 
                ? "0." 
                : ".";
        }

        #endregion

        #region ClearButtons
        public void BtnClearHistory()
        {
            BtnClear();
            Display = "0";
            _operation = string.Empty;
        }
        public void BtnClear()
        {
            Input = string.Empty;

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
