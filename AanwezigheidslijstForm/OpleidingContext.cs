using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AanwezigheidslijstForm
{
    public class OpleidingContext : DbContext
    {
        public DbSet<OpleidingsInformatie> Opleiding { get; set; }
        public OpleidingContext() : base("AanwezighijdslijstDatabase")
        {
            
        }
    }
}
