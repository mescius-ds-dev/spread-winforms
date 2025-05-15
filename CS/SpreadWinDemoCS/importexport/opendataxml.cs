using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class opendataxml : SpreadWinDemo.DemoBase
    {
        public opendataxml()
        {
            InitializeComponent();

            button1.Click += new EventHandler(button1_Click);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // XMLデータの読込
            GrapeCity.Spreadsheet.IWorkbook iWorkbook = fpSpread1.AsWorkbook().WorkbookSet.Workbooks.OpenXML(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.DataFormat.xml"));
            fpSpread1.Attach(iWorkbook);
        }
    }
}
