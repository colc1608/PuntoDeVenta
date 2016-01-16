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
        bool registrarArea(Area area);
        bool actualizarArea(Area area);
        bool eliminarArea(Area area);
        List<Area> listaDeAreas();
        List<Area> buscarArea(string cadena);
    }
}
