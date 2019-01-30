using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string gelenData = e.Data.GetData(DataFormats.StringFormat).ToString();

            if(gelenData=="pct")
            {
                pctKoala.Left = e.X - (pctKoala.Width / 2);
                pctKoala.Top = e.Y - (pctKoala.Height / 2);
                    
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pctKoala_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;
        }

        private void pctKoala_Click(object sender, EventArgs e)
        {

        }

        private void pctKoala_MouseDown(object sender, MouseEventArgs e)
        {
            pctKoala.DoDragDrop("pct", DragDropEffects.Move);
        }
    }
}
