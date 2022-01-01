﻿
namespace CafeOto.WinForm.AnaMenu
{
    partial class frmAnaMenu
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Tema = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnMasalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunHaraketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoller = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoviz = new DevExpress.XtraBars.BarButtonItem();
            this.btnYardim = new DevExpress.XtraBars.BarButtonItem();
            this.btnHakkimizda = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasaSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.KAfa = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.Tema);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Tema,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMasalar,
            this.btnMasaHareketleri,
            this.btnMenu,
            this.btnMenuHareketleri,
            this.btnUrunler,
            this.btnUrunHaraketleri,
            this.btnKullanici,
            this.btnKullaniciHareketleri,
            this.btnRoller,
            this.btnDoviz,
            this.btnYardim,
            this.btnHakkimizda,
            this.barButtonItem1,
            this.btnMasaSiparis,
            this.btnMusteriler,
            this.skinRibbonGalleryBarItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinPaletteDropDownButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.KAfa,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1460, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // Tema
            // 
            this.Tema.Caption = "skinRibbonGalleryBarItem2";
            this.Tema.Id = 21;
            this.Tema.Name = "Tema";
            // 
            // btnMasalar
            // 
            this.btnMasalar.Caption = "Masalar";
            this.btnMasalar.Id = 1;
            this.btnMasalar.ImageOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.bo_appearance;
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasalar_ItemClick);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Caption = "Masa Hareketleri";
            this.btnMasaHareketleri.Id = 2;
            this.btnMasaHareketleri.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.converttorange_16x16;
            this.btnMasaHareketleri.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.converttorange_32x32;
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Menu";
            this.btnMenu.Id = 3;
            this.btnMenu.ImageOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.bo_country;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_ItemClick);
            // 
            // btnMenuHareketleri
            // 
            this.btnMenuHareketleri.Caption = "Menu Hareketleri";
            this.btnMenuHareketleri.Id = 4;
            this.btnMenuHareketleri.ImageOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.fullextent;
            this.btnMenuHareketleri.Name = "btnMenuHareketleri";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 5;
            this.btnUrunler.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.product_16x16;
            this.btnUrunler.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.product_32x32;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnUrunHaraketleri
            // 
            this.btnUrunHaraketleri.Caption = "Ürün Haraketleri";
            this.btnUrunHaraketleri.Id = 6;
            this.btnUrunHaraketleri.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.packageproduct_16x16;
            this.btnUrunHaraketleri.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.packageproduct_32x32;
            this.btnUrunHaraketleri.Name = "btnUrunHaraketleri";
            // 
            // btnKullanici
            // 
            this.btnKullanici.ActAsDropDown = true;
            this.btnKullanici.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnKullanici.Caption = "Kullanıcılar";
            this.btnKullanici.Id = 7;
            this.btnKullanici.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.customer_16x16;
            this.btnKullanici.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.customer_32x32;
            this.btnKullanici.Name = "btnKullanici";
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.Caption = "Kullanıcı Hareketleri";
            this.btnKullaniciHareketleri.Id = 8;
            this.btnKullaniciHareketleri.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.usergroup_16x16;
            this.btnKullaniciHareketleri.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.usergroup_32x32;
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            // 
            // btnRoller
            // 
            this.btnRoller.Caption = "Rol Tanımlama";
            this.btnRoller.Id = 9;
            this.btnRoller.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.borole_16x16;
            this.btnRoller.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.borole_32x32;
            this.btnRoller.Name = "btnRoller";
            // 
            // btnDoviz
            // 
            this.btnDoviz.Caption = "Doviz";
            this.btnDoviz.Id = 10;
            this.btnDoviz.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.currency_16x16;
            this.btnDoviz.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.currency_32x32;
            this.btnDoviz.Name = "btnDoviz";
            // 
            // btnYardim
            // 
            this.btnYardim.Caption = "Yardım";
            this.btnYardim.Id = 11;
            this.btnYardim.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.question_16x16;
            this.btnYardim.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.question_32x32;
            this.btnYardim.Name = "btnYardim";
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Caption = "Hakkimizda";
            this.btnHakkimizda.Id = 12;
            this.btnHakkimizda.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.info_16x16;
            this.btnHakkimizda.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.info_32x32;
            this.btnHakkimizda.Name = "btnHakkimizda";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnMasaSiparis
            // 
            this.btnMasaSiparis.Caption = "Masa Siparişleri";
            this.btnMasaSiparis.Id = 14;
            this.btnMasaSiparis.ImageOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.mergecells;
            this.btnMasaSiparis.Name = "btnMasaSiparis";
            this.btnMasaSiparis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasaSiparis_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Musteriler";
            this.btnMusteriler.Id = 16;
            this.btnMusteriler.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.team_16x16;
            this.btnMusteriler.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.team_32x32;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "Tema";
            this.skinRibbonGalleryBarItem1.Id = 17;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 18;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 19;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 20;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // KAfa
            // 
            this.KAfa.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.KAfa.Name = "KAfa";
            this.KAfa.Text = "Kafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMasalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMasaHareketleri);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMasaSiparis);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "MASALAR";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "MENULER";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUrunHaraketleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = " ÜRÜNLER";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKullanici);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKullaniciHareketleri);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRoller);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "KULLANICILAR";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "MÜŞTERİLER";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoviz);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYardim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHakkimizda);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "AYARLAR";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 747);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1460, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Müşteri İşlem";
            this.barButtonItem2.Id = 22;
            this.barButtonItem2.ImageOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.bo_department;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 771);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = global::CafeOto.WinForm.Properties.Resources.redtoblack;
            this.IsMdiContainer = true;
            this.Name = "frmAnaMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "KAFE OTOMASYONU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnMasalar;
        private DevExpress.XtraBars.Ribbon.RibbonPage KAfa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnMasaHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnMenuHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnUrunHaraketleri;
        private DevExpress.XtraBars.BarButtonItem btnKullanici;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnRoller;
        private DevExpress.XtraBars.BarButtonItem btnDoviz;
        private DevExpress.XtraBars.BarButtonItem btnYardim;
        private DevExpress.XtraBars.BarButtonItem btnHakkimizda;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMasaSiparis;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem Tema;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}