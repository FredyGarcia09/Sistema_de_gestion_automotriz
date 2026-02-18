namespace Sistema_de_gestion_automotriz
{
    partial class CatalogoServicioss
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
            btnVer = new Button();
            button1 = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 47);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Catálogo de Servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 94);
            label2.Name = "label2";
            label2.Size = new Size(404, 20);
            label2.TabIndex = 1;
            label2.Text = "Gestión de servicios mecánicos, costos y tiempos estimados";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(77, 148);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 2;
            btnVer.Text = "👁️Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(237, 148);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "➕Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(415, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "🗑️Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // CatalogoServicioss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 602);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(btnVer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CatalogoServicioss";
            Text = "CatalogoServicioss";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVer;
        private Button button1;
        private Button btnEliminar;
    }
}