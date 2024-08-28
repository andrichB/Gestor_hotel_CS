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
            btn_agregra_user = new Button();
            btn_eliminar_user = new Button();
            btn_editar_user = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer_btn_usuarios = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_hora = new Label();
            button1 = new Button();
            hora = new System.Windows.Forms.Timer(components);
            pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sub_pnl_botones.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(153, 165, 95);
            pnl_menu.Controls.Add(pictureBox1);
            pnl_menu.Controls.Add(btn_user);
            pnl_menu.Controls.Add(sub_pnl_botones);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Margin = new Padding(0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(200, 711);
            pnl_menu.TabIndex = 1;
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
            sub_pnl_botones.Controls.Add(btn_agregra_user);
            sub_pnl_botones.Controls.Add(btn_eliminar_user);
            sub_pnl_botones.Controls.Add(btn_editar_user);
            sub_pnl_botones.Location = new Point(3, 133);
            sub_pnl_botones.Name = "sub_pnl_botones";
            sub_pnl_botones.Size = new Size(197, 170);
            sub_pnl_botones.TabIndex = 2;
            // 
            // btn_agregra_user
            // 
            btn_agregra_user.BackgroundImageLayout = ImageLayout.None;
            btn_agregra_user.FlatAppearance.BorderSize = 0;
            btn_agregra_user.FlatStyle = FlatStyle.Flat;
            btn_agregra_user.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregra_user.ForeColor = Color.White;
            btn_agregra_user.Image = (Image)resources.GetObject("btn_agregra_user.Image");
            btn_agregra_user.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregra_user.Location = new Point(3, 3);
            btn_agregra_user.Name = "btn_agregra_user";
            btn_agregra_user.Padding = new Padding(12, 0, 0, 0);
            btn_agregra_user.Size = new Size(197, 50);
            btn_agregra_user.TabIndex = 3;
            btn_agregra_user.Text = "Agregar usario";
            btn_agregra_user.TextAlign = ContentAlignment.MiddleRight;
            btn_agregra_user.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_user
            // 
            btn_eliminar_user.BackgroundImageLayout = ImageLayout.None;
            btn_eliminar_user.FlatAppearance.BorderSize = 0;
            btn_eliminar_user.FlatStyle = FlatStyle.Flat;
            btn_eliminar_user.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_user.ForeColor = Color.White;
            btn_eliminar_user.Image = (Image)resources.GetObject("btn_eliminar_user.Image");
            btn_eliminar_user.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar_user.Location = new Point(3, 59);
            btn_eliminar_user.Name = "btn_eliminar_user";
            btn_eliminar_user.Padding = new Padding(12, 0, 0, 0);
            btn_eliminar_user.Size = new Size(197, 50);
            btn_eliminar_user.TabIndex = 4;
            btn_eliminar_user.Text = "Eliminar usario";
            btn_eliminar_user.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar_user.UseVisualStyleBackColor = true;
            // 
            // btn_editar_user
            // 
            btn_editar_user.BackgroundImageLayout = ImageLayout.None;
            btn_editar_user.FlatAppearance.BorderSize = 0;
            btn_editar_user.FlatStyle = FlatStyle.Flat;
            btn_editar_user.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar_user.ForeColor = Color.White;
            btn_editar_user.Image = (Image)resources.GetObject("btn_editar_user.Image");
            btn_editar_user.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar_user.Location = new Point(3, 115);
            btn_editar_user.Name = "btn_editar_user";
            btn_editar_user.Padding = new Padding(12, 0, 0, 0);
            btn_editar_user.Size = new Size(197, 50);
            btn_editar_user.TabIndex = 5;
            btn_editar_user.Text = "Editar usuario";
            btn_editar_user.TextAlign = ContentAlignment.MiddleRight;
            btn_editar_user.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 209, 166);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_hora);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(200, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 93);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 19);
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
            lbl_hora.Location = new Point(55, 19);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(74, 25);
            lbl_hora.TabIndex = 0;
            lbl_hora.Text = "--:--:--";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 209, 166);
            button1.FlatAppearance.BorderColor = Color.FromArgb(200, 209, 166);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(200, 598);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // hora
            // 
            hora.Tick += hora_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pnl_menu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sub_pnl_botones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_menu;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_user;
        private FlowLayoutPanel sub_pnl_botones;
        private Button btn_agregra_user;
        private Button btn_eliminar_user;
        private Button btn_editar_user;
        private System.Windows.Forms.Timer timer_btn_usuarios;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lbl_hora;
        private Button button1;
        private System.Windows.Forms.Timer hora;
    }
}
