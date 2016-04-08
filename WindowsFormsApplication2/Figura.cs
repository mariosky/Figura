using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    class Figura
    {
    }

    class Rectangulo
    {
        public int X;
        public int Y;
        Pen pluma;
        public int ancho;
        public int largo;
        Color color;

        public Rectangulo(int x, int y ) {
            X = x;
            Y = y;
            pluma = new Pen(Color.Black, 2);
            ancho = 10;
            largo = 10;
        }

        public void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
        }

    }


}
