using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AanwezigheidslijstForm
{
    public class NietOpleidingsDagen
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Voormiddag { get; set; }
        public string Namiddag { get; set; }
        public OpleidingsInformatie Opleiding { get; set; }
    }
}
