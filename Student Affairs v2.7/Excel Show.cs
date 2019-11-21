using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Affairs_v2._7 {
    public partial class Excel_Show : Form {
        DataSet result ;
        bool[] wantedCoulmn = new bool[100];
        Dictionary<string, bool> dic = new Dictionary<string, bool>();

        public Excel_Show() {
            InitializeComponent();
        }

        private void buttonSelectExcel_Click(object sender, EventArgs e) {
           
            #region Out Sourcing Code
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WordBook|*.xls", ValidateNames = true }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    result = reader.AsDataSet();
                    reader.Close();
                }
            }
            #endregion
            dataGridView1.DataSource = result.Tables[0];

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                comboCoulms.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
        }

        private void labelExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboCoulms_SelectedIndexChanged(object sender, EventArgs e) {
            string SelectedValue = comboCoulms.Items[comboCoulms.SelectedIndex].ToString();
            dic.Add(SelectedValue, true);
            comboNeededCoulms.Items.Add(SelectedValue);
            comboCoulms.Items.RemoveAt(comboCoulms.SelectedIndex);
        }

        private void pictureSetting_Click(object sender, EventArgs e) {
            new AddUser().ShowDialog();
        }

        private void update_Click(object sender, EventArgs e) {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    if (!dic.ContainsKey(dataGridView1.Columns[i].HeaderText))
                        dataGridView1.Columns.RemoveAt(i--);
            
            comboCoulms.Items.Clear();
            comboNeededCoulms.Items.Clear();
        }
    }
}