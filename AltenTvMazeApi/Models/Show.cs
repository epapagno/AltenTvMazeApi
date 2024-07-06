namespace AltenTvMazeApi.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Premiered { get; set; }
        public string OfficialSite { get; set; }
        public string Summary { get; set; }
        // Agrega otros campos según la respuesta de la API
    }
}
