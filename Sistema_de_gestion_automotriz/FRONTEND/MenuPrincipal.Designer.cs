namespace Sistema_de_gestion_automotriz
{
    partial class MenuPrincipal
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
            btnServicios = new Button();
            btnRefacciones = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCerrar = new Button();
            btnExtender = new Button();
            btnMinimizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.Transparent;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnServicios.ForeColor = Color.DarkGreen;
            btnServicios.Location = new Point(119, 252);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(203, 38);
            btnServicios.TabIndex = 0;
            btnServicios.Text = "Acceder al módulo ➡️";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnRefacciones
            // 
            btnRefacciones.BackColor = Color.Transparent;
            btnRefacciones.FlatAppearance.BorderSize = 0;
            btnRefacciones.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnRefacciones.FlatStyle = FlatStyle.Flat;
            btnRefacciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRefacciones.ForeColor = Color.DarkGreen;
            btnRefacciones.Location = new Point(86, 252);
            btnRefacciones.Name = "btnRefacciones";
            btnRefacciones.Size = new Size(207, 38);
            btnRefacciones.TabIndex = 1;
            btnRefacciones.Text = "Acceder al módulo ➡️";
            btnRefacciones.UseVisualStyleBackColor = false;
            btnRefacciones.Click += btnRefacciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(56, 93);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 2;
            label1.Text = "🔧 Panel de Control";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 139);
            label3.Name = "label3";
            label3.Size = new Size(348, 20);
            label3.TabIndex = 4;
            label3.Text = "Bienvenido al sistema  integral de gestión  de taller mecánico. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(51, 125);
            label2.Name = "label2";
            label2.Size = new Size(261, 28);
            label2.TabIndex = 2;
            label2.Text = "Catalogó   de Refacciones.";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(32, 154);
            label6.Name = "label6";
            label6.Size = new Size(325, 70);
            label6.TabIndex = 5;
            label6.Text = "Control de inventario, categorías de repuestos, stock mínimo  y proveedores asociados.";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources._3709746_customer_evaluation_review_satisfaction_system_108070__1_;
            pictureBox2.Image = Properties.Resources.ajustes__1_;
            pictureBox2.Location = new Point(150, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(47, 154);
            label4.Name = "label4";
            label4.Size = new Size(309, 70);
            label4.TabIndex = 3;
            label4.Text = "Gestión de mano de obra, tarea preventivas y  correctivas. Defina tarifas y tiempos estimados.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(95, 125);
            label5.Name = "label5";
            label5.Size = new Size(227, 28);
            label5.TabIndex = 4;
            label5.Text = "Catalogó  de Servicios.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnRefacciones);
            panel1.Location = new Point(56, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 325);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._3709746_customer_evaluation_review_satisfaction_system_108070__1_;
            pictureBox1.Image = Properties.Resources.brazo_robotico;
            pictureBox1.Location = new Point(123, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnServicios);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(533, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 325);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(btnExtender);
            panel3.Controls.Add(btnMinimizar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 46);
            panel3.TabIndex = 9;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(920, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 39);
            btnCerrar.TabIndex = 17;
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
            btnExtender.Location = new Point(870, 3);
            btnExtender.Name = "btnExtender";
            btnExtender.Size = new Size(44, 39);
            btnExtender.TabIndex = 16;
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
            btnMinimizar.Location = new Point(819, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 39);
            btnMinimizar.TabIndex = 15;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(977, 557);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            Text = "Menu";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServicios;
        private Button btnRefacciones;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnCerrar;
        private Button btnExtender;
        private Button btnMinimizar;
    }
}
