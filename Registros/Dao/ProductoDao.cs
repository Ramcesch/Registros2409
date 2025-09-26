using Registros.Modelos;
using System;


namespace Registros.Dao
{
    public class ProductoDao
    {
        private static int TAM = 5;
        const int TAMAÑO = 10;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;

        public void Agregar(Producto prod)
        {
            if (pos < TAM)
            {
                carrito[pos++] = prod;
            }
            else Console.WriteLine("No se ppuede Agregar mas Productos");

        }

        public Producto[] VerCarrito()
        {
            return carrito;
        }

    }
}