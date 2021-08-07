using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_is
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sign_up1.Hide();
            log_in1.Hide();
        }
        // min form button
        private void button11_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        // exit form button
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // sign up button
        private void button1_Click(object sender, EventArgs e)
        {
            sign_up1.Show();
            log_in1.Hide();
        }
        // log in button
        private void button7_Click(object sender, EventArgs e)
        {
            sign_up1.Hide();
            log_in1.Show();
        }

        private void sign_up1_Load(object sender, EventArgs e)
        {

        }

        internal static void hide()
        {
            throw new NotImplementedException();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void log_in1_Load(object sender, EventArgs e)
        {

        }
    }
}
