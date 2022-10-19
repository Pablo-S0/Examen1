using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vehiculos
    {
        
        protected int[] codigos = new int[5];
        protected String[] marcas = new String[5];
        protected double[] costos = new double[5];
        protected String[] modelos = new String[5];
        int i = 0;
        public Vehiculos()
        {

        }

        public Vehiculos(int[] codigos, string[] marcas, double[] costos, string[] modelos)
        {
            this.codigos = codigos;
            this.marcas = marcas;
            this.costos = costos;
            this.modelos = modelos;
        }

        public void AgregarVehiculo()
        {
            if (i<=4)
            {
                if (codigos[i] == 0)
                {
                    Console.WriteLine("Ingrese codigo del auto (solo numerico no decimal)");
                    codigos[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese marca del vehiculo");
                    marcas[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese costo del vehiculo");
                    costos[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese modelo del vehiculo");
                    modelos[i] = Console.ReadLine();

                    i++;
                }
            }
            
            if (i > 4)
            {
                Console.WriteLine("------------no puede agregar mas--------------");
            }

        }
        public void ModificarVehiculo()
        {
            int buscando = 0;
            int buscar;
            Console.WriteLine("ingresar codigo del vehiculo a modificar");
            buscar = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < codigos.Length; i++)
            {
                if (buscar == codigos[i])
                {
                    Console.WriteLine("Ingrese codigo del auto (solo numerico no decimal)");
                    codigos[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese marca del vehiculo");
                    marcas[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese costo del vehiculo");
                    costos[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese modelo del vehiculo");
                    modelos[i] = Console.ReadLine();
                }
                else
                {
                    buscando++;
                }
            }
            if (buscando > 4)
            {
                Console.WriteLine("El vehiculo a buscar no se encuentra registrado");
            }
        }

        public void ConsultarVehiculo()
        {
            int buscando = 0;
            int buscar;
            Console.WriteLine("ingresar codigo del vehiculo a consultar");
            buscar = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < codigos.Length; i++)
            {
                if (buscar == codigos[i])
                {
                    Console.WriteLine("Vehiculo encontrado: " +
                        $"\n\tcodigo: {codigos[i]}\n\tmarca: {marcas[i]}" +
                        $"\n\tcosto: {costos[i]}\n\tmodelo: {modelos[i]}");
                }
                else
                {
                    buscando++;
                }
            }
            if (buscando > 4)
            {
                Console.WriteLine("El vehiculo a buscar no se encuentra registrado");
            }
        }

        public double Compra(int valor)
        {
            double costo = 0;

            if (codigos.Contains(valor))
            {
                Console.WriteLine("vehiculo encontrado");
                int index = Array.IndexOf(codigos, valor);
                costo = costos[index];
            }
            else
            {
                Console.WriteLine("no se encuentra el vehiculo");
            }

            return costo;
        }

        public void info()
        {
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i]!= 0)
                {
                    Console.WriteLine($"Vehiculo {i + 1}" +
                        $"\n\tcodigo: {codigos[i]}\n\tmarca: {marcas[i]}" +
                        $"\n\tcosto: {costos[i]}\n\tmodelo: {modelos[i]}\n");
                }
               
            }
                
        }
    }
}

