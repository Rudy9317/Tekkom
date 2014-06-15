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
        List<String> postfix = new List<String>();
        List<String> stack = new List<String>();
        List<Quadruple> quadruples = new List<Quadruple>();
        bool isProcessing = false;
        int processedItem;

        public FormPseudoCode()
        {
            InitializeComponent();
        }

        private bool preProcess(int type = 1)
        {
            String input = txtInput.Text;
            StringReader sReader = new StringReader(input);
            String tmp;
            switch(type) {
                case 1:
                    // postfix
                    while (sReader.Peek() != null)
                    {
                        tmp = sReader.ReadLine();
                        if (tmp.IndexOf(" ") > 0)
                        {
                            postfix.Clear();
                            MessageBox.Show("Please input the valid string format (separate each \"node\" with <enter> and no space is allowed in a line)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        postfix.Add(tmp);
                    }
                    break;
                case 2:
                    // pseudocode
                    while (sReader.Peek() != null)
                    {
                        tmp = sReader.ReadLine();
                    }
                    break;
            }
            return true;
        }

        private void processPostfix()
        {

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
                    processPseudo();
                    break;
                default:
                    MessageBox.Show("Please choose an input type", "Input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
