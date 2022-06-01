namespace PracticaPOO
{
    public class Grano : ProdVegetal
	{
		public Enums.Grano Tipo { get; set; }

		public Grano() : base("Grano", 100, 1) { }

		public Grano(Enums.Grano tipo) : this()
		{
			this.Tipo = tipo;
		}
	}
}
