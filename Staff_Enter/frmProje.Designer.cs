
namespace Staff_Enter
{
    partial class frmProje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdStaffSalary = new System.Windows.Forms.MaskedTextBox();
            this.rdbtnSingle = new System.Windows.Forms.RadioButton();
            this.rdbtnMarried = new System.Windows.Forms.RadioButton();
            this.txtStaffDuty = new System.Windows.Forms.TextBox();
            this.txtStaffSecName = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStaffCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllStatics = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnUptadeAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSECNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSINGLEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDatabaseDataSet = new Staff_Enter.personalDatabaseDataSet();
            this.tbl_STAFFTableAdapter = new Staff_Enter.personalDatabaseDataSetTableAdapters.tbl_STAFFTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdStaffSalary);
            this.groupBox1.Controls.Add(this.rdbtnSingle);
            this.groupBox1.Controls.Add(this.rdbtnMarried);
            this.groupBox1.Controls.Add(this.txtStaffDuty);
            this.groupBox1.Controls.Add(this.txtStaffSecName);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbStaffCity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayit";
            // 
            // mskdStaffSalary
            // 
            this.mskdStaffSalary.Location = new System.Drawing.Point(189, 229);
            this.mskdStaffSalary.Mask = "00000";
            this.mskdStaffSalary.Name = "mskdStaffSalary";
            this.mskdStaffSalary.Size = new System.Drawing.Size(168, 42);
            this.mskdStaffSalary.TabIndex = 5;
            this.mskdStaffSalary.ValidatingType = typeof(int);
            // 
            // rdbtnSingle
            // 
            this.rdbtnSingle.AutoSize = true;
            this.rdbtnSingle.Location = new System.Drawing.Point(278, 274);
            this.rdbtnSingle.Name = "rdbtnSingle";
            this.rdbtnSingle.Size = new System.Drawing.Size(67, 38);
            this.rdbtnSingle.TabIndex = 6;
            this.rdbtnSingle.TabStop = true;
            this.rdbtnSingle.Text = "EVLI";
            this.rdbtnSingle.UseVisualStyleBackColor = true;
            this.rdbtnSingle.CheckedChanged += new System.EventHandler(this.rdbtnSingle_CheckedChanged);
            // 
            // rdbtnMarried
            // 
            this.rdbtnMarried.AutoSize = true;
            this.rdbtnMarried.Location = new System.Drawing.Point(189, 274);
            this.rdbtnMarried.Name = "rdbtnMarried";
            this.rdbtnMarried.Size = new System.Drawing.Size(84, 38);
            this.rdbtnMarried.TabIndex = 5;
            this.rdbtnMarried.TabStop = true;
            this.rdbtnMarried.Text = "BEKAR";
            this.rdbtnMarried.UseVisualStyleBackColor = true;
            this.rdbtnMarried.CheckedChanged += new System.EventHandler(this.rdbtnMarried_CheckedChanged);
            // 
            // txtStaffDuty
            // 
            this.txtStaffDuty.Location = new System.Drawing.Point(189, 322);
            this.txtStaffDuty.Name = "txtStaffDuty";
            this.txtStaffDuty.Size = new System.Drawing.Size(168, 42);
            this.txtStaffDuty.TabIndex = 7;
            // 
            // txtStaffSecName
            // 
            this.txtStaffSecName.Location = new System.Drawing.Point(189, 130);
            this.txtStaffSecName.Name = "txtStaffSecName";
            this.txtStaffSecName.Size = new System.Drawing.Size(168, 42);
            this.txtStaffSecName.TabIndex = 3;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(189, 82);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(168, 42);
            this.txtStaffName.TabIndex = 2;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(189, 34);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(168, 42);
            this.txtStaffID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Personel GOREV:";
            // 
            // cmbStaffCity
            // 
            this.cmbStaffCity.FormattingEnabled = true;
            this.cmbStaffCity.Location = new System.Drawing.Point(189, 178);
            this.cmbStaffCity.Name = "cmbStaffCity";
            this.cmbStaffCity.Size = new System.Drawing.Size(168, 42);
            this.cmbStaffCity.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Personel DURUM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Personel SEHIR:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Personel MAAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAllStatics);
            this.groupBox2.Controls.Add(this.btnGraphics);
            this.groupBox2.Controls.Add(this.btnUptadeAll);
            this.groupBox2.Controls.Add(this.btnClearAll);
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.btnSaveAll);
            this.groupBox2.Controls.Add(this.btnListAll);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Islemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAllStatics
            // 
            this.btnAllStatics.Location = new System.Drawing.Point(79, 274);
            this.btnAllStatics.Name = "btnAllStatics";
            this.btnAllStatics.Size = new System.Drawing.Size(164, 39);
            this.btnAllStatics.TabIndex = 6;
            this.btnAllStatics.Text = "Istatistik";
            this.btnAllStatics.UseVisualStyleBackColor = true;
            this.btnAllStatics.Click += new System.EventHandler(this.btnAllStatics_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(79, 322);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(164, 39);
            this.btnGraphics.TabIndex = 7;
            this.btnGraphics.Text = "Grafikler";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnUptadeAll
            // 
            this.btnUptadeAll.Location = new System.Drawing.Point(79, 181);
            this.btnUptadeAll.Name = "btnUptadeAll";
            this.btnUptadeAll.Size = new System.Drawing.Size(164, 39);
            this.btnUptadeAll.TabIndex = 4;
            this.btnUptadeAll.Text = "Guncelle";
            this.btnUptadeAll.UseVisualStyleBackColor = true;
            this.btnUptadeAll.Click += new System.EventHandler(this.btnUptadeAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(79, 229);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(164, 39);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Temizle";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(79, 133);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(164, 39);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Sil";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(79, 82);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(164, 39);
            this.btnSaveAll.TabIndex = 2;
            this.btnSaveAll.Text = "Kaydet";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(79, 37);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(164, 39);
            this.btnListAll.TabIndex = 1;
            this.btnListAll.Text = "Listele";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(14, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayitlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perNAMEDataGridViewTextBoxColumn,
            this.perSECNAMEDataGridViewTextBoxColumn,
            this.perCITYDataGridViewTextBoxColumn,
            this.perSALARYDataGridViewTextBoxColumn,
            this.perSINGLEDataGridViewCheckBoxColumn,
            this.perJOBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSTAFFBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 200);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "perID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "perID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNAMEDataGridViewTextBoxColumn
            // 
            this.perNAMEDataGridViewTextBoxColumn.DataPropertyName = "perNAME";
            this.perNAMEDataGridViewTextBoxColumn.HeaderText = "perNAME";
            this.perNAMEDataGridViewTextBoxColumn.Name = "perNAMEDataGridViewTextBoxColumn";
            this.perNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSECNAMEDataGridViewTextBoxColumn
            // 
            this.perSECNAMEDataGridViewTextBoxColumn.DataPropertyName = "perSECNAME";
            this.perSECNAMEDataGridViewTextBoxColumn.HeaderText = "perSECNAME";
            this.perSECNAMEDataGridViewTextBoxColumn.Name = "perSECNAMEDataGridViewTextBoxColumn";
            this.perSECNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perCITYDataGridViewTextBoxColumn
            // 
            this.perCITYDataGridViewTextBoxColumn.DataPropertyName = "perCITY";
            this.perCITYDataGridViewTextBoxColumn.HeaderText = "perCITY";
            this.perCITYDataGridViewTextBoxColumn.Name = "perCITYDataGridViewTextBoxColumn";
            this.perCITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSALARYDataGridViewTextBoxColumn
            // 
            this.perSALARYDataGridViewTextBoxColumn.DataPropertyName = "perSALARY";
            this.perSALARYDataGridViewTextBoxColumn.HeaderText = "perSALARY";
            this.perSALARYDataGridViewTextBoxColumn.Name = "perSALARYDataGridViewTextBoxColumn";
            this.perSALARYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSINGLEDataGridViewCheckBoxColumn
            // 
            this.perSINGLEDataGridViewCheckBoxColumn.DataPropertyName = "perSINGLE";
            this.perSINGLEDataGridViewCheckBoxColumn.HeaderText = "perSINGLE";
            this.perSINGLEDataGridViewCheckBoxColumn.Name = "perSINGLEDataGridViewCheckBoxColumn";
            this.perSINGLEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // perJOBDataGridViewTextBoxColumn
            // 
            this.perJOBDataGridViewTextBoxColumn.DataPropertyName = "perJOB";
            this.perJOBDataGridViewTextBoxColumn.HeaderText = "perJOB";
            this.perJOBDataGridViewTextBoxColumn.Name = "perJOBDataGridViewTextBoxColumn";
            this.perJOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblSTAFFBindingSource
            // 
            this.tblSTAFFBindingSource.DataMember = "tbl_STAFF";
            this.tblSTAFFBindingSource.DataSource = this.personalDatabaseDataSet;
            // 
            // personalDatabaseDataSet
            // 
            this.personalDatabaseDataSet.DataSetName = "personalDatabaseDataSet";
            this.personalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_STAFFTableAdapter
            // 
            this.tbl_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 34);
            this.label8.TabIndex = 46;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // frmProje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(796, 694);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.MaximizeBox = false;
            this.Name = "frmProje";
            this.Text = "frmAnaform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStaffSecName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.ComboBox cmbStaffCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnSingle;
        private System.Windows.Forms.RadioButton rdbtnMarried;
        private System.Windows.Forms.TextBox txtStaffDuty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAllStatics;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnUptadeAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskdStaffSalary;
        private personalDatabaseDataSet personalDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblSTAFFBindingSource;
        private personalDatabaseDataSetTableAdapters.tbl_STAFFTableAdapter tbl_STAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSECNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perSINGLEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

