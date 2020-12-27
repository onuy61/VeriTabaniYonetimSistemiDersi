
namespace Otomasyon_Ticari
{
    partial class FrmAnaModul
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnUrunler,
            this.BtnStoklar,
            this.BtnMusteriler,
            this.BtnFirmalar,
            this.BtnAnaSayfa,
            this.BtnPersoneller,
            this.BtnGiderler,
            this.BtnKasa,
            this.BtnNotlar,
            this.BtnBankalar,
            this.BtnRehber,
            this.BtnFaturalar,
            this.BtnAyarlar,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1193, 153);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunler.ImageOptions.SvgImage")));
            this.BtnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 2;
            this.BtnStoklar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnStoklar.ImageOptions.SvgImage")));
            this.BtnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnStoklar_ItemClick);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "MÜŞTERİLER";
            this.BtnMusteriler.Id = 3;
            this.BtnMusteriler.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.team_16x16;
            this.BtnMusteriler.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.team_32x32;
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteriler_ItemClick);
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "FİRMALAR";
            this.BtnFirmalar.Id = 4;
            this.BtnFirmalar.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.bocontact2_16x16;
            this.BtnFirmalar.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.bocontact2_32x32;
            this.BtnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFirmalar.Name = "BtnFirmalar";
            this.BtnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFirmalar_ItemClick);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Caption = "ANASAYFA";
            this.BtnAnaSayfa.Id = 5;
            this.BtnAnaSayfa.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.home_16x16;
            this.BtnAnaSayfa.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.home_32x32;
            this.BtnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaSayfa_ItemClick);
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 6;
            this.BtnPersoneller.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.boposition2_16x16;
            this.BtnPersoneller.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.boposition2_32x32;
            this.BtnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnGiderler
            // 
            this.BtnGiderler.Caption = "GİDERLER";
            this.BtnGiderler.Id = 7;
            this.BtnGiderler.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.fieldheaderspivottable_16x16;
            this.BtnGiderler.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.fieldheaderspivottable_32x32;
            this.BtnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGiderler.Name = "BtnGiderler";
            this.BtnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGiderler_ItemClick);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 8;
            this.BtnKasa.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.currency2_16x16;
            this.BtnKasa.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.currency2_32x32;
            this.BtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKasa_ItemClick);
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 9;
            this.BtnNotlar.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.bonote_16x16;
            this.BtnNotlar.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.bonote_32x32;
            this.BtnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNotlar_ItemClick);
            // 
            // BtnBankalar
            // 
            this.BtnBankalar.Caption = "BANKALAR";
            this.BtnBankalar.Id = 10;
            this.BtnBankalar.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.accounting_16x16;
            this.BtnBankalar.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.accounting_32x32;
            this.BtnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBankalar.Name = "BtnBankalar";
            this.BtnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBankalar_ItemClick);
            // 
            // BtnRehber
            // 
            this.BtnRehber.Caption = "REHBER";
            this.BtnRehber.Id = 11;
            this.BtnRehber.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.phone_16x16;
            this.BtnRehber.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.phone_32x32;
            this.BtnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRehber.Name = "BtnRehber";
            this.BtnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRehber_ItemClick);
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.Caption = "FATURALAR";
            this.BtnFaturalar.Id = 12;
            this.BtnFaturalar.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.grandtotalsoffrowscolumnspivottable_16x16;
            this.BtnFaturalar.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.grandtotalsoffrowscolumnspivottable_32x32;
            this.BtnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFaturalar.Name = "BtnFaturalar";
            this.BtnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFaturalar_ItemClick);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 13;
            this.BtnAyarlar.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.technology_16x16;
            this.BtnAyarlar.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.technology_32x32;
            this.BtnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAyarlar_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "HAREKETLER";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.stretch_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.stretch_32x32;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "RAPORLAR";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.report2_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::Otomasyon_Ticari.Properties.Resources.report2_32x32;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.BackColor = System.Drawing.Color.Lime;
            this.ribbonPage1.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.ribbonPage1.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.ribbonPage1.Appearance.Options.UseBackColor = true;
            this.ribbonPage1.Appearance.Options.UseBorderColor = true;
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Appearance.Options.UseForeColor = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 661);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnGiderler;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnBankalar;
        private DevExpress.XtraBars.BarButtonItem BtnRehber;
        private DevExpress.XtraBars.BarButtonItem BtnFaturalar;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}

