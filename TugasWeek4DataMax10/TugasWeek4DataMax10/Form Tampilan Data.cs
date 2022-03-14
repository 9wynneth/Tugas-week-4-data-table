using System;
using System.Data;
using System.Windows.Forms;

namespace TugasWeek4DataMax10
{
    public partial class Form_Tampilan_Data : Form
    {
        public static string TampilanNama = "";
        public static string TampilanAlamat = "";
        public static string TampilanTelp = "";
        public static int dataKe = 0;
        public DataTable dataTampilan = new DataTable();
        public Form_Tampilan_Data(DataTable data)
        {
            InitializeComponent();
            dataTampilan = data;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Tampilan_Data_Load(object sender, EventArgs e)
        {
            if (Form_Penambahan_Data.TextNama == "")
            {
                txtboxInputNamaTampilan.Text = "<data kosong>";
            }
            if (Form_Penambahan_Data.TextAlamat == "")
            {
                txtBoxInputanAlamatTampilan.Text = "<data kosong>";
            }
            if (Form_Penambahan_Data.TextTelp == "")
            {
                txtboxInputTelpTampilan.Text = "<data kosong>";
            }
            else
                txtboxInputNamaTampilan.Text = dataTampilan.Rows[0][0].ToString();
            txtBoxInputanAlamatTampilan.Text = dataTampilan.Rows[0][1].ToString(); ;
            txtboxInputTelpTampilan.Text = dataTampilan.Rows[0][2].ToString(); ;
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            if (dataKe == dataTampilan.Rows.Count - 1)
            {
                MessageBox.Show("Data sudah data yang terakhir");
            }
            else
            {
                dataKe++;
                txtboxInputNamaTampilan.Text = dataTampilan.Rows[dataKe][0].ToString();
                txtBoxInputanAlamatTampilan.Text = dataTampilan.Rows[dataKe][1].ToString();
                txtboxInputTelpTampilan.Text = dataTampilan.Rows[dataKe][2].ToString();
            }
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            if (dataKe == 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
            else
            {
                dataKe--;
                txtboxInputNamaTampilan.Text = dataTampilan.Rows[dataKe][0].ToString();
                txtBoxInputanAlamatTampilan.Text = dataTampilan.Rows[dataKe][1].ToString();
                txtboxInputTelpTampilan.Text = dataTampilan.Rows[dataKe][2].ToString();

            }
        }
    }
}
