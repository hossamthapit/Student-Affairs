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

        Dictionary<string, int> columnsIndex = new Dictionary<string, int>();

        public Excel_Show() {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Format = "N2";
        }

        private void buttonSelectExcel_Click(object sender, EventArgs e) {
           
            #region Out Sourcing Code to take data from excel file
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                columnsIndex[dataGridView1.Columns[i].HeaderText] = i;
                comboCoulms.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void labelExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void comboCoulms_SelectedIndexChanged(object sender, EventArgs e) {
            string SelectedValue = comboCoulms.Items[comboCoulms.SelectedIndex].ToString();
            comboCoulms.Items.RemoveAt(comboCoulms.SelectedIndex);
            comboHideColumns.Items.Add(SelectedValue);        
            dataGridView1.Columns[columnsIndex[SelectedValue]].Visible=true;
        }

        private void pictureSetting_Click(object sender, EventArgs e) {
            new AddUser().ShowDialog();
        }

        private void comboHideColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string SelectedValue = comboHideColumns.Items[comboHideColumns.SelectedIndex].ToString();
            comboHideColumns.Items.RemoveAt(comboHideColumns.SelectedIndex);
            comboCoulms.Items.Add(SelectedValue);
            dataGridView1.Columns[columnsIndex[SelectedValue]].Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e) {
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

        private void btnSaveExcel_Click(object sender, EventArgs e) {

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
    }
}