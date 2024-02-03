using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TelephoneDirectory
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=TelephoneDirectory;Integrated Security=True");

		void listele()
		{
			connection.Open();
			SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER", connection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		void temizle()
		{
			TxtAd.Text = "";
			TxtID.Text = "";
			TxtEmail.Text = "";
			TxtSoyad.Text = "";
			MasketTelefon.Text = "";
			TxtAd.Focus();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();

		}

		private void BtnEkle_Click(object sender, EventArgs e)
		{

			connection.Open();
			SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD, TELEFON,MAIL) VALUES (@P1,@P2,@P3,@P4)", connection);

			komut.Parameters.AddWithValue("@P1", TxtAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@P3", MasketTelefon.Text);
			komut.Parameters.AddWithValue("@P4", TxtEmail.Text);
			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Yeni kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void BtnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}



		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = dataGridView1.SelectedCells[0].RowIndex;

			TxtID.Text = (dataGridView1.Rows[index].Cells[0].Value).ToString();
			TxtAd.Text = (dataGridView1.Rows[index].Cells[1].Value).ToString();
			TxtSoyad.Text = (dataGridView1.Rows[index].Cells[2].Value).ToString();
			MasketTelefon.Text = (dataGridView1.Rows[index].Cells[3].Value).ToString();
			TxtEmail.Text = (dataGridView1.Rows[index].Cells[4].Value).ToString();


		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			connection.Open();

			SqlCommand komut = new SqlCommand("update KISILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 where ID=@P5", connection);


			komut.Parameters.AddWithValue("@p5", TxtID.Text);
			komut.Parameters.AddWithValue("@P1", TxtAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@P3", MasketTelefon.Text);
			komut.Parameters.AddWithValue("@P4", TxtEmail.Text);

			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Kişi Bilgisi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			listele();


		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			connection.Open();

			SqlCommand komut = new SqlCommand("Delete From KISILER where ID=" + TxtID.Text, connection);

			komut.ExecuteNonQuery();
			connection.Close();

			MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

			listele();

		}
	}
}
