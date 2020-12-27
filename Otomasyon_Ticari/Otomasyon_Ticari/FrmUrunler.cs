using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Ticari
{

    public partial class FrmUrunler : Form
    {
        Baglanti bgl = new Baglanti();
        public FrmUrunler()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            maskYil.Text = "";
            nudAdet.Value = 0;
            txtAlisFyt.Text = "";
            txtSatisFyt.Text = "";
            richDetay.Text = "";
        }
        void listele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_URUNLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];


        }
        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_URUNLER\"(\"ADET\", \"ALISFYT\", \"SATISFYT\", \"DETAY\", \"MODEL\", \"URUNAD\", \"YIL\",\"MARKA\") VALUES(@p1, @p2, @p3 ,@p4,@p5 ,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", nudAdet.Value);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtAlisFyt.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtSatisFyt.Text));
            komut.Parameters.AddWithValue("@p4", richDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtModel.Text);
            komut.Parameters.AddWithValue("@p6", txtAd.Text);
            komut.Parameters.AddWithValue("@p7", maskYil.Text);
            komut.Parameters.AddWithValue("@p8", txtMarka.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Sisteme Eklend", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_URUNLER\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_URUNLER\" SET  \"ADET\" = @p1,  \"ALISFYT\" = @p2,\"SATISFYT\" = @p3,  \"DETAY\" = @p4, \"MODEL\" = @p5, \"URUNAD\" = @p6, \"YIL\" = @p7, \"MARKA\" = @p8 WHERE \"ID\" = @p9",bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", nudAdet.Value);
            komutGuncelle.Parameters.AddWithValue("@p2", decimal.Parse(txtAlisFyt.Text));
            komutGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtSatisFyt.Text));
            komutGuncelle.Parameters.AddWithValue("@p4", richDetay.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", txtModel.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", maskYil.Text);
            komutGuncelle.Parameters.AddWithValue("@p8", txtMarka.Text);
            komutGuncelle.Parameters.AddWithValue("@p9", int.Parse(txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            maskYil.Text = dr["YIL"].ToString();
            nudAdet.Value = int.Parse(dr["ADET"].ToString());
            txtAlisFyt.Text = dr["ALISFYT"].ToString();
            txtSatisFyt.Text = dr["SATISFYT"].ToString();
            richDetay.Text = dr["DETAY"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
    
}
