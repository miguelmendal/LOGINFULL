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

namespace LOGINFULL.View
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ServicioUsuarios servicio = new ServicioUsuarios();
            var usuarios = servicio.GetUsuarioDTOs();

            dgUsuarios.DataSource = usuarios;
            dgUsuarios.Refresh();
        }

        private void usuarioDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario vtnadd = new AgregarUsuario();
            vtnadd.FormClosed += Vtnadd_FormClosed;
            vtnadd.ShowDialog();
        }

        private void Vtnadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServicioUsuarios servicio = new ServicioUsuarios();
            var usuarios = servicio.GetUsuarioDTOs();

            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = usuarios;
            dgUsuarios.Refresh();
        }
    }
}
