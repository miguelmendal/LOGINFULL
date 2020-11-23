using LOGINFULL.Resources;
using Servicios.DTO;
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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar limpiar = new limpiar();
            limpiar.BorrarCampos(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioUsuarios servicio = new ServicioUsuarios();
            UsuarioDTO dto = new UsuarioDTO();

            dto.Contrasenia = txtContrasenia.Text;
            dto.Usuario = txtUsuario.Text;
            dto.Nombre = txtNombre.Text;
            dto.NombreArea = txtArea.Text;

            servicio.CreateUsuario(dto);
            this.Close(); 
        }
    }
}
