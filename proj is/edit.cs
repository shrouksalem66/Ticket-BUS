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
    public partial class edit : UserControl
    {
        string ticket_id_txt;
        //SqlConnection cn = new SqlConnection(@"Server=DESKTOP-1GH08LH\SQLEXPRESS; DataBase=Ticket;Integrated Security=True;");
        //SqlCommand cmd;
        ////SqlDataReader reader;
        //SqlDataAdapter da;
        DataTable dt = new DataTable();
        public edit()
        {
            InitializeComponent();
          //  showgridview();
            ticket_id.Clear();
            update1.Hide();
            
        }
        //public void showgridview()
        //{
        //    dt.Clear();

        //    SqlCommand cm = new SqlCommand("selection_ticket", cn);
        //    cm.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cm);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("past_ticket", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter para = new SqlParameter();
            //para = new SqlParameter("@ticket", SqlDbType.Int);
            //para.Value = ticket_id.Text;
            //cmd.Parameters.Add(para);
            //cn.Open();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //cn.Close();
            //showgridview();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            update1.Show();
            ticket_id_txt = ticket_id.Text;
           
           // frm.passingtxt(ticket_id_txt.ToString());
           
        }

        private void ticket_id_Click(object sender, EventArgs e)
        {

        }
    }
}
