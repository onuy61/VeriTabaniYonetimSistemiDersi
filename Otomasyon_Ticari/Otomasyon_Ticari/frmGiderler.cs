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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void giderListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_GIDERLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            giderListele();
            temizle();
        }
        void temizle()
        {
            txtYil.Text = "";
            txtSu.Text = "";
            txtMaas.Text = "";
            txtInternet.Text = "";
            txtId.Text = "";
            txtGaz.Text = "";
            txtElektrik.Text = "";
            txtEkstra.Text = "";
            richNot.Text = "";
            cmbAy.Text = "";

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_GIDERLER\" ( \"ELEKTRIK\", \"SU\", \"DOGALGAZ\", \"INTERNET\", \"MAASLAR\", \"EKSTRA\", \"NOTLAR\", \"AY\", \"YIL\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtGaz.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtMaas.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@p7", richNot.Text);
            komut.Parameters.AddWithValue("@p8", cmbAy.Text);
            komut.Parameters.AddWithValue("@p9", txtYil.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Gider Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtElektrik.Text = dr["ELEKTRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtGaz.Text = dr["DOGALGAZ"].ToString();
                txtInternet.Text = dr["INTERNET"].ToString();
                txtMaas.Text = dr["MAASLAR"].ToString();
                txtEkstra.Text = dr["EKSTRA"].ToString();
                richNot.Text = dr["NOTLAR"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                txtYil.Text = dr["YIL"].ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_GIDERLER\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            giderListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE \"TBL_GIDERLER\" SET  \"ELEKTRIK\"=@p1, \"SU\"=@p2, \"DOGALGAZ\"=@p3, \"INTERNET\"=@p4, \"MAASLAR\"=@p5, \"EKSTRA\"=@p6, \"NOTLAR\"=@p7, \"AY\"=@p8, \"YIL\"=@p9  WHERE \"ID\" = @p10", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", decimal.Parse(txtElektrik.Text));
            komutGuncelle.Parameters.AddWithValue("@p2", decimal.Parse(txtSu.Text));
            komutGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtGaz.Text));
            komutGuncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            komutGuncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtMaas.Text));
            komutGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtEkstra.Text));
            komutGuncelle.Parameters.AddWithValue("@p7", richNot.Text);
            komutGuncelle.Parameters.AddWithValue("@p8", cmbAy.Text);
            komutGuncelle.Parameters.AddWithValue("@p9", txtYil.Text);
            komutGuncelle.Parameters.AddWithValue("@p10", int.Parse(txtId.Text));
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Belirlenen Gider Günellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();
            temizle();
        }
    }
}
