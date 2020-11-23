using Servicios.DTO;
using Servicios.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class ServicioUsuarios
    {
        /// <summary>
        /// Este metodo me devuelve todos los usuario de la base de datos
        /// </summary>
        /// <returns>Una lista de usuariosDTO</returns>
        public List<UsuarioDTO> GetUsuarioDTOs()
        {
            List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();
            try
            {
               
                using (LOGINEntities entities = new LOGINEntities())
                {
                    var usuarioEntity = entities.USUARIOS.ToList();

                    foreach (var item in usuarioEntity)
                    {
                        UsuarioDTO dto = new UsuarioDTO();
                        dto.Contrasenia = item.CONTRASENIA;
                        dto.Id = item.ID_USUARIO;
                        dto.Nombre = item.NOMBRE;
                        dto.NombreArea = item.NOMBRE_AREA;
                        dto.Usuario = item.USUARIO;

                        usuariosDTO.Add(dto);
                    }
                }
            }
            catch (Exception)
            {

                throw;
                
            }

            return usuariosDTO;
        }

        public void CreateUsuario(UsuarioDTO usuario)
        {
            try
            {

                using (LOGINEntities entities = new LOGINEntities())
                {

                    USUARIOS u = new USUARIOS();
                    u.USUARIO = usuario.Usuario;
                    u.NOMBRE = usuario.Nombre;
                    u.NOMBRE_AREA = usuario.NombreArea;
                    u.CONTRASENIA = usuario.Contrasenia;

                    entities.USUARIOS.Add(u);
                    entities.SaveChanges();
                
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
