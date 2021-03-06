﻿using System;
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
        FormIntroduction intro;
        FormProcess process;

        List<Operator> operators = new List<Operator>();
        List<Postfix> postfix = new List<Postfix>();
        List<String> stack = new List<String>();
        List<Quadruple> quadruples = new List<Quadruple>();
        List<String> quadText = new List<String>();
        List<String> tacText = new List<String>();
        bool isProcessing = false;
        bool isFileProcessing = false;
        int processedItem;

        int countTemp;
        
        public Form1()
        {
            operators = new Operator().GenerateOperator();
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private Operator getOperator(Postfix token)
        {
            int operatorLen = operators.Count;
            for (int i = 0; i < operatorLen; i++)
            {
                if (token.item == operators[i].Name)
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
            btnProcessToFile.Enabled = false;

            int stringLen = postfix.Count;
            int operatorLen = operators.Count;
            stack.Clear();
            quadruples.Clear();
            countTemp = 0;
            processedItem = 0;
            isProcessing = true;

            dataGridViewStack.DataSource = null;
            dataGridViewquadruples.DataSource = null;

            btnNextProcess.Enabled = true;

            lblStackOutput.Text = "";
            lblProcessed.Visible = true;
            txtProcessedIndex.Text = "";
            txtProcessedIndex.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblProcessed.Visible = false;
            txtProcessedIndex.Visible = false;
            dataGridViewInput.ReadOnly = true;
            lblStackOutput.Text = "";
        }

        private void btnNextInput_Click(object sender, EventArgs e)
        {
            if (inputbox.Text != "")
            {
                postfix.Add(new Postfix(inputbox.Text));
                inputbox.Text = "";
                showInput();
            }
            inputbox.Focus();
        }

        private void setInputToDefault()
        {
            postfix = new Postfix().defaultPostfix();
        }

        private void showInput()
        {
            int inputLen = postfix.Count;
            if (inputLen == 0)
            {
                dataGridViewInput.Visible = false;
                proses.Enabled = false;
                btnProcessToFile.Enabled = false;
                return;
            }
            else
            {
                dataGridViewInput.Visible = true;
                proses.Enabled = true;
                btnProcessToFile.Enabled = true;
            }
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();

            for (int i = 0; i < inputLen; i++)
            {
                DataColumn col = new DataColumn(Convert.ToString(i + 1));
                dt.Columns.Add(col);
                row[i] = postfix[i].item;
            }
            dt.Rows.Add(row);

            dataGridViewInput.DataSource = dt;

            //if (postfix.Count > 3)
            //    dataGridViewInput.Height = 58;
            //else
            //    dataGridViewInput.Height = 43;

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
            dataGridViewStack.Columns[0].Width = 199;
            dataGridViewStack.ClearSelection();
        }

        private void showQuadruple()
        {
            var source = new BindingSource();
            source.DataSource = quadruples;

            dataGridViewquadruples.DataSource = source;
            dataGridViewquadruples.Columns[0].Width = 30;
            dataGridViewquadruples.Columns[1].Width = 60;
            dataGridViewquadruples.Columns[2].Width = 100;
            dataGridViewquadruples.Columns[3].Width = 100;
            dataGridViewquadruples.Columns[4].Width = 59;
            dataGridViewquadruples.ClearSelection();
        }

        private bool processOneStep()
        {
            if (!isProcessing || processedItem >= postfix.Count)
            {
                btnNextProcess.Enabled = false;
                return false;
            }

            Operator op;
            try
            {
                op = getOperator(postfix[processedItem]);

                if (op == null)
                {
                    // not operator
                    stack.Add(postfix[processedItem].item);
                }
                else
                {
                    // is operator
                    Quadruple tmp;
                    int lastIndex = stack.Count - 1;

                    if (op.Type == 2)
                    {
                        // a op b
                        String opr2 = stack[lastIndex];
                        String opr1 = stack[lastIndex - 1];
                        stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
                        countTemp++;
                        String res = "temp" + countTemp;
                        tmp = new Quadruple(quadruples.Count + 1, op.FName, opr1, opr2, res);
                        stack.Add(res);
                        quadruples.Add(tmp);

                        String tac = (tmp.Result + " := " + tmp.Operand1 + " " + op.Name + " " + tmp.Operand2);
                        lblStackOutput.Text = tac;

                        if (isFileProcessing)
                        {
                            tacText.Add(tmp.No + ". " + tac + "\n");
                            quadText.Add(tmp.No + ". " + tmp.Operator + "," + tmp.Operand1 + "," + tmp.Operand2 + "," + tmp.Result + "\n");
                        }
                    }
                    else
                    {
                        if (op.Name == "=")
                        {
                            // a = b
                            String opr = stack[lastIndex];
                            String res = stack[lastIndex - 1];
                            stack.RemoveAt(lastIndex); stack.RemoveAt(lastIndex - 1);
                            tmp = new Quadruple(quadruples.Count + 1, op.FName, opr, "", res);
                            quadruples.Add(tmp);

                            String tac = (tmp.Result + " := " + tmp.Operand1);
                            lblStackOutput.Text = tac;

                            if (isFileProcessing)
                            {
                                tacText.Add(tmp.No + ". " + tac + "\n");
                                quadText.Add(tmp.No + ". " + tmp.Operator + "," + tmp.Operand1 + "," + tmp.Operand2 + "," + tmp.Result + "\n");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured. Invalid input might be the cause of this.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            processedItem++;

            txtProcessedIndex.Text = Convert.ToString(processedItem);
            if (processedItem == postfix.Count)
            {
                if (stack.Count > 0)
                {
                    MessageBox.Show("Error occured. Invalid input might be the cause of this.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                stack.Clear();
                processedItem = 0;

                isProcessing = false;
                btnNextProcess.Enabled = false;
                btnClearInput.Enabled = true;
                btnDefaultInput.Enabled = true;
                btnNextInput.Enabled = true;
                proses.Enabled = false;
                btnProcessToFile.Enabled = false;

                lblProcessed.Visible = false;
                //txtProcessedIndex.Text = "";
                txtProcessedIndex.Visible = false;
            }
            showInput();
            showStack();
            showQuadruple();

            return true;
        }

        private void btnNextProcess_Click(object sender, EventArgs e)
        {
            if (!processOneStep())
            {
                showInput();
                showStack();
                showQuadruple();
                stack.Clear();
                processedItem = 0;

                isProcessing = false;
                btnNextProcess.Enabled = false;
                btnClearInput.Enabled = true;
                btnDefaultInput.Enabled = true;
                btnNextInput.Enabled = true;
                proses.Enabled = false;
                btnProcessToFile.Enabled = false;

                lblProcessed.Visible = false;
                //txtProcessedIndex.Text = "";
                txtProcessedIndex.Visible = false;
            }
        }

        private void dataGridViewInput_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < processedItem)
                e.CellStyle.BackColor = Color.Red;
        }

        private void introductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intro = new FormIntroduction();
            intro.Show();
            this.Visible = false;
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process = new FormProcess();
            process.Show();
            this.Visible = false;
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text4 = "\t\tCredits to:\n\n- Andrew Ongko (1501188561)\n- Jean Karunadewi (1501156105)\n- Rudy Sutrisno (1501169013)\n- Fidelson Tanzil (1501170753)\n- Jonathan Kevin (1501188536)\n- Alfonsus Andy Kristanto (1501158565)\n- Muhammad Falyanda Putra (1501160531)\n- Mendy Irawan (1501171333)\n- Christophorus Yohannes Suhaili (1501147800)\n- Martin Sendra (1501151426)";

            MessageBox.Show(text4, "Credits", MessageBoxButtons.OK);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text3 = "It's simple! Step one. You just need to input the postfix notation. Step two. Once you are done, click \"Process\" button to start processing your postfix input into quadruples. Then, click \"Next Process\" until the process is done. You can clear your postfix input by clicking \"Clear Input\".\n\nIf you stuck at this, you may look at our example by clicking \"Set to default\", and repeat form step two.";

            MessageBox.Show(text3, "How to Use?", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnProcessToFile_Click(object sender, EventArgs e)
        {
            isFileProcessing = true;

            if (postfix.Count <= 0)
                return;

            btnClearInput.Enabled = false;
            btnDefaultInput.Enabled = false;
            btnNextInput.Enabled = false;
            proses.Enabled = false;
            btnProcessToFile.Enabled = false;

            int stringLen = postfix.Count;
            int operatorLen = operators.Count;
            stack.Clear();
            quadruples.Clear();
            countTemp = 0;
            processedItem = 0;
            isProcessing = true;

            dataGridViewStack.DataSource = null;
            dataGridViewquadruples.DataSource = null;

            lblStackOutput.Text = "";
            lblProcessed.Visible = true;
            txtProcessedIndex.Text = "";
            txtProcessedIndex.Visible = true;

            quadText.Clear();
            tacText.Clear();
            while (isProcessing)
                processOneStep();

            isFileProcessing = false;

            saveFileDialog1.FileName = "quadruple.txt";
            saveFileDialog1.ShowDialog();

            saveFileDialog2.FileName = "three addess code.txt";
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = saveFileDialog1.FileName;
            System.IO.File.WriteAllLines(fileName, quadText);
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = saveFileDialog2.FileName;
            System.IO.File.WriteAllLines(fileName, tacText);
        }

        private void advancedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPseudoCode().Show();
            this.Visible = false;
        }
    }
}
