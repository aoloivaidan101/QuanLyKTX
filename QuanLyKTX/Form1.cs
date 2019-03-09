﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fmMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2013 Dark Gray";
        }
        
        private void fmMain_Load(object sender, EventArgs e)
        {
           
            skins();
  

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            xtabHienThi.TabPages.RemoveAt(xtabHienThi.SelectedTabPageIndex);
            //DevExpress.XtraTab.XtraTabControl TabControl = (DevExpress.XtraTab.XtraTabControl)sender;
            // int i = TabControl.SelectedTabPageIndex;
            //TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            // TabControl.SelectedTabPageIndex = i - 1;
        }

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Home home = new Home();
            DevExpress.XtraTab.XtraTabPage xtraTabHome = new DevExpress.XtraTab.XtraTabPage();
            xtraTabHome.Name = "tabHome";
            xtraTabHome.Text = "Nhà";
            xtraTabHome.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage  tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Nhà")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }
                
            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(xtraTabHome);
                xtabHienThi.SelectedTabPage = xtraTabHome;
            }
        }

        private void btnCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TinhThanh tinhThanh = new TinhThanh();
            DevExpress.XtraTab.XtraTabPage tabTinhThanh = new DevExpress.XtraTab.XtraTabPage();           
            tabTinhThanh.Name = "tabTinhThanh";
            tabTinhThanh.Text = "Tỉnh Thành";
            tabTinhThanh.Controls.Add(tinhThanh);
            tinhThanh.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Tỉnh Thành")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabTinhThanh);
                xtabHienThi.SelectedTabPage = tabTinhThanh;
            }
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanToc danToc = new DanToc();
            DevExpress.XtraTab.XtraTabPage tabDanToc = new DevExpress.XtraTab.XtraTabPage();
            tabDanToc.Name = "tabDanToc";
            tabDanToc.Text = "Dân Tộc";
            tabDanToc.Controls.Add(danToc);
            danToc.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Dân Tộc")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabDanToc);
                xtabHienThi.SelectedTabPage = tabDanToc;
            }
        }

        private void btnQuocTich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich quocTich = new QuocTich();
            DevExpress.XtraTab.XtraTabPage tabQuocTich = new DevExpress.XtraTab.XtraTabPage();
            tabQuocTich.Name = "tabQuocTich";
            tabQuocTich.Text = "Quốc tịch";
            tabQuocTich.Controls.Add(quocTich);
            quocTich.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Quốc tịch")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabQuocTich);
                xtabHienThi.SelectedTabPage = tabQuocTich;
            }
        }

        private void btnGiaPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiaLoaiPhong giaLoaiPhong = new GiaLoaiPhong();
            DevExpress.XtraTab.XtraTabPage tabGiaLoai = new DevExpress.XtraTab.XtraTabPage();
            tabGiaLoai.Name = "tabGiaLoaiPhong";
            tabGiaLoai.Text = "Giá loại phòng";
            tabGiaLoai.Controls.Add(giaLoaiPhong);
            giaLoaiPhong.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Giá loại phòng")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabGiaLoai);
                xtabHienThi.SelectedTabPage = tabGiaLoai;
            }
        }
    }
}
