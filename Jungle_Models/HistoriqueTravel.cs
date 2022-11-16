using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models
{
    public class HistoriqueTravel
    {
        [Key]
        public int id { get; set; }
        public int NbParticipant { get; set; }
        public IEnumerable<Travel> travel { get; set; }
    }
}
