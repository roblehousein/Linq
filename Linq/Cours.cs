namespace Linq
{
    public class Cours
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int ProfesseurId { get; set; }
        public Professeur? Professeur { get; set; }
        public List<Inscrit>? Inscrits { get; set; }
    }
}
