namespace pre
{
    partial class Contraseñas
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
            lbltitulo = new Label();
            lblLongitud = new Label();
            nudLongitud = new NumericUpDown();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnGenerar = new Button();
            btnVerificar = new Button();
            lblEstado = new Label();
            txtresultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = SystemColors.ButtonShadow;
            lbltitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(31, 20);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(237, 20);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "GENERADOR DE CONTRASEÑAS";
            lbltitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.BackColor = SystemColors.ButtonShadow;
            lblLongitud.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongitud.Location = new Point(72, 55);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(140, 15);
            lblLongitud.TabIndex = 1;
            lblLongitud.Text = "Longitud de contraseña:";
            lblLongitud.TextAlign = ContentAlignment.TopCenter;
            // 
            // nudLongitud
            // 
            nudLongitud.Location = new Point(96, 85);
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(100, 23);
            nudLongitud.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ButtonShadow;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(106, 112);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 141);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(12, 183);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(130, 33);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar Password";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(148, 183);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(138, 33);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar si es fuerte";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = SystemColors.ButtonShadow;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(72, 232);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(139, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado de la contraseña:";
            lblEstado.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(72, 260);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(139, 23);
            txtresultado.TabIndex = 8;
            txtresultado.Text = "-------------------------------";
            // 
            // Contraseñas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(298, 316);
            Controls.Add(txtresultado);
            Controls.Add(lblEstado);
            Controls.Add(btnVerificar);
            Controls.Add(btnGenerar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(nudLongitud);
            Controls.Add(lblLongitud);
            Controls.Add(lbltitulo);
            Name = "Contraseñas";
            Text = "Contraseñas";
            ((System.ComponentModel.ISupportInitialize)nudLongitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblLongitud;
        private NumericUpDown nudLongitud;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnGenerar;
        private Button btnVerificar;
        private Label lblEstado;
        private TextBox txtresultado;
    }
}
