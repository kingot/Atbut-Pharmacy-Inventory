using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalSoftware.Logic;
using Report;
using Telerik.Reporting;
using Telerik.ReportViewer.WinForms;

namespace RentalSoftware.Report_Windows
{
    public partial class OtherSalesReport : Form
    {
        public OtherSalesReport()
        {
            InitializeComponent();
           // reportType.Items.Add("you are");
           //this.Name= new CompanyLogic().GetCompanyInfo().CompanyName;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void reportType_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((string) reportType.SelectedItem == "Today Sales Report")
            {
                reportViewer1.ReportSource = new DailyReport();
               // reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
            }
                
                if ((string)reportType.SelectedItem == "Summary Sales Report")
                {
                reportViewer1.ReportSource = new DayMonthlyYearlyReport();
                //reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
                }

            if ((string)reportType.SelectedItem == "Detailed Sales Report")
            {
                reportViewer1.ReportSource = new DailyDetailReport();
               // reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
            }

            if ((string)reportType.SelectedItem == "Customer Order Report")
            {
                reportViewer1.ReportSource = new CustomerOrderReport();
                //reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
            }

            if ((string)reportType.SelectedItem == "Purchase Order Report")
            {
                reportViewer1.ReportSource = new PurchaseOrderReport();
              //  reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
            }

            if ((string)reportType.SelectedItem == "Expiry Drugs Report")
            {
                reportViewer1.ReportSource = new BrokenItemReport();
                //  reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ViewMode = ViewMode.Interactive;
                reportViewer1.RefreshReport();
            }

        }

        private void OtherSalesReport_Load(object sender, EventArgs e)
        {
           //reportTypeViwer.ReportSource= new OtherSalesReport();
        }

        private void reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (reportType.SelectedIndex == 1)
            //{
            //    var reportSource = new InstanceReportSource();
            //    reportSource.ReportDocument = new DailyDetailReport();
            //    reportTypeViwer.ReportSource = reportSource;
            //    reportTypeViwer.RefreshReport();
            //    reportTypeViwer.ReportSource = new DailyDetailReport();
            //    reportTypeViwer.RefreshReport();
            //}
        }

      //  public IReportDocument CustomerOrderReport { get;  set; }
    }
}
