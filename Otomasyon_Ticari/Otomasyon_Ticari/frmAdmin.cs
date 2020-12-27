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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
       
        private void simpleButton1_MouseHover(object sender, EventArgs e)
        {
            simpleButton1.BackColor = Color.Yellow;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT *FROM \"TBL_ADMIN\" WHERE  \"KullaniciAd\"= @p1 AND \"Sifre\"= @p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                fr.kullanici = txtKadi.Text;
                fr.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
