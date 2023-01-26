using Infra.Context;
using Infra.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ParticipanteRepository
    {
        private readonly BancoContext _bancoContext;

        public ParticipanteRepository( BancoContext bancoContext )
        {
            _bancoContext = bancoContext;
        }

        public List<ParticipanteModel> ListarParticipantes()
        {
            return _bancoContext.Participantes.ToList();
        }


    }
}
