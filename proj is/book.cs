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
    public partial class book : UserControl
    {
       int check;
       /* SqlConnection con = new SqlConnection(@"Server=DESKTOP-1GH08LH\SQLEXPRESS ; DataBase=Ticket;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tb = new DataTable();
        DataTable tb1 = new DataTable();
        */
        public book()
        {
            InitializeComponent();
            credit_sign1.Hide();
           
            //da = new SqlDataAdapter("select * from bus", con);
            //da.Fill(tb);
            //da.Fill(tb1);
            //cobox_origin.DataSource = tb;
            //cobox_origin.DisplayMember = "station";
            //cobox_origin.ValueMember = "bus_id";
            //cobox_des.DataSource = tb1;
            //cobox_des.DisplayMember = "station";
            //cobox_des.ValueMember = "bus_id";
        }

        private void credit_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
            // credit_card.Visible=true;
            credit_sign cc = new credit_sign();
            cc.Visible = true;
            credit_sign1.Show();
        }

        private void book_bttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to confirm the reservation?", "Cofirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //cmd.Parameters.AddRange(param);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("You Have Booked Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bus_id_txt.Clear();
                //this.Close();
            }
        }

        private void seats_number_numeric_ValueChanged(object sender, EventArgs e)
        {
            //double numOfseatsBooked;

            //cmd = new SqlCommand("select fare from bus where bus_id='" + bus_id_txt.Text + "'", con);
            //con.Open();
            //rd = cmd.ExecuteReader();
            //rd.Read();
            //double cost = Convert.ToDouble(rd[0]);
            //numOfseatsBooked = Convert.ToDouble(seats_number_numeric.Value);
            //payment.Text = Convert.ToString(numOfseatsBooked * cost);
            //rd.Close();
            //con.Close();
        }

        private void bus_id_txt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cash_CheckedChanged(object sender, EventArgs e)
        {
            check = 0;
            credit_sign1.Hide();
        }

        private void credit_CheckedChanged_1(object sender, EventArgs e)
        {
            credit_sign1.Show();
        }

        private void cash_CheckedChanged_1(object sender, EventArgs e)
        {
            credit_sign1.Hide();
        }

        private void credit_sign1_Load(object sender, EventArgs e)
        {

        }

        private void bus_id_txt_Leave(object sender, EventArgs e)
        {
            //double numOfseatsBooked;

            //cmd = new SqlCommand("select fare from bus where bus_id='" + bus_id_txt.Text + "'", con);
            //con.Open();
            //rd = cmd.ExecuteReader();
            //rd.Read();
            //double cost = Convert.ToDouble(rd[0]);
            //numOfseatsBooked = Convert.ToDouble(seats_number_numeric.Value);
            //payment.Text = Convert.ToString(numOfseatsBooked * cost);
            //rd.Close();
            //con.Close();
        }
    }
}
