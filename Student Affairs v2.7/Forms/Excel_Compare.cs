using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;
using System.IO;

namespace Student_Affairs_v2._7.Forms {
    public partial class Excel_Compare : Form {
        Dictionary<long, byte> oldNationalId = new Dictionary<long, byte>();
        public Excel_Compare() {
            InitializeComponent();
        }

        private void buttonSelectExcel_Click(object sender, EventArgs e) {
            #region Out Sourcing Code to take data from excel file
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WordBook|*.xls", ValidateNames = true }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    dataGridView1.DataSource = reader.AsDataSet().Tables[0];
                    reader.Close();
                }
            }
            #endregion
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                if (dataGridView1.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for(int k = 0; k < dataGridView1.RowCount; k++) {
                        try { 
                            long ID = long.Parse(dataGridView1[i, k].Value.ToString());
                            oldNationalId.Add(ID, 1);
                        }
                        catch {
                            return;
                        }
                    }
                    return;
                }
            }
        }

        private void buttonSelectExcelNew_Click(object sender, EventArgs e) {
            #region Out Sourcing Code to take data from excel file
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WordBook|*.xls", ValidateNames = true }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    dataGridView1.DataSource = reader.AsDataSet().Tables[0];
                    reader.Close();
                }
            }
            #endregion
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridView2.ColumnCount; i++) {
                if (dataGridView2.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridView2.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridView2[i, k].Value.ToString());
                            if (!oldNationalId.Contains(new KeyValuePair<long, byte>(ID, 1))) {
                                oldNationalId.Add(ID, 3);
                            }
                            else
                                oldNationalId[ID] = 2; // to make remove true in the dictionary
                        }
                        catch {
                            //return;
                        }
                    }
                    return;
                }
            }

        }

        private void Excel_Compare_Load(object sender, EventArgs e) {

        }

        private void labelExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonCompare_Click(object sender, EventArgs e) {
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                if (dataGridView1.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridView1.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridView1[i, k].Value.ToString());
                            if (oldNationalId[ID] == 1)
                                dataGridView1.Rows[k].DefaultCellStyle.BackColor = Color.Red;
                        }
                        catch {
                            //return;
                        }
                    }
                    break;
                }
            }
            for (int i = 0; i < dataGridView2.ColumnCount; i++) {
                if (dataGridView2.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridView2.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridView2[i, k].Value.ToString());
                            if (oldNationalId[ID] == 3)
                                dataGridView2.Rows[k].DefaultCellStyle.BackColor = Color.Green;
                        }
                        catch {
                            //return;
                        }
                    }
                    return;
                }
            }



        }
    }
}
