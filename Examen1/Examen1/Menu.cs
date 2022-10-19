using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal static class Menu
    {

        public static void LlamarMenu()
        {
            Vehiculos nuevoV = new Vehiculos();
            Tipo nTipos = new Tipo();
            Vendedor nVent = new Vendedor();

            int opcion = 0;
            Console.WriteLine("*************Bienvenido a la venta de carros************");

            do
            {
                Console.WriteLine("\nSeleccione una opcion: " +
                "\n\t1-Vehiculos \n\t2-Ventas \n\t3-Reportes \n\t4-Salir");

                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        do
                        {

                            Console.WriteLine("\nEsta dentro de la opcion Vehiculo\n" +
                            "\nSeleccione una opcion: " +
                            "\n\t1-Agregar \n\t2-Modificar \n\t3-Consultar \n\t4-Salir");
                            opcion = Int32.Parse(Console.ReadLine());

                            if (opcion == 1)
                            {
                                nuevoV.AgregarVehiculo();
                            }
                            if (opcion == 2)
                            {
                                nuevoV.ModificarVehiculo();
                            }
                            if (opcion == 3)
                            {
                                nuevoV.ConsultarVehiculo();
                            }


                        } while (opcion !=4);
                         
                        opcion = 0;

                        break;

                    case 2:
                        Console.WriteLine("ingrese codigo de vehiculo a comprar");
                        int code = Int32.Parse(Console.ReadLine());
                        double costo = nuevoV.Compra(code);
                        

                        Console.WriteLine("ingrese el tipo de vehiculo");
                        String tipoV = Console.ReadLine();
                        if (nTipos.Existencia(tipoV)== true)
                        {
                            Console.WriteLine("ingrese el codigo del vendedor");
                            int buscar = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(nVent.BuscarVendedor(buscar));

                            if (costo != code)
                            {
                                Console.WriteLine("ingrese cantidad de vehiculos a comprar");
                                int unidades= Int32.Parse(Console.ReadLine());
                                double total = costo * unidades;
                                Console.WriteLine($"El costo del vehiculo es de {costo} " +
                                    $"\nCantidad solicitada {unidades} \n\tMonto Total: {total}");
                            }
                            else
                            {
                                Console.WriteLine("compra interrumpida, vehiculo no encontrado");
                            }

                        }
                        else { Console.WriteLine("el tipo de vehiculo no existe"); }
                        
                        break;

                    case 3:
                        
                        nuevoV.info();
                        Console.WriteLine("\nTipos de vehiculos:"); 
                        foreach (var item in nTipos.tipos)
                        {
                            Console.WriteLine("\t"+item);
                        }
                        nVent.ListadoVendedores();
                        
                        break;
                   
                    case 4:
                        break;

                    default:
                        Console.WriteLine("la opcion marcada no se encuentra");
                        break;
                }


            } while (opcion != 4);
        }
    }
}
