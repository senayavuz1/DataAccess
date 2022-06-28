using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void kargoFirmalariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.MdiParent = this;
            urunler.Show();
        }

        private void selectFromNorthwindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NorthwindFrom form = new NorthwindFrom();
            form.MdiParent = this;
            form.Show();
        }
    }
}
