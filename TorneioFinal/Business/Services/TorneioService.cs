using Business.Interfaces;
using Infra.Context;
using Infra.Interfaces;
using Infra.Object;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class TorneioService : ITorneioService
    {
        private readonly ITorneioRepository _torneioRepository;
        private readonly IParticipanteRepository _participanteRepository;

        public TorneioService(ITorneioRepository torneioRepository, IParticipanteRepository participanteRepository)
        {
            _torneioRepository = torneioRepository;
            _participanteRepository = participanteRepository;
        }
        public int WinRate (ParticipanteModel participante)
        {
            return 100 * participante.Vitorias; 
        }
        public List<ParticipanteModel> OrdenaPorIdade(List<ParticipanteModel> listaDesordenada)
        {
            var listaOrdenada = new List<ParticipanteModel>();
            listaOrdenada = listaDesordenada.OrderBy(x => x.Idade).ToList();
            return listaOrdenada;
        }



    }
}
