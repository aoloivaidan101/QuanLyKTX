using System;
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
            
            xtabHienThi.TabPages.Add(xtraTabHome);
        }
    }
}
