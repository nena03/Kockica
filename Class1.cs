using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    using System.Drawing;

    class Tacka
    {
        private int x, y;
        private Color boja;

        public Tacka(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
            }
            else
                throw new Exception("Koordinate su <0!");
        }

        public void PostaviBoju(Color boja)
        {
            this.boja = boja;
        }

        public void Crtaj(Graphics g)
        {
            SolidBrush cetka = new SolidBrush(boja);
            g.FillEllipse(cetka, x - 3, y - 3, 6, 6);
        }
    }


    class Kockica
    {
        private int x, y, a = 100, n;
        private Color boja = Color.Black;

        public Kockica(int x, int y, int a, int n)
        {
            if (x >= 50 && y >= 50)
            {
                this.x = x;
                this.y = y;
                this.n = n;
            }
            else
                throw new Exception("Kockica bi izasla!");
        }

        public void Crtaj(Graphics g, int n, int x, int y, int a)
        {
            Point t1 = new Point(x - a / 2, y - a / 2);
            Point t2 = new Point(x + a / 2, y - a / 2);
            Point t3 = new Point(x + a / 2, y + a / 2);
            Point t4 = new Point(x - a / 2, y + a / 2);

            Pen olovka = new Pen(Color.Black);
            Point[] temena = { t1, t2, t3, t4 };
            g.DrawPolygon(olovka, temena);

            if (n % 2 == 1)
            {
                Tacka p1 = new Tacka(x, y);
                p1.PostaviBoju(Color.Black);
                p1.Crtaj(g);
            }
            if (n > 1)
            {
                Tacka p2 = new Tacka(x - a / 4, y - a / 4);
                p2.PostaviBoju(Color.Black);
                p2.Crtaj(g);
                Tacka p3 = new Tacka(x + a / 4, y + a / 4);
                p3.PostaviBoju(Color.Black);
                p3.Crtaj(g);
            }
            if (n >= 4)
            {
                Tacka p4 = new Tacka(x + a / 4, y - a / 4);
                p4.PostaviBoju(Color.Black);
                p4.Crtaj(g);
                Tacka p5 = new Tacka(x - a / 4, y + a / 4);
                p5.PostaviBoju(Color.Black);
                p5.Crtaj(g);
            }
            if (n == 6)
            {
                Tacka p6 = new Tacka(x - a / 4, y);
                p6.PostaviBoju(Color.Black);
                p6.Crtaj(g);
                Tacka p7 = new Tacka(x + a / 4, y);
                p7.PostaviBoju(Color.Black);
                p7.Crtaj(g);
            }
        }
    }


}
