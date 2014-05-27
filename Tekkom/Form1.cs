using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tekkom
{
    public partial class Form1 : Form
    {
        List<Operator> operators = new List<Operator>();
        List<String> postfix = new List<String>();
        List<String> stack = new List<String>();
        List<Quadruple> quadruples = new List<Quadruple>();
        String inputPostfix;
        String cekOperator;
        //String[] stack;
        String[] quadruple;
        String operasi;
        String[] hQuad;
        int countTemp, Flag;
        int countStack;

        public Form1()
        {
            operators.Add(new Operator("+", "ADD", 2));
            operators.Add(new Operator("-", "SUB", 2));
            operators.Add(new Operator("*", "MUL", 2));
            operators.Add(new Operator("/", "DIV", 2));
            operators.Add(new Operator("%", "MOD", 2));
            operators.Add(new Operator("<", "LT", 2));
            operators.Add(new Operator(">", "GT", 2));
            operators.Add(new Operator("=", "MOV", 1));
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private Operator getOperator(String token)
        {
            int operatorLen = operators.Count;
            for (int i = 0; i < operatorLen; i++)
            {
                if (token == operators[i].Name)
                    return operators[i];
            }

            return null;
        }

        private void proses_Click(object sender, EventArgs e)
        {
            int stringLen = postfix.Count;
            int operatorLen = operators.Count;
            stack.Clear();
            countTemp = 0;

            for (int i = 0; i < stringLen; i++)
            {
                Operator op = getOperator(postfix[i]);
                if (op == null)
                {
                    // not operator
                    stack.Add(postfix[i]);
                }
                else
                {
                    // is operator
                    Quadruple tmp;
                    int lastIndex = stack.Count - 1;

                    if (op.Type == 2)
                    {
                        String opr2 = stack[lastIndex];
                        String opr1 = stack[lastIndex - 1];
                        stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
                        countTemp++;
                        String res = "temp" + countTemp;
                        tmp = new Quadruple(op.FName, opr1, opr2, res);
                        stack.Add(res);
                        quadruples.Add(tmp);
                    }
                    else
                    {
                        if (op.Name == "=")
                        {
                            String opr = stack[lastIndex];
                            stack.RemoveAt(lastIndex);
                            tmp = new Quadruple(op.FName, opr, "", stack[lastIndex - 1]);
                            quadruples.Add(tmp);
                        }
                    }
                }
            }

            var source = new BindingSource();
            source.DataSource = quadruples;

            dataGridViewquadruples.DataSource = source;
            
            //for (int i = 0; i < stringLen; i++)
            //{
            //    Flag = 0;
            //    for (int j = 0; j < operatorLen; j++)
            //    {
            //        if (inputPostfix[i] == cekOperator[j])
            //        {
            //            quadruple[2] = stack[countStack - 1];
            //            quadruple[1] = cekOperator[j].ToString();
            //            quadruple[0] = stack[countStack - 2];
            //            Flag = j;
            //            break;
            //        }
            //        else
            //        {
            //            Flag = -1;
            //        }
            //    }
            //    if (Flag >= 0)
            //    {
            //        countTemp++;

            //        if (cekOperator[Flag] == '+')
            //        {
            //            operasi = "ADD";
            //        }
            //        else if (cekOperator[Flag] == '-')
            //        {
            //            operasi = "SUB";
            //        }
            //        else if (cekOperator[Flag] == '*')
            //        {
            //            operasi = "MUL";
            //        }
            //        else if (cekOperator[Flag] == '/')
            //        {
            //            operasi = "DIV";
            //        }
            //        else if (cekOperator[Flag] == '%')
            //        {
            //            operasi = "MOD";
            //        }
            //        else if (cekOperator[Flag] == '>')
            //        {
            //            operasi = "GT";
            //        }
            //        else if (cekOperator[Flag] == '<')
            //        {
            //            operasi = "LT";
            //        }
            //        else if (cekOperator[Flag] == '=')
            //        {
            //            operasi = "MOV";
            //        }

            //        if (cekOperator[Flag] != '=')
            //        {
            //            hQuad[countTemp] = operasi + "   " + quadruple[0] + ", " + quadruple[2] + ", " + " temp" + countTemp;
            //            stack[countStack - 1] = null;
            //            stack[countStack - 2] = "temp" + countTemp;
            //        }
            //        else
            //        {
            //            hQuad[countTemp] = operasi + "   " + quadruple[2] + ",  ," + quadruple[0];
            //            stack[countStack - 1] = null;
            //        }
            //        countStack--;
            //    }
            //    else
            //    {
            //        stack[countStack] = inputPostfix[i].ToString();
            //        countStack++;
            //    }
            //}
            //hasil.Text = "1. " + hQuad[1] + " \n" +
            //                   "2. " + hQuad[2] + " \n" +
            //                   "3. " + hQuad[3] + " \n" +
            //                   "4. " + hQuad[4] + " \n" +
            //                   "5. " + hQuad[5] + " \n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inputPostfix = "XABC-*DEF*+/=";
            //inputPostfix = "XABC-*DE+/=";
            postfix.Add("X");
            postfix.Add("A");
            postfix.Add("B");
            postfix.Add("C");
            postfix.Add("-");
            postfix.Add("*");
            postfix.Add("D");
            postfix.Add("E");
            postfix.Add("+");
            postfix.Add("/");
            postfix.Add("=");
            inputbox.Enabled = false;
            inputbox.Visible = false;
            //inputbox.Text = inputPostfix;
            //cekOperator = "+-*/=%><";
            //stack = new String[50];
            //quadruple = new String[3];
            //hQuad=new String[50];
            //countTemp = 0;
            //countStack = 0;
            //Flag = 0;
        }
    }
}
