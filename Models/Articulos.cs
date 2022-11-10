namespace RYSE.WEB.Models
{
    public class Articulos
    {
        public int IdArticulos { get; set; }
        public string? NameArticulos { get; set; }
        
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public string? Color { get; set; }

        public int Tamaño { get; set; }

        public string? Precio { get; set;}

        public int? Peso { get; set; }

    }
}
