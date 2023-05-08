namespace CarritoDeCompras
{
    partial class GestionClientes
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
            listCientes = new ListBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtTarjeta = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listCientes
            // 
            listCientes.FormattingEnabled = true;
            listCientes.ItemHeight = 15;
            listCientes.Location = new Point(12, -2);
            listCientes.Name = "listCientes";
            listCientes.Size = new Size(272, 409);
            listCientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(502, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(408, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(209, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(408, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(169, 23);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellidos:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(408, 85);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(169, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 88);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(408, 114);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(169, 23);
            txtTarjeta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 117);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 9;
            label4.Text = "Tarjeta de credito:";
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTarjeta);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(listCientes);
            Name = "GestionClientes";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCientes;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEliminar;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtTarjeta;
        private Label label4;
    }
}