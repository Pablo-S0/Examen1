using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedor
    {
       public Dictionary<int, string> DVendedores = new Dictionary<int, string>();
        
        public Vendedor()
        {
            DVendedores.Add(1, "Pedro");
            DVendedores.Add(2, "Jose");
        }

        public void ListadoVendedores()
        {
            Console.WriteLine("\nVendedores registrados: ");
            foreach (KeyValuePair<int, String> item in DVendedores)
            {
                Console.WriteLine($"\tCodigo: {item.Key}, Vendedor: {item.Value} ");
            }
        }

       public String BuscarVendedor(int codigo)
        {

            String mensaje = "no existe";
            if (DVendedores.ContainsKey(codigo))
            {
                mensaje = "Nombre del vendedor buscado: "+DVendedores[codigo].ToString();

                return mensaje;

            }

            return $"El vendedor {mensaje}";
        }
       
}
}
