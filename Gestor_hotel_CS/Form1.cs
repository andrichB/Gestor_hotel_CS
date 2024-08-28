namespace Gestor_hotel_CS
{
    public partial class Form1 : Form
    {
        bool bandera_menu, bandera_submenu, bandera_barra_inferior = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weidhtPnlAuto();
            sub_pnl_botones.Visible = false;
            sub_pnl_botones.Height = 0;
            hora.Start();
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
                if (pnl_menu.Width >= 200)
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

        private void btn_user_Click(object sender, EventArgs e)
        {
            timer_btn_usuarios.Start();

        }

        private void timer_btn_usuarios_Tick(object sender, EventArgs e)
        {

            if (sub_pnl_botones.Visible && sub_pnl_botones.Height >= 170)
            {
                bandera_submenu = sub_pnl_botones.Visible;
            }

            if (bandera_submenu)
            {
                sub_pnl_botones.Height -= 10;
                if (sub_pnl_botones.Height <= 10)
                {
                    bandera_submenu = false;
                    sub_pnl_botones.Visible = false;
                    timer_btn_usuarios.Stop();
                }
            }
            else
            {
                sub_pnl_botones.Visible = true;
                sub_pnl_botones.Height += 10;
                if (sub_pnl_botones.Height >= 170)
                {
                    bandera_submenu = true;
                    timer_btn_usuarios.Stop();
                }
            }
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer_barra_inferior_Tick(object sender, EventArgs e)
        {

            if (bandera_barra_inferior)
            {
                pnl_barra_inferior.Height -= 10;
                if (pnl_barra_inferior.Height <= 40)
                {
                    bandera_barra_inferior = false;
                    timer_barra_inferior.Stop();
                }
            }
            else
            {
                pnl_barra_inferior.Height += 10;
                if (pnl_barra_inferior.Height >= 100)
                {
                    bandera_barra_inferior = true;
                    timer_barra_inferior.Stop();
                }
            }
        }

        private void btn_barra_inferior_Click(object sender, EventArgs e)
        {
            timer_barra_inferior.Start();
        }
    }
}
