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
    public partial class FormPostfix : Form
    {
        FormProcess process;

        public FormPostfix()
        {
            InitializeComponent();
        }

        private void FormPostfix_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            process = new FormProcess();
            process.Show();
            this.Visible = false;
        }
    }
}
