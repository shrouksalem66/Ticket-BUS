using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace proj_is
{
    public partial class user : UserControl
    {
        Thread th;
        public user()
        {
            InitializeComponent();
            home1.Show();
            book1.Hide();
            edit1.Hide();
            history1.Hide();
            
        }
        //home button
        private void button7_Click(object sender, EventArgs e)
        {
            home1.Show();
            book1.Hide();
            edit1.Hide();
            history1.Hide();
            
        }
        //my account button
        private void button2_Click(object sender, EventArgs e)
        {
            home1.Hide();
            book1.Hide();
            edit1.Hide();
            history1.Hide();
           
        }
        //book button
        private void button1_Click(object sender, EventArgs e)
        {
            home1.Hide();
            book1.Show();
            edit1.Hide();
            history1.Hide();
           
        }
        //edit button
        private void button3_Click(object sender, EventArgs e)
        {
            home1.Hide();
            book1.Hide();
            edit1.Show();
            history1.Hide();
            
        }
        //history button
        private void button4_Click(object sender, EventArgs e)
        {
            home1.Hide();
            book1.Hide();
            edit1.Hide();
            history1.Show();
            
        }
        //log out button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            
        }


        //private void opennewform(object obj)
        //{
        //    Application.Run(new Form1());
        //}


        //done of my account
        private void button5_Click(object sender, EventArgs e)
        {
            home1.Hide();
            book1.Hide();
            edit1.Hide();
        }
        //textbok of username my account
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //textbox of email my account
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //textbox of passward my account
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //textbox of creditcard my account
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //textbox of phone
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home1_Load_1(object sender, EventArgs e)
        {

        }

        private void home1_Load_2(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void book1_Load(object sender, EventArgs e)
        {

        }

        private void edit1_Load(object sender, EventArgs e)
        {

        }
       /* private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            while (!Regex.IsMatch(textBox4.Text, pattern))
            {
                errorProvider1.SetError(this.textBox4, "Please check your E-mail !");
                return;
            }
            errorProvider1.Clear();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            string phone = "^([0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
            while (!Regex.IsMatch(textBox7.Text, phone))
            {
                errorProvider2.SetError(this.textBox7, "Please check your phone !");
                return;
            }
            errorProvider2.Clear();

        }*/

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void book1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }
        bool e1 = false;
        private void textBox4_Leave(object sender, EventArgs e)
        {
            e1 = false;

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            while (!Regex.IsMatch(textBox4.Text, pattern))
            {
                errorProvider1.SetError(this.textBox4, "Please check your E-mail !");
                e1 = true;
                return;
            }
            errorProvider1.Clear();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }
        }
        bool e2 = false;
        private void textBox7_Leave(object sender, EventArgs e)
        {
            e2 = false;

            string phone = "^([0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
            while (!Regex.IsMatch(textBox7.Text, phone))
            {
                errorProvider2.SetError(this.textBox7, "Please check your phone !");
                e2 = true;
                return;
            }
            errorProvider2.Clear();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button5.Focus();
            }
        }
        bool e3 = false;
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            e3 = false;

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                //e.Cancel = true;
                //textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please Enter Your user name");
                e3 = true;
            }
            else
            {
                //e.Cancel = false;
                errorProvider3.SetError(textBox3, null);
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
        }

        bool e4 = false;
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            e4 = false;
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                //e.Cancel = true;
                //textBox5.Focus();
                errorProvider4.SetError(textBox5, "Please Enter Your password");
                e4 = true;
            }
            else
            {
                //e.Cancel = false;
                errorProvider4.SetError(textBox5, null);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (e1)
            {
                MessageBox.Show("Check Your Data!");
            }

            else if ( e2)
            {
                MessageBox.Show("Check Your Data!");
            }
            else if (e3 )
            {
                MessageBox.Show("Check Your Data!");
            }
            else if ( e4)
            {
                MessageBox.Show("Check Your Data!");
            }
            else
            {
                MessageBox.Show("Your Data Is Saved");
            }
        }

       
    }
}
