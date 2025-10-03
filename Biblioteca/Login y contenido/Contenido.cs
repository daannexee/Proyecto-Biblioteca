using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Login_y_contenido
{
    public partial class Contenido : Form
    {
        public Contenido()
        {
            InitializeComponent();
        }
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                TXTUsua1.Text = $"Bienvenido: {usuario} a la biblioteca UTEC";
            }
        }

        private void Busqueda_Enter(object sender, EventArgs e)
        {
            if (Busqueda.Text == "Buscar aca")
            {
                Busqueda.Text = "";
                Busqueda.ForeColor = Color.Black;                
            }
        }

        private void Busqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Busqueda.Text))
            {
                Busqueda.Text = "Buscar aca";
                Busqueda.ForeColor = Color.Gray;                
            }
        }

        private void Contenido_Load(object sender, EventArgs e)
        {
            // Centra horizontalmente
            TXTUsua1.Left = (this.ClientSize.Width - TXTUsua1.Width) / 2;

            // Lo coloca cerca del borde superior (ajusta el valor si quieres más espacio)
            TXTUsua1.Top = 10;

        }
    }
}
