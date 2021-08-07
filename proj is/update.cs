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

    public partial class update : UserControl
    {

        //SqlConnection cn = new SqlConnection(@"Server=DESKTOP-1GH08LH\SQLEXPRESS; DataBase=Ticket;Integrated Security=True;");
        //SqlCommand cmd;
        //SqlDataReader reader;
        //SqlDataAdapter da;
        //DataTable tb = new DataTable();
        //DataTable tb1 = new DataTable();
        string passedtxt;
        int check;
        public void passingtxt(string ticked_id_txt)
        {
            passedtxt = ticked_id_txt;
        }
       
        public update()
        {
            InitializeComponent();
            //da = new SqlDataAdapter("select * from bus", cn);
            //da.Fill(tb);
            //da.Fill(tb1);
            //cobox_origin.DataSource = tb;
            //cobox_origin.DisplayMember = "station";
            //cobox_origin.ValueMember = "bus_id";
            //cobox_des.DataSource = tb1;
            //cobox_des.DisplayMember = "station";
            //cobox_des.ValueMember = "bus_id";

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {
            //ticket_id.Text = passedtxt;

            //cmd = new SqlCommand("select * from Ticket where ticket_id='" + ticket_id.Text + "'", cn);
            //cn.Open();
            //reader = cmd.ExecuteReader();
            //reader.Read();
            //bus_id_txt_e.Text = reader["bus_id"].ToString();
            //cobox_origin.Text = reader["origin"].ToString();
            //cobox_des.Text = reader["destination"].ToString();
            //pick_up_time_txt_e.Text = reader["pick_up_time"].ToString();
            //pick_up_date_txt_e.Text = reader["pick_up_date"].ToString();
            //seats_num_txt_e.Text = reader["seats_booked"].ToString();
            //payment.Text = reader["payment"].ToString();
            //check = (int)reader["pay_by"];
            ///*if (check == 0)
            //    cash_txt.CheckedChanged();
            //else
            //    cc_txt.CheckedChanged();*/
            //reader.Close();
            //cn.Close();
        }

        private void edit_bttn_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("update_ticket", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter[] param = new SqlParameter[8];
            //param[0] = new SqlParameter("@bus_id", SqlDbType.Int);
            //param[0].Value = bus_id_txt_e.Text;

            //param[1] = new SqlParameter("@origin", SqlDbType.NVarChar, 50);
            //param[1].Value = cobox_origin.Text;

            //param[2] = new SqlParameter("@destination", SqlDbType.NVarChar, 50);
            //param[2].Value = cobox_des.Text;

            //param[3] = new SqlParameter("@pick_up_time", SqlDbType.Time, 7);
            //param[3].Value = pick_up_time_txt_e.Text;

            //param[4] = new SqlParameter("@pick_up_date", SqlDbType.Date);
            //param[4].Value = pick_up_date_txt_e.Value;

            //param[5] = new SqlParameter("@seats_booked", SqlDbType.Int);
            //param[5].Value = seats_num_txt_e.Value;

            //param[6] = new SqlParameter("@pay_by", SqlDbType.Int);
            //param[6].Value = check;

            //param[7] = new SqlParameter("@payment", SqlDbType.Money);
            //param[7].Value = payment.Text;

            //cmd.Parameters.AddRange(param);
            //cn.Open();
            //cmd.ExecuteNonQuery();
            //cn.Close();
            MessageBox.Show("You Have Edited Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            this.Hide();
            
        }

        private void seats_num_txt_e_ValueChanged(object sender, EventArgs e)
        {
            double numOfseatsBooked;
            numOfseatsBooked = Convert.ToDouble(seats_num_txt_e.Value);
            payment.Text = Convert.ToString(numOfseatsBooked * 3.5);
        }

        private void cash_txt_CheckedChanged(object sender, EventArgs e)
        {

            check = 0;
        }

        private void cc_txt_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }
    }
}
