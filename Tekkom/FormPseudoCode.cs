using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tekkom
{
    public partial class FormPseudoCode : Form
    {
        List<Operator> operators = new List<Operator>();
        List<Postfix> postfix = new List<Postfix>();
        List<String> stack = new List<String>();
        List<Quadruple> quadruples = new List<Quadruple>();
        List<String> quadText = new List<String>();
        List<String> tacText = new List<String>();

        bool isProcessing = false;
        int processedItem;

        public FormPseudoCode()
        {
            InitializeComponent();
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

        private bool preProcess(int type = 1)
        {
            String input = txtInput.Text;
            StringReader sReader = new StringReader(input);
            String tmp;
            switch(type) {
                case 1:
                    // postfix
                    while (sReader.Peek() != -1)
                    {
                        tmp = sReader.ReadLine();
                        tmp = tmp.Trim();
                        if (tmp.IndexOf(" ") > 0)
                        {
                            postfix.Clear();
                            MessageBox.Show("Please input the valid string format (separate each \"node\" with <enter> and no space is allowed in a line)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        postfix.Add(new Postfix(tmp));
                    }
                    break;
                case 2:
                    // pseudocode
                    while (sReader.Peek() != -1)
                    {
                        tmp = sReader.ReadLine();
                    }
                    break;
            }
            return true;
        }

        private bool processPostfix()
        {
            try
            {
                preProcess(1);
                List<List<String>> output = new Postfix().process(postfix);

                tacText = output[0];
                quadText = output[1];

                saveFileDialog1.FileName = "quadruple.txt";
                saveFileDialog1.ShowDialog();

                saveFileDialog2.FileName = "three addess code.txt";
                saveFileDialog2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured. Invalid input might be the cause of this.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return true;
        }

        private void processPseudo()
        {

        }

        private void btnUploadInput_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        StreamReader reader = new StreamReader(myStream);
                        txtInput.Text = reader.ReadToEnd();
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: We could not read the file. Original error: "+ex.Message);
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int selectedInputType = ddlInputType.SelectedIndex;
            switch (selectedInputType)
            {
                case 1:
                    // postfix
                    processPostfix();
                    break;
                case 2:
                    // pseudocode
                    MessageBox.Show("We're truly sorry. But this function is not implemented yet.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //processPseudo();
                    break;
                default:
                    MessageBox.Show("Please choose an input type", "Input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
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

        private void btnDefaultInput_Click(object sender, EventArgs e)
        {
            ddlInputType.SelectedIndex = 1;
            postfix = new Postfix().defaultPostfix();
            int postfixLen = postfix.Count;
            txtInput.Text = "";
            for (int i = 0; i < postfixLen; i++)
            {
                txtInput.Text += (postfix[i].item + Environment.NewLine);
            }
        }

        private void FormPseudoCode_Load(object sender, EventArgs e)
        {
            ddlInputType.SelectedIndex = 0;
            lblNote.Text = "Note: " + Environment.NewLine + "Input a valid string by either typing directly to the textbox or upload a *.txt file."
                + Environment.NewLine + "Please separate each node in postfix using only [endline] or [enter]."
                + Environment.NewLine + "Then Click process."
                + Environment.NewLine + "Save the result."
                + Environment.NewLine + "The first result is in quadruple representation."
                + Environment.NewLine + "The second result is in three-address-code representation.";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
