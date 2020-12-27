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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        void kullaniciListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from \"TBL_ADMIN\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            if (button1.Text == "Kaydet")
            {
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_ADMIN\"(\"KullaniciAd\", \"Sifre\") VALUES(@p1, @p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKadi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Kullanıcı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciListele();
            }
            if (button1.Text == "Guncelle") {
                NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_ADMIN\" SET  \"Sifre\" = @p1 WHERE \"KullaniciAd\" = @p2", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@p1", txtKadi.Text);
                komutGuncelle.Parameters.AddWithValue("@p2", txtSifre.Text);
                
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanici sifresi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kullaniciListele();
            }



            txtKadi.Text = "";
            txtSifre.Text = "";
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            kullaniciListele();
            txtKadi.Text = "";
            txtSifre.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtKadi.Text = dr["KullaniciAd"].ToString();
            txtSifre.Text= dr["Sifre"].ToString();
            button1.Text = "Guncelle";
            button1.BackColor = Color.Green;

        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {
            
                button1.Text = "Kaydet";
                button1.BackColor = Color.Gray;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Kaydet";
            button1.BackColor = Color.Gray;
        }
    }
}
