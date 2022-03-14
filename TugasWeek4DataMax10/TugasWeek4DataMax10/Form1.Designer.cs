
namespace TugasWeek4DataMax10
{
    partial class Form_Penambahan_Data
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtboxInputNama = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtboxInputAlamat = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtboxInputTelp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(33, 40);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(55, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // txtboxInputNama
            // 
            this.txtboxInputNama.Location = new System.Drawing.Point(124, 34);
            this.txtboxInputNama.Name = "txtboxInputNama";
            this.txtboxInputNama.Size = new System.Drawing.Size(501, 26);
            this.txtboxInputNama.TabIndex = 1;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(33, 84);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(63, 20);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat:";
            // 
            // txtboxInputAlamat
            // 
            this.txtboxInputAlamat.Location = new System.Drawing.Point(124, 82);
            this.txtboxInputAlamat.Name = "txtboxInputAlamat";
            this.txtboxInputAlamat.Size = new System.Drawing.Size(648, 26);
            this.txtboxInputAlamat.TabIndex = 3;
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(33, 131);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(43, 20);
            this.lblTelp.TabIndex = 4;
            this.lblTelp.Text = "Telp:";
            // 
            // txtboxInputTelp
            // 
            this.txtboxInputTelp.Location = new System.Drawing.Point(124, 127);
            this.txtboxInputTelp.Name = "txtboxInputTelp";
            this.txtboxInputTelp.Size = new System.Drawing.Size(202, 26);
            this.txtboxInputTelp.TabIndex = 5;
            this.txtboxInputTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxInputTelp_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(37, 192);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(125, 48);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(201, 192);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(125, 48);
            this.btnLihatData.TabIndex = 7;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // Form_Penambahan_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtboxInputTelp);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.txtboxInputAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtboxInputNama);
            this.Controls.Add(this.lblNama);
            this.Name = "Form_Penambahan_Data";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form_Penambahan_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtboxInputNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtboxInputAlamat;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtboxInputTelp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihatData;
    }
}

