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
    public partial class sign_up : UserControl
    {
        public sign_up()
        {
            InitializeComponent();
            user1.Hide();
        }
        bool e1 = false;
        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            e1 = false;
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
               // e.Cancel = true;
               // maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Please Enter Your First Name");
                e1 = true;
            }

            else
            {
               // e.Cancel = false;
                errorProvider1.SetError(maskedTextBox1, null);
            }
        }
        bool e2 = false;
        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            e2 = false;
            if (string.IsNullOrEmpty(maskedTextBox2.Text))
            {
               // e.Cancel = true;
              //  maskedTextBox4.Focus();
                errorProvider2.SetError(maskedTextBox2, "Please Enter Your Last Name");
                e2 = true;
            }

            else
            {
                //e.Cancel = false;
                errorProvider2.SetError(maskedTextBox2, null);
            }
        }
        bool e3 = false;
        private void maskedTextBox8_Validating(object sender, CancelEventArgs e)
        {
            e3 = false;
            if (string.IsNullOrEmpty(maskedTextBox8.Text))
            {
                //e.Cancel = true;
               // maskedTextBox3.Focus();
                errorProvider3.SetError(maskedTextBox8, "Please Enter Your User-Name");
                e3 = true;
            }

            else
            {
               // e.Cancel = false;
                errorProvider3.SetError(maskedTextBox8, null);
            }
        }
       bool e4 = false;
        private void maskedTextBox4_Validating(object sender, CancelEventArgs e)
        {
            e4 = false;
            if (string.IsNullOrEmpty(maskedTextBox4.Text))
            {
                //e.Cancel = true;
                //maskedTextBox4.Focus();
                errorProvider4.SetError(maskedTextBox4, "Please Enter Your Email");
                e4 = true;
            }

            else if (!(maskedTextBox4.Text.Contains('@')) || !(maskedTextBox4.Text.Contains('.')))
            {
                errorProvider4.SetError(maskedTextBox4, "Please check Your Email");
            }

            else
            {
                //e.Cancel = false;
                errorProvider4.SetError(maskedTextBox4, null);
            }
        }
        bool e5 = false;
        private void maskedTextBox3_Validating(object sender, CancelEventArgs e)
        {
            e5 = false;
            if (string.IsNullOrEmpty(maskedTextBox3.Text))
            {
               // e.Cancel = true;
               // maskedTextBox3.Focus();
                errorProvider5.SetError(maskedTextBox3, "Please Enter Your Password");
                e5 = true;
            }

            else
            {
               // e.Cancel = false;
                errorProvider5.SetError(maskedTextBox3, null);
            }
        }
        bool e6 = false;
        private void maskedTextBox5_Validating(object sender, CancelEventArgs e)
        {
            e6 = false;
            if (string.IsNullOrEmpty(maskedTextBox5.Text))
            {
                //e.Cancel = true;
                //maskedTextBox5.Focus();
                errorProvider6.SetError(maskedTextBox5, "Please Enter Your Re-Password");
                e6 = true;
            }

            else
            {
                //e.Cancel = false;
                errorProvider6.SetError(maskedTextBox5, null);
            }
        }
       bool e7 = false;
        private void maskedTextBox6_Validating(object sender, CancelEventArgs e)
        {
            e7 = false;
            if (string.IsNullOrEmpty(maskedTextBox6.Text))
            {
               // e.Cancel = true;
               // maskedTextBox6.Focus();
                errorProvider7.SetError(maskedTextBox6, "Please Enter Your Phone");
                e7 = true;
            }

            else if (maskedTextBox6.Text.Length != 9)
            {
                errorProvider7.SetError(maskedTextBox6, "Please Check Your Phone");
            }

            else
            {
              //  e.Cancel = false;
                errorProvider7.SetError(maskedTextBox6, null);
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox2.Focus();
            }
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox8.Focus();
            }
        }

        private void maskedTextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox4.Focus();
            }
        }

        private void maskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox3.Focus();
            }
        }

        private void maskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox5.Focus();
            }
        }

        private void maskedTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox6.Focus();
            }
        }

        private void maskedTextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox1.Focus();
            }
        }
        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //sign up button
        string pass;
        private void button7_Click(object sender, EventArgs e)
        {
            if (e1)
            {
                MessageBox.Show("Check Your Data!");
            }

            else if (e2)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e3)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e4)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e5)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e6)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e7)
            {
                MessageBox.Show("Check Your Data!");
            }
            else
            {
                pass = maskedTextBox5.Text;
                if (pass != maskedTextBox3.Text)
                {
                    errorProvider6.SetError(maskedTextBox5, "Please Check Your Re-Password");
                }
                else
                {
                    if (string.IsNullOrEmpty(maskedTextBox1.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox2.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox8.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox4.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox3.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox5.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else if (string.IsNullOrEmpty(maskedTextBox6.Text))
                    {
                        MessageBox.Show("Enter Your Data !");
                    }
                    else { 
                        MessageBox.Show("You Submit Successfully");
                         user1.Show();
                    }
                }
            }

        }

        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
