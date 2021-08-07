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
    public partial class admain : UserControl
    {
        public admain()
        {
            InitializeComponent();
            admuser1.Hide();
            admroute1.Hide();
            admbus1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //user button
        private void button3_Click(object sender, EventArgs e)
        {
            admuser1.Show();
            admroute1.Hide();
            admbus1.Hide();
        }
        //route button
        private void button4_Click(object sender, EventArgs e)
        {
            admuser1.Hide();
            admroute1.Show();
            admbus1.Hide();
        }
        //bus button
        private void button5_Click(object sender, EventArgs e)
        {
            admuser1.Hide();
            admroute1.Hide();
            admbus1.Show();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
                this.Hide();
            
        }
    }
}
