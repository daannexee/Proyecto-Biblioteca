namespace Biblioteca
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Titulo = new System.Windows.Forms.Label();
            this.LoginBotton = new System.Windows.Forms.Button();
            this.TXTContra = new System.Windows.Forms.TextBox();
            this.ContraLa = new System.Windows.Forms.Label();
            this.TXTUsua = new System.Windows.Forms.TextBox();
            this.UsuaLa = new System.Windows.Forms.Label();
            this.LoginLetras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(-6, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titulo.Size = new System.Drawing.Size(312, 31);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "Bienvenido a la Biblioteca";
            // 
            // LoginBotton
            // 
            this.LoginBotton.Location = new System.Drawing.Point(9, 330);
            this.LoginBotton.Name = "LoginBotton";
            this.LoginBotton.Size = new System.Drawing.Size(128, 23);
            this.LoginBotton.TabIndex = 5;
            this.LoginBotton.Text = "Iniciar Sesion";
            this.LoginBotton.UseVisualStyleBackColor = true;
            this.LoginBotton.Click += new System.EventHandler(this.LoginBotton_Click);
            // 
            // TXTContra
            // 
            this.TXTContra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTContra.Location = new System.Drawing.Point(12, 238);
            this.TXTContra.Name = "TXTContra";
            this.TXTContra.Size = new System.Drawing.Size(235, 22);
            this.TXTContra.TabIndex = 4;
            this.TXTContra.Text = "Contraseña";
            this.TXTContra.Enter += new System.EventHandler(this.TXTContra_Enter);
            this.TXTContra.Leave += new System.EventHandler(this.TXTContra_Leave);
            this.TXTContra.MouseEnter += new System.EventHandler(this.TXTContra_Enter);
            this.TXTContra.MouseLeave += new System.EventHandler(this.TXTContra_Leave);
            // 
            // ContraLa
            // 
            this.ContraLa.AutoSize = true;
            this.ContraLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraLa.Location = new System.Drawing.Point(9, 218);
            this.ContraLa.Name = "ContraLa";
            this.ContraLa.Size = new System.Drawing.Size(86, 16);
            this.ContraLa.TabIndex = 3;
            this.ContraLa.Text = "Contraseña";
            // 
            // TXTUsua
            // 
            this.TXTUsua.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTUsua.Location = new System.Drawing.Point(12, 156);
            this.TXTUsua.Name = "TXTUsua";
            this.TXTUsua.Size = new System.Drawing.Size(235, 22);
            this.TXTUsua.TabIndex = 2;
            this.TXTUsua.Text = "Usuario";
            this.TXTUsua.Enter += new System.EventHandler(this.TXTUsua_Enter);
            this.TXTUsua.Leave += new System.EventHandler(this.TXTUsua_Leave);
            this.TXTUsua.MouseEnter += new System.EventHandler(this.TXTUsua_Enter);
            this.TXTUsua.MouseLeave += new System.EventHandler(this.TXTUsua_Leave);
            // 
            // UsuaLa
            // 
            this.UsuaLa.AutoSize = true;
            this.UsuaLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuaLa.Location = new System.Drawing.Point(9, 136);
            this.UsuaLa.Name = "UsuaLa";
            this.UsuaLa.Size = new System.Drawing.Size(61, 16);
            this.UsuaLa.TabIndex = 1;
            this.UsuaLa.Text = "Usuario";
            // 
            // LoginLetras
            // 
            this.LoginLetras.AutoSize = true;
            this.LoginLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLetras.Location = new System.Drawing.Point(9, 82);
            this.LoginLetras.Name = "LoginLetras";
            this.LoginLetras.Size = new System.Drawing.Size(49, 18);
            this.LoginLetras.TabIndex = 0;
            this.LoginLetras.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(343, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // GB1
            // 
            this.GB1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB1.Controls.Add(this.Titulo);
            this.GB1.Controls.Add(this.LoginBotton);
            this.GB1.Controls.Add(this.TXTContra);
            this.GB1.Controls.Add(this.ContraLa);
            this.GB1.Controls.Add(this.TXTUsua);
            this.GB1.Controls.Add(this.UsuaLa);
            this.GB1.Controls.Add(this.LoginLetras);
            this.GB1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GB1.Location = new System.Drawing.Point(0, 0);
            this.GB1.Name = "GB1";
            this.GB1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GB1.Size = new System.Drawing.Size(343, 554);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(867, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginLetras;
        private System.Windows.Forms.Label UsuaLa;
        private System.Windows.Forms.TextBox TXTContra;
        private System.Windows.Forms.Label ContraLa;
        private System.Windows.Forms.Button LoginBotton;
        protected internal System.Windows.Forms.TextBox TXTUsua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox GB1;
    }
}

