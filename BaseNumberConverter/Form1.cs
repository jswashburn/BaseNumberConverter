using System;
using System.Drawing;
using BaseNumberConverter.Numbers;

namespace BaseNumberConverter
{
    public enum InputType
    {
        Decimal, Binary, Octal
    }

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        void buttonSubmit_Click(object sender, EventArgs e)
        {
            string userInput = textBox.Text;
            InputType numberInputType = (InputType)inputType.SelectedIndex;
            INumber number;

            try
            {
                switch (numberInputType)
                {
                    case InputType.Binary:
                        number = new BinaryNumber(userInput);
                        break;
                    case InputType.Decimal:
                        number = new DecimalNumber(userInput);
                        break;
                    case InputType.Octal:
                        number = new OctalNumber(userInput);
                        break;
                    default:
                        number = new DecimalNumber(userInput);
                        break;
                }
                DisplayConversions(number);
                labelError.Text = "Conversion Sucessful!";
                labelError.ForeColor = Color.Green;
            }
            catch (FormatException formatEx)
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = formatEx.Message;
            }
        }

        void DisplayConversions(INumber number)
        {
            labelResultBinary.Text = number.ToBinaryString();
            labelResultDecimal.Text = number.ToDecimalString();
            labelResultOctal.Text = number.ToOctalString();
        }
    }
}
