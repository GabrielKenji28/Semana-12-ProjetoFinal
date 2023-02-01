using Infra.Context;
using Infra.Interfaces;
using Infra.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ParticipanteRepository : IParticipanteRepository
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
        public ParticipanteModel IniciarTorneio(ParticipanteModel vencedor)
        {
            TorneioModel torneioModel = new TorneioModel(vencedor.Nome);

            _bancoContext.Torneios.Add(torneioModel);
            _bancoContext.SaveChanges();
            return vencedor ;
        }

        public List<ParticipanteModel> ConverterEmListaDeObjetos(List<int> ints)
        {
            var l = new List<ParticipanteModel>();
            foreach(int i in ints)
            {
                var p = new ParticipanteModel();
                p = _bancoContext.Participantes.Find(i);
                l.Add(p);
            }
            return l;
        }



    }
}
