
using System.Text;

namespace Listas_Trabajo_v2
{
    internal class Program
    {

        static List<string> Productos = new List<string>();

        static List<double> Precios = new List<double>();

        static void Main(string[] args)
        {

            int opciones;

            do
            {
                Console.WriteLine("\n  --INVENTARIO--  ");
                Console.WriteLine("1. Para agregar un producto");
                Console.WriteLine("2. Para mostrar todos los productos");
                Console.WriteLine("3. Para buscar un producto");
                Console.WriteLine("4. Para modificar un producto");
                Console.WriteLine("5. Para eliminar un producto");
                Console.WriteLine("6. Para mostrar estadísticas");
                Console.WriteLine("7. Para ordenar la lista");
                Console.WriteLine("0. Para salir");

                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 0: Console.WriteLine("salites papu"); break;
                    case 1: AgregarProducto(); break;
                    case 2: VerProductos(); break;
                    case 3: IndiceProductos(); break;
                    case 4: ModificarProductos(); break;
                    case 5: EliminacionProductos(); break;
                    case 6: VerEstadisticas(); break;
                    case 7: ListaOrdenada(); break;
                    default: Console.WriteLine("Opcion no valida MONGOLO"); break;
                }

            } while (opciones != 0); 


            Console.ReadKey();
        }



        // primer caso
        static void AgregarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            String nombre = Console.ReadLine();
            double precio = LeerPrecio("El precio es de: ");

            Productos.Add(nombre);
            Precios.Add(precio);
            Console.WriteLine("El producto ha sido agregado.");
        }


        // segundo caso
        static void VerProductos()
        {
            if (ListaVacia()) return;

            for (int i = 0; i < Productos.Count; i++) { 
            
                Console.WriteLine($"{i + 1}. {Productos[i]} - ${Precios[i]} ");
            }
        }


        // tercer caso
        static void IndiceProductos()
        {
            if (ListaVacia()) return;

            Console.WriteLine("Producto buscado: ");
            int Indice = BuscarIndice(Console.ReadLine());

            if (Indice == -1) 
            { 
               Console.WriteLine("Producto no encontrado");
            } 
            else
            {
                Console.WriteLine($"{Productos[Indice]} - ${Precios[Indice]} ");
            }
        }


        // Cuarto caso
        static void ModificarProductos()
        {
            if (ListaVacia()) return;

            Console.Write("Producto que modificaras: ");
            int Indice = BuscarIndice(Console.ReadLine());

            if (Indice == -1)
            { 
              Console.WriteLine("Producto no encontrado");
                return;
            }

            Console.Write("Nuevo producto: ");
            Productos[Indice] = Console.ReadLine();
            Precios[Indice] = LeerPrecio("Nuevo precio: ");

            Console.WriteLine("Modificacion exitosa");
        }


        // Quinto caso 
        static void EliminacionProductos()
        {
            if (ListaVacia()) return;

            Console.Write("Producto que se borrara: ");
            int Indice = BuscarIndice(Console.ReadLine());

            Productos.RemoveAt(Indice);
            Precios.RemoveAt(Indice);

            Console.WriteLine("Eliminacion Exitosa");
        }


        // Sexto caso
        static void VerEstadisticas()
        {
            if (ListaVacia()) return;

            double mayor = Precios[0];
            double menor = Precios[0];
            double suma = 0;

            for (int i = 0; i <  Precios.Count; i++)
            {
                suma += Precios[i];
                if (Precios[i] > mayor) mayor = Precios[i];
                if (Precios[i] < menor) menor = Precios[i];
            }

            Console.WriteLine($"Total de productos {Productos.Count}");
            Console.WriteLine($"Mayor: {mayor}");
            Console.WriteLine($"Menor: {menor}");
            Console.WriteLine($"Promedio: {suma / Precios.Count}");
        }


        // Septimo caso
        static void ListaOrdenada()
        {
            if (ListaVacia()) return;


            List<double> preciosOrdenados = new List<double>(Precios);
            preciosOrdenados.Sort();

            List<string> ProductosOrdenados = new List<string>();
            foreach (double p in preciosOrdenados)
            {
                int Indice = Precios.IndexOf(p);
                ProductosOrdenados.Add(Productos[Indice]);
                Productos.RemoveAt(Indice);
                Precios.RemoveAt(Indice);
            }

            Productos = ProductosOrdenados;
            Precios = preciosOrdenados;

            Console.WriteLine("Lista ordenada por precio.");
        }
        





        // funcion para leer los precios
        static double LeerPrecio(string mensaje) {
            double precio;
            Console.Write(mensaje);

            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.Write("Precio inválido (debe ser mayor que 0). " + mensaje);
            
            }
            return precio;
        }



        // funcion para buscar el indice de un producto
        static int BuscarIndice(string Producto) 
        {
            for (int i = 0; i < Productos.Count; i++)
            {
                if (Productos[i].ToLower() == Producto.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }



        // funcion para confirmar si la lista esta vacia
               static bool ListaVacia()
          {
            if (Productos.Count == 0)
            {
                Console.WriteLine("No hay productos en la lista.");
                return true;
            }
            return false;




           }
    }
}
