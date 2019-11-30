using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Affairs_v2._7.Classes {
    class ExcelOptions {
        public static DataTable SelectExcelFile() {
            ;
            #region Out Sourcing Code to take data from excel file
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WordBook|*.xls", ValidateNames = true }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    DataSet tempData = reader.AsDataSet();
                    reader.Close();
                    return tempData.Tables[0];
                }
            }
            #endregion
            return null;
        }
    }
}
