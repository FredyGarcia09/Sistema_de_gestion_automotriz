namespace Sistema_de_gestion_automotriz
{
    partial class Refacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refacciones));
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigoRefaccion = new TextBox();
            txtMarca = new TextBox();
            txtNombreRefaccion = new TextBox();
            txtPrecioUnitario = new TextBox();
            label5 = new Label();
            txtStockMinimo = new TextBox();
            txtAtockActual = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnGuardar = new Button();
            label8 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            grbStock = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblModo = new Label();
            txtProveedor = new TextBox();
            panel1.SuspendLayout();
            grbStock.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(43, 129);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 1;
            label1.Text = "CÓDIGO DE REFACCIÓN ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(448, 129);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 2;
            label2.Text = "MARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(43, 216);
            label3.Name = "label3";
            label3.Size = new Size(289, 28);
            label3.TabIndex = 3;
            label3.Text = "NOMBRE DE LA REFACCION *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(43, 304);
            label4.Name = "label4";
            label4.Size = new Size(197, 28);
            label4.TabIndex = 4;
            label4.Text = "PRECIO UNITARIO *";
            // 
            // txtCodigoRefaccion
            // 
            txtCodigoRefaccion.Font = new Font("Segoe UI", 12F);
            txtCodigoRefaccion.ForeColor = Color.Gainsboro;
            txtCodigoRefaccion.Location = new Point(43, 170);
            txtCodigoRefaccion.Name = "txtCodigoRefaccion";
            txtCodigoRefaccion.PlaceholderText = "SKU - 000";
            txtCodigoRefaccion.Size = new Size(362, 34);
            txtCodigoRefaccion.TabIndex = 5;
            txtCodigoRefaccion.Text = "SKU - 000";
            txtCodigoRefaccion.Enter += txtFuncionalidad_Enter;
            txtCodigoRefaccion.KeyPress += txtCodigoRefaccion_KeyPress;
            txtCodigoRefaccion.Leave += txtFuncionalidad_Leave;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.ForeColor = Color.Gainsboro;
            txtMarca.Location = new Point(448, 170);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Ej. Bosch, Mazda..";
            txtMarca.Size = new Size(359, 34);
            txtMarca.TabIndex = 6;
            txtMarca.Text = "Ej. Bosch, Mazda..";
            txtMarca.Enter += txtMarca_Enter;
            txtMarca.KeyPress += txtMarca_KeyPress;
            txtMarca.Leave += txtMarca_Leave;
            // 
            // txtNombreRefaccion
            // 
            txtNombreRefaccion.Font = new Font("Segoe UI", 12F);
            txtNombreRefaccion.ForeColor = Color.Gainsboro;
            txtNombreRefaccion.Location = new Point(43, 253);
            txtNombreRefaccion.Name = "txtNombreRefaccion";
            txtNombreRefaccion.PlaceholderText = "Ej. Filtro de Aceite de Alto Rendimiento";
            txtNombreRefaccion.Size = new Size(764, 34);
            txtNombreRefaccion.TabIndex = 7;
            txtNombreRefaccion.Text = "Ej. Filtro de Aceite de Alto Rendimiento";
            txtNombreRefaccion.Enter += txtNombreRefaccion_Enter;
            txtNombreRefaccion.KeyPress += txtNombreRefaccion_KeyPress;
            txtNombreRefaccion.Leave += txtNombreRefaccion_Leave;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 12F);
            txtPrecioUnitario.ForeColor = Color.Gainsboro;
            txtPrecioUnitario.Location = new Point(43, 339);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.PlaceholderText = "$ 0.00";
            txtPrecioUnitario.Size = new Size(362, 34);
            txtPrecioUnitario.TabIndex = 8;
            txtPrecioUnitario.Text = "$ 0.00";
            txtPrecioUnitario.Enter += txtPrecioUnitario_Enter;
            txtPrecioUnitario.KeyPress += txtPrecioUnitario_KeyPress;
            txtPrecioUnitario.Leave += txtPrecioUnitario_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(448, 294);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 9;
            label5.Text = "PROVEEDOR";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Font = new Font("Segoe UI", 12F);
            txtStockMinimo.ForeColor = Color.Gainsboro;
            txtStockMinimo.Location = new Point(416, 59);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(359, 34);
            txtStockMinimo.TabIndex = 14;
            txtStockMinimo.KeyPress += txtStockMinimo_KeyPress;
            // 
            // txtAtockActual
            // 
            txtAtockActual.Font = new Font("Segoe UI", 12F);
            txtAtockActual.ForeColor = Color.Gainsboro;
            txtAtockActual.Location = new Point(11, 59);
            txtAtockActual.Name = "txtAtockActual";
            txtAtockActual.Size = new Size(362, 34);
            txtAtockActual.TabIndex = 12;
            txtAtockActual.KeyPress += txtAtockActual_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(416, 19);
            label7.Name = "label7";
            label7.Size = new Size(182, 28);
            label7.TabIndex = 13;
            label7.Text = "STOCK MÍNIMO  *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(11, 19);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 12;
            label6.Text = "STOCK ACTUAL *";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(738, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 45);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "📩Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(43, 31);
            label8.Name = "label8";
            label8.Size = new Size(270, 20);
            label8.TabIndex = 13;
            label8.Text = "          Los campos con * son obligatorios.";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 71);
            panel1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(22, 16);
            label9.Name = "label9";
            label9.Size = new Size(169, 28);
            label9.TabIndex = 3;
            label9.Text = "REFACCIONES\U0001f6d2";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(788, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 39);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "×";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ButtonFace;
            btnMinimizar.Location = new Point(737, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 39);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // grbStock
            // 
            grbStock.Controls.Add(txtStockMinimo);
            grbStock.Controls.Add(label7);
            grbStock.Controls.Add(txtAtockActual);
            grbStock.Controls.Add(label6);
            grbStock.Location = new Point(32, 400);
            grbStock.Name = "grbStock";
            grbStock.Size = new Size(801, 125);
            grbStock.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 86);
            panel2.TabIndex = 17;
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
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModo.ForeColor = Color.DarkGreen;
            lblModo.Location = new Point(43, 86);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(156, 28);
            lblModo.TabIndex = 19;
            lblModo.Text = "MODO: Edición";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 12F);
            txtProveedor.ForeColor = Color.Gainsboro;
            txtProveedor.Location = new Point(448, 339);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.PlaceholderText = "Michelin";
            txtProveedor.Size = new Size(362, 34);
            txtProveedor.TabIndex = 20;
            txtProveedor.Text = "Michelin";
            // 
            // Refacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(867, 649);
            Controls.Add(txtProveedor);
            Controls.Add(lblModo);
            Controls.Add(panel2);
            Controls.Add(grbStock);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtNombreRefaccion);
            Controls.Add(txtMarca);
            Controls.Add(txtCodigoRefaccion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Refacciones";
            Text = "Refacciones";
            Load += Refacciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbStock.ResumeLayout(false);
            grbStock.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigoRefaccion;
        private TextBox txtMarca;
        private TextBox txtNombreRefaccion;
        private TextBox txtPrecioUnitario;
        private Label label5;
        private TextBox txtStockMinimo;
        private TextBox txtAtockActual;
        private Label label7;
        private Label label6;
        private Button btnGuardar;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private Button btnCerrar;
        private Panel grbStock;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnMinimizar;
        private Label lblModo;
        private TextBox txtProveedor;
    }
}