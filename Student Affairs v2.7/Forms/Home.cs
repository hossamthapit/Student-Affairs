using Excel;
using Student_Affairs_v2._7.Classes;
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
    public partial class Home : Form {
        DataSet result;
        Dictionary<string, int> columnsIndex = new Dictionary<string, int>();
        Dictionary<long, byte> oldNationalId = new Dictionary<long, byte>();

        public Home() {
            InitializeComponent();
        }

        private void labelExit1_Click(object sender, EventArgs e) {
            Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e) {
            listView1.Visible = true;
            panelChild.SelectTab(0);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e) {
            panelChild.SelectTab(1);
        }

        private void pictureBoxAddUser_Click(object sender, EventArgs e) {
            panelChild.SelectTab(2);
        }

        private void panelChoice_SelectedIndexChanged(object sender, EventArgs e) {
            //  panelChoice.SelectTab(0);
            listView1.Visible = false;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = ExcelOptions.SelectExcelFile();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                columnsIndex[dataGridView1.Columns[i].HeaderText] = i;
                comboCoulms.Items.Add(dataGridView1.Columns[i].HeaderText);
                listView1.Items.Add(dataGridView1.Columns[i].HeaderText, "Data/boy.jpg");
            }
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                dataGridView1.Columns[i].Visible = false;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++) {
                if ((i & 1) == 1) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void buttonSaveToExcel_Click(object sender, EventArgs e) {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();

            #region outsourcingc code to export excel sheet
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            #endregion
            dataGridView1.Select();

        }

        private void btnPrint_Click(object sender, EventArgs e) {
            #region Out Sourcing Printing Code
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "FCI ASSIUT UNIVERSITY";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Good By";
            printer.FooterSpacing = 15;
            // printer.PrinterName = "HP LaserJet 2300 Series PCL 5";
            printer.printDocument.PrinterSettings.Copies = 1;
            printer.PrintDataGridView(dataGridView1);
            #endregion            
        }

        private void comboHideColumns_SelectedIndexChanged_1(object sender, EventArgs e) {
            string SelectedValue = comboHideColumns.Items[comboHideColumns.SelectedIndex].ToString();
            comboHideColumns.Items.RemoveAt(comboHideColumns.SelectedIndex);
            comboCoulms.Items.Add(SelectedValue);
            dataGridView1.Columns[columnsIndex[SelectedValue]].Visible = false;


        }

        private void comboCoulms_SelectedIndexChanged_1(object sender, EventArgs e) {
            string SelectedValue = comboCoulms.Items[comboCoulms.SelectedIndex].ToString();
            comboCoulms.Items.RemoveAt(comboCoulms.SelectedIndex);
            comboHideColumns.Items.Add(SelectedValue);
            dataGridView1.Columns[columnsIndex[SelectedValue]].Visible = true;

        }

        private void buttonSelectExcelNew_Click(object sender, EventArgs e) {
            dataGridViewNewFile.DataSource = ExcelOptions.SelectExcelFile();
            dataGridViewNewFile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridViewNewFile.ColumnCount; i++) {
                if (dataGridViewNewFile.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridViewNewFile.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridViewNewFile[i, k].Value.ToString());
                            if (!oldNationalId.Contains(new KeyValuePair<long, byte>(ID, 1))) {
                                oldNationalId.Add(ID, 3);
                            }
                            else
                                oldNationalId[ID] = 2; // to make remove true in the dictionary
                        }
                        catch {
                            buttonSelectExcelNew.Enabled = false;
                            //return;
                        }
                    }
                    buttonSelectExcelNew.Enabled = false;
                    return;
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e) {
            try {
                dataContext data = new dataContext();
                User newUser = new User() {
                    _name = boxName.Text,
                    _userName = boxUserName.Text,
                    _password = boxPassword.Text
                };
                data.Users.Add(newUser);
                data.SaveChanges();
                new Message("Saved", 1);
            }
            catch {
                new Message("Wrong Hapen :(", 2);
            }
        }

        private void buttonSelectExcelOld_Click(object sender, EventArgs e) {
            dataGridViewOldFile.DataSource = ExcelOptions.SelectExcelFile();
            dataGridViewOldFile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridViewOldFile.ColumnCount; i++) {
                if (dataGridViewOldFile.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridViewOldFile.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridViewOldFile[i, k].Value.ToString());
                            oldNationalId.Add(ID, 1);
                        }
                        catch {
                            buttonSelectExcelNew.Enabled = true;
                            buttonSelectExcelOld.Enabled = false;
                            return;
                        }
                    }
                    buttonSelectExcelNew.Enabled = true;
                    buttonSelectExcelOld.Enabled = false;
                    return;
                }
            }
        }
    
        private void buttonCompare_Click(object sender, EventArgs e) {
            for (int i = 0; i < dataGridViewOldFile.ColumnCount; i++) {
                if (dataGridViewOldFile.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridViewOldFile.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridViewOldFile[i, k].Value.ToString());
                            if (oldNationalId[ID] == 1)
                                dataGridViewOldFile.Rows[k].DefaultCellStyle.BackColor = Color.Red;
                        }
                        catch {
                            //return;
                        }
                    }
                    break;
                }
            }
            for (int i = 0; i < dataGridViewNewFile.ColumnCount; i++) {
                if (dataGridViewNewFile.Columns[i].HeaderText.Contains("قوم")) { // الرقم القومي
                    for (int k = 0; k < dataGridViewNewFile.RowCount; k++) {
                        try {
                            long ID = long.Parse(dataGridViewNewFile[i, k].Value.ToString());
                            if (oldNationalId[ID] == 3)
                                dataGridViewNewFile.Rows[k].DefaultCellStyle.BackColor = Color.Green;
                        }
                        catch {
                            //return;
                        }
                    }
                    return;
                }
            }
        }

        private void Home_Load(object sender, EventArgs e) {
            
        }

        private void listView1_ItemCheck_1(object sender, ItemCheckEventArgs e) {
            string SelectedValue = listView1.Items[e.Index].Text;
            bool state = dataGridView1.Columns[columnsIndex[SelectedValue]].Visible;
            dataGridView1.Columns[columnsIndex[SelectedValue]].Visible = !state;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void PanelParent_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void buttonExcelOptions_Click(object sender, EventArgs e) {
            PanelParent.SelectTab(0);
        }

        private void buttonStudentOptions_Click(object sender, EventArgs e) {
            PanelParent.SelectTab(1);
        }
    }
}
