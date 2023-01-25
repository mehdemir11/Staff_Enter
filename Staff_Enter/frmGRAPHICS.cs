using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Enter
{
    public partial class frmGRAPHICS : Form
    {
        public frmGRAPHICS()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MEHMETCAN-PC\\SQLEXPRESS;Initial Catalog=personalDatabase;Integrated Security=True");
        private void frmGRAPHICS_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select perCITY,Count(*) from tbl_STAFF Group by perCITY", connection);
            SqlDataReader DR1 = command1.ExecuteReader();
            while (DR1.Read())
            {
                chart1.Series["SEHIRLER"].Points.AddXY(DR1[0],DR1[1]);
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("Select perJOB,Avg(perSALARY) from tbl_STAFF group by perJOB", connection);
            SqlDataReader DR2 = command2.ExecuteReader();
            while (DR2.Read())
            {
                chart2.Series["MESLEK - MAAS"].Points.AddXY(DR2[0], DR2[1]);
            }
            connection.Close();
        }
    }
}
