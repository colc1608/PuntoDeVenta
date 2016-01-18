using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregando librerias
using dominio;

namespace interfaz
{
    public interface CategoriaInterfaz
    {
        bool registrar(Categoria categoria);
        bool actualizar(Categoria categoria);
        bool eliminar(Categoria categoria);
        List<Categoria> listarTodo();
        List<Categoria> buscar(string cadena);
    }
}
