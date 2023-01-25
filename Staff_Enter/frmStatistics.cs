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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MEHMETCAN-PC\\SQLEXPRESS;Initial Catalog=personalDatabase;Integrated Security=True");
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            //TOPLAM PERSONEL SAYISI
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(*) From tbl_STAFF", connection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                lblTotalStaff.Text = DR1[0].ToString();
            }   
            connection.Close();

            //EVLI PERSONEL SAYISI
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(*) From tbl_STAFF where perSINGLE=0", connection);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                lblTotalMarried.Text = DR2[0].ToString();
            }
            connection.Close();

            //BEKAR PERSONEL SAYISI
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Select Count (*) From tbl_STAFF where perSINGLE=1", connection);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                lblTotalSingle.Text = DR3[0].ToString();
            }
            connection.Close();

            //FARKLI SEHIR SAYISI
            connection.Open();
            SqlCommand cmd4 = new SqlCommand("Select count (distinct(perCITY)) from tbl_STAFF", connection);
            SqlDataReader DR4 = cmd4.ExecuteReader();
            while (DR4.Read())
            {
                lblCity.Text = DR4[0].ToString();
            }
            connection.Close();
            //TOPLAM MAAS 
            connection.Open();
            SqlCommand cmd5 = new SqlCommand("Select Sum(perSALARY) from tbl_STAFF",connection);
            SqlDataReader DR5 = cmd5.ExecuteReader();
            while (DR5.Read())
            {
                lblTotalSalary.Text = DR5[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand cmd6 = new SqlCommand("Select Avg(perSALARY) from tbl_STAFF",connection);
            SqlDataReader DR6 = cmd6.ExecuteReader();
            while (DR6.Read())
            {
                lblAvaregeSalary.Text = DR6[0].ToString();
            }
            connection.Close();
        }
    }
}
