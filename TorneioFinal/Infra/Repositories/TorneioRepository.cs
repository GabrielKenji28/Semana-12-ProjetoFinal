using Infra.Context;
using Infra.Interfaces;
using Infra.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class TorneioRepository : ITorneioRepository
    {
        private readonly BancoContext _bancoContext;

        public TorneioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<TorneioModel> ListarTorneios()
        {
            return _bancoContext.Torneios.ToList();
        }


    }
}
