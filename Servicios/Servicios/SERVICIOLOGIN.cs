using Servicios.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Servicios
{
    public class SERVICIOLOGIN
    {
        public bool ValidarUsuario(string usuario, string contrasenia)
        {
            try
            {
                using (LOGINEntities bd = new LOGINEntities())
                {
                    var result = bd.USUARIOS.FirstOrDefault(p => p.USUARIO == usuario & p.CONTRASENIA == contrasenia);

                    if(result!=null)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;

        }
    }
}
