namespace Sistema_de_gestion_automotriz
{
    partial class Detalles_Servicio
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
            label4 = new Label();
            btnMinimizar = new Button();
            groupBox1 = new GroupBox();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtNombreServicio = new TextBox();
            txtClaveServicio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCostoBase = new TextBox();
            txtTiempoEstimado = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            groupBox2 = new GroupBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnMinimizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 54);
            panel2.TabIndex = 12;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 0;
            label4.Text = "🔧Detalle del Servicio.";
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ButtonFace;
            btnMinimizar.Location = new Point(804, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 39);
            btnMinimizar.TabIndex = 24;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombreServicio);
            groupBox1.Controls.Add(txtClaveServicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(27, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 239);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "❗INFORMACION GENERAL";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.Gainsboro;
            txtDescripcion.Location = new Point(16, 140);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Detalle los alcances técnicos  y requerimientos del servicio...";
            txtDescripcion.Size = new Size(828, 82);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.Text = "Detalle los alcances técnicos  y requerimientos del servicio...";
            txtDescripcion.Enter += txtDescripcion_Enter;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(16, 114);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 4;
            label5.Text = "DESCRIPCION";
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombreServicio.ForeColor = Color.Gainsboro;
            txtNombreServicio.Location = new Point(472, 73);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.PlaceholderText = "Mantenimiento Preventivo";
            txtNombreServicio.Size = new Size(372, 34);
            txtNombreServicio.TabIndex = 3;
            txtNombreServicio.Text = "Mantenimiento Preventivo";
            txtNombreServicio.Enter += txtNombreServicio_Enter;
            txtNombreServicio.KeyPress += txtNombreServicio_KeyPress;
            txtNombreServicio.Leave += txtNombreServicio_Leave;
            // 
            // txtClaveServicio
            // 
            txtClaveServicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtClaveServicio.ForeColor = Color.Gainsboro;
            txtClaveServicio.Location = new Point(16, 73);
            txtClaveServicio.Name = "txtClaveServicio";
            txtClaveServicio.PlaceholderText = "Ex: SERV-001";
            txtClaveServicio.Size = new Size(387, 34);
            txtClaveServicio.TabIndex = 2;
            txtClaveServicio.Text = "Ex: SERV-001";
            txtClaveServicio.Enter += txtClaveServicio_Enter;
            txtClaveServicio.KeyPress += txtClaveServicio_KeyPress;
            txtClaveServicio.Leave += txtClaveServicio_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(472, 36);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 1;
            label3.Text = "NOMBRE DEL SERVICIO *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(16, 36);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 0;
            label2.Text = "CLAVE DEL SERVICIO *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(16, 51);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 6;
            label6.Text = "COSTO BASE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(463, 51);
            label8.Name = "label8";
            label8.Size = new Size(161, 23);
            label8.TabIndex = 8;
            label8.Text = "TIEMPO ESTIMADO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Italic);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(16, 124);
            label9.Name = "label9";
            label9.Size = new Size(282, 20);
            label9.TabIndex = 15;
            label9.Text = "Monto Sugerido antes de Impuestos.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Italic);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(463, 124);
            label10.Name = "label10";
            label10.Size = new Size(258, 20);
            label10.TabIndex = 16;
            label10.Text = "Duracion Promedio de Ejecucion.";
            // 
            // txtCostoBase
            // 
            txtCostoBase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCostoBase.ForeColor = Color.Gainsboro;
            txtCostoBase.Location = new Point(16, 87);
            txtCostoBase.Name = "txtCostoBase";
            txtCostoBase.PlaceholderText = "$ 0.00";
            txtCostoBase.Size = new Size(387, 34);
            txtCostoBase.TabIndex = 7;
            txtCostoBase.Text = "$ 0.00";
            txtCostoBase.Enter += txtCostoBase_Enter;
            txtCostoBase.KeyPress += txtCostoBase_KeyPress;
            txtCostoBase.Leave += txtCostoBase_Leave;
            // 
            // txtTiempoEstimado
            // 
            txtTiempoEstimado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTiempoEstimado.ForeColor = Color.Gainsboro;
            txtTiempoEstimado.Location = new Point(463, 87);
            txtTiempoEstimado.Name = "txtTiempoEstimado";
            txtTiempoEstimado.PlaceholderText = "1.5                                                   HRS";
            txtTiempoEstimado.Size = new Size(381, 34);
            txtTiempoEstimado.TabIndex = 8;
            txtTiempoEstimado.Text = "1.5                                                   HRS";
            txtTiempoEstimado.Enter += txtTiempoEstimado_Enter;
            txtTiempoEstimado.KeyPress += txtTiempoEstimado_KeyPress;
            txtTiempoEstimado.Leave += txtTiempoEstimado_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 545);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 86);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.exclamation_sign_icon_icons_com_73579;
            pictureBox1.Location = new Point(32, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(43, 31);
            label11.Name = "label11";
            label11.Size = new Size(270, 20);
            label11.TabIndex = 13;
            label11.Text = "          Los campos con * son obligatorios.";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(606, 19);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 45);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "❎Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.Location = new Point(738, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 45);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "📩Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCostoBase);
            groupBox2.Controls.Add(txtTiempoEstimado);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(26, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(865, 185);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "💵 DETALLES OPERATIVOS";
            // 
            // Detalles_Servicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 631);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detalles_Servicio";
            Text = "Detalles_Servicio";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private Label label4;
        private Button btnMinimizar;
        private GroupBox groupBox1;
        private TextBox txtNombreServicio;
        private TextBox txtClaveServicio;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCostoBase;
        private TextBox txtTiempoEstimado;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label11;
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox groupBox2;
    }
}