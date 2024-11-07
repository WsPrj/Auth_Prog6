using ABM_Usuario.Models;

namespace ABM_Usuario.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>()
            {
                new Usuario{ Nombre = "Gabi", Correo ="administrador@superior.com", Clave = "123" , Roles = new string[]{"Administrador" } },
                new Usuario{ Nombre = "Dani", Correo ="supervisor@superior.com", Clave = "123" , Roles = new string[]{"Supervisor" } },
                new Usuario{ Nombre = "Werni", Correo ="empleado@superior.com", Clave = "123" , Roles = new string[]{"Empleado" } },
                new Usuario{ Nombre = "Nico", Correo ="superempleado@superior.com", Clave = "123" , Roles = new string[]{"Supervisor","Empleado" } }
            };
        }

        public Usuario ValidarUsuario(string _Correo, string _Clave)
        {
            return ListaUsuario().Where(item => item.Correo == _Correo && item.Clave == _Clave).FirstOrDefault();
        }

    }
}
