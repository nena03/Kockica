using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
            int x, y, m1, m2, c1, c2, v1, v2, p1, p2, l1, l2, o1, o2;

            private void Form1_Load(object sender, EventArgs e)
            {
               
                m1 = ClientRectangle.Width / 3;
                m2 = ClientRectangle.Height / 3;
                c1 = ClientRectangle.Width / 2;
                c2=ClientRectangle.Height / 3;
                v1 = ClientRectangle.Width * 2 / 3;
                v2 = ClientRectangle.Height / 3;
            p1 = ClientRectangle.Width / 3;
            p2 = ClientRectangle.Height * 2 / 3;
            l1 = ClientRectangle.Width / 2;
            l2 = ClientRectangle.Height * 2 / 3;
            o1 = ClientRectangle.Width * 2 / 3;
            o2 = ClientRectangle.Height * 2 / 3;


        }

            Random n = new Random();

            private void button1_Click(object sender, EventArgs e)
            
            {
                Refresh();
                Graphics g = CreateGraphics();
               
                Kockica m = new Kockica(m1, m2, 100, n.Next(6) + 1);
                Kockica c= new Kockica(c1, c2, 100, n.Next(6) + 1);
                Kockica v= new Kockica(v1, v2, 100, n.Next(6) + 1);
                Kockica p= new Kockica(p1, p2, 100, n.Next(6) + 1);
                Kockica l= new Kockica(l1, l2, 100, n.Next(6) + 1);
                Kockica o = new Kockica(o1, o2, 100, n.Next(6) + 1);


            
                m.Crtaj(g, n.Next(6) + 1, m1, m2, 100);
                c.Crtaj(g, n.Next(6) + 1, c1, c2, 100);
                v.Crtaj(g, n.Next(6) + 1, v1, v2, 100);
                p.Crtaj(g, n.Next(6) + 1, p1, p2, 100);
                l.Crtaj(g, n.Next(6) + 1, l1, l2, 100);
                o.Crtaj(g, n.Next(6) + 1, o1, o2, 100);



        }


        
    }
}
