using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroCredit_Pyament
{
    public partial class ClientNew : Form
    {
        string pic = "";
        public ClientNew()
        {
            InitializeComponent();
        }
        public IParentForm CallerForm { get; set; }
        private void ClientNew_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT ISNULL(MAX(ClientId), 0)+1 FROM Clients";

                    con.Open();
                    int id = (int)cmd.ExecuteScalar();
                    con.Close();
                    lblCid.Text = id.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicroCredit_Pyament.Properties.Settings.creditpaymentdbcon"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Clients(ClientId, ClientName, Address,Picture, LoanAmount, LoanDate)" +
                        "VALUES(@id, @name, @add, @pic, @amt, @ld)";
                    cmd.Parameters.AddWithValue("@id", lblCid.Text);
                    cmd.Parameters.AddWithValue("@name", txtcName.Text);
                    cmd.Parameters.AddWithValue("@pic", File.ReadAllBytes(pic));
                    cmd.Parameters.AddWithValue("@add", txtCAdd.Text);
                    cmd.Parameters.AddWithValue("@amt",txtCAm.Text);
                    cmd.Parameters.AddWithValue("@ld", dpLD.Value.Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.CallerForm.ReloadClients();

                    pic = "";
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic = openFileDialog1.FileName;
                pbPic.Image = Image.FromFile(pic);
            }
        }
    }
}
