using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialConsola
{
    class ProgramConsola
    {
        static ClienteService clienteService = new ClienteService();
        static FacturaService facturaService = new FacturaService();
        static void Main(string[] args)
        {

            while (true)
            {
                MostrarMenu();
                int opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        CrearCliente();
                        break;
                    case 2:
                        LeerCliente();
                        break;
                    case 3:
                        ActualizarCliente();
                        break;
                    case 4:
                        EliminarCliente();
                        break;
                    case 5:
                        CrearFactura();
                        break;
                    case 6:
                        LeerFactura();
                        break;
                    case 7:
                        ActualizarFactura();
                        break;
                    case 8:
                        EliminarFactura();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Opcion no valida. Elija una que sea correcta");
                        break;
                }
            }
        }


        static void MostrarMenu()
        {
            Console.WriteLine("------- Menu: ------- ");
            Console.WriteLine("1. Crear Cliente");
            Console.WriteLine("2. Leer Cliente");
            Console.WriteLine("3. Actualizar Cliente");
            Console.WriteLine("4. Eliminar Cliente");
            Console.WriteLine("5. Crear Factura");
            Console.WriteLine("6. Leer Factura");
            Console.WriteLine("7. Actualizar Factura");
            Console.WriteLine("8. Eliminar Factura");
            Console.WriteLine("9. Salir");
        }
        static int LeerOpcion()
        {
            Console.Write("Seleccione una opcion:");
            return int.Parse(Console.ReadLine());
        }


        static void CrearCliente()
        {
            Console.WriteLine("Ingrese los datos del cliente: ");
            Clientes nuevoCliente = ObtenerDatosClienteDesdeConsola();
            clienteService.CrearCliente(nuevoCliente);
            Console.WriteLine("El cliente ha sido creado");
        }

        static void LeerCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente a consultar: ");
            int id = int.Parse(Console.ReadLine());
            Cliente cliente = clienteService.ObtenerClientePorId(id);
            if (cliente != null)
            {
                Console.WriteLine("Cliente encontrado: ");
                Console.WriteLine(cliente);
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }

        static void ActualizarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente a actualizar: ");
            int id = int.Parse(Console.ReadLine());
            Cliente cliente = clienteService.ObtenerClientePorId(id);
            if (cliente != null)
            {
                Console.WriteLine("Ingrese los nuevos datos del cliente: ");
                Cliente nuevosDatosCliente = ObtenerDatosClienteDesdeConsola();
                nuevosDatosCliente.Id = id;
                clienteService.ActualizarCliente(nuevosDatosCliente);
                Console.WriteLine("Cliente actualizado");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }

        static void EliminarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente a eliminar: ");
            int id = int.Parse(Console.ReadLine());
            bool eliminado = clienteService.EliminarCliente(id);
            if (eliminado)
            {
                Console.WriteLine("Cliente eliminado");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }

        static Clientes ObtenerDatosClienteDesdeConsola()
        {
            Clientes cliente = new Clientes();
            Console.Write("Nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Apellido:");
            cliente.Apellido = Console.ReadLine();
            return cliente;
        }

        static void CrearFactura()
        {
            Console.WriteLine("Ingrese los datos de la factura: ");
            Factura nuevaFactura = ObtenerDatosFacturaDesdeConsola();
            facturaService.CrearFactura(nuevaFactura);
            Console.WriteLine("Factura creada");
        }

        static void LeerFactura()
        {
            Console.WriteLine("Ingrese el ID de la factura: ");
            int id = int.Parse(Console.ReadLine());
            Factura factura = facturaService.ObtenerFacturaPorId(id);
            if (factura != null)
            {
                Console.WriteLine("Factura encontrada ");
                Console.WriteLine(factura);
            }
            else
            {
                Console.WriteLine("Factura no encontrada");
            }
        }

        static void ActualizarFactura()
        {
            Console.WriteLine("Ingrese el ID de la factura a actualizar: ");
            int id = int.Parse(Console.ReadLine());
            Factura factura = facturaService.ObtenerFacturaPorId(id);
            if (factura != null)
            {
                Console.WriteLine("Ingrese los nuevos datos de la factura: ");
                Factura nuevosDatosFactura = ObtenerDatosFacturaDesdeConsola();
                nuevosDatosFactura.Id = id;
                facturaService.ActualizarFactura(nuevosDatosFact
