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
    
    public partial class Form1 : Form, IParentForm
    {
        DataSet ds = new DataSet();
        SqlDataAdapter daClients, daPayemnts;
        BindingSource bsClients = new BindingSource();
        BindingSource bsPayments = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString);
            daClients = new SqlDataAdapter("SELECT * FROM Clients", con);
            daPayemnts = new SqlDataAdapter("SELECT * FROM Payments", con);
            FillDataSet();
            SetUpDataBindings();
            SqlCommandBuilder b1 = new SqlCommandBuilder(daClients);
            SqlCommandBuilder b2 = new SqlCommandBuilder(daPayemnts);

            this.dataGridView1.DataSource = bsClients;
            this.dataGridView2.DataSource = bsPayments;
            this.cbClient.DataSource = bsClients;

            this.groupBox2.Text = $"Workers {bsClients.Position + 1} of {bsClients.Count }";
            this.groupBox4.Text = $"Payent {bsPayments.Position + 1} of {bsPayments.Count }";

            var dt = (bsClients.Current as DataRowView)?.Row?.ItemArray[5];
            if (dt != null)
            {
                dpLD.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpED.Value = DateTime.Today;
            }
            dt = (bsClients.Current as DataRowView)?.Row?.ItemArray[7];
            if (dt != null)
            {
                dpED.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpED.Value = DateTime.Today;
            }
            dt = (bsPayments.Current as DataRowView)?.Row?.ItemArray[2];
            if (dt != null)
            {
                dpPD.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpPD.Value = DateTime.Today;
            }
        }

        private void SetUpDataBindings()
        {
            bsClients.DataSource = ds;
            bsClients.DataMember = "Clients";
            bsPayments.DataSource = bsClients;
            bsPayments.DataMember = "FK_CLIENT_PAYMENT";

            bsClients.CurrentChanged += BsClients_CurrentChanged;
            bsPayments.CurrentChanged += BsPayments_CurrentChanged;

            lblCid.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "ClientId", true));
            txtcName.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "ClientName", true));
            txtCAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "Address", true));
            txtCAm.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "LoanAMount", true));
            lblTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "TotalAmountToPay", true));
            lblPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsClients, "MinPayPerMonth", true));
            pbPic.DataBindings.Add(new System.Windows.Forms.Binding("Image", bsClients, "Picture", true));

            lblPid.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsPayments, "PaymentId", true));
            txtPAm.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsPayments, "PayAmount", true));
            cbClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", bsPayments, "ClientId", true));
        }

        private void BsPayments_CurrentChanged(object sender, EventArgs e)
        {
            this.groupBox4.Text = $"Payment {bsPayments.Position + 1} of {bsPayments.Count }";
            var dt = (bsPayments.Current as DataRowView)?.Row?.ItemArray[2];
            if (dt != null)
            {
                dpPD.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpPD.Value = DateTime.Today;
            }

        }

        private void BsClients_CurrentChanged(object sender, EventArgs e)
        {
            this.groupBox2.Text = $"Workers {bsClients.Position + 1} of {bsClients.Count }";

            var dt = (bsClients.Current as DataRowView)?.Row?.ItemArray[5];
            if (dt != null)
            {
                dpLD.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpED.Value = DateTime.Today;
            }
            dt = (bsClients.Current as DataRowView)?.Row?.ItemArray[7];
            if (dt != null)
            {
                dpED.Value = ((DateTime)dt).Date;
            }
            else
            {
                dpED.Value = DateTime.Today;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClientNew() { CallerForm=this}.ShowDialog();
        }

        private void FillDataSet()
        {
            daClients.Fill(ds, "Clients");
            daPayemnts.Fill(ds, "Payments");
            ds.Tables["Clients"].PrimaryKey = new DataColumn[] { ds.Tables["Clients"].Columns["ClientId"] };
            ds.Tables["Payments"].PrimaryKey = new DataColumn[] { ds.Tables["Payments"].Columns["PaymentId"] };
            DataRelation rel = new DataRelation("FK_CLIENT_PAYMENT", ds.Tables["Clients"].Columns["ClientId"], ds.Tables["Payments"].Columns["ClientId"]);
            ds.Relations.Add(rel);
        }

        public void ReloadClients()
        {
            daClients.Fill(ds, "Clients");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PaymentNew() { CallerForm = this }.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bsClients.EndEdit();
            this.daClients.Update(ds.Tables["Clients"]);
            ds.Tables["Clients"].AcceptChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.bsPayments.EndEdit();
            this.daPayemnts.Update(ds.Tables["Payments"]);
            ds.Tables["Payments"].AcceptChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bsClients.EndEdit();
            var r = ds.Tables["Clients"].Rows.Find(int.Parse(lblCid.Text));
            r.Delete();
            this.daClients.Update(ds.Tables["Clients"]);
            ds.Tables["Clients"].AcceptChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bsPayments.EndEdit();
            var r = ds.Tables["Payments"].Rows.Find(int.Parse(lblPid.Text));
            r.Delete();
            this.daPayemnts.Update(ds.Tables["Payments"]);
            ds.Tables["Payments"].AcceptChanges();
        }

        private void paymentByClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRpt().Show();
        }

        private void paymentByMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRpt1().Show();
        }

        public void ReloadPayments()
        {
            daPayemnts.Fill(ds, "Payments");
        }
    }
}
