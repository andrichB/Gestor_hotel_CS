namespace Gestor_hotel_CS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_titulo = new Label();
            lbl_nombre = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_documento = new Label();
            textBox3 = new TextBox();
            lbl_apellido = new Label();
            textBox4 = new TextBox();
            lbl_telefono = new Label();
            dataGridView1 = new DataGridView();
            btn_insertar = new Button();
            btn_regresar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(380, 26);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(226, 42);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Ingrese los datos";
            lbl_titulo.Click += label1_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre.Location = new Point(65, 96);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(76, 28);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            lbl_nombre.Click += lbl_documento_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 4;
            // 
            // lbl_documento
            // 
            lbl_documento.AutoSize = true;
            lbl_documento.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documento.Location = new Point(65, 135);
            lbl_documento.Name = "lbl_documento";
            lbl_documento.Size = new Size(105, 28);
            lbl_documento.TabIndex = 3;
            lbl_documento.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(537, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 6;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apellido.Location = new Point(426, 96);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(77, 28);
            lbl_apellido.TabIndex = 5;
            lbl_apellido.Text = "Apellido";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(537, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 8;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_telefono.Location = new Point(426, 135);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(80, 28);
            lbl_telefono.TabIndex = 7;
            lbl_telefono.Text = "Teléfono";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(851, 288);
            dataGridView1.TabIndex = 9;
            // 
            // btn_insertar
            // 
            btn_insertar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_insertar.Location = new Point(53, 519);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(117, 33);
            btn_insertar.TabIndex = 10;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            btn_regresar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar.Location = new Point(787, 519);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(117, 33);
            btn_regresar.TabIndex = 11;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(426, 519);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(117, 33);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar.Location = new Point(241, 519);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(117, 33);
            btn_modificar.TabIndex = 13;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(612, 519);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(117, 33);
            btn_buscar.TabIndex = 14;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 590);
            Controls.Add(btn_buscar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_regresar);
            Controls.Add(btn_insertar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(lbl_telefono);
            Controls.Add(textBox3);
            Controls.Add(lbl_apellido);
            Controls.Add(textBox2);
            Controls.Add(lbl_documento);
            Controls.Add(textBox1);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_titulo);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_nombre;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_documento;
        private TextBox textBox3;
        private Label lbl_apellido;
        private TextBox textBox4;
        private Label lbl_telefono;
        private DataGridView dataGridView1;
        private Button btn_insertar;
        private Button btn_regresar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_buscar;
    }
}