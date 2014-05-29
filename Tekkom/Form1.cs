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
        bool isProcessing = false;
        int processedItem;

        int countTemp;
        
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
            if (postfix.Count <= 0)
                return;

            btnClearInput.Enabled = false;
            btnDefaultInput.Enabled = false;
            btnNextInput.Enabled = false;
            proses.Enabled = false;

            int stringLen = postfix.Count;
            int operatorLen = operators.Count;
            stack.Clear();
            countTemp = 0;
            processedItem = 0;
            isProcessing = true;

            btnNextProcess.Enabled = true;

            lblProcessed.Visible = true;
            txtProcessedIndex.Text = "";
            txtProcessedIndex.Visible = true;

            //for (int i = 0; i < stringLen; i++)
            //{
            //    Operator op = getOperator(postfix[i]);
            //    if (op == null)
            //    {
            //        // not operator
            //        stack.Add(postfix[i]);
            //    }
            //    else
            //    {
            //        // is operator
            //        Quadruple tmp;
            //        int lastIndex = stack.Count - 1;

            //        if (op.Type == 2)
            //        {
            //            String opr2 = stack[lastIndex];
            //            String opr1 = stack[lastIndex - 1];
            //            stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
            //            countTemp++;
            //            String res = "temp" + countTemp;
            //            tmp = new Quadruple(op.FName, opr1, opr2, res);
            //            stack.Add(res);
            //            quadruples.Add(tmp);
            //        }
            //        else
            //        {
            //            if (op.Name == "=")
            //            {
            //                String opr = stack[lastIndex];
            //                stack.RemoveAt(lastIndex);
            //                tmp = new Quadruple(op.FName, opr, "", stack[lastIndex - 1]);
            //                quadruples.Add(tmp);
            //            }
            //        }
            //    }
            //}

            //var source = new BindingSource();
            //source.DataSource = quadruples;

            //dataGridViewquadruples.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inputPostfix = "XABC-*DEF*+/=";
            //inputPostfix = "XABC-*DE+/=";
            
            //inputbox.Enabled = false;
            //inputbox.Visible = false;
            //inputbox.Text = inputPostfix;
            //cekOperator = "+-*/=%><";
            //stack = new String[50];
            //quadruple = new String[3];
            //hQuad=new String[50];
            //countTemp = 0;
            //countStack = 0;
            //Flag = 0;
            lblProcessed.Visible = false;
            //txtProcessedIndex.Text = "";
            txtProcessedIndex.Visible = false;
            dataGridViewInput.ReadOnly = true;
        }

        private void btnNextInput_Click(object sender, EventArgs e)
        {
            if (inputbox.Text != "")
            {
                postfix.Add(inputbox.Text);
                inputbox.Text = "";
                showInput();
            }
        }

        private void setInputToDefault()
        {
            postfix.Clear();
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
        }

        private void showInput()
        {
            int inputLen = postfix.Count;
            if (inputLen == 0)
            {
                dataGridViewInput.Visible = false;
                proses.Enabled = false;
                return;
            }
            else
            {
                dataGridViewInput.Visible = true;
                proses.Enabled = true;
            }
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            for (int i = 0; i < inputLen; i++)
            {
                DataColumn col = new DataColumn(Convert.ToString(i + 1));
                dt.Columns.Add(col);
                row[i] = postfix[i];
            }
            dt.Rows.Add(row);

            dataGridViewInput.DataSource = dt;

            if (postfix.Count > 3)
                dataGridViewInput.Height = 58;
            else
                dataGridViewInput.Height = 43;

            dataGridViewInput.ClearSelection();
        }

        private void btnDefaultInput_Click(object sender, EventArgs e)
        {
            setInputToDefault();
            showInput();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            postfix.Clear();
            showInput();
        }

        private void showStack()
        {
            int stackLen = stack.Count;
            DataTable dt = new DataTable();
            dt.Columns.Add();
            for (int i = 0; i < stackLen; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = stack[i];

                dt.Rows.Add(row);
            }
            dataGridViewStack.DataSource = dt;
            dataGridViewStack.ClearSelection();
        }

        private void showQuadruple()
        {
            var source = new BindingSource();
            source.DataSource = quadruples;

            dataGridViewquadruples.DataSource = source;
            dataGridViewquadruples.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewquadruples.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewquadruples.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewquadruples.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewquadruples.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewquadruples.ClearSelection();
        }

        private void btnNextProcess_Click(object sender, EventArgs e)
        {
            if (!isProcessing || processedItem >= postfix.Count)
            {
                btnNextProcess.Enabled = false;
                return;
            }

            Operator op = getOperator(postfix[processedItem]);
            if (op == null)
            {
                // not operator
                stack.Add(postfix[processedItem]);
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
                    tmp = new Quadruple(quadruples.Count + 1, op.FName, opr1, opr2, res);
                    stack.Add(res);
                    quadruples.Add(tmp);
                }
                else
                {
                    if (op.Name == "=")
                    {
                        String opr = stack[lastIndex];
                        stack.RemoveAt(lastIndex);
                        tmp = new Quadruple(quadruples.Count + 1, op.FName, opr, "", stack[lastIndex - 1]);
                        quadruples.Add(tmp);
                    }
                }
            }
            processedItem++;
            
            txtProcessedIndex.Text = Convert.ToString(processedItem);
            if (processedItem == postfix.Count)
            {
                stack.Clear();
                processedItem = 0;
                isProcessing = false;
                btnNextProcess.Enabled = false;
                btnClearInput.Enabled = true;
                btnDefaultInput.Enabled = true;
                btnNextInput.Enabled = true;
                proses.Enabled = false;

                lblProcessed.Visible = false;
                //txtProcessedIndex.Text = "";
                txtProcessedIndex.Visible = false;
            }
            showInput();
            showStack();
            showQuadruple();
            
        }

        private void dataGridViewInput_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < processedItem)
                e.CellStyle.BackColor = Color.Red;
        }
    }
}
