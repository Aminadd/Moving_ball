using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priprema_ispit
{
    class linija
    {
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Purple, 5, 10, 15, 280);
            e.Graphics.FillRectangle(Brushes.Purple, 230, 10, 15, 280);
        }
    }
}
