namespace PracticaPOO
{
    public class Lechería : Granja, IProductor 
    {
		Cooperativa cooperativa;
		Producto producto { get; set; }

		public Lechería(string nombre, int cantidad, Cooperativa coop) : base(nombre, Enums.TipoProducto.Leche, cantidad)
		{
			cooperativa = coop;
		}

		public void Producir(Producto producto)
		{
			this.producto = producto;
			cooperativa.Gastar(producto.Precio);
		}
	}
}
