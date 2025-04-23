using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Cours> Cours { get; set; }
    }
}
