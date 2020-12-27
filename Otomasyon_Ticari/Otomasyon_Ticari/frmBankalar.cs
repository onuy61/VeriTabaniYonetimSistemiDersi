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
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        void BankalarListele()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from bankabilgileri()", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        void firmaListesi()
        {
            DataTable ds1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select \"ID\", \"AD\" from \"TBL_FIRMALAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da1.Fill(ds1);
            looUpFirma.Properties.NullText = "Bir Firma Secin";
            looUpFirma.Properties.ValueMember ="ID";
            looUpFirma.Properties.DisplayMember ="AD";
            looUpFirma.Properties.DataSource=ds1;

        }
        void sehirlistele()
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("Select * From \"TBL_ILLER\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[1]);

            }
        }
        void ilcelistele()
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT \"ILCE\" FROM \"TBL_ILCELER\" WHERE  \"SEHIR\" = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);

            // MessageBox.Show(da.ToString());
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);

            }
        }
        private void frmBankalar_Load(object sender, EventArgs e)
        {
            BankalarListele();
            sehirlistele();
            firmaListesi();
            temizle();
        }
        void temizle()
        {
            txtBadi.Text = "";
            txtSube.Text = "";
            txtIban.Text = "";
            txtHesap.Text = "";
            txtYetkili.Text = "";
            txtTarih.Text = "";
            txtTarih.Text = "";
            txtHturu.Text = "";
            looUpFirma.Text = "";
            cmbIlce.Text = "";
            mskTelefon.Text = "";
            cmbIl.Text = "";
            txtId.Text = "";


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"TBL_BANKALAR\" ( \"BANKAADI\", \"SUBE\", \"IBAN\", \"HESAPNO\", \"YETKILI\", \"TARIH\", \"HESAPTURU\",\"FIRMAID\", \"IL\" ,\"ILCE\", \"TELEFON\") VALUES( @p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8,@p9,@p10,@11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtBadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSube.Text);
            komut.Parameters.AddWithValue("@p3", txtIban.Text);
            komut.Parameters.AddWithValue("@p4", txtHesap.Text);
            komut.Parameters.AddWithValue("@p5", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p6", txtTarih.Text);
            komut.Parameters.AddWithValue("@p7",txtHturu.Text );
           komut.Parameters.AddWithValue("@p8",looUpFirma.EditValue);
            komut.Parameters.AddWithValue("@p9",cmbIl.Text );
            komut.Parameters.AddWithValue("@p10", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p11", mskTelefon.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Banka Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankalarListele();
            temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            ilcelistele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["id"].ToString();
                txtBadi.Text = dr["BankaAdı"].ToString();
                txtSube.Text = dr["Sube"].ToString();
              txtIban.Text= dr["iban"].ToString();
                txtHesap.Text = dr["HesapNo"].ToString();
                txtYetkili.Text = dr["Yetkili"].ToString();
               txtTarih.Text = dr["tarih"].ToString();
                txtHturu.Text = dr["HesapTürü"].ToString();
               cmbIl.Text = dr["il"].ToString();
                cmbIlce.Text = dr["ilce"].ToString();
                mskTelefon.Text = dr["Telefon"].ToString();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti bgl = new Baglanti();
            //Verileri kaydetme
            NpgsqlCommand komutsil = new NpgsqlCommand("DELETE FROM \"TBL_BANKALAR\" WHERE \"ID\"=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));

            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BankalarListele();
        }
    }
}
