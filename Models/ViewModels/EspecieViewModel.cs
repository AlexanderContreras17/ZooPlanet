namespace ZooPlanet.Models.ViewModels
{
    public class EspecieViewModel
    {
        public int Id { get; set; }
        public string Especie { get; set; } =null!;
        public string Clase { get; set; } = null!;
        public string Habitat { get; set; } = null!;
        public double? Peso {  get; set; }
        public int? Tamaño { get; set; }
        public string Observaciones {  get; set; } = null!; 


    }
}
