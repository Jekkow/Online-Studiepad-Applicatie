using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Studiepad.GUI
{
    public partial class ReportDataView : Form
    {
        private string name;
        public ReportDataView(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void ReportDataView_Load(object sender, EventArgs e)
        {
            ReportDataDataGrid.ReadOnly = true;
            RefreshReportDataDataGrid();
        }

        //Method to sync datagrid with datatable
        private void RefreshReportDataDataGrid()
        {
            Logic.Report report = new Logic.Report();
            ReportDataDataGrid.DataSource = report.GetReport(name);
            ReportDataDataGrid.Refresh();
        }
    }
}
