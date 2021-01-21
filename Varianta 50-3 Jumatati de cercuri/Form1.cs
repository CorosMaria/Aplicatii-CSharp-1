using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varianta_50_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_negru;
        System.Drawing.SolidBrush Pensula_neagra;
        public Cerc cerc1;
        public Cerc cerc2;
        public Cerc cerc3;
        private void Form1_Load(object sender, EventArgs e)
        {
            Desen = this.CreateGraphics();
            Creion_negru = new System.Drawing.Pen(System.Drawing.Color.Black);
            Pensula_neagra = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            cerc1 = new Cerc();
            cerc2 = new Cerc();
            cerc3 = new Cerc();
            cerc1.Initializare_cerc(100, 60, 130);
            cerc2.Initializare_cerc(300, 100, 100);
            cerc3.Initializare_cerc(270, 190, 50);
        }
        public class Cerc
        {
            int x0, y0, r0;
            public void Desenez_cerc(System.Drawing.Graphics Zona_desenare, System.Drawing.Pen Creion_n)
            {
                Zona_desenare.DrawEllipse(Creion_n, x0, y0, r0, r0);
            }
            public void setc(System.Drawing.Graphics Zona_desenare, System.Drawing.Pen creion, int r)
            {
                int x = System.Convert.ToInt16(System.Convert.ToDouble(x0) + System.Convert.ToDouble(r0 - r) / 2);
                int y = System.Convert.ToInt16(System.Convert.ToDouble(y0) + System.Convert.ToDouble(r0 - r) / 2);
                Zona_desenare.DrawEllipse(creion, x + 1, y + 1, r, r);
            }
            public void Initializare_cerc(int pozx, int pozy, int raza)
            {
                x0 = pozx;
                y0 = pozy;
                r0 = raza;
            }
            public void Umple_cerc(System.Drawing.Graphics Zona_desenare, System.Drawing.SolidBrush Pensula_neagra, int x, int y, int latime, int inaltime, int Unghi_start, int Unghi_final)
            {
                Zona_desenare.FillPie(Pensula_neagra, x, y, latime, inaltime, Unghi_start, Unghi_final);
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            cerc1.Desenez_cerc(Desen, Creion_negru);
            cerc2.Desenez_cerc(Desen, Creion_negru);
            cerc3.Desenez_cerc(Desen, Creion_negru);
            cerc1.Umple_cerc(Desen, Pensula_neagra, 100,60,130,130,0,180);
            cerc2.Umple_cerc(Desen, Pensula_neagra, 300,100,100,100,350, 180);
            cerc3.Umple_cerc(Desen, Pensula_neagra, 270, 190, 50, 50, 45, 180);
        }
    }
}
