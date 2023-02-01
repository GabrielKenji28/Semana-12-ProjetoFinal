using Infra.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITorneioService
    {
        public int WinRate(ParticipanteModel participante);
        public List<ParticipanteModel> OrdenaPorIdade(List<ParticipanteModel> listaDesordenada);
        public List<ParticipanteModel> TransformaParaListaParticipantes(List<int> listaDeIds);
    }
}
