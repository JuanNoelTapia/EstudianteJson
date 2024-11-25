namespace EstudianteJson
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtCarrera = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtCarnet = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            DatosEstudiantes = new ListBox();
            Agregar = new Button();
            Guardar = new Button();
            Actualizar = new Button();
            Salir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(660, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 17);
            label1.Name = "label1";
            label1.Size = new Size(312, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista De Estudiantes con Json";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCarrera);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtCarnet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(18, 74);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(327, 198);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(81, 158);
            txtCarrera.Margin = new Padding(3, 2, 3, 2);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(110, 23);
            txtCarrera.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(81, 122);
            txtEdad.Margin = new Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(110, 23);
            txtEdad.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(81, 92);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 60);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(81, 24);
            txtCarnet.Margin = new Padding(3, 2, 3, 2);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(110, 23);
            txtCarnet.TabIndex = 5;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 158);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 4;
            label6.Text = "Carrera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 122);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 3;
            label5.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 92);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 62);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 26);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Carnet";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DatosEstudiantes);
            groupBox3.Location = new Point(363, 82);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(318, 190);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // DatosEstudiantes
            // 
            DatosEstudiantes.FormattingEnabled = true;
            DatosEstudiantes.ItemHeight = 15;
            DatosEstudiantes.Location = new Point(5, 21);
            DatosEstudiantes.Margin = new Padding(3, 2, 3, 2);
            DatosEstudiantes.Name = "DatosEstudiantes";
            DatosEstudiantes.Size = new Size(308, 169);
            DatosEstudiantes.TabIndex = 0;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(18, 286);
            Agregar.Margin = new Padding(3, 2, 3, 2);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(82, 22);
            Agregar.TabIndex = 3;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(125, 292);
            Guardar.Margin = new Padding(3, 2, 3, 2);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(82, 22);
            Guardar.TabIndex = 4;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(249, 295);
            Actualizar.Margin = new Padding(3, 2, 3, 2);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(82, 22);
            Actualizar.TabIndex = 5;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(376, 291);
            Salir.Margin = new Padding(3, 2, 3, 2);
            Salir.Name = "Salir";
            Salir.Size = new Size(82, 22);
            Salir.TabIndex = 6;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Salir);
            Controls.Add(Actualizar);
            Controls.Add(Guardar);
            Controls.Add(Agregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtCarrera;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCarnet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private ListBox DatosEstudiantes;
        private Button Agregar;
        private Button Guardar;
        private Button Actualizar;
        private Button Salir;
    }
}
