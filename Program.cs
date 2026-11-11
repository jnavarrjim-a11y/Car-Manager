int opcion = 0;
int ventas = 0;
double dineroCaja = 0;
double ventaMayor = 0;
string clienteMayor = "";

do
{

Console.WriteLine("Elige una opcion: ");
 if (!int.TryParse(Console.ReadLine(), out opcion))
 {
    opcion = 0;
 }

switch (opcion)
{
    case 1:
        Console.WriteLine("Has elegido vender un vehiculo");
        
        Console.WriteLine("Introduce el nombre del cliente:");
        string nombreCliente = Console.ReadLine().Trim();

        while (nombreCliente == "")
        {
            Console.WriteLine("El nombre no puede estar vacio. Introducelo otra vez:");
            nombreCliente = Console.ReadLine().Trim();
        }

        Console.WriteLine("---VEHICULOS DISPONIBLES---");
        Console.WriteLine("1. Coche de segunda mano - 8000 euros");
        Console.WriteLine("2. Coche seminuevo - 15000 euros");
        Console.WriteLine("3. Coche nuevo - 22000 euros");

        int tipoVehiculo = 0;
        double precio = 0;

        Console.WriteLine("Selecciona un vehiculo");
        int.TryParse(Console.ReadLine(), out tipoVehiculo);

        while (tipoVehiculo < 1 || tipoVehiculo > 3)
        {
            Console.WriteLine("Vehiculo incoreecto. Elige entre 1, 2 o 3:");
            int.TryParse(Console.ReadLine(), out tipoVehiculo);
        }    

        switch (tipoVehiculo)
        {
            case 1:
                precio = 8000;
                break;
            
            case 2:
                precio = 15000;
                break;

            case 3 :
                precio = 22000;
                break;
            default:
                Console.WriteLine("Vehiculo Incorrecto");
                break;
        }

        Console.WriteLine("Precio del Vehiculo: " + precio + " euros");

        Console.WriteLine("---EXTRAS DISPONIBLES---");
        Console.WriteLine("1. Garantia ampliada - 500 euros");
        Console.WriteLine("2. Limpieza Premium - 100 euros");
        Console.WriteLine("3. Matriculacion - 300 euros");
        Console.WriteLine("0. No añadir extra");

        int extra = -1;
        double precioExtras = 0;

        bool garantia = false;
        bool limpieza = false;
        bool matriculacion = false;

        while (extra != 0)
        {
            Console.WriteLine("Elige un extra (0 para terminar):");
            int.TryParse(Console.ReadLine(), out extra);

            if (extra ==1)
            {
                if (garantia == false)
                {
                    precioExtras = precioExtras + 500;
                    garantia = true;
                    Console.WriteLine("Garantia Añadida");
                }
                else 
                {
                    Console.WriteLine("Ya has añadido la garantia");
                }
            }

            if (extra == 2)
            {
                if (limpieza == false)
                {
                    precioExtras = precioExtras + 100;
                    limpieza = true;
                    Console.WriteLine("Limpieza premium añadida");
                }
                else
                {
                    Console.WriteLine("Ya has añadido la limpieza");
                }
            }

            if (extra == 3)
            {
                if (matriculacion == false)
                {
                    precioExtras = precioExtras + 300;
                    matriculacion = true;
                    Console.WriteLine("Matriculacion Añadida");
                }
                else 
                {
                    Console.WriteLine("Ya has añadido la matriculacion");
                }
            }
            if (extra < 0 || extra > 3)
                {
                    Console.WriteLine("Extra incorrecto. Elige entre 0 y 3.");
                }
        }

        double subtotal = precio + precioExtras;

        Console.WriteLine("Precio del coche: " + precio + " euros");
        Console.WriteLine("Precio de los extras: " + precioExtras + " euros");
        Console.WriteLine("Subtotal: " + subtotal + " euros");

        Console.WriteLine("--- ENTREGA DEL VEHICULO ---");
        Console.WriteLine("1. Recoger en el concesionario - Gratis");
        Console.WriteLine("2. Entrega a domicilo - 200 euros");

        int entrega = 0;

        Console.WriteLine("Elige una opcion de entrega:");
        int.TryParse(Console.ReadLine(), out entrega);

        while (entrega != 1 && entrega != 2)
        {
            Console.WriteLine("Opcion incorrecta. Elige 1 o 2:");
            int.TryParse(Console.ReadLine(), out entrega);
        }

        if (entrega == 1)
        {
            Console.WriteLine("Recogida en el concesionario");
        }
        else
        {
            Console.WriteLine("Introduce la direccion de entrega:");
            string direccion = Console.ReadLine();

            subtotal = subtotal + 200;

            Console.WriteLine("Entrega a domicilio seleccionada");
        }

        Console.WriteLine("Subtotal con entrga: " + subtotal + " euros");

        double descuento = 0;

        if (subtotal > 20000)
        {
            descuento = subtotal * 0.05;
            Console.WriteLine("Se aplica el descunto del 5%");
        }
        else 
        {
            Console.WriteLine("No se aplica el descuento");
        }
        double total = subtotal - descuento;

        Console.WriteLine("Descuento: " + descuento + " euros");
        Console.WriteLine("TOTAL A PAGAR: " + total + " euros");

        Console.WriteLine("--- PAGO DEL VEHICULO ---");
        Console.WriteLine("Introduce la cantidad que paga el cliente:");

        double pago = 0;
        double.TryParse(Console.ReadLine(), out pago);

        while (pago < total)
        {
            Console.WriteLine("Cantidad Insuficiente.");
            Console.WriteLine("Introduce una cantidad igual o superior al total:");
            double.TryParse(Console.ReadLine(), out pago);
        }

        double cambio = pago - total;

        Console.WriteLine("Pago recibido: " + pago + " euros");
        Console.WriteLine("Cambio a devolver: " + cambio + " euros");
        Console.WriteLine("Venta realizada correctamente");

        Console.WriteLine("============================");
        Console.WriteLine("     TICKET CAR MANAGER");
        Console.WriteLine("============================");

        Console.WriteLine("Cliente: " + nombreCliente);
        Console.WriteLine("Precio del vehiculo: " + precio + " euros");
        Console.WriteLine("Extras: " + precioExtras + " euros");
        Console.WriteLine("Subtotal con entrega: " + subtotal + " euros");
        Console.WriteLine("Descuento: " + descuento + " euros");
        Console.WriteLine("Total: " + total + " euros");
        Console.WriteLine("Pagado: " + pago + " euros");
        Console.WriteLine("Cambio: " + cambio + " euros");

        Console.WriteLine("============================");
        Console.WriteLine("   Gracias por su compra");
        Console.WriteLine("============================");
        
        ventas = ventas + 1;
        dineroCaja = dineroCaja + total;

        if (total > ventaMayor)
        {
            ventaMayor = total;
            clienteMayor = nombreCliente;
        }

        break;

    case 2:
        Console.WriteLine("Has elegido consultar caja");

        Console.WriteLine("Ventas realizadas: " + ventas);
        Console.WriteLine("Dinero total en la caja: " + dineroCaja + " euros");

        if (ventas > 0)
        {
            Console.WriteLine("Media por venta: " + (dineroCaja / ventas) + " euros");
            Console.WriteLine("Ventas mas cara: " + ventaMayor + " euros");
            Console.WriteLine("Cliente de la venta mas cara: " + clienteMayor);
        }
        else
        {
            Console.WriteLine("Todavia no se han realizado ventas");
        }

        break;

    case 3:
        Console.WriteLine("Gracias por visitar CAR MANAGER");
        break;

    default:
        Console.WriteLine("Opcion Incorrecta");
        break;
}

} while (opcion !=3);