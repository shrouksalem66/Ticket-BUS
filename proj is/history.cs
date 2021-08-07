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
    public partial class history : UserControl
    {
        static string sql = "";
        SqlConnection con = new SqlConnection(sql);
        public history()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public DataTable loadusertable()
        {
            DataTable dt = new DataTable();
            string query = "";
            con.Open();
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
