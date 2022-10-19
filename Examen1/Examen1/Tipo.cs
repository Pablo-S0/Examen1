using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Tipo
    {
       public List<String> tipos = new List<String>() { "Motocicleta", "Automovil", "Dron" };
        public virtual void TipoVehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehiculos");
            
        }

        public void ListadoVehiculos()
        {

        }

        public Boolean Existencia(String valor)
        {
            Boolean existe = tipos.Contains(valor);

            return existe;
 
        }
        

    }
}
