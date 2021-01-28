using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class ProductReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReportData"] != null)
            {
                var productList = Session["ReportData"] as List<ProductCls>;
                CrystalReport1 infoReport = new CrystalReport1();
                infoReport.SetDataSource(productList);
                CrystalReportViewer1.ReportSource = infoReport;
            }
        }
    }
}