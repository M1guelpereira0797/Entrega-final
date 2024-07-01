namespace SistemaGestionUI
{
    partial class VentaForm
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
            btnVolver = new Button();
            btnEliminar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtComentario = new TextBox();
            txtIdUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(261, 230);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(151, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(31, 230);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 37);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 100);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Comentario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 158);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "IdUsuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(204, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(204, 97);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(100, 23);
            txtComentario.TabIndex = 7;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(204, 150);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 8;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 290);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentario);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "VentaForm";
            Text = "VentaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnEliminar;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtComentario;
        private TextBox txtIdUsuario;
    }
}