namespace MainMenu
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTOcultar = new FontAwesome.Sharp.IconButton();
            this.BTCatLib = new FontAwesome.Sharp.IconButton();
            this.BTCalen = new FontAwesome.Sharp.IconButton();
            this.BTHist = new FontAwesome.Sharp.IconButton();
            this.BTConfig = new FontAwesome.Sharp.IconButton();
            this.BTNoti = new FontAwesome.Sharp.IconButton();
            this.BTComuni = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BTComuni);
            this.panel1.Controls.Add(this.BTNoti);
            this.panel1.Controls.Add(this.BTConfig);
            this.panel1.Controls.Add(this.BTHist);
            this.panel1.Controls.Add(this.BTCalen);
            this.panel1.Controls.Add(this.BTCatLib);
            this.panel1.Controls.Add(this.BTOcultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 681);
            this.panel1.TabIndex = 0;
            // 
            // BTOcultar
            // 
            this.BTOcultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTOcultar.FlatAppearance.BorderSize = 0;
            this.BTOcultar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.BTOcultar.IconColor = System.Drawing.Color.Black;
            this.BTOcultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTOcultar.IconSize = 30;
            this.BTOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTOcultar.Location = new System.Drawing.Point(0, 0);
            this.BTOcultar.Name = "BTOcultar";
            this.BTOcultar.Size = new System.Drawing.Size(150, 50);
            this.BTOcultar.TabIndex = 0;
            this.BTOcultar.UseVisualStyleBackColor = true;
            // 
            // BTCatLib
            // 
            this.BTCatLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTCatLib.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCatLib.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BTCatLib.IconColor = System.Drawing.Color.Black;
            this.BTCatLib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTCatLib.IconSize = 30;
            this.BTCatLib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTCatLib.Location = new System.Drawing.Point(0, 50);
            this.BTCatLib.Name = "BTCatLib";
            this.BTCatLib.Size = new System.Drawing.Size(150, 50);
            this.BTCatLib.TabIndex = 1;
            this.BTCatLib.Text = "Catálogo de libros";
            this.BTCatLib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCatLib.UseVisualStyleBackColor = true;
            // 
            // BTCalen
            // 
            this.BTCalen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTCalen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCalen.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.BTCalen.IconColor = System.Drawing.Color.Black;
            this.BTCalen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTCalen.IconSize = 30;
            this.BTCalen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTCalen.Location = new System.Drawing.Point(0, 100);
            this.BTCalen.Name = "BTCalen";
            this.BTCalen.Size = new System.Drawing.Size(150, 50);
            this.BTCalen.TabIndex = 2;
            this.BTCalen.Text = "Calendario";
            this.BTCalen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCalen.UseVisualStyleBackColor = true;
            // 
            // BTHist
            // 
            this.BTHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTHist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTHist.IconChar = FontAwesome.Sharp.IconChar.History;
            this.BTHist.IconColor = System.Drawing.Color.Black;
            this.BTHist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTHist.IconSize = 30;
            this.BTHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTHist.Location = new System.Drawing.Point(0, 150);
            this.BTHist.Name = "BTHist";
            this.BTHist.Size = new System.Drawing.Size(150, 50);
            this.BTHist.TabIndex = 3;
            this.BTHist.Text = "Historial";
            this.BTHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTHist.UseVisualStyleBackColor = true;
            // 
            // BTConfig
            // 
            this.BTConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTConfig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConfig.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.BTConfig.IconColor = System.Drawing.Color.Black;
            this.BTConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTConfig.IconSize = 30;
            this.BTConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTConfig.Location = new System.Drawing.Point(0, 200);
            this.BTConfig.Name = "BTConfig";
            this.BTConfig.Size = new System.Drawing.Size(150, 50);
            this.BTConfig.TabIndex = 4;
            this.BTConfig.Text = "Configuración";
            this.BTConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTConfig.UseVisualStyleBackColor = true;
            // 
            // BTNoti
            // 
            this.BTNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNoti.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNoti.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.BTNoti.IconColor = System.Drawing.Color.Black;
            this.BTNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNoti.IconSize = 30;
            this.BTNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNoti.Location = new System.Drawing.Point(0, 250);
            this.BTNoti.Name = "BTNoti";
            this.BTNoti.Size = new System.Drawing.Size(150, 50);
            this.BTNoti.TabIndex = 5;
            this.BTNoti.Text = "Notificaciones";
            this.BTNoti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNoti.UseVisualStyleBackColor = true;
            // 
            // BTComuni
            // 
            this.BTComuni.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTComuni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTComuni.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.BTComuni.IconColor = System.Drawing.Color.Black;
            this.BTComuni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTComuni.IconSize = 30;
            this.BTComuni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTComuni.Location = new System.Drawing.Point(0, 300);
            this.BTComuni.Name = "BTComuni";
            this.BTComuni.Size = new System.Drawing.Size(150, 50);
            this.BTComuni.TabIndex = 6;
            this.BTComuni.Text = "Contacto";
            this.BTComuni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTComuni.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca UTEC";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BTCatLib;
        private FontAwesome.Sharp.IconButton BTOcultar;
        private FontAwesome.Sharp.IconButton BTNoti;
        private FontAwesome.Sharp.IconButton BTConfig;
        private FontAwesome.Sharp.IconButton BTHist;
        private FontAwesome.Sharp.IconButton BTCalen;
        private FontAwesome.Sharp.IconButton BTComuni;
    }
}

