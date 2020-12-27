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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtId.Text = "";
            txtPAd.Text = "";
            txtGorev.Text = "";
            txtMail.Text = "";
            txtsoyad.Text = "";
            mskTc.Text = "";
            mskTel1.Text = "";
            richAdres.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";

            
        }
        Baglanti bgl = new Baglanti();
        void Personellistele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_PERSONELLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];


        }
        void sehirlistele()
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("Select * From \"TBL_ILLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[1]);

            }
        }
        void ilcelistele()
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT \"ILCE\" FROM \"TBL_ILCELER\" WHERE  \"SEHIR\" = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);

            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);

            }
        }
        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            Personellistele();
            sehirlistele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_PERSONELLER\" ( \"AD\", \"SOYAD\", \"TELEFON\", \"TC\", \"MAIL\", \"IL\", \"ILCE\", \"ADRES\", \"GOREV\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPAd.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTel1.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", richAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Personellistele();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            ilcelistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtPAd.Text = dr["AD"].ToString();
            mskTc.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            txtsoyad.Text = dr["SOYAD"].ToString();
            txtGorev.Text = dr["GOREV"].ToString();
            cmbIl.Text = dr["IL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            richAdres.Text = dr["ADRES"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_PERSONELLER\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Personellistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_PERSONELLER\" SET  \"AD\"=@p1, \"SOYAD\"=@p2, \"TELEFON\"=@p3, \"TC\"=@p4, \"MAIL\"=@p5, \"IL\"=@p6, \"ILCE\"=@p7, \"ADRES\"=@p8, \"GOREV\"=@p9  WHERE \"ID\" = @p10", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", txtPAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", mskTel1.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", mskTc.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", txtMail.Text);
            
            komutGuncelle.Parameters.AddWithValue("@p6", cmbIl.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komutGuncelle.Parameters.AddWithValue("@p8", richAdres.Text);
            komutGuncelle.Parameters.AddWithValue("@p9", txtGorev.Text);
            komutGuncelle.Parameters.AddWithValue("@p10", int.Parse(txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Personellistele();
        }
    }
}
