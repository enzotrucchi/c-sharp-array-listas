namespace ProgramacionITest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //! Este código no respeta buenas prácticas, es sólo una rápida demo

            ////Array
            String[] productos = new String[] { "Coca Cola", "Pepsi", "Fanta" };

            Console.WriteLine("Productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
            }

            //Hasta que el usuario presione la tecla "ESC" se repetirá el bucle
            //* https://stackoverflow.com/questions/5891538/listen-for-key-press-in-net-console-app
            do
            {
                Console.WriteLine("Ingrese un nuevo producto");
                String nuevoProducto = Console.ReadLine();

                bool productoExistente = false;

                ////Hay una forma más prolija de hacerlo(o varias).Vamos a recorrer porque todavía no vimos LINQ ni estamos tan preparados para trabajar con métodos de array.

                //if (productos.FirstOrDefault(x => x == nuevoProducto) != null)
                //{
                //    Console.WriteLine("El producto ya existe");
                //}
                //else
                //{
                //    //Agregamos el nuevo producto al array
                //    Array.Resize(ref productos, productos.Length + 1);
                //    productos[productos.Length - 1] = nuevoProducto;
                //}

                //Controlo si el producto existe en el array
                //if (productos.Contains(nuevoProducto))
                //{
                //    Console.WriteLine("El producto ya existe");
                //}
                //else
                //{
                //    //Creo un nuevo array con el tamaño del array original + 1
                //    String[] productosNuevo = new String[productos.Length + 1];

                //    //Copio los elementos del array original al nuevo
                //    for (int i = 0; i < productos.Length; i++)
                //    {
                //        productosNuevo[i] = productos[i];
                //    }

                //    //Agrego el nuevo producto al final del array
                //    productosNuevo[productosNuevo.Length - 1] = nuevoProducto;

                //    //Reemplazo el array original por el nuevo
                //    productos = productosNuevo;
                //}


                foreach (var producto in productos)
                {
                    //Controlo si el producto existe en el array
                    if (producto == nuevoProducto)
                    {
                        Console.WriteLine("El producto ya existe");
                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    Array.Resize(ref productos, productos.Length + 1);
                    productos[productos.Length - 1] = nuevoProducto;

                    //Función imprimir
                    Console.WriteLine("Productos:");
                    foreach (var producto in productos)
                    {
                        Console.WriteLine(producto);
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


            //List
            List<string> productsList = new List<string>();
            
            productsList.Add("Coca");
            productsList.Add("Sprite");
            productsList.Add("Fanta");

            Console.WriteLine("Productos:");
            foreach (var product in productsList)
            {
                Console.WriteLine("Producto: " + product);
            }


            do
            {
                Console.WriteLine("Ingrese un nuevo producto");
                String nuevoProducto = Console.ReadLine();

                bool productoExistente = false;

                foreach (var producto in productsList)
                {
                    //Controlo si el producto existe en List
                    if (producto == nuevoProducto)
                    {
                        Console.WriteLine("El producto ya existe");
                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    productsList.Add(nuevoProducto);

                    Console.WriteLine("Productos:");
                    foreach (var producto in productsList)
                    {
                        Console.WriteLine("Producto: " + producto);
                    }
                } 
                else
                {
                    Console.WriteLine("El producto ya existe");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }
    }
}