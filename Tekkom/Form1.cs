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
        String inputPostfix;
        String cekOperator;
        String[] stack;
        String[] quadruple;
        String operasi;
        String[] hQuad;
        int countTemp, Flag;
        int countStack;

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void proses_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputPostfix.Length; i++)
            {
                Flag = 0;
                for (int j = 0; j< cekOperator.Length; j++)
                {
                    if (inputPostfix[i] == cekOperator[j])
                    {
                        quadruple[2] = stack[countStack - 1];
                        quadruple[1] = cekOperator[j].ToString();
                        quadruple[0] = stack[countStack - 2];
                        Flag = j;
                        break;
                    }
                    else
                    {
                        Flag = -1;
                    }
                }
                if (Flag >=0)
                {
                    countTemp++;

                    if (cekOperator[Flag] == '+')
                    {
                        operasi = "ADD";
                    }
                    else if (cekOperator[Flag] == '-')
                    {
                        operasi = "SUB";
                    }
                    else if (cekOperator[Flag] == '*')
                    {
                        operasi = "MUL";
                    }
                    else if (cekOperator[Flag] == '/')
                    {
                        operasi = "DIV";
                    }
                    else if (cekOperator[Flag] == '%')
                    {
                        operasi = "MOD";
                    }
                    else if (cekOperator[Flag] == '>')
                    {
                        operasi = "GT";
                    }
                    else if (cekOperator[Flag] == '<')
                    {
                        operasi = "LT";
                    }
                    else if (cekOperator[Flag] == '=')
                    {
                        operasi = "MOV";
                    }

                    if (cekOperator[Flag] != '=')
                    {
                        hQuad[countTemp] = operasi + "   " + quadruple[0] + ", " + quadruple[2] + ", " + " temp" + countTemp;
                        stack[countStack - 1] = null;
                        stack[countStack - 2] = "temp" + countTemp;
                    }
                    else
                    {
                        hQuad[countTemp] = operasi + "   " + quadruple[2] + ",  ," + quadruple[0];
                        stack[countStack - 1] = null;
                    }
                    countStack--;
                }
                else
                {
                    stack[countStack] = inputPostfix[i].ToString();
                    countStack++;
                }
            }
            hasil.Text = "1. " + hQuad[1] + " \n" +
                               "2. " + hQuad[2] + " \n" +
                               "3. " + hQuad[3] + " \n" +
                               "4. " + hQuad[4] + " \n" +
                               "5. " + hQuad[5] + " \n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inputPostfix = "XABC-*DEF*+/=";
            inputPostfix = "XABC-*DE+/=";
            inputbox.Enabled = false;
            inputbox.Text = inputPostfix;
            cekOperator = "+-*/=%><";
            stack = new String[50];
            quadruple = new String[3];
            hQuad=new String[50];
            countTemp = 0;
            countStack = 0;
            Flag = 0;
        }
    }
}
