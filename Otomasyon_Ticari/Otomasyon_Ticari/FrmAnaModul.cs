using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Ticari
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        frmAnasayfa fr15;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr15 = new frmAnasayfa();
            fr15.MdiParent = this;
            fr15.Show();
        }

        FrmUrunler fr;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr = new FrmUrunler();
            fr.MdiParent = this;
            fr.Show();
        }
        frmMusteriler fr2;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new frmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
                
            }
            
        }

        frmFirma fr3;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr3 = new frmFirma();
            fr3.MdiParent = this;
            fr3.Show();

        }

        frmPersoneller fr4;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr4 = new frmPersoneller();
            fr4.MdiParent = this;
            fr4.Show();
        }
        frmRehber fr5;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr5 = new frmRehber();
            fr5.MdiParent = this;
            fr5.Show();
        }

        frmGiderler fr6;

        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr6 = new frmGiderler();
            fr6.MdiParent = this;
            fr6.Show();
        }

        frmBankalar fr7;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr7 = new frmBankalar();
            fr7.MdiParent = this;
            fr7.Show();
        }
        frmFatura fr8;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr8 = new frmFatura();
            fr8.MdiParent = this;
            fr8.Show();
        }
        frmNotlar fr9;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr9 = new frmNotlar();
            fr9.MdiParent = this;
            fr9.Show();
        }
        frmHareketler fr10;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr10 = new frmHareketler();
            fr10.MdiParent = this;
            fr10.Show();
        }

        public string kullanici;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            fr15 = new frmAnasayfa();
            fr15.MdiParent = this;
            fr15.Show();
        }
        frmRaporlar fr11;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr11 = new frmRaporlar();
            fr11.MdiParent = this;
            fr11.Show();
        }
        frmStoklar fr12;
        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr12 = new frmStoklar();
            fr12.MdiParent = this;
            fr12.Show();

        }
        frmAyarlar fr13;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr13 = new frmAyarlar();
            //fr13.MdiParent = this;
            fr13.Show();
        }
        frmKasa fr14;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr14 = new frmKasa();
            fr14.ad = kullanici;
            fr14.MdiParent = this;
            fr14.Show();
        }
    }
}
