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
    public partial class bus : UserControl
    {
        public bus()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string update = @"UPDATE Ticket SET b=@route_id , c=@seat , d=@fare where a=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(update, con);
            SqlParameter route_id = new SqlParameter("@route_id", textBox2.Text);
            cmd.Parameters.Add(route_id);
            SqlParameter seat = new SqlParameter("@seat", textBox3.Text);
            cmd.Parameters.Add(seat);
            SqlParameter fare = new SqlParameter("@fare", textBox4.Text);
            cmd.Parameters.Add(fare);
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            string add = "INSERT INTO Ticket(b,c,d) VALUES(@route_id,@seat,@fare) ";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlParameter route_id = new SqlParameter("@route_id", textBox2.Text);
            cmd.Parameters.Add(route_id);
            SqlParameter seat = new SqlParameter("@seat", textBox3.Text);
            cmd.Parameters.Add(seat);
            SqlParameter fare = new SqlParameter("@fare", textBox4.Text);
            cmd.Parameters.Add(fare);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data is Added");
            dataGridView1.DataSource = loadusertable();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
