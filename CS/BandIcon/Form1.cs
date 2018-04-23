using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace BandIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            MyBand band = new MyBand();
            report.Bands.Add(band);
            report.ShowDesignerDialog();
            this.Close();
        }
    }
    [ToolboxBitmap("XRDetailBand.gif")]
    class MyBand : DetailBand
    {
    }
}