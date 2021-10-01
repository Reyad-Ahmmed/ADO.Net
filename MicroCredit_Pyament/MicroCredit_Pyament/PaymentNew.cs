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
    public partial class PaymentNew : Form
    {
        public PaymentNew()
        {
            InitializeComponent();
        }
        public IParentForm CallerForm { get; set; }
        private void PaymentNew_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT ISNULL(MAX(PaymentId), 0)+1 FROM Payments";

                    con.Open();
                    int id = (int)cmd.ExecuteScalar();
                    con.Close();
                    lblPid.Text = id.ToString();
                }
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT ClientId, ClientName FROM Clients", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbClient.DataSource = dt;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Payments" +
                        "(PaymentId, ClientId, PaymentDate, PayAmount) " +
                        "VALUES(@id, @cid, @pd,@pa)";
                    cmd.Parameters.AddWithValue("@id", lblPid.Text);
                    cmd.Parameters.AddWithValue("@cid", cbClient.SelectedValue);
                    cmd.Parameters.AddWithValue("@pd", dpPD.Value.Date);
                    cmd.Parameters.AddWithValue("@pa", txtPAm.Text);
                  
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.CallerForm.ReloadPayments();

                    
                    this.Close();
                }
            }
        }
    }
}
