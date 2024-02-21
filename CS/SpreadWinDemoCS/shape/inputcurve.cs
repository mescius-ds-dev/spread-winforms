using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class inputcurve : SpreadWinDemo.DemoBase
    {
        public inputcurve()
        {
            InitializeComponent();

            button1.Click += new EventHandler(button1_Click);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 曲線シェイプの入力を開始
            fpSpread1.Features.EnhancedShapeEngine = true;
            fpSpread1.StartAnnotationMode(AnnotationMode.Curve);
        }
    }
}
