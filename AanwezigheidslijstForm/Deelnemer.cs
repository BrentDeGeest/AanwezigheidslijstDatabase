using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AanwezigheidslijstForm
{
    public class Deelnemers
    {
        public int Id { get; set; }
        public string VoorNaam { get; set; }
        public string AchterNaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        public int BadgeNummer { get; set; }
        public int OpleidingsId { get; set; }
    }
}
