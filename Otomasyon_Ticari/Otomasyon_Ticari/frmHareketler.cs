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
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void musterihareketleriListele()
        {
            DataSet ds1 = new DataSet();
            NpgsqlDataAdapter da1= new NpgsqlDataAdapter("select * from musterihareketleribilgisi()", bgl.baglanti());
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
            gridControl2.DataSource = ds.Tables[0];
        }

        private void frmHareketler_Load(object sender, EventArgs e)
        {
            musterihareketleriListele();
            firmahareketleriBilgisi();
        }
    }
}
