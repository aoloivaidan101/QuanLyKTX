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
            TestThoi a = new TestThoi();
            skins();
            DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();
            DevExpress.XtraTab.XtraTabPage xtraTab1 = new DevExpress.XtraTab.XtraTabPage();
            xtraTab.Name = "Testadd";
           xtraTab.Text = "lồn chim cu cặc bím";
            xtraTab1.Text = "aaaaaa";
            xtraTab.Controls.Add(a);
            xtraTab1.Controls.Add(a);
            xtabHienThi.TabPages.Add(xtraTab);
            xtabHienThi.TabPages.Add(xtraTab1);
           

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

       
    }
}
