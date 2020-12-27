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
using DevExpress.Charts;

namespace Otomasyon_Ticari
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void musterihareketleriListele()
        {
            DataSet ds1 = new DataSet();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from musterihareketleribilgisi()", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da1.Fill(ds1);
            gridControl1.DataSource = ds1.Tables[0];
        }
        void firmahareketleriBilgisi()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from firmahareketleriBilgisi()", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl3.DataSource = ds.Tables[0];
        }

        void giderler()
        {
            DataSet ds3 = new DataSet();
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from \"TBL_GIDERLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da3.Fill(ds3);
            gridControl2.DataSource = ds3.Tables[0];
        }
        public string ad;
        private void frmKasa_Load(object sender, EventArgs e)
        {
            lblAktif.Text = ad;
            musterihareketleriListele();
            firmahareketleriBilgisi();
            giderler();
            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT   sum(\"TUTAR\") from \"TBL_FATURADETAY\"", bgl.baglanti());

            NpgsqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblTutar.Text = dr2[0].ToString() + " TL";

            }

            NpgsqlCommand komut3 = new NpgsqlCommand("SELECT  (\"ELEKTRIK\"+\"SU\"+\"DOGALGAZ\" +\"INTERNET\"+\"EKSTRA\") FROM \"TBL_GIDERLER\" ORDER BY \"ID\" ASC", bgl.baglanti());

            NpgsqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblOdeme.Text = dr3[0].ToString() + " TL";

            }

            NpgsqlCommand komut4 = new NpgsqlCommand("SELECT   \"MAASLAR\" FROM \"TBL_GIDERLER\" ORDER BY \"ID\" ASC", bgl.baglanti());

            NpgsqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblPersonel.Text = dr4[0].ToString() + " TL";

            }

            NpgsqlCommand komut5= new NpgsqlCommand("SELECT   COUNT(*) FROM \"TBL_MUSTERİLER\" ", bgl.baglanti());

            NpgsqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblMusteri.Text = dr5[0].ToString();

            }

            NpgsqlCommand komut6 = new NpgsqlCommand("SELECT   COUNT(*) FROM \"TBL_FIRMALAR\" ", bgl.baglanti());

            NpgsqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblFirma.Text = dr6[0].ToString();

            }

            NpgsqlCommand komut7 = new NpgsqlCommand("select count(DISTINCT(\"IL\")) from \"TBL_FIRMALAR\"", bgl.baglanti());

            NpgsqlDataReader dr7 = komut7.ExecuteReader();
            while (dr6.Read())
            {
                lblSehir.Text = dr7[0].ToString();

            }

            NpgsqlCommand komut8 = new NpgsqlCommand("SELECT   COUNT(*) FROM \"TBL_PERSONELLER\" ", bgl.baglanti());

            NpgsqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblPersonelSayisi.Text= dr8[0].ToString();

            }

            NpgsqlCommand komut10 = new NpgsqlCommand("SELECT   SUM(\"ADET\") FROM \"TBL_URUNLER\" ", bgl.baglanti());

            NpgsqlDataReader dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                lblStok.Text = dr10[0].ToString();

            }

            

            NpgsqlCommand komut12 = new NpgsqlCommand("select \"AY\",\"SU\" from  \"TBL_GIDERLER\" order by \"ID\" LIMIT 4", bgl.baglanti());

            NpgsqlDataReader dr12 = komut12.ExecuteReader();
            while (dr12.Read())
            {
                chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac < 5)

            {
                groupControl10.Text = "Elektrik";
                NpgsqlCommand komut11 = new NpgsqlCommand("select \"AY\",\"ELEKTRIK\" from  \"TBL_GIDERLER\" order by \"ID\" LIMIT 4", bgl.baglanti());

                NpgsqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
            }
            if (sayac > 5 && sayac < 10)
                groupControl10.Text = "SU";
            {
                chartControl1.Series["Aylar"].Points.Clear();
                NpgsqlCommand komut12 = new NpgsqlCommand("select \"AY\",\"SU\" from  \"TBL_GIDERLER\" order by \"ID\" LIMIT 4", bgl.baglanti());

                NpgsqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

                }

            }

            if (sayac > 10 && sayac < 15)

            {
                groupControl10.Text = "Dogalgaz";
                NpgsqlCommand komut13 = new NpgsqlCommand("select \"AY\",\"DOGALGAZ\" from  \"TBL_GIDERLER\" order by \"ID\" LIMIT 4", bgl.baglanti());

                NpgsqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));

                }
            }
            if (sayac > 15 && sayac < 20)
                groupControl10.Text = "İnternet";
            {
                chartControl1.Series["Aylar"].Points.Clear();
                NpgsqlCommand komut14 = new NpgsqlCommand("select \"AY\",\"INTERNET\" from  \"TBL_GIDERLER\" order by \"ID\" LIMIT 4", bgl.baglanti());

                NpgsqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));

                }

            }
            if (sayac == 26) { sayac = 0; }
        }
    }
}
