using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelBelgrano.FormarParejas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Los campos email y password son obligatorios","Error");
                return;
            }

            if (Validar(email, password))
            {
                //llamamos al formulario del juego
                var frm = new Form1(email);
                this.Visible = false;                
                frm.ShowDialog();
                this.Visible = true;
            }
            else {
                MessageBox.Show("Usuario o contraseña no válidos", "Error");
                return;
            }

        }

        private bool Validar(string email, string password)
        {
            return true;
        }
    }
}
