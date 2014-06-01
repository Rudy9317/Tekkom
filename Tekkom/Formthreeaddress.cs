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
    public partial class Formthreeaddress : Form
    {
        FormProcess process;

        public Formthreeaddress()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)  //back
        {
            process = new FormProcess();
            process.Show();
            this.Visible = false;
        }
    }
}
