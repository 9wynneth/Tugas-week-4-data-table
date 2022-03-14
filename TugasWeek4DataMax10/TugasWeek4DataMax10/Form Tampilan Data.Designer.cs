
namespace TugasWeek4DataMax10
{
    partial class Form_Tampilan_Data
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
            this.txtboxInputTelpTampilan = new System.Windows.Forms.TextBox();
            this.lblTelpTampilan = new System.Windows.Forms.Label();
            this.lblAlamatTampilan = new System.Windows.Forms.Label();
            this.txtboxInputNamaTampilan = new System.Windows.Forms.TextBox();
            this.lblNamaTampilan = new System.Windows.Forms.Label();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.txtBoxInputanAlamatTampilan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxInputTelpTampilan
            // 
            this.txtboxInputTelpTampilan.Enabled = false;
            this.txtboxInputTelpTampilan.Location = new System.Drawing.Point(122, 125);
            this.txtboxInputTelpTampilan.Name = "txtboxInputTelpTampilan";
            this.txtboxInputTelpTampilan.Size = new System.Drawing.Size(202, 26);
            this.txtboxInputTelpTampilan.TabIndex = 11;
            // 
            // lblTelpTampilan
            // 
            this.lblTelpTampilan.AutoSize = true;
            this.lblTelpTampilan.Location = new System.Drawing.Point(31, 129);
            this.lblTelpTampilan.Name = "lblTelpTampilan";
            this.lblTelpTampilan.Size = new System.Drawing.Size(43, 20);
            this.lblTelpTampilan.TabIndex = 10;
            this.lblTelpTampilan.Text = "Telp:";
            // 
            // lblAlamatTampilan
            // 
            this.lblAlamatTampilan.AutoSize = true;
            this.lblAlamatTampilan.Location = new System.Drawing.Point(31, 82);
            this.lblAlamatTampilan.Name = "lblAlamatTampilan";
            this.lblAlamatTampilan.Size = new System.Drawing.Size(63, 20);
            this.lblAlamatTampilan.TabIndex = 8;
            this.lblAlamatTampilan.Text = "Alamat:";
            // 
            // txtboxInputNamaTampilan
            // 
            this.txtboxInputNamaTampilan.Enabled = false;
            this.txtboxInputNamaTampilan.Location = new System.Drawing.Point(122, 32);
            this.txtboxInputNamaTampilan.Name = "txtboxInputNamaTampilan";
            this.txtboxInputNamaTampilan.Size = new System.Drawing.Size(501, 26);
            this.txtboxInputNamaTampilan.TabIndex = 7;
            // 
            // lblNamaTampilan
            // 
            this.lblNamaTampilan.AutoSize = true;
            this.lblNamaTampilan.Location = new System.Drawing.Point(31, 38);
            this.lblNamaTampilan.Name = "lblNamaTampilan";
            this.lblNamaTampilan.Size = new System.Drawing.Size(55, 20);
            this.lblNamaTampilan.TabIndex = 6;
            this.lblNamaTampilan.Text = "Nama:";
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(199, 180);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(125, 48);
            this.btnPrevData.TabIndex = 13;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(35, 180);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(125, 48);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(363, 180);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(125, 48);
            this.btnNextData.TabIndex = 14;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // txtBoxInputanAlamatTampilan
            // 
            this.txtBoxInputanAlamatTampilan.AccessibleName = "";
            this.txtBoxInputanAlamatTampilan.Enabled = false;
            this.txtBoxInputanAlamatTampilan.Location = new System.Drawing.Point(122, 82);
            this.txtBoxInputanAlamatTampilan.Name = "txtBoxInputanAlamatTampilan";
            this.txtBoxInputanAlamatTampilan.Size = new System.Drawing.Size(652, 26);
            this.txtBoxInputanAlamatTampilan.TabIndex = 15;
            // 
            // Form_Tampilan_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.txtBoxInputanAlamatTampilan);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtboxInputTelpTampilan);
            this.Controls.Add(this.lblTelpTampilan);
            this.Controls.Add(this.lblAlamatTampilan);
            this.Controls.Add(this.txtboxInputNamaTampilan);
            this.Controls.Add(this.lblNamaTampilan);
            this.Name = "Form_Tampilan_Data";
            this.Text = "Form_Tampilan_Data";
            this.Load += new System.EventHandler(this.Form_Tampilan_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInputTelpTampilan;
        private System.Windows.Forms.Label lblTelpTampilan;
        private System.Windows.Forms.Label lblAlamatTampilan;
        private System.Windows.Forms.TextBox txtboxInputNamaTampilan;
        private System.Windows.Forms.Label lblNamaTampilan;
        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.TextBox txtBoxInputanAlamatTampilan;
    }
}