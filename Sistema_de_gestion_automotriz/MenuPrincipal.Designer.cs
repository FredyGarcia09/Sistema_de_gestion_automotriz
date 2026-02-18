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
            SuspendLayout();
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(366, 238);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(190, 38);
            btnServicios.TabIndex = 0;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnRefacciones
            // 
            btnRefacciones.Location = new Point(366, 309);
            btnRefacciones.Name = "btnRefacciones";
            btnRefacciones.Size = new Size(190, 38);
            btnRefacciones.TabIndex = 1;
            btnRefacciones.Text = "Refacciones";
            btnRefacciones.UseVisualStyleBackColor = true;
            btnRefacciones.Click += btnRefacciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 148);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona una función";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 622);
            Controls.Add(label1);
            Controls.Add(btnRefacciones);
            Controls.Add(btnServicios);
            Name = "MenuPrincipal";
            Text = "Menu";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServicios;
        private Button btnRefacciones;
        private Label label1;
    }
}
