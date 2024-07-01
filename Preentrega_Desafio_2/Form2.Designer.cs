namespace SistemaGestionUI
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
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NombreUsuario = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(46, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 48);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 196);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(296, 48);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(91, 15);
            NombreUsuario.TabIndex = 4;
            NombreUsuario.Text = "NombreUsuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 112);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "Contrasena";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 191);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 6;
            label6.Text = "Mail";
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 188);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(403, 188);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 10;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(403, 104);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 11;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(403, 40);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 290);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(464, 290);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 350);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(NombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label NombreUsuario;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private Button btnEliminar;
        private Button btnVolver;
    }
}