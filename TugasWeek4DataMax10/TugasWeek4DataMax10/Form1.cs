using System;
using System.Data;
using System.Windows.Forms;

namespace TugasWeek4DataMax10
{
    public partial class Form_Penambahan_Data : Form
    {
        public static string TextNama = "";
        public static string TextAlamat = "";
        public static string TextTelp = "";

        public Form_Penambahan_Data()
        {
            InitializeComponent();
        }
        public DataTable data = new DataTable();
        private void btnLihatData_Click(object sender, EventArgs e)
        {
            Form_Penambahan_Data formPertama = new Form_Penambahan_Data();
            this.Hide();
            Form_Tampilan_Data formData = new Form_Tampilan_Data(data);
            formData.ShowDialog();
            this.Show();
        }

        private void Form_Penambahan_Data_Load(object sender, EventArgs e)
        {
            data.Columns.Add(lblNama.Text, typeof(string));
            data.Columns.Add(lblAlamat.Text, typeof(string));
            data.Columns.Add(lblTelp.Text, typeof(string));
        }
        public static string nama = "";
        public static int dataKe = 0;

        public void btnSimpan_Click(object sender, EventArgs e)
        {

            if (txtboxInputNama.Text == "" || txtboxInputAlamat.Text == "" || txtboxInputTelp.Text == "")
            {
                MessageBox.Show("Data belum terisi lengkap!");
            }
            else
            {
                TextNama = txtboxInputNama.Text;
                TextAlamat = txtboxInputAlamat.Text;
                TextTelp = txtboxInputTelp.Text;
                data.Rows.Add(TextNama, TextAlamat, TextTelp);
                if (data.Rows.Count == 1)
                {
                    TextNama = txtboxInputNama.Text;
                    TextAlamat = txtboxInputAlamat.Text;
                    TextTelp = txtboxInputTelp.Text;
                }
                if (data.Rows.Count == 10)
                {
                    MessageBox.Show("Data telah penuh!");
                }
                else
                {
                    TextNama = data.Rows[dataKe][0].ToString();
                    TextAlamat = data.Rows[dataKe][1].ToString();
                    TextTelp = data.Rows[dataKe][2].ToString();
                    dataKe++;
                }
            }

        }

        private void txtboxInputTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

    }
}
