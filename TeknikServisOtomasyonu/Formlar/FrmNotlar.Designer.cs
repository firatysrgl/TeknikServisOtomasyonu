namespace TeknikServisOtomasyonu.Formlar
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Txtİcerik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1474, 335);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(237)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Txtİcerik);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl27);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtBaslik);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1484, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(456, 758);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "AJANDA İŞLEMLERİ";
            // 
            // Txtİcerik
            // 
            this.Txtİcerik.Location = new System.Drawing.Point(112, 130);
            this.Txtİcerik.Name = "Txtİcerik";
            this.Txtİcerik.Size = new System.Drawing.Size(250, 22);
            this.Txtİcerik.TabIndex = 25;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "İÇERİK :";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(115, 197);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Okundu Olarak İşaretle";
            this.checkEdit1.Size = new System.Drawing.Size(170, 24);
            this.checkEdit1.TabIndex = 23;
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(55, 199);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(51, 16);
            this.labelControl27.TabIndex = 22;
            this.labelControl27.Text = "DURUM :";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(112, 428);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(250, 56);
            this.BtnListele.TabIndex = 21;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(112, 74);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(250, 22);
            this.TxtID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(56, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "NOT ID :";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(112, 366);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(250, 56);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(112, 304);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(250, 56);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(112, 242);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(250, 56);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(112, 102);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(250, 22);
            this.TxtBaslik.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "BAŞLIK :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(176, 23);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Okunmamış Notlar";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 393);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 23);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Okunan Notlar";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(4, 422);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1474, 335);
            this.gridControl2.TabIndex = 24;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.SandyBrown;
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(112, 158);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            this.TxtTarih.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTarih.Properties.MaskSettings.Set("mask", "d");
            this.TxtTarih.Size = new System.Drawing.Size(250, 22);
            this.TxtTarih.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "TARİH:";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 763);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmNotlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit Txtİcerik;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}