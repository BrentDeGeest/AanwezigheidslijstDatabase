using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AanwezigheidslijstForm
{
    public class DeelnemerContext : DbContext
    {
        public DbSet<Deelnemers> Deelnemer { get; set; }

        public DeelnemerContext() : base("AanwezighijdslijstDatabase")
        {

        }
    }
}
