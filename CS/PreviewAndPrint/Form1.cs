using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PreviewAndPrint {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // set advanced print options, if needed
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
            printableComponentLink1.Landscape = true;
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            printableComponentLink1.ShowPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            printableComponentLink1.Print(string.Empty);
        }
    }
}