using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private List<Rectangulo> rectangulos;
        public Form1()
        {
            rectangulos = new List<Rectangulo>();
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
          Rectangulo r =  new Rectangulo(e.X, e.Y);
            r.Draw(this);
            rectangulos.Add(r);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Polimorfismo
            foreach (Rectangulo r in rectangulos)
                r.Draw(this);
        }
    }
}
