namespace MicroCredit_Pyament
{
    partial class PaymentNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPid = new System.Windows.Forms.Label();
            this.txtPAm = new System.Windows.Forms.TextBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpPD = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(153, 30);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(60, 20);
            this.lblPid.TabIndex = 15;
            this.lblPid.Text = "label13";
            // 
            // txtPAm
            // 
            this.txtPAm.Location = new System.Drawing.Point(157, 129);
            this.txtPAm.Name = "txtPAm";
            this.txtPAm.Size = new System.Drawing.Size(248, 26);
            this.txtPAm.TabIndex = 14;
            // 
            // cbClient
            // 
            this.cbClient.DisplayMember = "ClientName";
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(157, 53);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(248, 28);
            this.cbClient.TabIndex = 12;
            this.cbClient.ValueMember = "ClientId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Payment Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Client Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Payment Id";
            // 
            // dpPD
            // 
            this.dpPD.CustomFormat = "MM/dd.yyyy";
            this.dpPD.Location = new System.Drawing.Point(157, 87);
            this.dpPD.Name = "dpPD";
            this.dpPD.Size = new System.Drawing.Size(248, 26);
            this.dpPD.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 32);
            this.button6.TabIndex = 16;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PaymentNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 349);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.txtPAm);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dpPD);
            this.Name = "PaymentNew";
            this.Text = "PaymentNew";
            this.Load += new System.EventHandler(this.PaymentNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.TextBox txtPAm;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpPD;
        private System.Windows.Forms.Button button6;
    }
}