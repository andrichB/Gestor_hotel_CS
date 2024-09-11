namespace Gestor_hotel_CS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnl_menu = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btn_user = new Button();
            sub_pnl_botones = new FlowLayoutPanel();
            btn_agregra_persona = new Button();
            btn_registrar_cliente = new Button();
            btn_asignar_empleado = new Button();
            btn_reportes = new Button();
            sub_pnl_reportes = new FlowLayoutPanel();
            btn_crear_habitaciones = new Button();
            btn_ver_habitaciones = new Button();
            btn_reservar_habitaciones = new Button();
            btn_factura = new Button();
            sub_pnl_factura = new FlowLayoutPanel();
            btn_registros_pago = new Button();
            btn_imprimir_factura = new Button();
            btn_consultar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer_btn_usuarios = new System.Windows.Forms.Timer(components);
            pnl_barra_inferior = new Panel();
            pictureBox2 = new PictureBox();
            lbl_hora = new Label();
            btn_barra_inferior = new Button();
            hora = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            timer_barra_inferior = new System.Windows.Forms.Timer(components);
            timer_btn_reportes = new System.Windows.Forms.Timer(components);
            timer_btn_factura = new System.Windows.Forms.Timer(components);
            pnl_main = new Panel();
            pictureBox4 = new PictureBox();
            pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sub_pnl_botones.SuspendLayout();
            sub_pnl_reportes.SuspendLayout();
            sub_pnl_factura.SuspendLayout();
            pnl_barra_inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(153, 165, 95);
            pnl_menu.Controls.Add(pictureBox1);
            pnl_menu.Controls.Add(btn_user);
            pnl_menu.Controls.Add(sub_pnl_botones);
            pnl_menu.Controls.Add(btn_reportes);
            pnl_menu.Controls.Add(sub_pnl_reportes);
            pnl_menu.Controls.Add(btn_factura);
            pnl_menu.Controls.Add(sub_pnl_factura);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Margin = new Padding(0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(200, 749);
            pnl_menu.TabIndex = 1;
            pnl_menu.Paint += pnl_menu_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_user
            // 
            btn_user.BackgroundImageLayout = ImageLayout.None;
            btn_user.FlatAppearance.BorderSize = 0;
            btn_user.FlatStyle = FlatStyle.Flat;
            btn_user.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_user.ForeColor = Color.FromArgb(9, 33, 62);
            btn_user.Image = (Image)resources.GetObject("btn_user.Image");
            btn_user.ImageAlign = ContentAlignment.MiddleLeft;
            btn_user.Location = new Point(3, 77);
            btn_user.Name = "btn_user";
            btn_user.Padding = new Padding(12, 0, 0, 0);
            btn_user.Size = new Size(197, 50);
            btn_user.TabIndex = 0;
            btn_user.Text = "Usuarios";
            btn_user.TextAlign = ContentAlignment.MiddleRight;
            btn_user.UseVisualStyleBackColor = true;
            btn_user.Click += btn_user_Click;
            // 
            // sub_pnl_botones
            // 
            sub_pnl_botones.BackColor = Color.FromArgb(9, 33, 62);
            sub_pnl_botones.Controls.Add(btn_agregra_persona);
            sub_pnl_botones.Controls.Add(btn_registrar_cliente);
            sub_pnl_botones.Controls.Add(btn_asignar_empleado);
            sub_pnl_botones.Location = new Point(3, 133);
            sub_pnl_botones.Name = "sub_pnl_botones";
            sub_pnl_botones.Size = new Size(197, 170);
            sub_pnl_botones.TabIndex = 2;
            // 
            // btn_agregra_persona
            // 
            btn_agregra_persona.BackgroundImageLayout = ImageLayout.None;
            btn_agregra_persona.FlatAppearance.BorderSize = 0;
            btn_agregra_persona.FlatStyle = FlatStyle.Flat;
            btn_agregra_persona.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregra_persona.ForeColor = Color.White;
            btn_agregra_persona.Image = (Image)resources.GetObject("btn_agregra_persona.Image");
            btn_agregra_persona.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregra_persona.Location = new Point(3, 3);
            btn_agregra_persona.Name = "btn_agregra_persona";
            btn_agregra_persona.Padding = new Padding(12, 0, 0, 0);
            btn_agregra_persona.Size = new Size(197, 50);
            btn_agregra_persona.TabIndex = 3;
            btn_agregra_persona.Text = "Agregar persona";
            btn_agregra_persona.TextAlign = ContentAlignment.MiddleRight;
            btn_agregra_persona.UseVisualStyleBackColor = true;
            // 
            // btn_registrar_cliente
            // 
            btn_registrar_cliente.BackgroundImageLayout = ImageLayout.None;
            btn_registrar_cliente.FlatAppearance.BorderSize = 0;
            btn_registrar_cliente.FlatStyle = FlatStyle.Flat;
            btn_registrar_cliente.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar_cliente.ForeColor = Color.White;
            btn_registrar_cliente.Image = (Image)resources.GetObject("btn_registrar_cliente.Image");
            btn_registrar_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_registrar_cliente.Location = new Point(3, 59);
            btn_registrar_cliente.Name = "btn_registrar_cliente";
            btn_registrar_cliente.Padding = new Padding(12, 0, 0, 0);
            btn_registrar_cliente.Size = new Size(197, 50);
            btn_registrar_cliente.TabIndex = 4;
            btn_registrar_cliente.Text = "Registrar cliente";
            btn_registrar_cliente.TextAlign = ContentAlignment.MiddleRight;
            btn_registrar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_asignar_empleado
            // 
            btn_asignar_empleado.BackgroundImageLayout = ImageLayout.None;
            btn_asignar_empleado.FlatAppearance.BorderSize = 0;
            btn_asignar_empleado.FlatStyle = FlatStyle.Flat;
            btn_asignar_empleado.Font = new Font("Poppins SemiBold", 9.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_asignar_empleado.ForeColor = Color.White;
            btn_asignar_empleado.Image = (Image)resources.GetObject("btn_asignar_empleado.Image");
            btn_asignar_empleado.ImageAlign = ContentAlignment.MiddleLeft;
            btn_asignar_empleado.Location = new Point(3, 115);
            btn_asignar_empleado.Name = "btn_asignar_empleado";
            btn_asignar_empleado.Padding = new Padding(12, 0, 0, 0);
            btn_asignar_empleado.Size = new Size(197, 50);
            btn_asignar_empleado.TabIndex = 5;
            btn_asignar_empleado.Text = "Asignar empleado";
            btn_asignar_empleado.TextAlign = ContentAlignment.MiddleRight;
            btn_asignar_empleado.UseVisualStyleBackColor = true;
            // 
            // btn_reportes
            // 
            btn_reportes.BackgroundImageLayout = ImageLayout.None;
            btn_reportes.FlatAppearance.BorderSize = 0;
            btn_reportes.FlatStyle = FlatStyle.Flat;
            btn_reportes.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportes.ForeColor = Color.FromArgb(9, 33, 62);
            btn_reportes.Image = (Image)resources.GetObject("btn_reportes.Image");
            btn_reportes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportes.Location = new Point(3, 309);
            btn_reportes.Name = "btn_reportes";
            btn_reportes.Padding = new Padding(12, 0, 0, 0);
            btn_reportes.Size = new Size(197, 50);
            btn_reportes.TabIndex = 3;
            btn_reportes.Text = "Reportes";
            btn_reportes.TextAlign = ContentAlignment.MiddleRight;
            btn_reportes.UseVisualStyleBackColor = true;
            btn_reportes.Click += btn_reportes_Click;
            // 
            // sub_pnl_reportes
            // 
            sub_pnl_reportes.AccessibleDescription = "";
            sub_pnl_reportes.BackColor = Color.FromArgb(9, 33, 62);
            sub_pnl_reportes.Controls.Add(btn_crear_habitaciones);
            sub_pnl_reportes.Controls.Add(btn_ver_habitaciones);
            sub_pnl_reportes.Controls.Add(btn_reservar_habitaciones);
            sub_pnl_reportes.Location = new Point(3, 365);
            sub_pnl_reportes.Name = "sub_pnl_reportes";
            sub_pnl_reportes.Size = new Size(197, 170);
            sub_pnl_reportes.TabIndex = 4;
            // 
            // btn_crear_habitaciones
            // 
            btn_crear_habitaciones.BackgroundImageLayout = ImageLayout.None;
            btn_crear_habitaciones.FlatAppearance.BorderSize = 0;
            btn_crear_habitaciones.FlatStyle = FlatStyle.Flat;
            btn_crear_habitaciones.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_crear_habitaciones.ForeColor = Color.White;
            btn_crear_habitaciones.Image = (Image)resources.GetObject("btn_crear_habitaciones.Image");
            btn_crear_habitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btn_crear_habitaciones.Location = new Point(3, 3);
            btn_crear_habitaciones.Name = "btn_crear_habitaciones";
            btn_crear_habitaciones.Padding = new Padding(12, 0, 0, 0);
            btn_crear_habitaciones.Size = new Size(197, 50);
            btn_crear_habitaciones.TabIndex = 3;
            btn_crear_habitaciones.Text = "Crear habitaciones";
            btn_crear_habitaciones.TextAlign = ContentAlignment.MiddleRight;
            btn_crear_habitaciones.UseVisualStyleBackColor = true;
            // 
            // btn_ver_habitaciones
            // 
            btn_ver_habitaciones.BackgroundImageLayout = ImageLayout.None;
            btn_ver_habitaciones.FlatAppearance.BorderSize = 0;
            btn_ver_habitaciones.FlatStyle = FlatStyle.Flat;
            btn_ver_habitaciones.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ver_habitaciones.ForeColor = Color.White;
            btn_ver_habitaciones.Image = (Image)resources.GetObject("btn_ver_habitaciones.Image");
            btn_ver_habitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ver_habitaciones.Location = new Point(3, 59);
            btn_ver_habitaciones.Name = "btn_ver_habitaciones";
            btn_ver_habitaciones.Padding = new Padding(12, 0, 0, 0);
            btn_ver_habitaciones.Size = new Size(197, 50);
            btn_ver_habitaciones.TabIndex = 4;
            btn_ver_habitaciones.Text = "Ver habitaciones";
            btn_ver_habitaciones.TextAlign = ContentAlignment.MiddleRight;
            btn_ver_habitaciones.UseVisualStyleBackColor = true;
            // 
            // btn_reservar_habitaciones
            // 
            btn_reservar_habitaciones.BackgroundImageLayout = ImageLayout.None;
            btn_reservar_habitaciones.FlatAppearance.BorderSize = 0;
            btn_reservar_habitaciones.FlatStyle = FlatStyle.Flat;
            btn_reservar_habitaciones.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reservar_habitaciones.ForeColor = Color.White;
            btn_reservar_habitaciones.Image = (Image)resources.GetObject("btn_reservar_habitaciones.Image");
            btn_reservar_habitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reservar_habitaciones.Location = new Point(3, 115);
            btn_reservar_habitaciones.Name = "btn_reservar_habitaciones";
            btn_reservar_habitaciones.Padding = new Padding(12, 0, 0, 0);
            btn_reservar_habitaciones.Size = new Size(197, 58);
            btn_reservar_habitaciones.TabIndex = 5;
            btn_reservar_habitaciones.Text = "Reservar \r\nhabitaciones";
            btn_reservar_habitaciones.TextAlign = ContentAlignment.MiddleRight;
            btn_reservar_habitaciones.UseVisualStyleBackColor = true;
            // 
            // btn_factura
            // 
            btn_factura.BackgroundImageLayout = ImageLayout.None;
            btn_factura.FlatAppearance.BorderSize = 0;
            btn_factura.FlatStyle = FlatStyle.Flat;
            btn_factura.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_factura.ForeColor = Color.FromArgb(9, 33, 62);
            btn_factura.Image = (Image)resources.GetObject("btn_factura.Image");
            btn_factura.ImageAlign = ContentAlignment.MiddleLeft;
            btn_factura.Location = new Point(3, 541);
            btn_factura.Name = "btn_factura";
            btn_factura.Padding = new Padding(12, 0, 0, 0);
            btn_factura.Size = new Size(197, 50);
            btn_factura.TabIndex = 5;
            btn_factura.Text = "Factura";
            btn_factura.TextAlign = ContentAlignment.MiddleRight;
            btn_factura.UseVisualStyleBackColor = true;
            btn_factura.Click += btn_factura_Click;
            // 
            // sub_pnl_factura
            // 
            sub_pnl_factura.AccessibleDescription = "";
            sub_pnl_factura.BackColor = Color.FromArgb(9, 33, 62);
            sub_pnl_factura.Controls.Add(btn_registros_pago);
            sub_pnl_factura.Controls.Add(btn_imprimir_factura);
            sub_pnl_factura.Controls.Add(btn_consultar);
            sub_pnl_factura.Location = new Point(3, 597);
            sub_pnl_factura.Name = "sub_pnl_factura";
            sub_pnl_factura.Size = new Size(197, 170);
            sub_pnl_factura.TabIndex = 6;
            // 
            // btn_registros_pago
            // 
            btn_registros_pago.BackgroundImageLayout = ImageLayout.None;
            btn_registros_pago.FlatAppearance.BorderSize = 0;
            btn_registros_pago.FlatStyle = FlatStyle.Flat;
            btn_registros_pago.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registros_pago.ForeColor = Color.White;
            btn_registros_pago.Image = (Image)resources.GetObject("btn_registros_pago.Image");
            btn_registros_pago.ImageAlign = ContentAlignment.MiddleLeft;
            btn_registros_pago.Location = new Point(3, 3);
            btn_registros_pago.Name = "btn_registros_pago";
            btn_registros_pago.Padding = new Padding(12, 0, 0, 0);
            btn_registros_pago.Size = new Size(197, 50);
            btn_registros_pago.TabIndex = 3;
            btn_registros_pago.Text = "Registros de pago";
            btn_registros_pago.TextAlign = ContentAlignment.MiddleRight;
            btn_registros_pago.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir_factura
            // 
            btn_imprimir_factura.BackgroundImageLayout = ImageLayout.None;
            btn_imprimir_factura.FlatAppearance.BorderSize = 0;
            btn_imprimir_factura.FlatStyle = FlatStyle.Flat;
            btn_imprimir_factura.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_imprimir_factura.ForeColor = Color.White;
            btn_imprimir_factura.Image = (Image)resources.GetObject("btn_imprimir_factura.Image");
            btn_imprimir_factura.ImageAlign = ContentAlignment.MiddleLeft;
            btn_imprimir_factura.Location = new Point(3, 59);
            btn_imprimir_factura.Name = "btn_imprimir_factura";
            btn_imprimir_factura.Padding = new Padding(12, 0, 0, 0);
            btn_imprimir_factura.Size = new Size(197, 50);
            btn_imprimir_factura.TabIndex = 4;
            btn_imprimir_factura.Text = "Imprimir factura";
            btn_imprimir_factura.TextAlign = ContentAlignment.MiddleRight;
            btn_imprimir_factura.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.BackgroundImageLayout = ImageLayout.None;
            btn_consultar.FlatAppearance.BorderSize = 0;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.White;
            btn_consultar.Image = (Image)resources.GetObject("btn_consultar.Image");
            btn_consultar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consultar.Location = new Point(3, 115);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Padding = new Padding(12, 0, 0, 0);
            btn_consultar.Size = new Size(197, 58);
            btn_consultar.TabIndex = 5;
            btn_consultar.Text = "Consultar";
            btn_consultar.TextAlign = ContentAlignment.MiddleRight;
            btn_consultar.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer_btn_usuarios
            // 
            timer_btn_usuarios.Interval = 1;
            timer_btn_usuarios.Tick += timer_btn_usuarios_Tick;
            // 
            // pnl_barra_inferior
            // 
            pnl_barra_inferior.BackColor = Color.FromArgb(200, 209, 166);
            pnl_barra_inferior.Controls.Add(pictureBox2);
            pnl_barra_inferior.Controls.Add(lbl_hora);
            pnl_barra_inferior.Dock = DockStyle.Bottom;
            pnl_barra_inferior.Location = new Point(200, 649);
            pnl_barra_inferior.Name = "pnl_barra_inferior";
            pnl_barra_inferior.Size = new Size(984, 100);
            pnl_barra_inferior.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 27);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lbl_hora
            // 
            lbl_hora.AutoSize = true;
            lbl_hora.Font = new Font("Poppins Medium", 10.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hora.ForeColor = Color.FromArgb(9, 33, 62);
            lbl_hora.Location = new Point(39, 10);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(74, 25);
            lbl_hora.TabIndex = 0;
            lbl_hora.Text = "--:--:--";
            // 
            // btn_barra_inferior
            // 
            btn_barra_inferior.BackColor = Color.FromArgb(200, 209, 166);
            btn_barra_inferior.FlatAppearance.BorderColor = Color.FromArgb(200, 209, 166);
            btn_barra_inferior.FlatAppearance.BorderSize = 0;
            btn_barra_inferior.FlatStyle = FlatStyle.Flat;
            btn_barra_inferior.Image = (Image)resources.GetObject("btn_barra_inferior.Image");
            btn_barra_inferior.Location = new Point(0, -4);
            btn_barra_inferior.Name = "btn_barra_inferior";
            btn_barra_inferior.Size = new Size(25, 23);
            btn_barra_inferior.TabIndex = 4;
            btn_barra_inferior.UseVisualStyleBackColor = false;
            btn_barra_inferior.Click += btn_barra_inferior_Click;
            // 
            // hora
            // 
            hora.Tick += hora_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_barra_inferior);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(200, 629);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 20);
            panel2.TabIndex = 5;
            // 
            // timer_barra_inferior
            // 
            timer_barra_inferior.Interval = 1;
            timer_barra_inferior.Tick += timer_barra_inferior_Tick;
            // 
            // timer_btn_reportes
            // 
            timer_btn_reportes.Interval = 10;
            timer_btn_reportes.Tick += timer_btn_reportes_Tick;
            // 
            // timer_btn_factura
            // 
            timer_btn_factura.Interval = 1;
            timer_btn_factura.Tick += timer_btn_factura_Tick;
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(pictureBox4);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(200, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(984, 629);
            pnl_main.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Mesa_de_trabajo_2;
            pictureBox4.Location = new Point(200, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(625, 242);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 749);
            Controls.Add(pnl_main);
            Controls.Add(panel2);
            Controls.Add(pnl_barra_inferior);
            Controls.Add(pnl_menu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sub_pnl_botones.ResumeLayout(false);
            sub_pnl_reportes.ResumeLayout(false);
            sub_pnl_factura.ResumeLayout(false);
            pnl_barra_inferior.ResumeLayout(false);
            pnl_barra_inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_menu;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_user;
        private FlowLayoutPanel sub_pnl_botones;
        private Button btn_agregra_persona;
        private Button btn_registrar_cliente;
        private Button btn_asignar_empleado;
        private System.Windows.Forms.Timer timer_btn_usuarios;
        private Panel pnl_barra_inferior;
        private PictureBox pictureBox2;
        private Label lbl_hora;
        private Button btn_barra_inferior;
        private System.Windows.Forms.Timer hora;
        private Panel panel2;
        private System.Windows.Forms.Timer timer_barra_inferior;
        private Button btn_reportes;
        private FlowLayoutPanel sub_pnl_reportes;
        private Button btn_crear_habitaciones;
        private Button btn_ver_habitaciones;
        private Button btn_reservar_habitaciones;
        private System.Windows.Forms.Timer timer_btn_reportes;
        private Button btn_factura;
        private FlowLayoutPanel sub_pnl_factura;
        private Button btn_registros_pago;
        private Button btn_imprimir_factura;
        private Button btn_consultar;
        private System.Windows.Forms.Timer timer_btn_factura;
        private Panel pnl_main;
        private PictureBox pictureBox4;
    }
}
