﻿using Infra.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Interfaces
{
    public interface IParticipanteRepository
    {
        public List<ParticipanteModel> ListarParticipantes();
        public List<ParticipanteModel> ConverterEmListaDeObjetos(List<int> ints);
    }
}
