using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace XtraVerticalGridNavigation {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            myVGridControl1.DataSource = CreateTable(50);
        }

        public DataTable CreateTable(int RowCount) {
            var tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (var i = 0; i < RowCount; i++) {
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            }
            return tbl;
        }

        private void chUseNavigator_CheckedChanged(object sender, EventArgs e) {
            myVGridControl1.UseEmbeddedNavigator = (sender as CheckBox).Checked;
        }
    }
}
