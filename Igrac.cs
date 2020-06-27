using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priprema_ispit
{
    class Igrac
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int brojac = 0;

        public Igrac(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, this.X, this.Y, 20, 20 );
        }

        public void plivacMove()
        {
            if (brojac % 2 == 0)
            {
                if (this.Y >= 330)
                {
                    brojac++;
                }
                //MoveDown();
            }
            else
            {
                if (this.Y <= 20)
                {
                    brojac++;
                }
               // MoveUp();
            }
        }


        public void MoveUp()
        {
            this.Y -= 10; 
        }

        public void MoveDown()
        {
            this.Y += 10;
        }
        public void MoveRight()
        {
            this.X += 10;
        }
        public void MoveLeft()
        {
            this.X -= 10;
        }
    }
}
