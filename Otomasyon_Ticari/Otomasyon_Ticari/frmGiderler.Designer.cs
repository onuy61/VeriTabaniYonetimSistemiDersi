
namespace Otomasyon_Ticari
{
    partial class frmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMaas = new DevExpress.XtraEditors.TextEdit();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.txtSu = new DevExpress.XtraEditors.TextEdit();
            this.txtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.richNot = new System.Windows.Forms.RichTextBox();
            this.txtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtGaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtYil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-4, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(924, 455);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbAy);
            this.groupControl1.Controls.Add(this.txtMaas);
            this.groupControl1.Controls.Add(this.txtInternet);
            this.groupControl1.Controls.Add(this.txtSu);
            this.groupControl1.Controls.Add(this.txtElektrik);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.richNot);
            this.groupControl1.Controls.Add(this.txtEkstra);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtGaz);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtYil);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(926, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(244, 451);
            this.groupControl1.TabIndex = 6;
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(97, 60);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.Properties.Appearance.Options.UseFont = true;
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Agustos",
            "Eylul",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Size = new System.Drawing.Size(134, 24);
            this.cmbAy.TabIndex = 35;
            // 
            // txtMaas
            // 
            this.txtMaas.EditValue = "";
            this.txtMaas.Location = new System.Drawing.Point(98, 235);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaas.Properties.Appearance.Options.UseFont = true;
            this.txtMaas.Size = new System.Drawing.Size(136, 24);
            this.txtMaas.TabIndex = 34;
            // 
            // txtInternet
            // 
            this.txtInternet.EditValue = "";
            this.txtInternet.Location = new System.Drawing.Point(97, 205);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtInternet.Properties.Appearance.Options.UseFont = true;
            this.txtInternet.Size = new System.Drawing.Size(136, 24);
            this.txtInternet.TabIndex = 33;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(97, 147);
            this.txtSu.Name = "txtSu";
            this.txtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSu.Properties.Appearance.Options.UseFont = true;
            this.txtSu.Size = new System.Drawing.Size(134, 24);
            this.txtSu.TabIndex = 32;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(97, 118);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtElektrik.Properties.Appearance.Options.UseFont = true;
            this.txtElektrik.Size = new System.Drawing.Size(134, 24);
            this.txtElektrik.TabIndex = 31;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.clear_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(164, 406);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(43, 37);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // richNot
            // 
            this.richNot.Location = new System.Drawing.Point(98, 296);
            this.richNot.Name = "richNot";
            this.richNot.Size = new System.Drawing.Size(136, 72);
            this.richNot.TabIndex = 24;
            this.richNot.Text = "";
            // 
            // txtEkstra
            // 
            this.txtEkstra.EditValue = "";
            this.txtEkstra.Location = new System.Drawing.Point(98, 265);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEkstra.Properties.Appearance.Options.UseFont = true;
            this.txtEkstra.Size = new System.Drawing.Size(136, 24);
            this.txtEkstra.TabIndex = 23;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(21, 270);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 18);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Ekstra:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(21, 238);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 18);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Maaşlar:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.convert_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(115, 406);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(43, 37);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.cancel_32x32;
            this.btnSil.Location = new System.Drawing.Point(69, 406);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(43, 37);
            this.btnSil.TabIndex = 18;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = global::Otomasyon_Ticari.Properties.Resources.saveall_32x321;
            this.btnKaydet.Location = new System.Drawing.Point(20, 406);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(43, 37);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(21, 307);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 18);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Notlar:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(21, 208);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İnternet:";
            // 
            // txtGaz
            // 
            this.txtGaz.Location = new System.Drawing.Point(98, 175);
            this.txtGaz.Name = "txtGaz";
            this.txtGaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtGaz.Properties.Appearance.Options.UseFont = true;
            this.txtGaz.Size = new System.Drawing.Size(136, 24);
            this.txtGaz.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 180);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Doğalgaz:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(23, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(21, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Su:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Elektrik:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(98, 87);
            this.txtYil.Name = "txtYil";
            this.txtYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtYil.Properties.Appearance.Options.UseFont = true;
            this.txtYil.Size = new System.Drawing.Size(134, 24);
            this.txtYil.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Yıl:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ay:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 31);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(134, 24);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.frmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richNot;
        private DevExpress.XtraEditors.TextEdit txtEkstra;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtGaz;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtYil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaas;
        private DevExpress.XtraEditors.TextEdit txtInternet;
        private DevExpress.XtraEditors.TextEdit txtSu;
        private DevExpress.XtraEditors.TextEdit txtElektrik;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
    }
}