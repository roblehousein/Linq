using Linq;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
//nouveau professeur
var professeur = new Professeur
{
    Nom = "Ali",
};
var professeur1 = new Professeur
{
    Nom = "Aicha",
};
context.Professeurs.AddRange(professeur,professeur1);
context.SaveChanges();

//cours
var coursMaths = new Cours
{
    Titre = "Math",
    ProfesseurId = professeur.Id
};
var coursAsp = new Cours
{
    Titre = "ASP",
    ProfesseurId = professeur.Id
};
var coursJava = new Cours
{
    Titre = "java",
    ProfesseurId = professeur1.Id
};
context.Cour.AddRange(coursMaths, coursAsp, coursJava);
context.SaveChanges();

// afficher les professeurs avec leurs cours
var professeurs = context.Professeurs
    .Include(p => p.Cours) // inclure les informations des cours
    .ToList();
foreach (var p in professeurs)
{
    Console.WriteLine($"Professeur : {p.Nom}");
    foreach (var c in p.Cours)
    {
        Console.WriteLine($"Cours : {c.Titre}");
    }
}

// enregistrement des étudiants
//var etudiant1 = new Etudiant() { Nom = "Aicha", Prenom = "Ali" };
//var etudiant2 = new Etudiant() { Nom = "Omar", Prenom = "Saban" };
//context.Etudiants.AddRange(etudiant1, etudiant2);
//context.SaveChanges();

//// enregistrement des dossiers étudiant
//var dossier1 = new DossierScolaire() { EtudiantId = 1 };
//var dossier2 = new DossierScolaire() { EtudiantId = 2 };
//context.DossierScolaires.AddRange(dossier1, dossier2);
//context.SaveChanges();

// récuperer dans la base tous les étudiants avec leur dossier
//var etudiants = context.Etudiants
//    .Include(e => e.dossier) // inclure les informations du dossier
//    .ToList();

//var dossier = context.DossierScolaires
//    .Include(e => e.etudiant) // inclure les informations du dossier
//    .ToList();
//Console.WriteLine("----------------étudiants------------------");
//foreach (var e in etudiants)
//{
//    Console.WriteLine($"Etudiant : {e.Nom} {e.Prenom}");
//    Console.WriteLine($"Dossier : {e.dossier.Id}");
//}

//Console.WriteLine("----------------dossier------------------");
//foreach (var e in dossier)
//{
//    Console.WriteLine($"Dossier : {e.Id}");
//    Console.WriteLine($"Etudiant : {e.etudiant.Nom} {e.etudiant.Prenom}");

//}

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
