using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Etudiant
    {
        public int Id {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DossierScolaire? dossier { get; set; }
    }
}
