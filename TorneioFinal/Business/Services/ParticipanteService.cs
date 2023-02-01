using Business.Interfaces;
using Infra.Interfaces;
using Infra.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ParticipanteService : IParticipanteService
    {
        private readonly IParticipanteRepository _participanteRepository;

        public ParticipanteService(IParticipanteRepository participanteRepository)
        {
            _participanteRepository = participanteRepository;
        }
        public List<ParticipanteModel> ListandoParticipantes()
        {
            try
            {
                return _participanteRepository.ListarParticipantes();
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao listar os participantes : " + e.Message);
            }
        }
        public List<ParticipanteModel> OrganizaPorIdade(List<ParticipanteModel> listaDesordenada)
        {
            List<ParticipanteModel> listaPorIdade = new List<ParticipanteModel>();
            listaPorIdade = listaDesordenada.OrderBy(x => x.Idade).ToList();
           
            return listaPorIdade;
        }
    }
}
