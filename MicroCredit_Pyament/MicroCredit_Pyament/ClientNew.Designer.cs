namespace MicroCredit_Pyament
{
    partial class ClientNew
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
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.dpLD = new System.Windows.Forms.DateTimePicker();
            this.txtCAm = new System.Windows.Forms.TextBox();
            this.txtCAdd = new System.Windows.Forms.TextBox();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(481, 68);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(150, 150);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 24;
            this.pbPic.TabStop = false;
            // 
            // dpLD
            // 
            this.dpLD.CustomFormat = "MM/dd.yyyy";
            this.dpLD.Location = new System.Drawing.Point(192, 224);
            this.dpLD.Name = "dpLD";
            this.dpLD.Size = new System.Drawing.Size(200, 26);
            this.dpLD.TabIndex = 22;
            // 
            // txtCAm
            // 
            this.txtCAm.Location = new System.Drawing.Point(188, 179);
            this.txtCAm.Name = "txtCAm";
            this.txtCAm.Size = new System.Drawing.Size(200, 26);
            this.txtCAm.TabIndex = 21;
            // 
            // txtCAdd
            // 
            this.txtCAdd.Location = new System.Drawing.Point(188, 139);
            this.txtCAdd.Name = "txtCAdd";
            this.txtCAdd.Size = new System.Drawing.Size(200, 26);
            this.txtCAdd.TabIndex = 20;
            // 
            // txtcName
            // 
            this.txtcName.Location = new System.Drawing.Point(188, 98);
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(200, 26);
            this.txtcName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Client Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loadn Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loan Amt.";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(184, 68);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(51, 20);
            this.lblCid.TabIndex = 15;
            this.lblCid.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Picture";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png";
            // 
            // ClientNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.dpLD);
            this.Controls.Add(this.txtCAm);
            this.Controls.Add(this.txtCAdd);
            this.Controls.Add(this.txtcName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.label1);
            this.Name = "ClientNew";
            this.Text = "ClientNew";
            this.Load += new System.EventHandler(this.ClientNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.DateTimePicker dpLD;
        private System.Windows.Forms.TextBox txtCAm;
        private System.Windows.Forms.TextBox txtCAdd;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}