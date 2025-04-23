using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Inscrit
    {
        public int Id { get; set; }
        public int CoursId {  get; set; }
        public int EtudiantId {  get; set; }

        public Cours? cours { get; set; }
        public Etudiant? etudiant { get; set; }
    }
}
