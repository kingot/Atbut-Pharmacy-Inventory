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
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace RentalSoftware.Report_Windows
{
    public partial class TodaySales : Form, IReportDocument
    {
        public TodaySales()
        {
            InitializeComponent();
           // new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void TodaySales_Load(object sender, EventArgs e)
        {
          reportViewer1.RefreshReport();
        }


        public IEnumerable<Telerik.Reporting.Report> Reports { get; }
        public string DocumentName { get; set; }
        public PageSettings PageSettings { get; set; }
        public IEnumerable<IReportParameter> ReportParameters { get; }
    }
}
