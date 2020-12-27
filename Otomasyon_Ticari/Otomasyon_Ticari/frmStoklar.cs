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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT \"URUNAD\", SUM( \"ADET\" )  AS \"STOK\" FROM  \"TBL_URUNLER\" GROUP BY \"URUNAD\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];

            NpgsqlCommand komut = new NpgsqlCommand("SELECT \"URUNAD\", SUM( \"ADET\" )  AS \"STOK\" FROM  \"TBL_URUNLER\" GROUP BY \"URUNAD\"", bgl.baglanti());

            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));

            }
            // Firmarlar için
            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT   \"IL\" ,COUNT(*) FROM \"TBL_FIRMALAR\" GROUP BY  \"IL\"", bgl.baglanti());

            NpgsqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 2"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));

            }
        }
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            stokDetay fr = new stokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
                fr.Show();
            }
        }
    }
}
