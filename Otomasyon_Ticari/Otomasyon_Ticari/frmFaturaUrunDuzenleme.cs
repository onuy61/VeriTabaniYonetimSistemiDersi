using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Otomasyon_Ticari
{
    public partial class frmFaturaUrunDuzenleme : Form
    {
        public frmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }

        private void txtTutar_Properties_Click(object sender, EventArgs e)
        {

        }

        private void txtTutar_Properties_DoubleClick(object sender, EventArgs e)
        {

        }

        public string urunid;
        private void frmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            txtUrunId.Text = urunid;
          
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM \"TBL_FATURADETAY\" WHERE  \"FATURAURUNID\" = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse(urunid));
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtMiktar.Text = dr[1].ToString();
                txtBirimFiyat.Text = dr[2].ToString();
                txtTutar.Text = dr[3].ToString();


            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_FATURADETAY\" SET  \"URUNAD\" = @p1,  \"MIKTAR\" = @p2,\"BirimFIYAT\" = @p3,  \"TUTAR\" = @p4 WHERE \"FATURAURUNID\" = @p5", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", int.Parse(txtMiktar.Text));
            komutGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtBirimFiyat.Text));
            komutGuncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            komutGuncelle.Parameters.AddWithValue("@p5", int.Parse(txtUrunId.Text));

            
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Detay Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"FATURADETAY\" WHERE \"FATURAURUNID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtUrunId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Detayı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
    }
}
