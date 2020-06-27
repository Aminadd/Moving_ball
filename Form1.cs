using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priprema_ispit
{ 
    public partial class Form1 : Form
    {
        Keys key;
        private int k { get; set; }
        private int idi = 2;
        int playerPts = 0;
        public Form1()
        {
            InitializeComponent();
            k = 0;
        }

        Igrac igrac = new Igrac(20, 20);
        linija linija = new linija();
      

       public void movePlayer()
        {
            switch (key)
            {
                case Keys.Up:
                    if (igrac.X >= 20)
                          igrac.X -= 10;
                        
                    break;
                case Keys.Down:
                    
                    if (igrac.X <= 330)
                        igrac.X += 10;
                   
                    break;
            }
        }

        public void Victory()
        {
            if(playerPts == 0)
            {
                label2.Text = playerPts.ToString();
            }
            if (igrac.X >= 230)
            {
                k++;               
                playerPts++;
                label2.Text = playerPts.ToString();
                igrac.X = 20;               
            }
        }

        public void SamaKaoListNaVetru()
        {
            switch(idi)
            {
                case 2:
                    if(igrac.X >= 210)
                    {
                        idi++;
                    }
                    igrac.MoveRight();
                    break;
                case 3:
                    if(igrac.Y >= 270)
                    {
                        idi++;
                    }
                    igrac.MoveDown();
                    break;
                case 4:
                    if(igrac.X <= 20)
                    {
                        idi++;
                    }
                    igrac.MoveLeft();
                    break;
                case 5:
                    if(igrac.Y <= 20 )
                    {
                        idi = 2;
                    }
                    igrac.MoveUp();
                    break;
            }
            /*
            if(idi % 2 == 0)
            {
                if(igrac.X >= 210)
                {
                    idi++;
                }
                igrac.MoveRight();
                igrac.MoveDown();
            }
            else
            {
                if(igrac.X <= 20)
                {
                    idi++;
                }
                igrac.MoveLeft();
                igrac.MoveUp();
                */
            }
              

        private void timer1_Tick(object sender, EventArgs e)
        {
           // movePlayer();
         
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            igrac.Draw(e);
            linija.Draw(e);
           Victory();
            SamaKaoListNaVetru();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
        }       
    }
}
