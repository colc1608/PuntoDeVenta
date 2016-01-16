using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar
using dominio;
using System.Data;



namespace interfaz
{
    public interface UsuarioInterfaz
    {
        Usuario iniciarSesion(Usuario usuario);
    }
}
