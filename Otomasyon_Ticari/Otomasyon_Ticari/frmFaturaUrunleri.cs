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
    public partial class frmFaturaUrunleri : Form
    {
        public frmFaturaUrunleri()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void faturaDetayListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECt * FROM \"TBL_FATURADETAY\" WHERE  \"FATURAID\" =" + id, bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        public string id;
        private void frmFaturaUrunleri_Load(object sender, EventArgs e)
        {
            faturaDetayListele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDuzenleme fr = new frmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.urunid= dr["FATURAURUNID"].ToString();
                fr.Show();
            }
        }
    }
}
