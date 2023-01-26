using Infra.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
                    
        }
        public DbSet<ParticipanteModel> Participantes { get; set; }
        public DbSet<TorneioModel> Torneios { get; set; }
    }
}
