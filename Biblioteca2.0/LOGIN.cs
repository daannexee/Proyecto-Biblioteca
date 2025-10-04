using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Biblioteca2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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

        private void TXTCon_Enter(object sender, EventArgs e)
        {
            if (TXTCon.Text == "Contraseña")
            {
                TXTCon.Text = "";
                TXTCon.ForeColor = Color.Black;
                TXTCon.UseSystemPasswordChar = true;
            }
        }

        private void TXTCon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTCon.Text))
            {
                TXTCon.Text = "Contraseña";
                TXTCon.ForeColor = Color.Gray;
                TXTCon.UseSystemPasswordChar = false;
            }
        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
    }
}
