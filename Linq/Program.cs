using Linq;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
// enregistrement des étudiants
//var etudiant1 = new Etudiant() { Nom = "Aicha", Prenom = "Ali" };
//var etudiant2 = new Etudiant() { Nom = "Omar", Prenom = "Saban" };
//context.Etudiants.AddRange(etudiant1, etudiant2);
//context.SaveChanges();

//// enregistrement des dossiers étudiant
//var dossier1 = new DossierScolaire() { EtudiantId = etudiant1.Id };
//var dossier2 = new DossierScolaire() { EtudiantId = etudiant2.Id };
//context.DossierScolaires.AddRange(dossier1, dossier2);
//context.SaveChanges();

// récuperer dans la base tous les étudiants avec leur dossier
var etudiants = context.Etudiants
    .Include(e => e.dossier) // inclure les informations du dossier
    .ToList();

var dossier = context.DossierScolaires
    .Include(e => e.etudiant) // inclure les informations du dossier
    .ToList();
Console.WriteLine("----------------étudiants------------------");
foreach (var e in etudiants)
{
    Console.WriteLine($"Etudiant : {e.Nom} {e.Prenom}");
    Console.WriteLine($"Dossier : {e.dossier.Id}");
}

Console.WriteLine("----------------dossier------------------");
foreach (var e in dossier)
{
    Console.WriteLine($"Dossier : {e.Id}");
    Console.WriteLine($"Etudiant : {e.etudiant.Nom} {e.etudiant.Prenom}");
    
}

//var etudiant = new Etudiant
//{
//    Nom = "Robert",
//    Prenom = "Ronald",
//    dossier = new DossierScolaire
//    {
//        DateCreation = DateTime.Now
//    }
//};
//context.Etudiants.Add(etudiant);
//context.SaveChanges();
