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
    public partial class FormProcess : Form
    {
        Form1 main;
        FormPostfix postfix;
        Formthreeaddress tac;
        FormQuad quad;

        public FormProcess()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)  //back
        {
            main = new Form1();
            main.Show();
            this.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //postfix
        {
            postfix = new FormPostfix();
            postfix.Show();
            this.Visible = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //three address
        {
            tac = new Formthreeaddress();
            tac.Show();
            this.Visible = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //quadruples
        {
            quad = new FormQuad();
            quad.Show();
            this.Visible = false;
            this.Close();
        }
    }
}
