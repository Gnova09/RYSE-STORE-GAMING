using RYSE.STOREINLINE.Enities;


namespace RYSE.STOREINLINE.Interfaces
{
	public interface IArticulosRepository()
	{
		void Save(Articulos articulos);

		void Update(Articulos articulos);

		void Remove(Articulos articulos);

		void GetStudent(Articulos articulos);

		void Exists(int articulosID);

}
}
