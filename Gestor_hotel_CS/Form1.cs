namespace Gestor_hotel_CS
{
    public partial class Form1 : Form
    {
        bool bandera_menu;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weidhtPnlAuto();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bandera_menu)
            {
                pnl_menu.Width -= 10;
                if (pnl_menu.Width <= 60)
                {
                    bandera_menu = false;
                    timer1.Stop();
                }
            }
            else
            {
                pnl_menu.Width += 10;
                if(pnl_menu.Width >= 200)
                {
                    bandera_menu = true;
                    timer1.Stop();
                }
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void weidhtPnlAuto()//Hace un auto size al panel del menu y prepara el booleano para saber como arrancar
        {
            switch (pnl_menu.Width)
            {
                case < 200:
                    pnl_menu.Width = 60;
                    bandera_menu = false;
                    break;
                case >= 200:
                    pnl_menu.Width = 200;
                    bandera_menu = true;
                    break;
            }
        }
    }
}
