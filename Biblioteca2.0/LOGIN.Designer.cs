namespace Biblioteca2._0
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTUsua = new System.Windows.Forms.TextBox();
            this.TXTCon = new System.Windows.Forms.TextBox();
            this.BTlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BTMini = new System.Windows.Forms.PictureBox();
            this.BTCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TXTUsua
            // 
            this.TXTUsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXTUsua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTUsua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUsua.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXTUsua.Location = new System.Drawing.Point(290, 75);
            this.TXTUsua.Name = "TXTUsua";
            this.TXTUsua.Size = new System.Drawing.Size(408, 20);
            this.TXTUsua.TabIndex = 1;
            this.TXTUsua.Text = "Usuario";
            this.TXTUsua.Enter += new System.EventHandler(this.TXTUsua_Enter);
            this.TXTUsua.Leave += new System.EventHandler(this.TXTUsua_Leave);
            this.TXTUsua.MouseEnter += new System.EventHandler(this.TXTUsua_Enter);
            this.TXTUsua.MouseLeave += new System.EventHandler(this.TXTUsua_Leave);
            // 
            // TXTCon
            // 
            this.TXTCon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXTCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTCon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXTCon.Location = new System.Drawing.Point(290, 137);
            this.TXTCon.Name = "TXTCon";
            this.TXTCon.Size = new System.Drawing.Size(408, 20);
            this.TXTCon.TabIndex = 2;
            this.TXTCon.Text = "Contraseña";
            this.TXTCon.Enter += new System.EventHandler(this.TXTCon_Enter);
            this.TXTCon.Leave += new System.EventHandler(this.TXTCon_Leave);
            this.TXTCon.MouseEnter += new System.EventHandler(this.TXTCon_Enter);
            this.TXTCon.MouseLeave += new System.EventHandler(this.TXTCon_Leave);
            // 
            // BTlogin
            // 
            this.BTlogin.BackColor = System.Drawing.Color.Black;
            this.BTlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.BTlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BTlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTlogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTlogin.Location = new System.Drawing.Point(290, 210);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(408, 40);
            this.BTlogin.TabIndex = 3;
            this.BTlogin.Text = "ACCEDER";
            this.BTlogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(375, 263);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(243, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿has olvidado tu contraseña?";
            // 
            // BTMini
            // 
            this.BTMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTMini.BackgroundImage")));
            this.BTMini.Location = new System.Drawing.Point(741, 0);
            this.BTMini.Name = "BTMini";
            this.BTMini.Size = new System.Drawing.Size(15, 15);
            this.BTMini.TabIndex = 6;
            this.BTMini.TabStop = false;
            this.BTMini.Click += new System.EventHandler(this.BTMini_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTCerrar.BackgroundImage")));
            this.BTCerrar.Location = new System.Drawing.Point(762, 0);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(15, 15);
            this.BTCerrar.TabIndex = 7;
            this.BTCerrar.TabStop = false;
            this.BTCerrar.Click += new System.EventHandler(this.BTCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.BTCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTMini);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BTlogin);
            this.Controls.Add(this.TXTCon);
            this.Controls.Add(this.TXTUsua);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTUsua;
        private System.Windows.Forms.TextBox TXTCon;
        private System.Windows.Forms.Button BTlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox BTMini;
        private System.Windows.Forms.PictureBox BTCerrar;
    }
}

