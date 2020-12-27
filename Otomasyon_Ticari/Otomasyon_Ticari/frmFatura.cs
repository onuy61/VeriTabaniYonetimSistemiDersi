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
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void faturaListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_FATURABILGI\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            faturaListele();
            temizle();
        }

        void temizle() {
            txtId.Text = "";
            txtSeri.Text="";
            txtSira.Text = "";
            dateTarih.Text = "";
            timeSaat.Text = "";
            vergi.Text = "";
            txtAlici.Text = "";
            txtTeslimEden.Text = "";
            txtTesliMAlan.Text = "";
            txtUrunAd.Text = "";
            txtMiktar.Text = "";

            txtBirimFiyat.Text = "";
            txtTutar.Text = "";
            txtFaturaid.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            if (txtFaturaid.Text == "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_FATURABILGI\" ( \"SERI\", \"SIRANO\", \"TARIH\", \"SAAT\", \"VERGIDAIRE\", \"ALICI\", \"TESLIMEDEN\", \"TESLIMALAN\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSira.Text);
                komut.Parameters.AddWithValue("@p3", dateTarih.EditValue);
                komut.Parameters.AddWithValue("@p4", timeSaat.EditValue);
                komut.Parameters.AddWithValue("@p5", vergi.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txtTesliMAlan.Text);


                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni FaturaBilgisi Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faturaListele();
            }
            if (txtFaturaid.Text != "") {
            
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_FATURADETAYI\" ( \"URUNAD\", \"MIKTAR\", \"BirimFIYAT\", \"TUTAR\", \"FATURAID\") VALUES( @p1, @p2, @p3, @p4,@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtBirimFiyat.Text));


                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut.Parameters.AddWithValue("@p5",int.Parse(txtFaturaid.Text));

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faturaListele();
            }

        }

        private void txtTutar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar_Properties_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void txtTutar_Properties_Click(object sender, EventArgs e)
        {
            double miktar, birimF, tutar;
     
            birimF = Convert.ToDouble(txtBirimFiyat.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = birimF * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_FATURABILGI\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            faturaListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAlici.Text = dr["ALICI"].ToString();
                timeSaat.Text = dr["SAAT"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                txtSira.Text= dr["SIRANO"].ToString();
                dateTarih.Text = dr["TARIH"].ToString();
                txtTesliMAlan.Text= dr["TESLIMALAN"].ToString();
                txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
               vergi.Text = dr["VERGIDAIRE"].ToString();
               

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunleri fr = new frmFaturaUrunleri();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                fr.id = dr["ID"].ToString();
                fr.Show();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
