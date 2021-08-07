using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_is
{
    public partial class credit_sign : UserControl
    {
        public credit_sign()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Submitted Successfully","Done", MessageBoxButtons.OK , MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
