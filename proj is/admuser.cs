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

namespace proj_is
{
    public partial class admuser : UserControl
    {
        public admuser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string delete = @"DELETE Ticket SET  b=@route_id , c=@seat , d=@fare where a=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Deleted");
            dataGridView1.DataSource = loadusertable();
        }

                private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string update = @"UPDATE Ticket SET  b=@origin , c=@des , d=@time , e=@date , g=@seat , h=@cost where a=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(update, con);
            SqlParameter origin = new SqlParameter("@origin", textBox2.Text);
            cmd.Parameters.Add(origin);
            SqlParameter des = new SqlParameter("@des", textBox3.Text);
            cmd.Parameters.Add(des);
            SqlParameter time = new SqlParameter("@time", textBox4.Text);
            cmd.Parameters.Add(time);
            SqlParameter date = new SqlParameter("@date", textBox7.Text);
            cmd.Parameters.Add(date);
            SqlParameter seat = new SqlParameter("@seat", textBox8.Text);
            cmd.Parameters.Add(seat);
            SqlParameter cost = new SqlParameter("@cost", textBox5.Text);
            cmd.Parameters.Add(cost);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Updated");
            dataGridView1.DataSource = loadusertable();
        }

        public DataTable loadusertable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT *FROM Ticket";
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
