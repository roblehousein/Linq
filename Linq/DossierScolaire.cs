using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DossierScolaire
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public int EtudiantId { get; set; }
        public Etudiant? etudiant { get; set; }
    }
}
