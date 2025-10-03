namespace Biblioteca.Login_y_contenido
{
    partial class Contenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenido));
            this.TXTUsua1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Busqueda = new System.Windows.Forms.TextBox();
            this.BBusq = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTUsua1
            // 
            this.TXTUsua1.AutoSize = true;
            this.TXTUsua1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUsua1.Location = new System.Drawing.Point(32, 12);
            this.TXTUsua1.Name = "TXTUsua1";
            this.TXTUsua1.Size = new System.Drawing.Size(31, 18);
            this.TXTUsua1.TabIndex = 0;
            this.TXTUsua1.Text = "SB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el libro que desea buscar:";
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(16, 86);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(457, 20);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.Text = "Buscar aca";
            this.Busqueda.Enter += new System.EventHandler(this.Busqueda_Enter);
            this.Busqueda.Leave += new System.EventHandler(this.Busqueda_Leave);
            // 
            // BBusq
            // 
            this.BBusq.Location = new System.Drawing.Point(525, 86);
            this.BBusq.Name = "BBusq";
            this.BBusq.Size = new System.Drawing.Size(75, 20);
            this.BBusq.TabIndex = 3;
            this.BBusq.Text = "Buscar";
            this.BBusq.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1246, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Contenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1664, 1011);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BBusq);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTUsua1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenido";
            this.Load += new System.EventHandler(this.Contenido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TXTUsua1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Busqueda;
        private System.Windows.Forms.Button BBusq;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}