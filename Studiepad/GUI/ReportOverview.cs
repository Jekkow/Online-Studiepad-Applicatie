using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studiepad.Logic;

namespace Studiepad.GUI
{
    public partial class ReportOverview : Form
    {
        public ReportOverview()
        {
            InitializeComponent();
        }

        //Method to activate cancel buton
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportOverview_Load(object sender, EventArgs e)
        {
            ReportNameTextBox.ReadOnly = true;
            ReportTypeTextBox.ReadOnly = true;
            ReportDescriptionTextBox.ReadOnly = true;
            ReportPublishedTextBox.ReadOnly = true;
            ReportOverviewDatagrid.ReadOnly = true;
            RefreshReportDataGrid();
        }

        //Method to refresh the Hour Datagrid
        private void RefreshReportDataGrid()
        {
            Teamleader teamleader = new Teamleader();

            List<Report> AvailableReports = teamleader.ListReports();
            DataTable reportstable = new DataTable();
            reportstable.Columns.Add("ID", typeof(int));
            reportstable.Columns.Add("Naam", typeof(string));
            reportstable.Columns.Add("Type", typeof(string));
            reportstable.Columns.Add("Beschrijving", typeof(string));
            reportstable.Columns.Add("Gepubliceerd op", typeof(DateTime));

            //Fill datagrid with reportdata
            for(int i = 0; i < AvailableReports.Count(); i++)
            {
                reportstable.Rows.Add(AvailableReports[i].GetID(), AvailableReports[i].GetName(), AvailableReports[i].GetType(), AvailableReports[i].GetShortDescription(), AvailableReports[i].GetPublished().ToString());
            }

            ReportOverviewDatagrid.DataSource = reportstable;
            ReportOverviewDatagrid.Refresh();
            ReportOverviewDatagrid.Columns[0].MinimumWidth = 40;
            ReportOverviewDatagrid.Columns[3].MinimumWidth = 220;
        }

        //Method to sync textboxes and cells in Datagridview
        private void ReportOverviewDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReportNameTextBox.Text = ReportOverviewDatagrid[1, e.RowIndex].Value.ToString();
            ReportTypeTextBox.Text = ReportOverviewDatagrid[2, e.RowIndex].Value.ToString();
            ReportDescriptionTextBox.Text = ReportOverviewDatagrid[3, e.RowIndex].Value.ToString();
            ReportPublishedTextBox.Text = ReportOverviewDatagrid[4, e.RowIndex].Value.ToString();            
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            ReportDataView reportWindow = new ReportDataView(ReportNameTextBox.Text);
            reportWindow.Show();
        }
    }
}
