using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
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
                textBox8.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string update = @"UPDATE Ticket SET  b=@origin , c=@des , d=@time , e=@date , f=@pay , g=@seat , h=@cost where a=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(update, con);
            SqlParameter origin = new SqlParameter("@origin", textBox2.Text);
            cmd.Parameters.Add(origin);
            SqlParameter des = new SqlParameter("@des", textBox3.Text);
            cmd.Parameters.Add(des);
            SqlParameter time = new SqlParameter("@time", textBox4.Text);
            cmd.Parameters.Add(time);
            SqlParameter date = new SqlParameter("@date", textBox7.Text);
            cmd.Parameters.Add(date);
            SqlParameter pay = new SqlParameter("@pay", textBox6.Text);
            cmd.Parameters.Add(pay);
            SqlParameter seat = new SqlParameter("@seat", textBox8.Text);
            cmd.Parameters.Add(seat);
            SqlParameter cost = new SqlParameter("@cost", textBox5.Text);
            cmd.Parameters.Add(cost);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Updated");
            dataGridView1.DataSource=loadusertable();
        }

        public DataTable loadusertable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT *FROM Ticket";
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string add = "INSERT INTO Ticket(b,c,d,e,f,g,h) VALUES(@origin,@des,@time,@date,@pay,@seat,@cost) ";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlParameter origin = new SqlParameter("@origin", textBox2.Text);
            cmd.Parameters.Add(origin);
            SqlParameter des = new SqlParameter("@des", textBox3.Text);
            cmd.Parameters.Add(des);
            SqlParameter time = new SqlParameter("@time", textBox4.Text);
            cmd.Parameters.Add(time);
            SqlParameter date = new SqlParameter("@date", textBox7.Text);
            cmd.Parameters.Add(date);
            SqlParameter pay = new SqlParameter("@pay", textBox6.Text);
            cmd.Parameters.Add(pay);
            SqlParameter seat = new SqlParameter("@seat", textBox8.Text);
            cmd.Parameters.Add(seat);
            SqlParameter cost = new SqlParameter("@cost", textBox5.Text);
            cmd.Parameters.Add(cost);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Added");
            dataGridView1.DataSource = loadusertable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string delete = @"DELETE Ticket SET  b=@origin , c=@des , d=@time , e=@date , f=@pay , g=@seat , h=@cost where a=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Deleted");
            dataGridView1.DataSource = loadusertable();
        }

    }
}
