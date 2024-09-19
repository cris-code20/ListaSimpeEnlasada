using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpeEnlasada
{
    class Program
    {
       static void Main(string[] args)
        {
            SimpleLists list = new SimpleLists();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.ListarDatos();

            list.Eliminar(2);
            list.ListarDatos();
            list.Eliminar(7);
        }
    }
}
