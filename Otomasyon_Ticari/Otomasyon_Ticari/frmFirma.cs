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
    public partial class frmFirma : Form
    {
        Baglanti bgl = new Baglanti();
        public frmFirma()
        {
            InitializeComponent();
        }
        void firmaListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_FIRMALAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }

        void cariAciklama()
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("Select * From \"TBL_KODLAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                richtxt1.Text = dr[0].ToString();
                richtxt2.Text = dr[1].ToString();
                richtxt3.Text = dr[2].ToString();

            }
        }
        void temizle() {
            txtAd.Text = "";
            mskfaxNo.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            txtMail.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtKod3.Text = "";
            txtYetkili.Text = "";
            txtVergi.Text = "";
            txtSektor.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtyGorev.Text = "";
            richAdres.Text = "";
            mskTc.Text = "";
            txtId.Text = "";
            sehirlistele();
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
        private void txtsoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmFirma_Load(object sender, EventArgs e)
        {
            firmaListele();
            temizle();
            cariAciklama();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null) { 
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            mskTc.Text = dr["YETKILITC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            txtSektor.Text = dr["SEKTOR"].ToString();
            txtVergi.Text = dr["VERGIDAIRE"].ToString();
            cmbIl.Text = dr["IL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            richAdres.Text = dr["ADRES"].ToString();
            mskTel1.Text = dr["TELEFON1"].ToString();
            mskTel2.Text = dr["TELEFON2"].ToString();
            mskTel3.Text = dr["TELEFON2"].ToString();
            txtYetkili.Text = dr["YETKILIADISOYADI"].ToString();
            mskfaxNo.Text = dr["FAX"].ToString();
            txtKod1.Text = dr["OZELKOD1"].ToString();
            txtKod2.Text = dr["OZELKOD2"].ToString();
            txtKod3.Text = dr["OZELKOD3"].ToString();
            txtyGorev.Text = dr["YETKILISTATU"].ToString();
        }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_FIRMALAR\" ( \"AD\", \"ADRES\",\"FAX\", \"TELEFON1\", \"TELEFON2\",\"TELEFON3\", \"YETKILITC\", \"MAIL\",\"OZELKOD1\", \"OZELKOD2\", \"OZELKOD3\",  \"IL\", \"ILCE\",\"YETKILISTATU\",  \"SEKTOR\", \"YETKILIADISOYADI\", \"VERGIDAIRE\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", richAdres.Text);
            komut.Parameters.AddWithValue("@p3", mskfaxNo.Text);
            komut.Parameters.AddWithValue("@p4", mskTel1.Text);
            komut.Parameters.AddWithValue("@p5", mskTel2.Text);
            komut.Parameters.AddWithValue("@p6", mskTel3.Text);
            komut.Parameters.AddWithValue("@p7", mskTc.Text);
            try
            {
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
            }
            catch
            {
                MessageBox.Show("Maii Kontrol Ediniz");
            }
            komut.Parameters.AddWithValue("@p9", txtKod1.Text);
            komut.Parameters.AddWithValue("@p10", txtKod2.Text);
            komut.Parameters.AddWithValue("@p11", txtKod3.Text);
            komut.Parameters.AddWithValue("@p12", cmbIl.Text);
            komut.Parameters.AddWithValue("@p13", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p14", txtyGorev.Text);
            komut.Parameters.AddWithValue("@p15", txtSektor.Text);
            komut.Parameters.AddWithValue("@p16", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p17", txtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Firma Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListele();
            temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            ilcelistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_FIRMALAR\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            firmaListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_FIRMALAR\" SET  \"AD\"=@p1, \"ADRES\"=@p2,\"FAX\"=@p3, \"TELEFON1\"=@p4, \"TELEFON2\"=@p5,\"TELEFON3\"=@p6, \"YETKILITC\"=@p7, \"MAIL\"=@p8,\"OZELKOD1\"=@p9, \"OZELKOD2\"=@p10, \"OZELKOD3\"=@p11,  \"IL\"=@p12, \"ILCE\"=@p13,\"YETKILISTATU\"=@p14,  \"SEKTOR\"=@p15, \"YETKILIADISOYADI\"=@p16, \"VERGIDAIRE\"=@p17 WHERE \"ID\" = @p18", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", richAdres.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", mskfaxNo.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", mskTel1.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", mskTel2.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", mskTel3.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", mskTc.Text);
            try
            {
                komutGuncelle.Parameters.AddWithValue("@p8", txtMail.Text);
            }
            catch
            {
                MessageBox.Show("Maii Kontrol Ediniz");
            }
            komutGuncelle.Parameters.AddWithValue("@p9", txtKod1.Text);
            komutGuncelle.Parameters.AddWithValue("@p10", txtKod2.Text);
            komutGuncelle.Parameters.AddWithValue("@p11", txtKod3.Text);
            komutGuncelle.Parameters.AddWithValue("@p12", cmbIl.Text);
            komutGuncelle.Parameters.AddWithValue("@p13", cmbIlce.Text);
            komutGuncelle.Parameters.AddWithValue("@p14", txtyGorev.Text);
            komutGuncelle.Parameters.AddWithValue("@p15", txtSektor.Text);
            komutGuncelle.Parameters.AddWithValue("@p16", txtYetkili.Text);
            komutGuncelle.Parameters.AddWithValue("@p17", txtVergi.Text);
            komutGuncelle.Parameters.AddWithValue("@p18", int.Parse( txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmaListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
