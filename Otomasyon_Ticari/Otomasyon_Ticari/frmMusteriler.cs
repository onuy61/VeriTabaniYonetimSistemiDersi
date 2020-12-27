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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_MUSTERİLER\"", bgl.baglanti());
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
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex+1);

            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);

            }
        }
        private void labelControl11_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistele();
            txtMAd.Text = "";
            txtsoyad.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            richAdres.Text = "";
            txtVergi.Text = "";
            cmbIlce.Text = "";

        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            ilcelistele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_MUSTERİLER\" ( \"AD\", \"SOYADI\", \"TELEFON1\", \"TELEFON2\", \"TC\", \"MAIL\", \"İL\", \"ILCE\", \"ADRES\", \"VERGIDAIRE\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtMAd.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTel1.Text);
            komut.Parameters.AddWithValue("@p4", mskTel2.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", richAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtMAd.Text = "";
            txtsoyad.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            richAdres.Text = "";
            txtVergi.Text = "";
            cmbIlce.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_MUSTERİLER\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_MUSTERİLER\" SET  \"AD\" = @p1,  \"SOYADI\" = @p2,\"TELEFON1\" = @p3,  \"TELEFON2\" = @p4, \"TC\" = @p5, \"MAIL\" = @p6, \"İL\" = @p7, \"ILCE\" = @p8 ,\"ADRES\" = @p9,\"VERGIDAIRE\" = @p10  WHERE \"ID\" = @p11", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", txtMAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", mskTel1.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", mskTel2.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", mskTc.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", txtMail.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", cmbIl.Text);
            komutGuncelle.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komutGuncelle.Parameters.AddWithValue("@p9", richAdres.Text);
            komutGuncelle.Parameters.AddWithValue("@p10", txtVergi.Text);
            komutGuncelle.Parameters.AddWithValue("@p11", int.Parse(txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtMAd.Text = dr["AD"].ToString();
            mskTc.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            txtsoyad.Text = dr["SOYADI"].ToString();
            txtVergi.Text = dr["VERGIDAIRE"].ToString();
            cmbIl.Text = dr["İL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            richAdres.Text = dr["ADRES"].ToString();
            mskTel1.Text = dr["TELEFON1"].ToString();
            mskTel2.Text = dr["TELEFON2"].ToString();
        }
    }
    }

