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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void notlarListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_NOTLAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            notlarListele();
            temizle();
        }
        void temizle()
        {
            txtId.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtBaslik.Text = "";
            richDetay.Text = "";
            txtOlusturan.Text = "";
            txtHitap.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_NOTLAR\" ( \"TARIH\", \"SAAT\", \"BASLIK\", \"DETAY\", \"OLUSTURAN\", \"HITAP\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTarih.EditValue);
            komut.Parameters.AddWithValue("@p2", txtSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", richDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            
          
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Not Bilgisi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            notlarListele();
            temizle();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtBaslik.Text = dr["BASLIK"].ToString();
                txtHitap.Text = dr["HITAP"].ToString();
                txtOlusturan.Text = dr["OLUSTURAN"].ToString();
                txtSaat.Text = dr["SAAT"].ToString();
                txtTarih.Text = dr["TARIH"].ToString();
                richDetay.Text= dr["DETAY"].ToString();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_NOTLAR\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgisi Sİlindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            notlarListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_NOTLAR\" SET  \"TARIH\" = @p1,  \"SAAT\" = @p2,\"BASLIK\" = @p3,  \"DETAY\" = @p4, \"OLUSTURAN\" = @p5, \"HITAP\" = @p6  WHERE \"ID\" = @p7", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", DateTime.Parse( txtTarih.Text));
            komutGuncelle.Parameters.AddWithValue("@p2", txtSaat.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", richDetay.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", txtHitap.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", int.Parse(txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notlar Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            notlarListele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay fr = new frmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["DETAY"].ToString();
                fr.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
