namespace Gestor_hotel_CS
{
    public partial class Form1 : Form
    {
        bool bandera_menu, bandera_barra_inferior = true;
        //banderas de timers de animacion
        //sub_menu usuario, sub_menu_reporte, sub_menu_facturas
        bool[] banderas = new bool[] { false, false, false };
        int contador = 10;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weidhtPnlAuto();
            sub_pnl_botones.Visible = false;
            sub_pnl_reportes.Visible = false;
            sub_pnl_factura.Visible = false;
            sub_pnl_botones.Height = 0;
            sub_pnl_reportes.Height = 0;
            sub_pnl_factura.Height = 0;
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

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        *   Esta shit me ha hecho plantearme si es que sufro de alguna deficiencia mental, porque 
        *   estuve 6 horas tratando de que funcionara
        *   Esto se encarga de hacer la lógica para posteriormente hacer la animacion de despliegue
        *   y repliegue de los submenus
        */
        private void animacion_sub_menu(FlowLayoutPanel sub_pnl, bool[] bandera, int posicion, System.Windows.Forms.Timer tiempo)
        {

            if (sub_pnl.Visible && sub_pnl.Height >= 170)
            {
                bandera[posicion] = true;
            }

            if (bandera[posicion])
            {
                sub_pnl.Height -= 10;

                if (sub_pnl.Height <= 10)
                {
                    bandera[posicion] = false;
                    sub_pnl.Visible = false;
                    tiempo.Stop();

                }
            }
            else
            {
                sub_pnl.Visible = true;
                sub_pnl.Height += 10;

                if (sub_pnl.Height >= 170)
                {
                    bandera[posicion] = true;
                    tiempo.Stop();
                }
            }
        }

        //Timers de animacion de los sub menus
        private void timer_btn_usuarios_Tick(object sender, EventArgs e)
        {
            animacion_sub_menu(sub_pnl_botones, banderas, 0, timer_btn_usuarios);
        }

        private void timer_btn_reportes_Tick(object sender, EventArgs e)
        {
            animacion_sub_menu(sub_pnl_reportes, banderas, 1, timer_btn_reportes);
        }
        private void timer_btn_factura_Tick(object sender, EventArgs e)
        {
            animacion_sub_menu(sub_pnl_factura, banderas, 2, timer_btn_factura);
        }

        //Botones para activar los timers
        private void btn_user_Click(object sender, EventArgs e)
        {
            timer_btn_usuarios.Start();
        }
        private void btn_reportes_Click(object sender, EventArgs e)
        {
            timer_btn_reportes.Start();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            timer_btn_factura.Start();
        }

        private void btn_agregra_persona_Click(object sender, EventArgs e)
        {
            abrir_panel_hijo(new Form2());
        }

        private Form current_form  = null;

        private void abrir_panel_hijo(Form form_hijo)
        {
            current_form = form_hijo;
            form_hijo.TopLevel = false;
            form_hijo.FormBorderStyle = FormBorderStyle.None;
            form_hijo.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(form_hijo);
            pnl_main.Tag = pnl_main;
            form_hijo.BringToFront();
            form_hijo.Show();
        }
    }
}

