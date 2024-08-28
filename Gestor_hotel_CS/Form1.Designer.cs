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
            pnlBoton = new Panel();
            btn_agregar_user = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBoton.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(153, 165, 95);
            pnl_menu.Controls.Add(pictureBox1);
            pnl_menu.Controls.Add(pnlBoton);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(200, 461);
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
            // pnlBoton
            // 
            pnlBoton.Controls.Add(btn_agregar_user);
            pnlBoton.Location = new Point(3, 77);
            pnlBoton.Name = "pnlBoton";
            pnlBoton.Size = new Size(197, 57);
            pnlBoton.TabIndex = 1;
            // 
            // btn_agregar_user
            // 
            btn_agregar_user.BackgroundImageLayout = ImageLayout.None;
            btn_agregar_user.FlatAppearance.BorderSize = 0;
            btn_agregar_user.FlatStyle = FlatStyle.Flat;
            btn_agregar_user.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_user.ForeColor = Color.FromArgb(9, 33, 62);
            btn_agregar_user.Image = (Image)resources.GetObject("btn_agregar_user.Image");
            btn_agregar_user.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_user.Location = new Point(0, 0);
            btn_agregar_user.Name = "btn_agregar_user";
            btn_agregar_user.Padding = new Padding(12, 0, 0, 0);
            btn_agregar_user.Size = new Size(197, 57);
            btn_agregar_user.TabIndex = 0;
            btn_agregar_user.Text = "Agregar usario";
            btn_agregar_user.TextAlign = ContentAlignment.MiddleRight;
            btn_agregar_user.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(pnl_menu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBoton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_menu;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlBoton;
        private Button btn_agregar_user;
    }
}
