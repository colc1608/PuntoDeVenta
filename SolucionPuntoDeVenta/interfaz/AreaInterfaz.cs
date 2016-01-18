using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregando librerias
using dominio;

namespace interfaz
{
    public interface AreaInterfaz
    {
        bool registrar(Area area);
        bool actualizar(Area area);
        bool eliminar(Area area);
        List<Area> listarTodo();
        List<Area> buscar(string cadena);
    }
}
