namespace Sistema_de_gestion_automotriz
{
    partial class Catalogo_Servicio
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
            panel2 = new Panel();
            btnCerrar = new Button();
            btnExtender = new Button();
            label4 = new Label();
            btnMinimizar = new Button();
            btnVer = new Button();
            dgvServicios = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnRecargar = new Button();
            txtBuscar_Clave_Nombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnExtender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnMinimizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 54);
            panel2.TabIndex = 11;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(855, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 39);
            btnCerrar.TabIndex = 26;
            btnCerrar.Text = "×";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnExtender
            // 
            btnExtender.BackColor = Color.Transparent;
            btnExtender.FlatAppearance.BorderSize = 0;
            btnExtender.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnExtender.FlatStyle = FlatStyle.Flat;
            btnExtender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtender.ForeColor = SystemColors.ButtonFace;
            btnExtender.Location = new Point(805, 4);
            btnExtender.Name = "btnExtender";
            btnExtender.Size = new Size(44, 39);
            btnExtender.TabIndex = 25;
            btnExtender.Text = "▭";
            btnExtender.UseVisualStyleBackColor = false;
            btnExtender.Click += btnExtender_Click;
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
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ButtonFace;
            btnMinimizar.Location = new Point(754, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 39);
            btnMinimizar.TabIndex = 24;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnVer
            // 
            btnVer.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnVer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVer.Location = new Point(12, 206);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(66, 39);
            btnVer.TabIndex = 21;
            btnVer.Text = "👁️ Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(14, 263);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(897, 426);
            dgvServicios.TabIndex = 20;
            dgvServicios.CellDoubleClick += dgvServicios_CellDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(333, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 39);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(205, 206);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 39);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "✏️ Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(84, 206);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 39);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "➕ Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecargar.Location = new Point(865, 145);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(46, 48);
            btnRecargar.TabIndex = 16;
            btnRecargar.Text = "🔃";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // txtBuscar_Clave_Nombre
            // 
            txtBuscar_Clave_Nombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            txtBuscar_Clave_Nombre.Location = new Point(420, 155);
            txtBuscar_Clave_Nombre.Name = "txtBuscar_Clave_Nombre";
            txtBuscar_Clave_Nombre.Size = new Size(439, 30);
            txtBuscar_Clave_Nombre.TabIndex = 15;
            txtBuscar_Clave_Nombre.Text = "🔍Buscar por Nombre del Servicio";
            txtBuscar_Clave_Nombre.TextChanged += txtBuscar_Clave_Nombre_TextChanged;
            txtBuscar_Clave_Nombre.Enter += txtBuscar_Clave_Nombre_Enter;
            txtBuscar_Clave_Nombre.KeyPress += txtBuscar_Clave_Nombre_KeyPress;
            txtBuscar_Clave_Nombre.Leave += txtBuscar_Clave_Nombre_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 14;
            label3.Text = "Gestión de Servicios.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-49, -72);
            label2.Name = "label2";
            label2.Size = new Size(319, 38);
            label2.TabIndex = 13;
            label2.Text = "Catálogo de Refacciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(-49, -92);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 12;
            label1.Text = "📂CATALOGOS ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 112);
            label5.Name = "label5";
            label5.Size = new Size(287, 38);
            label5.TabIndex = 23;
            label5.Text = "Catálogo de Servicios.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(12, 92);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 22;
            label6.Text = "📂CATALOGOS ";
            // 
            // Catalogo_Servicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 711);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnVer);
            Controls.Add(dgvServicios);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnRecargar);
            Controls.Add(txtBuscar_Clave_Nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo_Servicio";
            Text = "Catalogo_Servicio";
            Load += Catalogo_Servicio_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Button btnVer;
        private DataGridView dgvServicios;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnRecargar;
        private TextBox txtBuscar_Clave_Nombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btnCerrar;
        private Button btnExtender;
        private Button btnMinimizar;
    }
}