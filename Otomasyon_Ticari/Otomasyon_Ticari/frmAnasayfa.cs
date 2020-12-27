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
using System.Xml;

namespace Otomasyon_Ticari
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        void stoklar()
        {
            DataSet ds1 = new DataSet();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("SELECT \"URUNAD\", sum(\"ADET\") as \"Adet\" from \"TBL_URUNLER\" GROUP by \"URUNAD\" HAVING sum(\"ADET\")<=20 order by sum(\"ADET\")", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da1.Fill(ds1);
            gridControl1.DataSource = ds1.Tables[0];
        }

        void ajanda()
        {
            DataSet ds2 = new DataSet();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select  \"TARIH\" , \"SAAT\" , \"BASLIK\" FROM \"TBL_NOTLAR\" ORDER BY \"ID\" DESC", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da2.Fill(ds2);
            gridControl2.DataSource = ds2.Tables[0];
        }

        void firmahareketleriBilgisi()
        {
            DataSet ds3 = new DataSet();
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from firmahareketleriBilgisi()", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da3.Fill(ds3);
            gridControl3.DataSource = ds3.Tables[0];
        }

        void fihrist()
        {
            DataSet ds4 = new DataSet();
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select  \"AD\", \"TELEFON1\" from \"TBL_FIRMALAR\"", bgl.baglanti());
            // MessageBox.Show(da.ToString());
            da4.Fill(ds4);
            gridControl4.DataSource = ds4.Tables[0];
        }

        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.cnnturk.com/feed/rss/news");
            while (xmloku.Read())
            {
                
                    listBox1.Items.Add(xmloku.ToString());
                
            }
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            haberler();
            stoklar();
            ajanda();
            fihrist();
            firmahareketleriBilgisi();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
