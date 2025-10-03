using Biblioteca.Login_y_contenido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TXTUsua_Enter(object sender, EventArgs e)
        {
            if (TXTUsua.Text == "Usuario")
            {
                TXTUsua.Text = "";
                TXTUsua.ForeColor = Color.Black;
            }
        }

        private void TXTUsua_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTUsua.Text))
            {
                TXTUsua.Text = "Usuario";
                TXTUsua.ForeColor = Color.Gray;
            }            
        }

        private void TXTContra_Enter(object sender, EventArgs e)
        {
            if (TXTContra.Text == "Contraseña")
            {
                TXTContra.Text = "";
                TXTContra.ForeColor = Color.Black;
                TXTContra.UseSystemPasswordChar = true;
            }
        }

        private void TXTContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTContra.Text))
            {
                TXTContra.Text = "Contraseña";
                TXTContra.ForeColor = Color.Gray;
                TXTContra.UseSystemPasswordChar= false;
            }
        }

        private void LoginBotton_Click(object sender, EventArgs e)
        {
            Contenido co = new Contenido();
            co.Usuario = TXTUsua.Text;
            co.ShowDialog();
        }

        
    }
}
