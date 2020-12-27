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
    public partial class stokDetay : Form
    {
        public stokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        private void stokDetay_Load(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * From \"TBL_URUNLER\" WHERE \"URUNAD\"='"+ad+"'", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
    }
}
