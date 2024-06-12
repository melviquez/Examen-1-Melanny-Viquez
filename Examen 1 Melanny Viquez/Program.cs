using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Melanny_Viquez
{
    //MI CLASE
    internal class Clientes
    {
        // ARRAYS PARA ALMACENAR INFORMACION
        static string[] nombres = new string[1000000];
        static int[] indice = new int[1000000]; //Se decidio agregar el ID del cliente para mas facilidad en el manejo de datos ademas de evitar confusiones con nombres iguales
        static string[] direcciones = new string[1000000];
        static string[] telefonos = new string[1000000];
        static string[] correosElectronicos = new string[1000000];
        static int contadorClientes = 0;
        
        // METODOS
        public static void Agregar()
        {
            Console.WriteLine("Digite el ID del cliente:");
            indice[contadorClientes] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el nombre del cliente:");
            nombres[contadorClientes] = Console.ReadLine();
            Console.WriteLine("Digite la direccion del cliente:");
            direcciones[contadorClientes] = Console.ReadLine();
            Console.WriteLine("Digite el telefono del cliente:");
            telefonos[contadorClientes] = Console.ReadLine();
            Console.WriteLine("Digite el email del cliente:");
            correosElectronicos[contadorClientes] = Console.ReadLine();
            contadorClientes++; //Se van sumando los clientes ya que los arrays tienen un limite
            Console.WriteLine("Cliente agregado exitosamente.");
        }

        public static void Actualizar()
        {
            Console.WriteLine("Ingrese el ID del cliente a actualizar:");
            int idClienteActualizar = int.Parse(Console.ReadLine());

            // Buscar el id en indice de array
            int indiceActualizar = Array.IndexOf(indice, idClienteActualizar); //(info array que queremos, numero exacto)

            if (indiceActualizar != -1) //contador empieza a contar en 0
            {
                Console.WriteLine("Ingrese el nuevo nombre del cliente:");
                nombres[indiceActualizar] = Console.ReadLine();

                Console.WriteLine("Ingrese la nueva dirección del cliente:");
                direcciones[indiceActualizar] = Console.ReadLine();

                Console.WriteLine("Ingrese el nuevo teléfono del cliente:");
                telefonos[indiceActualizar] = Console.ReadLine();

                Console.WriteLine("Ingrese el nuevo correo electrónico del cliente:");
                correosElectronicos[indiceActualizar] = Console.ReadLine();

                Console.WriteLine("Cliente actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public static void Borrar()
        {
            Console.WriteLine("Ingrese el ID del cliente a borrar:");
            int idClienteBorrar = int.Parse(Console.ReadLine());

            int idIndiceBorrar = Array.IndexOf(indice, idClienteBorrar);

            if (idIndiceBorrar != -1)
            {
                if (contadorClientes == 1)
                {
                    // 1 cliente
                    nombres[0] = null;
                    direcciones[0] = null;
                    telefonos[0] = null;
                    correosElectronicos[0] = null;
                    indice[0] = -1;
                    contadorClientes = 0;
                    Console.WriteLine("Cliente borrado exitosamente.");
                }
                else //cuando hay mas clientes
                {
                    for (int i = idIndiceBorrar; i < contadorClientes - 1; i++)
                    {
                        nombres[i] = nombres[i + 1];
                        direcciones[i] = direcciones[i + 1];
                        telefonos[i] = telefonos[i + 1];
                        correosElectronicos[i] = correosElectronicos[i + 1];
                        indice[i] = indice[i + 1]; // Actualizar los ID 
                    }
                    indice[contadorClientes - 1] = -1; 
                    contadorClientes--;
                    Console.WriteLine("Cliente borrado exitosamente.");
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public static void Consultar()
        {
            Console.WriteLine("Ingrese el ID del cliente a consultar:");
            int idClienteConsultar = int.Parse(Console.ReadLine());

            int idIndiceConsultar = Array.IndexOf(indice, idClienteConsultar);

            if (idIndiceConsultar != -1)
            {
                Console.WriteLine($"ID: {indice[idIndiceConsultar]}");
                Console.WriteLine($"Nombre: {nombres[idIndiceConsultar]}");
                Console.WriteLine($"Dirección: {direcciones[idIndiceConsultar]}");
                Console.WriteLine($"Teléfono: {telefonos[idIndiceConsultar]}");
                Console.WriteLine($"Correo electrónico: {correosElectronicos[idIndiceConsultar]}");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Escriba una opcion");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Actualizar Cliente");
                Console.WriteLine("3. Borrar Cliente");
                Console.WriteLine("4. Consultar Cliente");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)

                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Actualizar();
                        break;
                    case 3:
                        Borrar();
                        break;
                    case 4:
                        Consultar();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;

                }

            }
            while (opcion != 5);


            {

                Console.WriteLine("Presione enter para cerrar la consola");
                Console.Read();

            }



        }
    }
}
