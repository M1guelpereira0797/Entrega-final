namespace SistemaGestionUI
{
    partial class ProductoVendidoForm
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
            btnVovler = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            txtIdProducto = new TextBox();
            txtStock = new TextBox();
            txtIdVenta = new TextBox();
            Id = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnVovler
            // 
            btnVovler.Location = new Point(329, 244);
            btnVovler.Name = "btnVovler";
            btnVovler.Size = new Size(75, 23);
            btnVovler.TabIndex = 0;
            btnVovler.Text = "Volver";
            btnVovler.UseVisualStyleBackColor = true;
            btnVovler.Click += btnVovler_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(34, 231);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 40);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(253, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(253, 85);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(253, 135);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 4;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(253, 186);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 5;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(56, 50);
            Id.Name = "Id";
            Id.Size = new Size(17, 15);
            Id.TabIndex = 6;
            Id.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 103);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "IdProducto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 152);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 195);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "IdVenta";
            // 
            // ProductoVendidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 293);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Id);
            Controls.Add(txtIdVenta);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnVovler);
            Name = "ProductoVendidoForm";
            Text = "ProductoVendidoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVovler;
        private Button btnEliminar;
        private TextBox txtId;
        private TextBox txtIdProducto;
        private TextBox txtStock;
        private TextBox txtIdVenta;
        private Label Id;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}