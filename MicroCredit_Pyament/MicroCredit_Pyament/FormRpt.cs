using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroCredit_Pyament
{
    public partial class FormRpt : Form
    {
        public FormRpt()
        {
            InitializeComponent();
        }

        private void FormRpt_Load(object sender, EventArgs e)
        {
            PaymentByClient rpt = new PaymentByClient();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clients", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clients");
            da.SelectCommand.CommandText = "SELECT * FROM Payments";
            da.Fill(ds, "Payments");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
