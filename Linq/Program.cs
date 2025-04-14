// Liste de personnes
var personnes = new List<Personne>
        {
            new Personne { Id = 1, Nom = "Alice", Age = 35},
            new Personne { Id = 2, Nom = "Bob", Age = 28 },
            new Personne { Id = 3, Nom = "Charlie", Age = 42 },
            new Personne { Id = 4, Nom = "Diane", Age = 22,},
        };

// selectionner les personnes qui ont plus de 30ans
var agees = personnes.Where(e => e.Age > 30).ToList();
// trier la liste des personnes selectionnées par ordre alpha (nom)
agees = agees.OrderBy(e => e.Nom).ToList();
// ajouter a cette nouvelle liste une nouvelle personne vous (votre nom,age et id)
agees.Add(new Personne() { Id = 20, Nom = "ELMI", Age = 32 });
//supprimer de la liste la personne la plus jeune
agees = agees.OrderBy(e=> e.Age).ToList();

foreach (var personne in agees)
{
    Console.WriteLine(personne.Id + " " + personne.Nom + " " + personne.Age);
}
Console.WriteLine("---------------après suppression--------------");
var first = agees.First();
agees.Remove(first);
// afficher le contenu de la liste
foreach (var personne in agees)
{
    Console.WriteLine(personne.Id +" "+ personne.Nom +" "+personne.Age);
} 

class Personne
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public int Age { get; set; }
    public int VilleId { get; set; }
}


