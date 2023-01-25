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
    public partial class frmProje : Form
    {
        public frmProje()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MEHMETCAN-PC\\SQLEXPRESS;Initial Catalog=personalDatabase;Integrated Security=True");

        void temizle()
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtStaffSecName.Text = "";
            cmbStaffCity.Text = "";
            mskdStaffSalary.Text = "";
            rdbtnMarried.Checked = false;
            rdbtnSingle.Checked = false;
            txtStaffDuty.Text = "";
            txtStaffName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStaffName.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            this.tbl_STAFFTableAdapter.Fill(this.personalDatabaseDataSet.tbl_STAFF);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            this.tbl_STAFFTableAdapter.Fill(this.personalDatabaseDataSet.tbl_STAFF);
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tbl_STAFF (perNAME,perSECNAME,perCITY,perSALARY,perJOB,perSINGLE) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            command.Parameters.AddWithValue("@p1", txtStaffName.Text);
            command.Parameters.AddWithValue("@p2", txtStaffSecName.Text);
            command.Parameters.AddWithValue("@p3", cmbStaffCity.Text);
            command.Parameters.AddWithValue("@p4", mskdStaffSalary.Text);
            command.Parameters.AddWithValue("@p5", txtStaffDuty.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Ekleme Islemı Basarili","ISLEM BASARILI!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void rdbtnMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMarried.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void rdbtnSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSingle.Checked==true)
            {
                label8.Text = "False";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtStaffID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtStaffName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtStaffSecName.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbStaffCity.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mskdStaffSalary.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txtStaffDuty.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                rdbtnMarried.Checked = true;
            }
            else if (label8.Text == "False")
            {
                rdbtnSingle.Checked = true;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmddlt = new SqlCommand("Delete From tbl_STAFF Where perID=@d1", connection);
            cmddlt.Parameters.AddWithValue("@d1", txtStaffID.Text);
            cmddlt.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Silme Islemı Basarili", "ISLEM BASARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUptadeAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmduptd = new SqlCommand("Update tbl_STAFF Set perNAME=@u1,perSECNAME=@u2,perCITY=@u3,perSALARY=@u4,perSINGLE=@u5,perJOB=@u6 where perID=@u7", connection);
            cmduptd.Parameters.AddWithValue("@u1", txtStaffName.Text);
            cmduptd.Parameters.AddWithValue("@u2", txtStaffSecName.Text);
            cmduptd.Parameters.AddWithValue("@u3", cmbStaffCity.Text);
            cmduptd.Parameters.AddWithValue("@u4", mskdStaffSalary.Text);
            cmduptd.Parameters.AddWithValue("@u5", label8.Text);
            cmduptd.Parameters.AddWithValue("@u6", txtStaffDuty.Text);
            cmduptd.Parameters.AddWithValue("@u7", txtStaffID.Text);
            cmduptd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Guncelleme Islemı Basarili", "ISLEM BASARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAllStatics_Click(object sender, EventArgs e)
        {
            frmStatistics fr = new frmStatistics();
            fr.Show();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            frmGRAPHICS fr1 = new frmGRAPHICS();
            fr1.Show();
        }
    }
}
