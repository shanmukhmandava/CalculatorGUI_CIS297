//SHANMUKH GOPINATH MANDAVA
// UMID:13136658
// CIS 297 - C SHARP
// GUI - CALCULATOR

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// GUI CALCULATOR
/// </summary>
namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        double result3 = 0.0;
        string spaceResult = string.Empty;


        public CalculatorGUIForm()
      {
         InitializeComponent();
      }


        /// <summary>
        /// MULTIPLICATION OPERATOR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }
        /// <summary>
        /// EQUALS OPERATOR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
           
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);


            ///<summary>
            /// PERFROMS ADD OPERATION
            /// </summary>
            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            ///<summary>
            /// PERFROMS SUBTRACTION OPERATION
            /// </summary>
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            ///<summary>
            /// PERFROMS MULTIPLICATION OPERATION
            /// </summary>
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            ///<summary>
            /// PERFROMS DIVISON OPERATION
            ///</summary>
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
            ///<summary>
            /// PERFROMS SQUARE ROOT OPERATION
            /// </summary>
            else if (operation == '√')
            {
                
                if(num1 != 0)
                {
                    result = Math.Sqrt(num1);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Zero!";
                }

            }
            ///<summary>
            /// PERFROMS MODULUS OPERATION
            /// </summary> 
            else if (operation == '%')
            {

                if (num1 != 0 && num2 !=0)
                {
                    double tempresult;
                    int num3;
                    tempresult = Math.DivRem((int)num1, (int)num2, out num3);
                    result = num3;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = num1 + " ";
                }

            }
            ///<summary>
            /// PERFROMS LOGARTHMIC TO BASE 10 OPERATION
            /// </summary>
            else if (operation == 'L')
            {

                if (num1 != 0)
                {
                    result = Math.Log10(num1); ;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Zero!";
                }

            }
            ///<summary>
            /// PERFROMS LOGARTHMICI OPERATION TO GIVEN NUMBER
            /// </summary>
            else if (operation == 'l')
            {

                if (num1 != 0)
                {
                    result = Math.Log(num1, num2);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Zero!";
                }

            }
            ///<summary>
            /// PERFROMS QUADRATIC EQUATION OPERATION AND GIVES ROOTS
            /// </summary>
            else if (operation == '!')
            {
                double result2 = 0.0;

                string operand3 = string.Empty;
                double num3;
                double.TryParse(operand3, out num3);
                
                double root1 = 0;
                double root2 = 0;
                double eq = 0;

                double c;
                double b;
                double a;

                c = num3;

                b = num2;

                a = num1;

                eq = b * b - 4 * a * c;

                if (a != 0)
                {
                    if (eq > 0)
                    {
                        root1 = (-b + Math.Sqrt(eq)) / (2 * a);
                        root2 = (-b - Math.Sqrt(eq)) / (2 * a);
                        result = root1;
                        result2 = root2;
                        textBox1.Text = result.ToString() + result2.ToString();

                    }
                    else if (eq == 0)
                    {
                        root1 = root2 = (-b) / (2 * a);
                        result = root1;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        root1 = (-b) / (2 * a);
                        root2 = Math.Sqrt(-eq) / (2 * a);
                        result = root1;
                        result2 = root2;
                        textBox1.Text = "root 1: "+ result.ToString() + "root 2: "+ result2.ToString();
                    }
                }
                else
                { 
                    textBox1.Text = "Not a Quadratic equation";
                }
                
            }
            ///<summary>
            /// PERFROMS POWER OPERATION
            /// </summary>
            else if (operation == '^')
            {

                if (num1 != 0)
                {
                    result = Math.Pow(num1, num2);
                    textBox1.Text = result.ToString();

                }
                else
                {
                    textBox1.Text = "Zero!";
                }

            }
            ///<summary>
            /// PERFROMS MIN AND MAX OPERATIONS - MIN FIRST AND MAX NEXT
            /// </summary>
            else if (operation == '@')
            {
      
                    double result = Math.Min(num1, num2);
                    double result3 = Math.Max(num1, num2);
                    textBox1.Text = "Min:"+result.ToString() + "Max:"+result3.ToString();

            }
            ///<summary>
            /// REMOVES WHITE SPACE FOR THE GIVEN TWO INPUTS
            /// </summary>
            //REMOVE WHITESPACE
            else if (operation == '$')
            {

                string trimmed = String.Concat(spaceResult.Where(c => !Char.IsWhiteSpace(c)));
                textBox1.Text = trimmed.ToString();
            }
            ///<summary>
            /// PERFROMS STRING REVERSE FOR ONE INPUT
            /// </summary>
            else if (operation == '#')
            {
                string revoStir = num1.ToString();
                
                textBox1.Text = Reverse(revoStir);
            }
            ///<summary>
            /// PERFROMS SPACE OPERATION : ADDS WHITE SPACE AFTER THE INPUT
            /// </summary>
            else if (operation == '_')
            {
    
               textBox1.Text = num1.ToString() + " " + num2.ToString();
               spaceResult = num1.ToString() + " " + num2.ToString();

            }
            
        }
        /// <summary>
        /// INPUTS DECIMAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            input += ".";
        }
        /// <summary>
        /// INPUTS ZERO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input+= 0;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS THREE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }
        /// <summary>
        ///  INPUTS TWO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS ONE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS SIX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS FIVE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS FOUR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS NINE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS EIGHT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS SEVEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }
        /// <summary>
        /// INPUTS MOD OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;

        }
        /// <summary>
        /// INPUTS DIVISION OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
        /// <summary>
        /// INPUTS LOG BASE 10 OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = 'L'; 
            input = string.Empty;
        }
        /// <summary>
        /// INPUTS LOGARTHAMIC OPERTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = 'l'; 
            input = string.Empty;
        }

        /// <summary>
        /// INPUTS SQUARE ROOT OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '√';
            input = string.Empty;
        }
        /// <summary>
        /// INPUTS QUAD ROOTS OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '!'; 
            input = string.Empty;
        }
        /// <summary>
        /// INPUTS POWER OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^'; 
            input = string.Empty;
        }
        /// <summary>
        /// CLEARS THE ENTIRE INPUTS AND OPERATIONS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   
        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
        /// <summary>
        /// DEFAULT TEXT BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // this.textBox1.Text = " PLEASE INPUT THE NUMBER THEN PRESS THE FUNCTION AND EQUAL SIGNS TO USE IT";
        }
        /// <summary>
        /// DEFAULT FORM LOADER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorGUIForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ADD OPERATOR
        /// TO ADD YOU MUST GIVE INPUT 1 AND PRESS + OPERATOR AND EQUAL SIGN FOR THE RESULT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operation = '+';
            input = string.Empty;

           
            
        }
        /// <summary>
        /// REMOVES WHITE SPACES
        /// TO REMOVE WHITE SPACES YOU MUST GIVE INPUT WITH SPACE AND PRESS THE -SPACE OPERATOR AND EQUAL SIGN FOR THE RESULT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button23_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '$'; 
            input = string.Empty;

        }
        /// <summary>
        /// INPUTS REVERSE THE STRING OPERATION 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operation = '#';
            input = string.Empty;


        }
        /// <summary>
        /// INPUTS MIN MAX OPERATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '@';
            input = string.Empty;
        }
        /// <summary>
        /// INPUTS SPACE IN BETWEEN INPUT NUM 1 AND NUM 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '_';
            input = string.Empty;

            
        }
        /// <summary>
        /// reverse string input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse(string revInput)
        {
            char[] charArray = revInput.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/