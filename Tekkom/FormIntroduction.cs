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
    public partial class FormIntroduction : Form
    {
        Form1 main;
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void FormIntroduction_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main = new Form1();
            main.Show();
            this.Visible = false;
        }
    }
}
