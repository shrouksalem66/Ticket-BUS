using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace proj_is
{
    public partial class log_in : UserControl
    {
        SqlConnection con = new SqlConnection("");
        public log_in()
        {
            InitializeComponent();
            user1.Hide();
            admain1.Hide();
            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        //button log in
        string email = null;
        string pass2 = null;
        string username="Admin@hh.hh";
        string pass="0000";
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == email && textBox2.Text== pass2)
            {
                MessageBox.Show("Your data empty!");
            }
            else
            {
                if (e1)
                {
                    MessageBox.Show("Check Your Data!");
                }

                else if (e2)
                {
                    MessageBox.Show("Check Your Data!");
                }
                else
                {
                    if (username == textBox1.Text && pass == textBox2.Text)
                    {
                        admain1.Show();
                        
                    }
                    else
                    {
                        user1.Show();
                        
                    }
                }
            }

          //  con.Open();
          //  SqlCommand cmd = new SqlCommand("login", con);
         //   cmd.CommandType = CommandType.StoredProcedure;
          //  cmd.Parameters.Add(new SqlParameter("@email", textBox1.Text));
          //  cmd.Parameters.Add(new SqlParameter("@password", textBox2.Text));
         //   SqlParameter p = cmd.Parameters.Add("@ID_pass", SqlDbType.Int);
          //  p.Direction = ParameterDirection.Output;
          //  int x = (int)p.Value;
           // if (x == null)
            {
           //     MessageBox.Show("you have entered wrong e-mail or password");
            }
           // else
            {


            }
         //   cmd.ExecuteNonQuery();
          //  con.Close();
            MessageBox.Show("welcome :)");
        }
        //back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //button email
        bool e1 = false;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            e1 = false;
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            while (!Regex.IsMatch(textBox1.Text, pattern))
            {
                errorProvider1.SetError(this.textBox1, "Please check your E-mail !");
                e1 = true;
                return;
            }
            errorProvider1.Clear();
        }
        //button email
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //button password
        bool e2 = false;

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            e2 = false;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                //e.Cancel = true;
                //textBox5.Focus();
                errorProvider2.SetError(textBox2, "Please Enter Your password");
                e2 = true;
            }
            else
            {
                //e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void admain1_Load(object sender, EventArgs e)
        {

        }

        private void logout1_Load(object sender, EventArgs e)
        {
            admain1.Hide();
            user1.Hide();
            this.Hide();
        }

        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
