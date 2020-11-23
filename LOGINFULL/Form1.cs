using LOGINFULL.View;
using Servicios.Modelo;
using Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINFULL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_INGRESAR_Click(object sender, EventArgs e)
        {
            var usuario = txtusuario.Text;
            var contrasenia = txtpassword.Text;

            if (usuario == string.Empty)
            {
                MessageBox.Show("El nombre de usuario es requerido", "FALTA NOMBRE", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                txtusuario.Focus();
                return;

            }

            if (contrasenia == string.Empty)
            {
                MessageBox.Show("La contraseña es requerida", "FALTA CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;

            }


            SERVICIOLOGIN servicio = new SERVICIOLOGIN();

            var resul = servicio.ValidarUsuario(usuario, contrasenia);

            if (resul)
            {
                MessageBox.Show("READY PLAYER ONE", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Usuarios usuarios = new Usuarios();
                usuarios.Show();
            
                
                
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "INTENTA NUEVAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
