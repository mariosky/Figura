using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    abstract class Figura
    {
        protected int X;
        protected int Y;
        protected Pen pluma;
        protected int ancho;
        protected int largo;
        protected Color color;

        public Figura(int x, int y ) {
            X = x;
            Y = y;
            pluma = new Pen(Color.Black, 2);
            Random rnd = new Random();
            ancho = rnd.Next(10,60);
            largo = ancho;
        }

        public abstract void Draw(Form f);

    }


    class Rectangulo:Figura
    {
        public Rectangulo(int x, int y ):base(x,y)
    	{
        } 

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
        }

    }

    class Circulo : Figura
    {
        public Circulo(int x, int y) : base(x, y)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
        }

    }

}
