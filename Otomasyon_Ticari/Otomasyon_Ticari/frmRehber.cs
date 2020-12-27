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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void frmRehber_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select \"AD\",\"SOYADI\",\"TELEFON1\",\"TELEFON2\",\"MAIL\" From \"TBL_MUSTERİLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];

            DataSet ds2 = new DataSet();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("Select \"AD\",\"YETKILIADISOYADI\",\"TELEFON1\",\"TELEFON2\", \"TELEFON3\", \"MAIL\", \"FAX\" From \"TBL_FIRMALAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da2.Fill(ds2);
            gridControl2.DataSource = ds2.Tables[0];
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null) {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
