using Infra.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IParticipanteService
    {
        public List<ParticipanteModel> ListandoParticipantes();
    }
}
