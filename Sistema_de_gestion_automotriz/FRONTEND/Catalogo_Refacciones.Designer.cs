namespace Sistema_de_gestion_automotriz
{
    partial class Catalogo_Refacciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBuscar_Clave_Nombre = new TextBox();
            btnRecargar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dgvRefacciones = new DataGridView();
            panel2 = new Panel();
            btnCerrar = new Button();
            label4 = new Label();
            btnExtender = new Button();
            btnMinimizar = new Button();
            btnVer = new Button();
            btnModifica = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(34, 84);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "📂CATALOGOS ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(319, 38);
            label2.TabIndex = 1;
            label2.Text = "Catálogo de Refacciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 157);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 2;
            label3.Text = "Gestión de Refacciones y Costos .";
            // 
            // txtBuscar_Clave_Nombre
            // 
            txtBuscar_Clave_Nombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            txtBuscar_Clave_Nombre.Location = new Point(441, 152);
            txtBuscar_Clave_Nombre.Name = "txtBuscar_Clave_Nombre";
            txtBuscar_Clave_Nombre.Size = new Size(439, 30);
            txtBuscar_Clave_Nombre.TabIndex = 3;
            txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre.";
            txtBuscar_Clave_Nombre.TextChanged += txtBuscar_Clave_Nombre_TextChanged;
            txtBuscar_Clave_Nombre.Enter += txtBuscar_Clave_Nombre_Enter;
            txtBuscar_Clave_Nombre.Leave += txtBuscar_Clave_Nombre_Leave;
            // 
            // btnRecargar
            // 
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecargar.Location = new Point(886, 142);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(46, 48);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "🔃";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(106, 202);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 39);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "➕ Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(359, 202);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 39);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button4_Click;
            // 
            // dgvRefacciones
            // 
            dgvRefacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRefacciones.Location = new Point(35, 293);
            dgvRefacciones.Name = "dgvRefacciones";
            dgvRefacciones.RowHeadersWidth = 51;
            dgvRefacciones.Size = new Size(897, 426);
            dgvRefacciones.TabIndex = 8;
            dgvRefacciones.CellDoubleClick += dgvRefacciones_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnExtender);
            panel2.Controls.Add(btnMinimizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 54);
            panel2.TabIndex = 10;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(908, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 39);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "×";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(137, 17);
            label4.TabIndex = 0;
            label4.Text = "🔧TALLER MECANICO";
            // 
            // btnExtender
            // 
            btnExtender.BackColor = Color.Transparent;
            btnExtender.FlatAppearance.BorderSize = 0;
            btnExtender.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnExtender.FlatStyle = FlatStyle.Flat;
            btnExtender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtender.ForeColor = SystemColors.ButtonFace;
            btnExtender.Location = new Point(858, 4);
            btnExtender.Name = "btnExtender";
            btnExtender.Size = new Size(44, 39);
            btnExtender.TabIndex = 13;
            btnExtender.Text = "▭";
            btnExtender.UseVisualStyleBackColor = false;
            btnExtender.Click += btnExtender_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ButtonFace;
            btnMinimizar.Location = new Point(807, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 39);
            btnMinimizar.TabIndex = 12;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnVer
            // 
            btnVer.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnVer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVer.Location = new Point(34, 202);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(66, 39);
            btnVer.TabIndex = 11;
            btnVer.Text = "👁️ Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnModifica
            // 
            btnModifica.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnModifica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifica.Location = new Point(236, 202);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(117, 39);
            btnModifica.TabIndex = 12;
            btnModifica.Text = "✏️Modificar";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // Catalogo_Refacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 764);
            Controls.Add(btnModifica);
            Controls.Add(btnVer);
            Controls.Add(panel2);
            Controls.Add(dgvRefacciones);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnRecargar);
            Controls.Add(txtBuscar_Clave_Nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo_Refacciones";
            Text = "Catalogo_Refacciones";
            Load += Catalogo_Refacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBuscar_Clave_Nombre;
        private Button btnRecargar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvRefacciones;
        private Panel panel2;
        private Label label4;
        private Button btnVer;
        private Button btnCerrar;
        private Button btnExtender;
        private Button btnMinimizar;
        private Button btnModifica;
    }
}