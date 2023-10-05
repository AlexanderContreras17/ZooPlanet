namespace ZooPlanet.Models.ViewModels
{
    public class EspeciesViewModel
    {public int? Id { get; set; }
        public string Clase { get; set; }= null!;
        public IEnumerable<EspecieAnimal> Animales { get; set; } = null!;
    }
    public class EspecieAnimal
    {
        public int? IdClase { get; set; } 
        public int Id {  get; set; }
        public string Nombre { get; set; } = null!;
    }
}
