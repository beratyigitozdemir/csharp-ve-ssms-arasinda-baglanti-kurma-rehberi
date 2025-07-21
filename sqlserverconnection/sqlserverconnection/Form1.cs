using System.Data;
using Microsoft.Data.SqlClient;

namespace sqlserverconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }

        string connectionString = "Server=BERAT;Database=KisiVeritabani;Integrated Security=True;TrustServerCertificate=True;";
        private void KisileriListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Kisiler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKisiler.DataSource = dt;
            }
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Kisiler (Ad, Soyad) VALUES (@Ad, @Soyad)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", txtAd.Text);
                    command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kiþi kaydedildi.");

                    KisileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
