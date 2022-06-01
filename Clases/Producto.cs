namespace PracticaPOO
{
    public abstract class Producto
    {
		public string Nombre { get; set; }
		public decimal Precio { get; set; }

		public abstract int Tiempo { get; set; }

		public Producto(string nombre, decimal precio)
		{
			Nombre = nombre;
			Precio = precio;
		}
	}
}
